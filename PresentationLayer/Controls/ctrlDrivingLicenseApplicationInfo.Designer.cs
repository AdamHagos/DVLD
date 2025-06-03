namespace DVLD
{
    partial class ctrlDrivingLicenseApplicationInfo
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
            this.ctrlApplicationBasicInfo1 = new DVLD.ctrlApplicationBasicInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LKShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.LbDLAppID = new System.Windows.Forms.Label();
            this.LbPassedTests = new System.Windows.Forms.Label();
            this.LbAppliedForLicense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(3, 121);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(589, 207);
            this.ctrlApplicationBasicInfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LKShowLicenseInfo);
            this.groupBox1.Controls.Add(this.LbDLAppID);
            this.groupBox1.Controls.Add(this.LbPassedTests);
            this.groupBox1.Controls.Add(this.LbAppliedForLicense);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info";
            // 
            // LKShowLicenseInfo
            // 
            this.LKShowLicenseInfo.AutoSize = true;
            this.LKShowLicenseInfo.Location = new System.Drawing.Point(119, 63);
            this.LKShowLicenseInfo.Name = "LKShowLicenseInfo";
            this.LKShowLicenseInfo.Size = new System.Drawing.Size(94, 13);
            this.LKShowLicenseInfo.TabIndex = 6;
            this.LKShowLicenseInfo.TabStop = true;
            this.LKShowLicenseInfo.Text = "Show License Info";
            this.LKShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKShowLicenseInfo_LinkClicked);
            // 
            // LbDLAppID
            // 
            this.LbDLAppID.AutoSize = true;
            this.LbDLAppID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDLAppID.Location = new System.Drawing.Point(116, 26);
            this.LbDLAppID.Name = "LbDLAppID";
            this.LbDLAppID.Size = new System.Drawing.Size(35, 13);
            this.LbDLAppID.TabIndex = 5;
            this.LbDLAppID.Text = "[???]";
            // 
            // LbPassedTests
            // 
            this.LbPassedTests.AutoSize = true;
            this.LbPassedTests.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassedTests.Location = new System.Drawing.Point(424, 64);
            this.LbPassedTests.Name = "LbPassedTests";
            this.LbPassedTests.Size = new System.Drawing.Size(14, 13);
            this.LbPassedTests.TabIndex = 4;
            this.LbPassedTests.Text = "0";
            // 
            // LbAppliedForLicense
            // 
            this.LbAppliedForLicense.AutoSize = true;
            this.LbAppliedForLicense.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAppliedForLicense.Location = new System.Drawing.Point(424, 26);
            this.LbAppliedForLicense.Name = "LbAppliedForLicense";
            this.LbAppliedForLicense.Size = new System.Drawing.Size(35, 13);
            this.LbAppliedForLicense.TabIndex = 3;
            this.LbAppliedForLicense.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passed Tests:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applied For License:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.App ID:";
            // 
            // ctrlDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Name = "ctrlDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(598, 331);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbPassedTests;
        private System.Windows.Forms.Label LbAppliedForLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LKShowLicenseInfo;
        private System.Windows.Forms.Label LbDLAppID;
    }
}
