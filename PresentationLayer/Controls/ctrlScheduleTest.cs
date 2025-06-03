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
    public partial class ctrlScheduleTest : UserControl
    {
        private clsTestAppointment _TestAppointment;
        private clsApplication _RetakeTestApplication;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private int _TestTypeID;
        private int _Trails;
        public enum Mode { AddNew, Update }
        private Mode _enMode;
        public ctrlScheduleTest()
        {
            InitializeComponent();
            //Trying thisin the control constructor for the time
        }
        private void SetTestTitle(int TestTypeID)
        {
            groupBoxTestType.Text = clsTestType.GetTestTypeInfoByID(TestTypeID).TestTypeTitle;
        }
        private bool _LoadScheduleApplicationInfo()
        {
            if (_TestAppointment != null)
            {
                LBDLAppID.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
                LBDClass.Text = _TestAppointment.LocalDrivingLicenseApplicationInfo.LicenseClassInfo.ClassName.ToString();
                LBName.Text = _TestAppointment.LocalDrivingLicenseApplicationInfo.ApplicationInfo.ApplicantPersonInfo.FullName();
                LBTrial.Text = clsTest.Trials(_TestAppointment.LocalDrivingLicenseApplicationID, _TestAppointment.TestTypeID).ToString();
                dTPDate.Value = _TestAppointment.AppointmentDate;
                LBFees.Text = _TestAppointment.PaidFees.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool _LoadRetakeTestApplication()
        {
            _RetakeTestApplication = clsApplication.GetApplicationInfoByID(_TestAppointment.RetakeTestApplicationID);
            if (_RetakeTestApplication == null)
            {
                return false;
            }
            else
            {
                groupBoxRetakeTestFilter.Enabled = true;
                LBRAppFees.Text = _RetakeTestApplication.PaidFees.ToString();
                LBRTestAppID.Text = _RetakeTestApplication.ApplicationID.ToString();
                LBTotalFees.Text = (_TestAppointment.PaidFees + _RetakeTestApplication.PaidFees).ToString();
                return true;
            }
        }
        public bool LoadScheduleTest(int TestAppointmenID)
        {
            _TestAppointment = clsTestAppointment.GetTestAppointmentInfoByID(TestAppointmenID);
            SetTestTitle(_TestAppointment.TestTypeID);
            if (!_LoadScheduleApplicationInfo())
            {
                return false;
            }
            if (_TestAppointment.RetakeTestApplicationID != -1)
            {
                if (!_LoadRetakeTestApplication())
                {
                    return false;
                }
                LBScheduleTitle.Text = "Schedule Retake Test";
            }
            if (_TestAppointment.IsLocked)
            {
                LBSecondTitle.Text = "Applicant Already Sat for the exam";
                dTPDate.Enabled = false;
                BTSave.Enabled = false;
                if (!clsTestAppointment.IsTestAppointmentPassed(TestAppointmenID))
                {
                    LBScheduleTitle.Text = "Schedule Retake Test";
                }
            }
            this._enMode = Mode.Update;
            return true;
        }
        private void _FillScheduleApplicationInfo()
        {
            LBDLAppID.Text = this._LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            LBDClass.Text = this._LocalDrivingLicenseApplication.LicenseClassInfo.ClassName.ToString();
            LBName.Text = this._LocalDrivingLicenseApplication.ApplicationInfo.ApplicantPersonInfo.FullName();
            LBFees.Text = clsTestType.GetTestTypeInfoByID(this._TestTypeID).TestTypeFees.ToString();
            LBTrial.Text = this._Trails.ToString();
        }
        private void _FillRetakeTestApplicationInfo()
        {
            //this._RetakeTestApplication = new clsApplication();
            LBRAppFees.Text = clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.RetakeTest).ApplicationFees.ToString();
            LBTotalFees.Text = (int.Parse(LBRAppFees.Text) + int.Parse(LBFees.Text)).ToString();
        }
        public void _SetAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            this._enMode = Mode.AddNew;
            this._LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID);
            this._TestTypeID = TestTypeID;
            this._Trails = clsTest.Trials(this._LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, this._TestTypeID);

            _TestAppointment = new clsTestAppointment();
            SetTestTitle(this._TestTypeID);
            _FillScheduleApplicationInfo();
            if (this._Trails > 0)
            {
                LBScheduleTitle.Text = "Schedule Retake Test";
                _FillRetakeTestApplicationInfo();
                groupBoxRetakeTestFilter.Enabled = true;
            }
        }
        private bool _AddRetakeTestApplication(ref int RetakeTestApplicationID)
        {
            this._RetakeTestApplication = new clsApplication();
            this._RetakeTestApplication.ApplicantPersonID = this._LocalDrivingLicenseApplication.ApplicationInfo.ApplicantPersonID;
            this._RetakeTestApplication.ApplicationTypeID = (int)clsApplicationType.enApplicationTypes.RetakeTest;
            this._RetakeTestApplication.ApplicationStatus = (int)clsApplication.enStatus.Completed;
            this._RetakeTestApplication.PaidFees = clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.RetakeTest).ApplicationFees;
            this._RetakeTestApplication.CreatedByUserID = Global.CurrentUser.UserID;
            if (this._RetakeTestApplication.Save())
            {
                RetakeTestApplicationID = this._RetakeTestApplication.ApplicationID;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BTSave_Click(object sender, EventArgs e)
        {
            if(_enMode == Mode.AddNew)
            {
                this._TestAppointment.LocalDrivingLicenseApplicationID = int.Parse(LBDLAppID.Text);
                this._TestAppointment.TestTypeID = this._TestTypeID;
                this._TestAppointment.AppointmentDate = dTPDate.Value;
                this._TestAppointment.PaidFees = int.Parse(LBFees.Text);
                this._TestAppointment.CreatedByUserID = Global.CurrentUser.UserID;
            }
            else
            {
                this._TestAppointment.AppointmentDate = dTPDate.Value;
            }
            if (_enMode == Mode.AddNew & this._Trails > 0)
            {
                int RetakeTestApplicationID = -1;
                if (_AddRetakeTestApplication(ref RetakeTestApplicationID))
                {
                    this._TestAppointment.RetakeTestApplicationID = RetakeTestApplicationID;
                    LBRTestAppID.Text = RetakeTestApplicationID.ToString();
                }
                else
                {
                    MessageBox.Show("Failed Adding Retake Applicaion");
                    return;
                }
            }
            if (!this._TestAppointment.Save())
            {
                MessageBox.Show("Failed Saving Test Appointment");
                return;
            }

            MessageBox.Show("Test Appointment Saved Successfully");
            BTSave.Enabled = false;
        }
    }
}
