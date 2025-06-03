namespace DVLD
{
    partial class frmShowPersonLicenseHistory
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
            this.ctrlPersonCardWithFitler1 = new DVLD.ctrlPersonCardWithFitler();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlDriverLicenses1 = new DVLD.ctrlDriverLicenses();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "License History";
            // 
            // ctrlPersonCardWithFitler1
            // 
            this.ctrlPersonCardWithFitler1.Location = new System.Drawing.Point(155, 54);
            this.ctrlPersonCardWithFitler1.Name = "ctrlPersonCardWithFitler1";
            this.ctrlPersonCardWithFitler1.Size = new System.Drawing.Size(633, 288);
            this.ctrlPersonCardWithFitler1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 148);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlDriverLicenses1
            // 
            this.ctrlDriverLicenses1.Location = new System.Drawing.Point(12, 348);
            this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            this.ctrlDriverLicenses1.Size = new System.Drawing.Size(650, 277);
            this.ctrlDriverLicenses1.TabIndex = 7;
            // 
            // frmShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.ctrlDriverLicenses1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlPersonCardWithFitler1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowPersonLicenseHistory";
            this.Text = "frmShowPersonLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlPersonCardWithFitler ctrlPersonCardWithFitler1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrlDriverLicenses ctrlDriverLicenses1;
    }
}