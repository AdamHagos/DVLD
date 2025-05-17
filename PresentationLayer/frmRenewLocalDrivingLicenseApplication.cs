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
    public partial class frmRenewLocalDrivingLicenseApplication : Form
    {
        private clsLicense _OldLicense;
        private int _RenewedLicenseID;
        public frmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void FillApplicationNewLicenseInfo()
        {
            LBApplicationDate.Text = DateTime.Now.ToString();
            LBIssueDate.Text = DateTime.Now.ToString();
            LBApplicationFees.Text = clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.RenewDrivingLicenseService).ApplicationFees.ToString();
            LBLicenseFees.Text = clsLicenseClass.GetLicenseClassInfoByID((int)clsLicenseClass.enLicenseClasses.OrdinaryDrivingLicense).ClassFees.ToString();
            LBOldLicenseID.Text = _OldLicense.LicenseID.ToString();
            LBExpirationDate.Text = _OldLicense.ExpirationDate.ToString();
            LBCreatedBy.Text = Global.CurrentUser.UserName;
            LbTotalFees.Text = (int.Parse(LBLicenseFees.Text) + int.Parse(LBApplicationFees.Text)).ToString();
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseIDSelected(int obj)
        {
            int LicenseID = obj;
            _OldLicense = clsLicense.GetLicenseInfoByID(LicenseID);

            if (_OldLicense.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show($"The license is not expired it will expire in {_OldLicense.ExpirationDate}");
                return;
            }

            BTRenewLicense.Enabled = true;
            LKShowLicensesHistory.Enabled = true;
            FillApplicationNewLicenseInfo();
        }

        private void LKShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(this._OldLicense.DriverID);
            frm.ShowDialog();
        }

        private void LKShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(this._RenewedLicenseID);
            frm.ShowDialog();
        }
        private bool AddApplication(ref int ApplicationID)
        {
            clsApplication Application = new clsApplication();
            Application.ApplicantPersonID = _OldLicense.DriverInfo.PersonID;
            Application.ApplicationTypeID = (int)clsApplicationType.enApplicationTypes.RenewDrivingLicenseService;
            Application.ApplicationStatus = (int)clsApplication.enStatus.Completed;
            Application.PaidFees = int.Parse(LBApplicationFees.Text);
            Application.CreatedByUserID = Global.CurrentUser.UserID;
            if (Application.Save())
            {
                ApplicationID = Application.ApplicationID;
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool DeactivateOldLicense()
        {
            _OldLicense.IsActive = false;
            return _OldLicense.Save();
        }
        private bool RenewLicense(int ApplicationID)
        {
            clsLicense RenewedLicense = new clsLicense();
            RenewedLicense.ApplicationID = ApplicationID;
            RenewedLicense.DriverID = this._OldLicense.DriverID;
            RenewedLicense.LicenseClass = (int)clsLicenseClass.enLicenseClasses.OrdinaryDrivingLicense;
            RenewedLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.GetLicenseClassInfoByID((int)clsLicenseClass.enLicenseClasses.OrdinaryDrivingLicense).DefaultValidityLength);
            RenewedLicense.Notes = RTBNotes.Text;
            RenewedLicense.PaidFees = int.Parse(LBLicenseFees.Text);
            RenewedLicense.IsActive = true;
            RenewedLicense.IssueReason = (int)clsLicense.enIssueReasons.Renew;
            RenewedLicense.CreatedByUserID = Global.CurrentUser.UserID;
            if (RenewedLicense.Save())
            {
                _RenewedLicenseID = RenewedLicense.LicenseID;
                return true;
            }
            return false;
        }
        private void BTRenewLicense_Click(object sender, EventArgs e)
        {
            int ApplicationID = -1;
            if (!AddApplication(ref ApplicationID))
            {
                MessageBox.Show("Could not issue Application record ");
                return;
            }
            LBRLApplicationID.Text = ApplicationID.ToString();

            if (!DeactivateOldLicense())
            {
                MessageBox.Show("Could not deactivate the license");
                return;
            }

            if (!RenewLicense(ApplicationID))
            {
                MessageBox.Show("Could not Renew the license");
                return;
            }
            LKShowNewLicenseInfo.Enabled = true;
            LBRenewedLicenseID.Text = _RenewedLicenseID.ToString();
            BTRenewLicense.Enabled = false;
            MessageBox.Show($"license Renewed new License ID = {_RenewedLicenseID}");
        }
    }
}
