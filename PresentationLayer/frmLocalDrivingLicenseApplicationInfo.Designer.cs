namespace DVLD
{
    partial class frmLocalDrivingLicenseApplicationInfo
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
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLD.ctrlDrivingLicenseApplicationInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(-1, 3);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(598, 331);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Name = "frmLocalDrivingLicenseApplicationInfo";
            this.Text = "frmLocalDrivingLicenseApplicationInfo";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Button button1;
    }
}