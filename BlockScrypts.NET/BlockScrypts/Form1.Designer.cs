namespace BlockScrypts
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.signedInComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DrugInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QtyInput = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PatientSelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PatientIDInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signed in as";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // signedInComboBox
            // 
            this.signedInComboBox.FormattingEnabled = true;
            this.signedInComboBox.Items.AddRange(new object[] {
            "Dr. Smith"});
            this.signedInComboBox.Location = new System.Drawing.Point(257, 27);
            this.signedInComboBox.Name = "signedInComboBox";
            this.signedInComboBox.Size = new System.Drawing.Size(146, 21);
            this.signedInComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create New Prescription";
            // 
            // DrugInput
            // 
            this.DrugInput.Location = new System.Drawing.Point(25, 146);
            this.DrugInput.Name = "DrugInput";
            this.DrugInput.Size = new System.Drawing.Size(100, 20);
            this.DrugInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Drug";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qty";
            // 
            // QtyInput
            // 
            this.QtyInput.Location = new System.Drawing.Point(132, 145);
            this.QtyInput.Name = "QtyInput";
            this.QtyInput.Size = new System.Drawing.Size(39, 20);
            this.QtyInput.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 189);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(378, 91);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Signature";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(25, 319);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "(Use Hardware Signature Module)";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(257, 306);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(146, 44);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientSelect
            // 
            this.PatientSelect.FormattingEnabled = true;
            this.PatientSelect.Location = new System.Drawing.Point(25, 103);
            this.PatientSelect.Name = "PatientSelect";
            this.PatientSelect.Size = new System.Drawing.Size(146, 21);
            this.PatientSelect.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Patient";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Patient ID Number";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PatientIDInput
            // 
            this.PatientIDInput.Location = new System.Drawing.Point(210, 103);
            this.PatientIDInput.Name = "PatientIDInput";
            this.PatientIDInput.Size = new System.Drawing.Size(122, 20);
            this.PatientIDInput.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 372);
            this.Controls.Add(this.PatientIDInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PatientSelect);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.QtyInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DrugInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signedInComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BlockScrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox signedInComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DrugInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QtyInput;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox PatientSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PatientIDInput;
    }
}

