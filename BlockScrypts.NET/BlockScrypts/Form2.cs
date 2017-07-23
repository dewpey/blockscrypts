using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BlockScrypts
{
    public partial class Form2 : Form
    {
        private const string apiURL = "http://d24a9ed0.ngrok.io/api/";
        private const string pharmacy = "CVS";
        private Prescriptions prescriptions;

        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = (Prescription) listBox1.SelectedItem ?? (Prescription) listBox1.Items[0];
            qtyLabel.Text = sel.quantity;
            drugLabel.Text = sel.drug;
            hashLabel.Text = sel.hash;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DoWebRequest(apiURL + $"pharmacyQuery?id={pharmacy}", "GET", "");
            var result = DoWebRequest(apiURL + "getState", "GET", "");
            prescriptions = JsonConvert.DeserializeObject<Prescriptions>(result);
            foreach (Prescription p in prescriptions.prescriptions)
            {
                listBox1.Items.Add(p);
            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DoWebRequest(apiURL + $"pharmacyQuery?id={pharmacy}", "GET", "");
            var result = DoWebRequest(apiURL + "getState", "GET", "");
            prescriptions = JsonConvert.DeserializeObject<Prescriptions>(result);
            foreach (Prescription p in prescriptions.prescriptions)
            {
                listBox1.Items.Add(p);
            }
        }
    }

    public class Prescriptions
    {
        public Prescription[] prescriptions;

    }

    public class Prescription
    {
        public string hash;
        public string drug;
        public string quantity;
        
        public override string ToString() => "( " + quantity + " ) x " + drug;
    }

}
