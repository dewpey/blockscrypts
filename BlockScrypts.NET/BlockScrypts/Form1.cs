using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BlockScrypts
{
    public partial class Form1 : Form
    {
        private const string apiURL = "http://d24a9ed0.ngrok.io/api/";
        private const string xKey = "4e15343230c1095dec0fe323e5d81c2d8665c6b2044f85ded6a80117455a4a09095835951b8942e27b8fa29b72887b7de778fe58ed57e898acf45189f0a5035d";
        private dynamic patients;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();

            var output = DoWebRequest(apiURL + "getPatients", "GET", "");
            patients = JsonConvert.DeserializeObject<Patients>(output);
            foreach (Patient patient in patients.patients)
            {
                PatientSelect.Items.Add(patient.alias);
            }
            PatientSelect.SelectedIndex = 1;
            signedInComboBox.Text = @"Dr. Smith";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drug = DrugInput.Text;
            var quantity = QtyInput.Text;
            var patient = patients.ByAlias(PatientSelect.SelectedItem.ToString());
            var hash = "hash(" + patient.id + ", " + PatientIDInput.Text + ")";
            
            var assetAlias = DoWebRequest(apiURL + "createPrescription", "POST", $"hsm={xKey}&drug={drug}&quantity={quantity}&hash={hash}");

            DoWebRequest(apiURL + "issuePrescription", "POST", $"hsm={xKey}&assetAlias={assetAlias}&accountAlias={patient.alias}");
            DoWebRequest("https://hooks.zapier.com/hooks/catch/1705705/5z37it/", "POST", $"assetAlias={assetAlias}&messengerID={patient.messengerID}");
            DoWebRequest("https://hooks.zapier.com/hooks/catch/1705705/5zhset/", "POST", $"assetAlias={assetAlias}&messengerID={patient.messengerID}");
        }



        //"Borrowed" from LeanKit API Docs
        private string DoWebRequest(string address, string method, string body)
        {
            var request = (HttpWebRequest)WebRequest.Create(address);
            request.Method = method;
            
            if (method == "POST")
            {
                if (!string.IsNullOrEmpty(body))
                {
                    var requestBody = Encoding.UTF8.GetBytes(body);
                    request.ContentLength = requestBody.Length;
                    request.ContentType = "application/x-www-form-urlencoded";
                    using (var requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(requestBody, 0, requestBody.Length);
                    }
                }
                else
                {
                    request.ContentLength = 0;
                }
            }

            request.Timeout = 15000;
            request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);

            string output = string.Empty;
            try
            {
                using (var response = request.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        output = stream.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    using (var stream = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        output = stream.ReadToEnd();
                    }
                }
                else if (ex.Status == WebExceptionStatus.Timeout)
                {
                    output = "Request timeout is expired.";
                }
            }
            Console.WriteLine(output);

            return output;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

    public class Patients
    {
        public Patient[] patients { get; set; }

        public Patient ByAlias(string alias)
        {
            return patients.First(x => x.alias == alias);
        }
    }

    public class Patient
    {
        public string alias { get; set; }
        public string id { get; set; }
        public string messengerID { get; set; }

    }

}
