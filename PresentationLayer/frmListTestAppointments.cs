using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmListTestAppointments : Form
    {
        private int _LocalDrivingLicenseApplication;
        private int _TestTypeID;
        private void SetAppointmentTitle()
        {
            LBTestAppointmentsTitle.Text = clsTestType.GetTestTypeInfoByID(this._TestTypeID).TestTypeTitle;
        }
        public frmListTestAppointments(int LocalDLApplication, int TestTypeID)
        {
            InitializeComponent();
            this._LocalDrivingLicenseApplication = LocalDLApplication;
            this._TestTypeID = TestTypeID;
        }
        private void LoadTestAppointmentList()
        {
            dGVTestAppointments.DataSource = clsTestAppointment.GetTestAppointments(this._LocalDrivingLicenseApplication,this._TestTypeID);
            LbRecords.Text = dGVTestAppointments.RowCount.ToString();
        }
        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadLocalDrivingLicenseApplicationInfo(_LocalDrivingLicenseApplication);
            SetAppointmentTitle();
            LoadTestAppointmentList();
        }
        private void ShowScheduleTestForm()
        {
            frmScheduleTest frm = new frmScheduleTest(this._LocalDrivingLicenseApplication, this._TestTypeID);
            frm.ShowDialog();
        }
        
        private void BTAddTestAppointment_Click(object sender, EventArgs e)
        {
            if (clsTest.PassedTest(this._LocalDrivingLicenseApplication, this._TestTypeID))
            {
                MessageBox.Show("You cant Set Appointment because he already Passed the Test");
                return;
            }
            if (clsTestAppointment.IsTestScheduledNotTakenYet(this._LocalDrivingLicenseApplication, this._TestTypeID))
            {
                MessageBox.Show("You cant Set Appointment because he already have Active Test Appointment");
                return;
            }
            ShowScheduleTestForm();
            LoadTestAppointmentList();
        }

        private void contextMenuStripEditSchedule_Opening(object sender, CancelEventArgs e)
        {
            toolStripMenuEditSchedule.Enabled = true;
            toolStripMenuTakeTest.Enabled = !bool.Parse(dGVTestAppointments.CurrentRow.Cells[3].Value.ToString());
            //if (bool.Parse(dGVTestAppointments.CurrentRow.Cells[3].Value.ToString()))
            //{
            //    toolStripMenuTakeTest.Enabled = false;
            //}
        }

        private void toolStripMenuEditSchedule_Click(object sender, EventArgs e)
        {
            frmScheduleTest frm = new frmScheduleTest(int.Parse(dGVTestAppointments.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
            LoadTestAppointmentList();
        }

        private void toolStripMenuTakeTest_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest(int.Parse(dGVTestAppointments.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
            LoadTestAppointmentList();
        }
    }
}
