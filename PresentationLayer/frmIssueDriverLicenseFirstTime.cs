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
    public partial class frmIssueDriverLicenseFirstTime : Form
    {
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private int _DriverID;
        public frmIssueDriverLicenseFirstTime(int LocalDrivingLicenseApplication)
        {
            InitializeComponent();
            this._LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplication);
        }

        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            if (!ctrlDrivingLicenseApplicationInfo1.LoadLocalDrivingLicenseApplicationInfo(this._LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("LocalDrivingLicenseApplication Does Not Exist");
                return;
            }
        }
        private bool MarkTheApplicationCompleted()
        {
            clsApplication Application = clsApplication.GetApplicationInfoByID(this._LocalDrivingLicenseApplication.ApplicationID);
            Application.ApplicationStatus = (int)clsApplication.enStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            return Application.Save();
        }
        private bool AddDriver()
        {
            clsDriver Driver = new clsDriver();
            Driver.CreatedByUserID = Global.CurrentUser.UserID;
            Driver.PersonID = this._LocalDrivingLicenseApplication.ApplicationInfo.ApplicantPersonID;
            if (Driver.Save())
            {
                this._DriverID = Driver.DriverID;
                return true;
            }
            return false;
        }
        private bool IssueLicense()
        {
            clsLicense License = new clsLicense();
            License.ApplicationID = this._LocalDrivingLicenseApplication.ApplicationID;
            License.DriverID = this._DriverID;
            License.LicenseClass = this._LocalDrivingLicenseApplication.LicenseClassID;
            License.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.GetLicenseClassInfoByID(this._LocalDrivingLicenseApplication.LicenseClassID).DefaultValidityLength);
            License.Notes = RTBNotes.Text;
            License.PaidFees = clsLicenseClass.GetLicenseClassInfoByID(this._LocalDrivingLicenseApplication.LicenseClassID).ClassFees;
            License.IsActive = true;
            License.IssueReason = (int)clsLicense.enIssueReasons.FirstTime;
            License.CreatedByUserID = Global.CurrentUser.UserID;
            return License.Save();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (clsPerson.IsDriver(this._LocalDrivingLicenseApplication.ApplicationInfo.ApplicantPersonID, ref this._DriverID))
            {
                if (!IssueLicense())
                {
                    MessageBox.Show("Could Not Issue License");
                    return;
                }
            }
            else
            {
                if (!AddDriver())
                {
                    MessageBox.Show("Could Not Add Driver");
                    return;
                }
                if (IssueLicense())
                {
                    MessageBox.Show("License Issued Successfully");
                    if (!MarkTheApplicationCompleted())
                    {
                        MessageBox.Show("Could not Mark the application completed");
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Could Not Issue License");
                    return;
                }
            }
        }
    }
}
