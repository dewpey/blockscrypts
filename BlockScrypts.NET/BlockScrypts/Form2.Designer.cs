namespace BlockScrypts
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drugLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hashLabel = new System.Windows.Forms.TextBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CVS Pharmacy Chain Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 251);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(138, 136);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(80, 55);
            this.qtyLabel.TabIndex = 3;
            this.qtyLabel.Text = "30";
            this.qtyLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Drug";
            // 
            // drugLabel
            // 
            this.drugLabel.AutoSize = true;
            this.drugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugLabel.Location = new System.Drawing.Point(255, 148);
            this.drugLabel.Name = "drugLabel";
            this.drugLabel.Size = new System.Drawing.Size(171, 39);
            this.drugLabel.TabIndex = 5;
            this.drugLabel.Text = "Ibuprofen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Patient Identity Verification";
            // 
            // hashLabel
            // 
            this.hashLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hashLabel.Enabled = false;
            this.hashLabel.Location = new System.Drawing.Point(151, 239);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(169, 20);
            this.hashLabel.TabIndex = 11;
            // 
            // fillButton
            // 
            this.fillButton.BackColor = System.Drawing.Color.Red;
            this.fillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillButton.ForeColor = System.Drawing.Color.White;
            this.fillButton.Location = new System.Drawing.Point(367, 239);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(138, 73);
            this.fillButton.TabIndex = 12;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = false;
            this.fillButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pharmacist Signature";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(151, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "(Use Hardware Signature Module)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 368);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.hashLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drugLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label drugLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hashLabel;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}