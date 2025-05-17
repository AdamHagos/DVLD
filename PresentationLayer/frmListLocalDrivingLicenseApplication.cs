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
        private void DeleteApplication()
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value);
            
            if (clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplicationByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value))
            {
                
            }
        }
        private void tsmDeleteApplication_Click(object sender, EventArgs e)
        {
            //How will the delete will happen is it through local applications or applications
            if (clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplicationByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value))
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
            int PassedTests = (int)dGVListLocalApplications.CurrentRow.Cells[5].Value;
            if (PassedTests == 0)
            {
                tsmscheduleWrittenTest.Enabled = false;
                tsmScheduleStreetTest.Enabled = false;
                return;
            }
            else if (PassedTests == 1)
            {
                tsmScheduleVisionTest.Enabled = false;
                tsmScheduleStreetTest.Enabled = false;
                return;
            }
            else if (PassedTests == 2)
            {
                tsmscheduleWrittenTest.Enabled = false;
                tsmScheduleVisionTest.Enabled = false;
                return;
            }
            tsmScheduleTests.Enabled = false;
        }
        private void CancelSettings()
        {
            tsmEditApplication.Enabled = false;
            tsmDeleteApplication.Enabled = false;
            tsmCancelApplication.Enabled = false;
            tsmIssueDrivingLicense.Enabled = false;
            tsmShowLicense.Enabled = false;
            int DriverID = -1;
            tsmShowPersonLicenseHistory.Enabled = clsPerson.IsDriver(clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value).ApplicationInfo.ApplicantPersonID, ref DriverID);
        }
        private void NewSettings()
        {
            int LicenseID = -1;
            tsmIssueDrivingLicense.Enabled = !clsLocalDrivingLicenseApplication.IsLicenseIssued(clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value).LocalDrivingLicenseApplicationID, ref LicenseID);
            tsmShowLicense.Enabled = clsLocalDrivingLicenseApplication.IsLicenseIssued(clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID((int)dGVListLocalApplications.CurrentRow.Cells[0].Value).LocalDrivingLicenseApplicationID, ref LicenseID);
        }
        private void CompletedSettings()
        {
            tsmEditApplication.Enabled = false;
            tsmDeleteApplication.Enabled = false;
            tsmCancelApplication.Enabled = false;
            tsmIssueDrivingLicense.Enabled = false;
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
            }
        }
    }
}
