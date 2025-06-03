namespace DVLD
{
    partial class ctrlPersonCardWithFitler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBFilter = new System.Windows.Forms.GroupBox();
            this.BTAddPerson = new System.Windows.Forms.Button();
            this.BTOkay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new DVLD.ctrlPersonCard();
            this.GBFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBFilter
            // 
            this.GBFilter.Controls.Add(this.BTAddPerson);
            this.GBFilter.Controls.Add(this.BTOkay);
            this.GBFilter.Controls.Add(this.textBox1);
            this.GBFilter.Controls.Add(this.comboBox1);
            this.GBFilter.Controls.Add(this.label1);
            this.GBFilter.Location = new System.Drawing.Point(3, 3);
            this.GBFilter.Name = "GBFilter";
            this.GBFilter.Size = new System.Drawing.Size(624, 57);
            this.GBFilter.TabIndex = 0;
            this.GBFilter.TabStop = false;
            this.GBFilter.Text = "Filter";
            // 
            // BTAddPerson
            // 
            this.BTAddPerson.Location = new System.Drawing.Point(436, 19);
            this.BTAddPerson.Name = "BTAddPerson";
            this.BTAddPerson.Size = new System.Drawing.Size(27, 23);
            this.BTAddPerson.TabIndex = 4;
            this.BTAddPerson.UseVisualStyleBackColor = true;
            this.BTAddPerson.Click += new System.EventHandler(this.BTAddPerson_Click);
            // 
            // BTOkay
            // 
            this.BTOkay.Location = new System.Drawing.Point(403, 19);
            this.BTOkay.Name = "BTOkay";
            this.BTOkay.Size = new System.Drawing.Size(27, 23);
            this.BTOkay.TabIndex = 3;
            this.BTOkay.UseVisualStyleBackColor = true;
            this.BTOkay.Click += new System.EventHandler(this.BTOkay_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 66);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(639, 216);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // ctrlPersonCardWithFitler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.GBFilter);
            this.Name = "ctrlPersonCardWithFitler";
            this.Size = new System.Drawing.Size(633, 288);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFitler_Load);
            this.GBFilter.ResumeLayout(false);
            this.GBFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTOkay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Button BTAddPerson;
    }
}
