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
    public partial class ctrlScheduledTest : UserControl
    {
        private int _TestAppointmentID;
        public ctrlScheduledTest()
        {
            InitializeComponent();
        }
        private void SetTestTitle(int TestTypeID)
        {
            groupBoxTestType.Text = clsTestType.GetTestTypeInfoByID(TestTypeID).TestTypeTitle;
        }
        public bool LoadScheduledTestInfo(int TestAppointmentID)
        {
            clsTestAppointment TestAppointment = clsTestAppointment.GetTestAppointmentInfoByID(TestAppointmentID);
            SetTestTitle(TestAppointment.TestTypeID);
            if (TestAppointment != null)
            {
                _TestAppointmentID = TestAppointment.TestAppointmentID;
                LBDLAppID.Text = TestAppointment.LocalDrivingLicenseApplicationID.ToString();
                LbDClass.Text = TestAppointment.LocalDrivingLicenseApplicationInfo.LicenseClassInfo.ClassName;
                LBName.Text = TestAppointment.LocalDrivingLicenseApplicationInfo.ApplicationInfo.ApplicantPersonInfo.FullName();
                LbTrial.Text = clsTest.Trials(TestAppointment.LocalDrivingLicenseApplicationID, TestAppointment.TestTypeID).ToString();
                LBDate.Text = TestAppointment.AppointmentDate.ToString();
                LBFees.Text = clsTestType.GetTestTypeInfoByID(TestAppointment.TestTypeID).TestTypeFees.ToString();
                return true;
            }
            return false;
        }
        private bool LockTestAppointment()
        {
            clsTestAppointment TestAppointment = clsTestAppointment.GetTestAppointmentInfoByID(this._TestAppointmentID);

            if (TestAppointment == null)
            {
                return false;
            }

            TestAppointment.IsLocked = true;
            return TestAppointment.Save();
        }
        private bool TestResultSaved(ref int TestID)
        {
            clsTest Test = new clsTest();
            Test.TestAppointmentID = this._TestAppointmentID;
            Test.TestResult = RBPass.Checked;
            Test.Notes = RTBNotes.Text;
            Test.CreatedByUserID = Global.CurrentUser.UserID;
            if (Test.Save())
            {
                TestID = Test.TestID;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BTSave_Click(object sender, EventArgs e)
        {
            if (!(RbFail.Checked || RBPass.Checked))
            {
                MessageBox.Show("Click either Pass or Fail");
                return;
            }
            
            
            int TestID = 0;
            if (TestResultSaved(ref TestID))
            {
                MessageBox.Show("Test Taken Successfully");
                LBTestID.Text = TestID.ToString();
            }
            else
            {
                MessageBox.Show("Could not Save The Test");
            }

            if (!LockTestAppointment())
            {
                MessageBox.Show("Could not Lock The Test Appointment");
            }

            BTSave.Enabled = false;
        }
    }
}
