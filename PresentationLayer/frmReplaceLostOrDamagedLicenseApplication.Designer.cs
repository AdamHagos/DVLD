namespace DVLD
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            this.LbLicenseReplacement = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.ctrlDriverLicenseInfoWithFilter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBLostLicense = new System.Windows.Forms.RadioButton();
            this.RBDamagedLicense = new System.Windows.Forms.RadioButton();
            this.LKShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.LKShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.BTIssueReplacement = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBApplicationDate = new System.Windows.Forms.Label();
            this.LBCreatedBy = new System.Windows.Forms.Label();
            this.LBReplacedLicenseID = new System.Windows.Forms.Label();
            this.LBOldLicenseID = new System.Windows.Forms.Label();
            this.LBLRApplicationID = new System.Windows.Forms.Label();
            this.LBApplicationFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbLicenseReplacement
            // 
            this.LbLicenseReplacement.AutoSize = true;
            this.LbLicenseReplacement.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLicenseReplacement.Location = new System.Drawing.Point(175, 9);
            this.LbLicenseReplacement.Name = "LbLicenseReplacement";
            this.LbLicenseReplacement.Size = new System.Drawing.Size(231, 25);
            this.LbLicenseReplacement.TabIndex = 6;
            this.LbLicenseReplacement.Text = "License Replacement";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(-1, 37);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(799, 384);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 7;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseIDSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseIDSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBLostLicense);
            this.groupBox1.Controls.Add(this.RBDamagedLicense);
            this.groupBox1.Location = new System.Drawing.Point(377, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement For";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RBLostLicense
            // 
            this.RBLostLicense.AutoSize = true;
            this.RBLostLicense.Location = new System.Drawing.Point(6, 53);
            this.RBLostLicense.Name = "RBLostLicense";
            this.RBLostLicense.Size = new System.Drawing.Size(83, 17);
            this.RBLostLicense.TabIndex = 1;
            this.RBLostLicense.TabStop = true;
            this.RBLostLicense.Text = "Lost License";
            this.RBLostLicense.UseVisualStyleBackColor = true;
            this.RBLostLicense.CheckedChanged += new System.EventHandler(this.RBLostLicense_CheckedChanged);
            // 
            // RBDamagedLicense
            // 
            this.RBDamagedLicense.AutoSize = true;
            this.RBDamagedLicense.Location = new System.Drawing.Point(6, 19);
            this.RBDamagedLicense.Name = "RBDamagedLicense";
            this.RBDamagedLicense.Size = new System.Drawing.Size(111, 17);
            this.RBDamagedLicense.TabIndex = 0;
            this.RBDamagedLicense.TabStop = true;
            this.RBDamagedLicense.Text = "Damaged  License";
            this.RBDamagedLicense.UseVisualStyleBackColor = true;
            this.RBDamagedLicense.CheckedChanged += new System.EventHandler(this.RBDamagedLicense_CheckedChanged);
            // 
            // LKShowLicenseInfo
            // 
            this.LKShowLicenseInfo.AutoSize = true;
            this.LKShowLicenseInfo.Enabled = false;
            this.LKShowLicenseInfo.Location = new System.Drawing.Point(128, 528);
            this.LKShowLicenseInfo.Name = "LKShowLicenseInfo";
            this.LKShowLicenseInfo.Size = new System.Drawing.Size(92, 13);
            this.LKShowLicenseInfo.TabIndex = 9;
            this.LKShowLicenseInfo.TabStop = true;
            this.LKShowLicenseInfo.Text = "Show License info";
            this.LKShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKShowLicenseInfo_LinkClicked);
            // 
            // LKShowLicensesHistory
            // 
            this.LKShowLicensesHistory.AutoSize = true;
            this.LKShowLicensesHistory.Enabled = false;
            this.LKShowLicensesHistory.Location = new System.Drawing.Point(9, 528);
            this.LKShowLicensesHistory.Name = "LKShowLicensesHistory";
            this.LKShowLicensesHistory.Size = new System.Drawing.Size(113, 13);
            this.LKShowLicensesHistory.TabIndex = 10;
            this.LKShowLicensesHistory.TabStop = true;
            this.LKShowLicensesHistory.Text = "Show Licenses History";
            this.LKShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKShowLicensesHistory_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTIssueReplacement
            // 
            this.BTIssueReplacement.Enabled = false;
            this.BTIssueReplacement.Location = new System.Drawing.Point(599, 519);
            this.BTIssueReplacement.Name = "BTIssueReplacement";
            this.BTIssueReplacement.Size = new System.Drawing.Size(133, 31);
            this.BTIssueReplacement.TabIndex = 12;
            this.BTIssueReplacement.Text = "Issue Replacement";
            this.BTIssueReplacement.UseVisualStyleBackColor = true;
            this.BTIssueReplacement.Click += new System.EventHandler(this.BTIssueReplacement_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBApplicationDate);
            this.groupBox2.Controls.Add(this.LBCreatedBy);
            this.groupBox2.Controls.Add(this.LBReplacedLicenseID);
            this.groupBox2.Controls.Add(this.LBOldLicenseID);
            this.groupBox2.Controls.Add(this.LBLRApplicationID);
            this.groupBox2.Controls.Add(this.LBApplicationFees);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 139);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info For License Replacement";
            // 
            // LBApplicationDate
            // 
            this.LBApplicationDate.AutoSize = true;
            this.LBApplicationDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBApplicationDate.Location = new System.Drawing.Point(154, 63);
            this.LBApplicationDate.Name = "LBApplicationDate";
            this.LBApplicationDate.Size = new System.Drawing.Size(77, 13);
            this.LBApplicationDate.TabIndex = 19;
            this.LBApplicationDate.Text = "[??/??/????]";
            // 
            // LBCreatedBy
            // 
            this.LBCreatedBy.AutoSize = true;
            this.LBCreatedBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCreatedBy.Location = new System.Drawing.Point(507, 104);
            this.LBCreatedBy.Name = "LBCreatedBy";
            this.LBCreatedBy.Size = new System.Drawing.Size(35, 13);
            this.LBCreatedBy.TabIndex = 18;
            this.LBCreatedBy.Text = "[???]";
            // 
            // LBReplacedLicenseID
            // 
            this.LBReplacedLicenseID.AutoSize = true;
            this.LBReplacedLicenseID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBReplacedLicenseID.Location = new System.Drawing.Point(507, 25);
            this.LBReplacedLicenseID.Name = "LBReplacedLicenseID";
            this.LBReplacedLicenseID.Size = new System.Drawing.Size(35, 13);
            this.LBReplacedLicenseID.TabIndex = 17;
            this.LBReplacedLicenseID.Text = "[???]";
            // 
            // LBOldLicenseID
            // 
            this.LBOldLicenseID.AutoSize = true;
            this.LBOldLicenseID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBOldLicenseID.Location = new System.Drawing.Point(507, 63);
            this.LBOldLicenseID.Name = "LBOldLicenseID";
            this.LBOldLicenseID.Size = new System.Drawing.Size(35, 13);
            this.LBOldLicenseID.TabIndex = 16;
            this.LBOldLicenseID.Text = "[???]";
            // 
            // LBLRApplicationID
            // 
            this.LBLRApplicationID.AutoSize = true;
            this.LBLRApplicationID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRApplicationID.Location = new System.Drawing.Point(154, 25);
            this.LBLRApplicationID.Name = "LBLRApplicationID";
            this.LBLRApplicationID.Size = new System.Drawing.Size(35, 13);
            this.LBLRApplicationID.TabIndex = 15;
            this.LBLRApplicationID.Text = "[???]";
            // 
            // LBApplicationFees
            // 
            this.LBApplicationFees.AutoSize = true;
            this.LBApplicationFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBApplicationFees.Location = new System.Drawing.Point(154, 104);
            this.LBApplicationFees.Name = "LBApplicationFees";
            this.LBApplicationFees.Size = new System.Drawing.Size(38, 13);
            this.LBApplicationFees.TabIndex = 14;
            this.LBApplicationFees.Text = "[$$$]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Application Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Application Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "L.R.Application ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Created By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Old License ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Replaced License ID:";
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTIssueReplacement);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LKShowLicensesHistory);
            this.Controls.Add(this.LKShowLicenseInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.LbLicenseReplacement);
            this.Name = "frmReplaceLostOrDamagedLicenseApplication";
            this.Text = "frmReplaceLostOrDamagedLicenseApplication";
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbLicenseReplacement;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBLostLicense;
        private System.Windows.Forms.RadioButton RBDamagedLicense;
        private System.Windows.Forms.LinkLabel LKShowLicenseInfo;
        private System.Windows.Forms.LinkLabel LKShowLicensesHistory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTIssueReplacement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBApplicationFees;
        private System.Windows.Forms.Label LBCreatedBy;
        private System.Windows.Forms.Label LBReplacedLicenseID;
        private System.Windows.Forms.Label LBOldLicenseID;
        private System.Windows.Forms.Label LBLRApplicationID;
        private System.Windows.Forms.Label LBApplicationDate;
    }
}