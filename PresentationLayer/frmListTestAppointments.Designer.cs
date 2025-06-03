namespace DVLD
{
    partial class frmListTestAppointments
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
            this.components = new System.ComponentModel.Container();
            this.LBTestAppointmentsTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbRecords = new System.Windows.Forms.Label();
            this.BTAddTestAppointment = new System.Windows.Forms.Button();
            this.BTClose = new System.Windows.Forms.Button();
            this.dGVTestAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStripEditSchedule = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuEditSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLD.ctrlDrivingLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTestAppointments)).BeginInit();
            this.contextMenuStripEditSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBTestAppointmentsTitle
            // 
            this.LBTestAppointmentsTitle.AutoSize = true;
            this.LBTestAppointmentsTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTestAppointmentsTitle.Location = new System.Drawing.Point(259, 132);
            this.LBTestAppointmentsTitle.Name = "LBTestAppointmentsTitle";
            this.LBTestAppointmentsTitle.Size = new System.Drawing.Size(278, 25);
            this.LBTestAppointmentsTitle.TabIndex = 4;
            this.LBTestAppointmentsTitle.Text = "Vision Test Appointments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 107);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Appointments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "#Records:";
            // 
            // LbRecords
            // 
            this.LbRecords.AutoSize = true;
            this.LbRecords.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRecords.Location = new System.Drawing.Point(84, 631);
            this.LbRecords.Name = "LbRecords";
            this.LbRecords.Size = new System.Drawing.Size(19, 13);
            this.LbRecords.TabIndex = 10;
            this.LbRecords.Text = "??";
            // 
            // BTAddTestAppointment
            // 
            this.BTAddTestAppointment.Location = new System.Drawing.Point(550, 488);
            this.BTAddTestAppointment.Name = "BTAddTestAppointment";
            this.BTAddTestAppointment.Size = new System.Drawing.Size(35, 32);
            this.BTAddTestAppointment.TabIndex = 11;
            this.BTAddTestAppointment.UseVisualStyleBackColor = true;
            this.BTAddTestAppointment.Click += new System.EventHandler(this.BTAddTestAppointment_Click);
            // 
            // BTClose
            // 
            this.BTClose.Location = new System.Drawing.Point(476, 621);
            this.BTClose.Name = "BTClose";
            this.BTClose.Size = new System.Drawing.Size(109, 32);
            this.BTClose.TabIndex = 12;
            this.BTClose.Text = "button2";
            this.BTClose.UseVisualStyleBackColor = true;
            // 
            // dGVTestAppointments
            // 
            this.dGVTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTestAppointments.ContextMenuStrip = this.contextMenuStripEditSchedule;
            this.dGVTestAppointments.Location = new System.Drawing.Point(16, 514);
            this.dGVTestAppointments.Name = "dGVTestAppointments";
            this.dGVTestAppointments.Size = new System.Drawing.Size(569, 114);
            this.dGVTestAppointments.TabIndex = 13;
            // 
            // contextMenuStripEditSchedule
            // 
            this.contextMenuStripEditSchedule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEditSchedule,
            this.toolStripMenuTakeTest});
            this.contextMenuStripEditSchedule.Name = "contextMenuStripEditSchedule";
            this.contextMenuStripEditSchedule.Size = new System.Drawing.Size(146, 48);
            this.contextMenuStripEditSchedule.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripEditSchedule_Opening);
            // 
            // toolStripMenuEditSchedule
            // 
            this.toolStripMenuEditSchedule.Name = "toolStripMenuEditSchedule";
            this.toolStripMenuEditSchedule.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuEditSchedule.Text = "Edit Schedule";
            this.toolStripMenuEditSchedule.Click += new System.EventHandler(this.toolStripMenuEditSchedule_Click);
            // 
            // toolStripMenuTakeTest
            // 
            this.toolStripMenuTakeTest.Name = "toolStripMenuTakeTest";
            this.toolStripMenuTakeTest.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuTakeTest.Text = "Take Test";
            this.toolStripMenuTakeTest.Click += new System.EventHandler(this.toolStripMenuTakeTest_Click);
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(0, 160);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(598, 331);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 6;
            // 
            // frmListTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 655);
            this.Controls.Add(this.dGVTestAppointments);
            this.Controls.Add(this.BTClose);
            this.Controls.Add(this.BTAddTestAppointment);
            this.Controls.Add(this.LbRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBTestAppointmentsTitle);
            this.Name = "frmListTestAppointments";
            this.Text = "frmListTestAppointments";
            this.Load += new System.EventHandler(this.frmListTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTestAppointments)).EndInit();
            this.contextMenuStripEditSchedule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBTestAppointmentsTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbRecords;
        private System.Windows.Forms.Button BTAddTestAppointment;
        private System.Windows.Forms.Button BTClose;
        private System.Windows.Forms.DataGridView dGVTestAppointments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEditSchedule;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEditSchedule;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTakeTest;
    }
}