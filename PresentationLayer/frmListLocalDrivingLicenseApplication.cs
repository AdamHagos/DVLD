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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class frmListLocalDrivingLicenseApplication : Form
    {
        public frmListLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        private void _RefreshLocalApplicationsList()
        {
            dGVListLocalApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
        }
        private bool CancelTheApplication()
        {
            clsApplication Application = clsApplication.GetApplicationInfoByID(clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value).ApplicationID);
            Application.ApplicationStatus = (int)clsApplication.enStatus.Cancelled;
            Application.LastStatusDate = DateTime.Now;
            return Application.Save();
        }
        private void tsmShowApplicationDetails_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo frm = new frmLocalDrivingLicenseApplicationInfo((int)dGVListLocalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalApplicationsList();
        }
        private bool DeleteLocalApplication()
        {
            return clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplicationByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value);
        }
        private bool DeleteApplication()
        {
            int ApplicationID = clsLocalDrivingLicenseApplication.GetApplicationID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value);

            if (DeleteLocalApplication())
            {
                return clsApplication.DeleteApplicationByID(ApplicationID);
            }
            return false;
        }
        private void tsmDeleteApplication_Click(object sender, EventArgs e)
        {
            if (DeleteApplication())
            {
                MessageBox.Show("Local Application Deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete Local Application");
            }
        }
        
        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value);
            int DriverID = -1;
            if (clsPerson.IsDriver(LocalDrivingLicenseApplication.ApplicationInfo.ApplicantPersonID, ref DriverID))
            {
                frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(DriverID);
                frm.ShowDialog();
                _RefreshLocalApplicationsList();
            }
        }
        private void ScheduleTestsMenuStripeSettings()
        {
            tsmScheduleTests.Enabled = true;
            int PassedTests = (int)dGVListLocalApplications.CurrentRow.Cells[5].Value;
            if (PassedTests == 0)
            {
                tsmScheduleVisionTest.Enabled = true;
                tsmscheduleWrittenTest.Enabled = false;
                tsmScheduleStreetTest.Enabled = false;
                return;
            }
            else if (PassedTests == 1)
            {
                tsmScheduleVisionTest.Enabled = false;
                tsmscheduleWrittenTest.Enabled = true;
                tsmScheduleStreetTest.Enabled = false;
                return;
            }
            else if (PassedTests == 2)
            {
                tsmscheduleWrittenTest.Enabled = false;
                tsmScheduleVisionTest.Enabled = false;
                tsmScheduleStreetTest.Enabled = true;
                return;
            }
            tsmScheduleTests.Enabled = false;
        }
        private void CancelSettings()
        {
            tsmShowApplicationDetails.Enabled = true;
            tsmEditApplication.Enabled = false;
            tsmDeleteApplication.Enabled = false;
            tsmCancelApplication.Enabled = false;
            tsmIssueDrivingLicense.Enabled = false;
            tsmShowLicense.Enabled = false;
            tsmScheduleTests.Enabled = false;
            int DriverID = -1;
            tsmShowPersonLicenseHistory.Enabled = clsPerson.IsDriver(clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value).ApplicationInfo.ApplicantPersonID, ref DriverID);
        }
        private void NewSettings()
        {
            tsmShowApplicationDetails.Enabled = true;
            tsmEditApplication.Enabled = true;
            tsmDeleteApplication.Enabled = true;
            tsmCancelApplication.Enabled = true;
            tsmIssueDrivingLicense.Enabled = false;
            tsmShowLicense.Enabled = false;

            int LicenseID = -1;
            int PassedTests = (int)dGVListLocalApplications.CurrentRow.Cells[5].Value;
            if (PassedTests == 3)
            {
                tsmIssueDrivingLicense.Enabled = !clsLocalDrivingLicenseApplication.IsLicenseIssued(clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value).LocalDrivingLicenseApplicationID, ref LicenseID);
                tsmShowLicense.Enabled = !tsmIssueDrivingLicense.Enabled;
            }
        }
        private void CompletedSettings()
        {
            tsmShowApplicationDetails.Enabled = true;
            tsmEditApplication.Enabled = false;
            tsmDeleteApplication.Enabled = false;
            tsmCancelApplication.Enabled = false;
            tsmIssueDrivingLicense.Enabled = false;
            tsmScheduleTests.Enabled = false;
            int LicenseID = -1;
            tsmShowLicense.Enabled = clsLocalDrivingLicenseApplication.IsLicenseIssued((int)dGVListLocalApplications.CurrentRow.Cells[0].Value, ref LicenseID);
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ScheduleTestsMenuStripeSettings();

            string Status = dGVListLocalApplications.CurrentRow.Cells[6].Value.ToString();

            switch (Status)
            {
                case "New":
                    NewSettings();
                    break;
                case "Cancelled":
                    CancelSettings();
                    break;
                case "Completed":
                    CompletedSettings();
                    break;
            }
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value);
            int DriverID = -1;
            tsmShowPersonLicenseHistory.Enabled = clsPerson.IsDriver(LocalDrivingLicenseApplication.ApplicationInfo.ApplicantPersonID, ref DriverID);

        }

        private void tsmIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime((int)dGVListLocalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalApplicationsList();
        }

        private void frmListLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _RefreshLocalApplicationsList();
        }

        private void tsmCancelApplication_Click(object sender, EventArgs e)
        {
            if (CancelTheApplication())
            {
                MessageBox.Show("Application Cancelled");
            }
            else
            {
                MessageBox.Show("Could not Cancel the application");
            }
            _RefreshLocalApplicationsList();
        }

        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = -1;
            if (clsLocalDrivingLicenseApplication.IsLicenseIssued((int)dGVListLocalApplications.CurrentRow.Cells[0].Value, ref LicenseID))
            {
                frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
                frm.ShowDialog();
            }
        }

        private void tsmEditApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication((int)dGVListLocalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalApplicationsList();
        }

        private void tsmScheduleVisionTest_Click(object sender, EventArgs e)
        {
            frmListTestAppointments frm = new frmListTestAppointments((int)dGVListLocalApplications.CurrentRow.Cells[0].Value,(int)clsTestType.enTestTypes.VisionTest);
            frm.ShowDialog();
            _RefreshLocalApplicationsList();
        }

        private void tsmscheduleWrittenTest_Click(object sender, EventArgs e)
        {
            frmListTestAppointments frm = new frmListTestAppointments((int)dGVListLocalApplications.CurrentRow.Cells[0].Value, (int)clsTestType.enTestTypes.Written);
            frm.ShowDialog();
            _RefreshLocalApplicationsList();
        }

        private void tsmScheduleStreetTest_Click(object sender, EventArgs e)
        {
            frmListTestAppointments frm = new frmListTestAppointments((int)dGVListLocalApplications.CurrentRow.Cells[0].Value, (int)clsTestType.enTestTypes.Practical);
            frm.ShowDialog();
            _RefreshLocalApplicationsList();
        }
    }
}
