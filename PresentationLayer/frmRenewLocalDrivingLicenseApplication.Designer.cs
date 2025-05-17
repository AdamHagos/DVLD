namespace DVLD
{
    partial class frmRenewLocalDrivingLicenseApplication
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
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.ctrlDriverLicenseInfoWithFilter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBExpirationDate = new System.Windows.Forms.Label();
            this.LBIssueDate = new System.Windows.Forms.Label();
            this.LBApplicationDate = new System.Windows.Forms.Label();
            this.LBLicenseFees = new System.Windows.Forms.Label();
            this.LbTotalFees = new System.Windows.Forms.Label();
            this.LBApplicationFees = new System.Windows.Forms.Label();
            this.LBRLApplicationID = new System.Windows.Forms.Label();
            this.LBCreatedBy = new System.Windows.Forms.Label();
            this.LBOldLicenseID = new System.Windows.Forms.Label();
            this.LBRenewedLicenseID = new System.Windows.Forms.Label();
            this.RTBNotes = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelll = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LKShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.LKShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.BTRenewLicense = new System.Windows.Forms.Button();
            this.BTClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Renew License Application";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(0, 37);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(799, 384);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 6;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseIDSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseIDSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBExpirationDate);
            this.groupBox1.Controls.Add(this.LBIssueDate);
            this.groupBox1.Controls.Add(this.LBApplicationDate);
            this.groupBox1.Controls.Add(this.LBLicenseFees);
            this.groupBox1.Controls.Add(this.LbTotalFees);
            this.groupBox1.Controls.Add(this.LBApplicationFees);
            this.groupBox1.Controls.Add(this.LBRLApplicationID);
            this.groupBox1.Controls.Add(this.LBCreatedBy);
            this.groupBox1.Controls.Add(this.LBOldLicenseID);
            this.groupBox1.Controls.Add(this.LBRenewedLicenseID);
            this.groupBox1.Controls.Add(this.RTBNotes);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelll);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 277);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application New License Info";
            // 
            // LBExpirationDate
            // 
            this.LBExpirationDate.AutoSize = true;
            this.LBExpirationDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBExpirationDate.Location = new System.Drawing.Point(551, 92);
            this.LBExpirationDate.Name = "LBExpirationDate";
            this.LBExpirationDate.Size = new System.Drawing.Size(77, 13);
            this.LBExpirationDate.TabIndex = 21;
            this.LBExpirationDate.Text = "[??/??/????]";
            // 
            // LBIssueDate
            // 
            this.LBIssueDate.AutoSize = true;
            this.LBIssueDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBIssueDate.Location = new System.Drawing.Point(137, 92);
            this.LBIssueDate.Name = "LBIssueDate";
            this.LBIssueDate.Size = new System.Drawing.Size(77, 13);
            this.LBIssueDate.TabIndex = 20;
            this.LBIssueDate.Text = "[??/??/????]";
            // 
            // LBApplicationDate
            // 
            this.LBApplicationDate.AutoSize = true;
            this.LBApplicationDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBApplicationDate.Location = new System.Drawing.Point(137, 60);
            this.LBApplicationDate.Name = "LBApplicationDate";
            this.LBApplicationDate.Size = new System.Drawing.Size(77, 13);
            this.LBApplicationDate.TabIndex = 19;
            this.LBApplicationDate.Text = "[??/??/????]";
            // 
            // LBLicenseFees
            // 
            this.LBLicenseFees.AutoSize = true;
            this.LBLicenseFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLicenseFees.Location = new System.Drawing.Point(134, 163);
            this.LBLicenseFees.Name = "LBLicenseFees";
            this.LBLicenseFees.Size = new System.Drawing.Size(38, 13);
            this.LBLicenseFees.TabIndex = 18;
            this.LBLicenseFees.Text = "[$$$]";
            // 
            // LbTotalFees
            // 
            this.LbTotalFees.AutoSize = true;
            this.LbTotalFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalFees.Location = new System.Drawing.Point(548, 163);
            this.LbTotalFees.Name = "LbTotalFees";
            this.LbTotalFees.Size = new System.Drawing.Size(38, 13);
            this.LbTotalFees.TabIndex = 17;
            this.LbTotalFees.Text = "[$$$]";
            // 
            // LBApplicationFees
            // 
            this.LBApplicationFees.AutoSize = true;
            this.LBApplicationFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBApplicationFees.Location = new System.Drawing.Point(137, 126);
            this.LBApplicationFees.Name = "LBApplicationFees";
            this.LBApplicationFees.Size = new System.Drawing.Size(38, 13);
            this.LBApplicationFees.TabIndex = 16;
            this.LBApplicationFees.Text = "[$$$]";
            // 
            // LBRLApplicationID
            // 
            this.LBRLApplicationID.AutoSize = true;
            this.LBRLApplicationID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRLApplicationID.Location = new System.Drawing.Point(137, 28);
            this.LBRLApplicationID.Name = "LBRLApplicationID";
            this.LBRLApplicationID.Size = new System.Drawing.Size(35, 13);
            this.LBRLApplicationID.TabIndex = 15;
            this.LBRLApplicationID.Text = "[???]";
            // 
            // LBCreatedBy
            // 
            this.LBCreatedBy.AutoSize = true;
            this.LBCreatedBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCreatedBy.Location = new System.Drawing.Point(551, 126);
            this.LBCreatedBy.Name = "LBCreatedBy";
            this.LBCreatedBy.Size = new System.Drawing.Size(35, 13);
            this.LBCreatedBy.TabIndex = 14;
            this.LBCreatedBy.Text = "[???]";
            // 
            // LBOldLicenseID
            // 
            this.LBOldLicenseID.AutoSize = true;
            this.LBOldLicenseID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBOldLicenseID.Location = new System.Drawing.Point(551, 60);
            this.LBOldLicenseID.Name = "LBOldLicenseID";
            this.LBOldLicenseID.Size = new System.Drawing.Size(35, 13);
            this.LBOldLicenseID.TabIndex = 13;
            this.LBOldLicenseID.Text = "[???]";
            // 
            // LBRenewedLicenseID
            // 
            this.LBRenewedLicenseID.AutoSize = true;
            this.LBRenewedLicenseID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRenewedLicenseID.Location = new System.Drawing.Point(551, 28);
            this.LBRenewedLicenseID.Name = "LBRenewedLicenseID";
            this.LBRenewedLicenseID.Size = new System.Drawing.Size(35, 13);
            this.LBRenewedLicenseID.TabIndex = 12;
            this.LBRenewedLicenseID.Text = "[???]";
            // 
            // RTBNotes
            // 
            this.RTBNotes.Location = new System.Drawing.Point(137, 179);
            this.RTBNotes.Name = "RTBNotes";
            this.RTBNotes.Size = new System.Drawing.Size(621, 85);
            this.RTBNotes.TabIndex = 11;
            this.RTBNotes.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Application Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Issue Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Application Fees:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "License Fees:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Notes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Old License ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Expiration Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Created By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Fees:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelll.Location = new System.Drawing.Point(398, 28);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(120, 13);
            this.labelll.TabIndex = 1;
            this.labelll.Text = "Renewed License ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "R.L.Aplication ID:";
            // 
            // LKShowLicensesHistory
            // 
            this.LKShowLicensesHistory.AutoSize = true;
            this.LKShowLicensesHistory.Enabled = false;
            this.LKShowLicensesHistory.Location = new System.Drawing.Point(12, 678);
            this.LKShowLicensesHistory.Name = "LKShowLicensesHistory";
            this.LKShowLicensesHistory.Size = new System.Drawing.Size(113, 13);
            this.LKShowLicensesHistory.TabIndex = 11;
            this.LKShowLicensesHistory.TabStop = true;
            this.LKShowLicensesHistory.Text = "Show Licenses History";
            this.LKShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKShowLicensesHistory_LinkClicked);
            // 
            // LKShowNewLicenseInfo
            // 
            this.LKShowNewLicenseInfo.AutoSize = true;
            this.LKShowNewLicenseInfo.Enabled = false;
            this.LKShowNewLicenseInfo.Location = new System.Drawing.Point(147, 678);
            this.LKShowNewLicenseInfo.Name = "LKShowNewLicenseInfo";
            this.LKShowNewLicenseInfo.Size = new System.Drawing.Size(118, 13);
            this.LKShowNewLicenseInfo.TabIndex = 12;
            this.LKShowNewLicenseInfo.TabStop = true;
            this.LKShowNewLicenseInfo.Text = "Show New License Info";
            this.LKShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKShowNewLicenseInfo_LinkClicked);
            // 
            // BTRenewLicense
            // 
            this.BTRenewLicense.Enabled = false;
            this.BTRenewLicense.Location = new System.Drawing.Point(622, 669);
            this.BTRenewLicense.Name = "BTRenewLicense";
            this.BTRenewLicense.Size = new System.Drawing.Size(117, 31);
            this.BTRenewLicense.TabIndex = 13;
            this.BTRenewLicense.Text = "Renew License";
            this.BTRenewLicense.UseVisualStyleBackColor = true;
            this.BTRenewLicense.Click += new System.EventHandler(this.BTRenewLicense_Click);
            // 
            // BTClose
            // 
            this.BTClose.Location = new System.Drawing.Point(487, 669);
            this.BTClose.Name = "BTClose";
            this.BTClose.Size = new System.Drawing.Size(117, 31);
            this.BTClose.TabIndex = 14;
            this.BTClose.Text = "Close";
            this.BTClose.UseVisualStyleBackColor = true;
            // 
            // frmRenewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 712);
            this.Controls.Add(this.BTClose);
            this.Controls.Add(this.BTRenewLicense);
            this.Controls.Add(this.LKShowNewLicenseInfo);
            this.Controls.Add(this.LKShowLicensesHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.label1);
            this.Name = "frmRenewLocalDrivingLicenseApplication";
            this.Text = "frmRenewLocalDrivingLicenseApplication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLicenseFees;
        private System.Windows.Forms.Label LbTotalFees;
        private System.Windows.Forms.Label LBApplicationFees;
        private System.Windows.Forms.Label LBRLApplicationID;
        private System.Windows.Forms.Label LBCreatedBy;
        private System.Windows.Forms.Label LBOldLicenseID;
        private System.Windows.Forms.Label LBRenewedLicenseID;
        private System.Windows.Forms.RichTextBox RTBNotes;
        private System.Windows.Forms.Label LBExpirationDate;
        private System.Windows.Forms.Label LBIssueDate;
        private System.Windows.Forms.Label LBApplicationDate;
        private System.Windows.Forms.LinkLabel LKShowLicensesHistory;
        private System.Windows.Forms.LinkLabel LKShowNewLicenseInfo;
        private System.Windows.Forms.Button BTRenewLicense;
        private System.Windows.Forms.Button BTClose;
    }
}