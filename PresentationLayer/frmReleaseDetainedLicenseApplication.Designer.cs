namespace DVLD
{
    partial class frmReleaseDetainedLicenseApplication
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
            this.LKShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.LKShowLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBDetainID = new System.Windows.Forms.Label();
            this.LBLicenseID = new System.Windows.Forms.Label();
            this.LBCreatedBy = new System.Windows.Forms.Label();
            this.LBDetainDate = new System.Windows.Forms.Label();
            this.LBFineFees = new System.Windows.Forms.Label();
            this.LBApplicationID = new System.Windows.Forms.Label();
            this.LBTotalFees = new System.Windows.Forms.Label();
            this.LBApplicationFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Release Detained License";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(2, 37);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(799, 384);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 7;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseIDSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseIDSelected);
            // 
            // LKShowLicensesHistory
            // 
            this.LKShowLicensesHistory.AutoSize = true;
            this.LKShowLicensesHistory.Location = new System.Drawing.Point(12, 557);
            this.LKShowLicensesHistory.Name = "LKShowLicensesHistory";
            this.LKShowLicensesHistory.Size = new System.Drawing.Size(113, 13);
            this.LKShowLicensesHistory.TabIndex = 8;
            this.LKShowLicensesHistory.TabStop = true;
            this.LKShowLicensesHistory.Text = "Show Licenses History";
            this.LKShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKShowLicensesHistory_LinkClicked);
            // 
            // LKShowLicensesInfo
            // 
            this.LKShowLicensesInfo.AutoSize = true;
            this.LKShowLicensesInfo.Location = new System.Drawing.Point(131, 557);
            this.LKShowLicensesInfo.Name = "LKShowLicensesInfo";
            this.LKShowLicensesInfo.Size = new System.Drawing.Size(97, 13);
            this.LKShowLicensesInfo.TabIndex = 9;
            this.LKShowLicensesInfo.TabStop = true;
            this.LKShowLicensesInfo.Text = "Show Licenses info";
            this.LKShowLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKShowLicensesInfo_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(661, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Release";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Application Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Created By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Aplication ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Fees:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBDetainID);
            this.groupBox1.Controls.Add(this.LBLicenseID);
            this.groupBox1.Controls.Add(this.LBCreatedBy);
            this.groupBox1.Controls.Add(this.LBDetainDate);
            this.groupBox1.Controls.Add(this.LBFineFees);
            this.groupBox1.Controls.Add(this.LBApplicationID);
            this.groupBox1.Controls.Add(this.LBTotalFees);
            this.groupBox1.Controls.Add(this.LBApplicationFees);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(2, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 164);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            // 
            // LBDetainID
            // 
            this.LBDetainID.AutoSize = true;
            this.LBDetainID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDetainID.Location = new System.Drawing.Point(141, 27);
            this.LBDetainID.Name = "LBDetainID";
            this.LBDetainID.Size = new System.Drawing.Size(35, 13);
            this.LBDetainID.TabIndex = 17;
            this.LBDetainID.Text = "[???]";
            // 
            // LBLicenseID
            // 
            this.LBLicenseID.AutoSize = true;
            this.LBLicenseID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLicenseID.Location = new System.Drawing.Point(503, 27);
            this.LBLicenseID.Name = "LBLicenseID";
            this.LBLicenseID.Size = new System.Drawing.Size(35, 13);
            this.LBLicenseID.TabIndex = 18;
            this.LBLicenseID.Text = "[???]";
            // 
            // LBCreatedBy
            // 
            this.LBCreatedBy.AutoSize = true;
            this.LBCreatedBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCreatedBy.Location = new System.Drawing.Point(503, 61);
            this.LBCreatedBy.Name = "LBCreatedBy";
            this.LBCreatedBy.Size = new System.Drawing.Size(35, 13);
            this.LBCreatedBy.TabIndex = 19;
            this.LBCreatedBy.Text = "[???]";
            // 
            // LBDetainDate
            // 
            this.LBDetainDate.AutoSize = true;
            this.LBDetainDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDetainDate.Location = new System.Drawing.Point(141, 61);
            this.LBDetainDate.Name = "LBDetainDate";
            this.LBDetainDate.Size = new System.Drawing.Size(77, 13);
            this.LBDetainDate.TabIndex = 21;
            this.LBDetainDate.Text = "[??/??/????]";
            // 
            // LBFineFees
            // 
            this.LBFineFees.AutoSize = true;
            this.LBFineFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFineFees.Location = new System.Drawing.Point(503, 98);
            this.LBFineFees.Name = "LBFineFees";
            this.LBFineFees.Size = new System.Drawing.Size(38, 13);
            this.LBFineFees.TabIndex = 22;
            this.LBFineFees.Text = "[$$$]";
            // 
            // LBApplicationID
            // 
            this.LBApplicationID.AutoSize = true;
            this.LBApplicationID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBApplicationID.Location = new System.Drawing.Point(503, 136);
            this.LBApplicationID.Name = "LBApplicationID";
            this.LBApplicationID.Size = new System.Drawing.Size(35, 13);
            this.LBApplicationID.TabIndex = 20;
            this.LBApplicationID.Text = "[???]";
            // 
            // LBTotalFees
            // 
            this.LBTotalFees.AutoSize = true;
            this.LBTotalFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTotalFees.Location = new System.Drawing.Point(141, 136);
            this.LBTotalFees.Name = "LBTotalFees";
            this.LBTotalFees.Size = new System.Drawing.Size(38, 13);
            this.LBTotalFees.TabIndex = 23;
            this.LBTotalFees.Text = "[$$$]";
            // 
            // LBApplicationFees
            // 
            this.LBApplicationFees.AutoSize = true;
            this.LBApplicationFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBApplicationFees.Location = new System.Drawing.Point(141, 98);
            this.LBApplicationFees.Name = "LBApplicationFees";
            this.LBApplicationFees.Size = new System.Drawing.Size(38, 13);
            this.LBApplicationFees.TabIndex = 24;
            this.LBApplicationFees.Text = "[$$$]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(386, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "License ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fine Fees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Detain Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Detain ID:";
            // 
            // frmReleaseDetainedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LKShowLicensesInfo);
            this.Controls.Add(this.LKShowLicensesHistory);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.label1);
            this.Name = "frmReleaseDetainedLicenseApplication";
            this.Text = "frmReleaseDetainedLicenseApplication";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicenseApplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.LinkLabel LKShowLicensesHistory;
        private System.Windows.Forms.LinkLabel LKShowLicensesInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBDetainID;
        private System.Windows.Forms.Label LBLicenseID;
        private System.Windows.Forms.Label LBCreatedBy;
        private System.Windows.Forms.Label LBApplicationID;
        private System.Windows.Forms.Label LBDetainDate;
        private System.Windows.Forms.Label LBFineFees;
        private System.Windows.Forms.Label LBTotalFees;
        private System.Windows.Forms.Label LBApplicationFees;
    }
}