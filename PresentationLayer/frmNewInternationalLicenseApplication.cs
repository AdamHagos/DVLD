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
    public partial class frmNewInternationalLicenseApplication : Form
    {
        private clsInternationalLicense _InternationalLicense;
        private clsLicense _License;
        private int _LicenseID;
        public frmNewInternationalLicenseApplication(int LicenseID)
        {
            InitializeComponent();
            this._LicenseID = LicenseID;
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            LBApplicationDate.Text = DateTime.Now.ToString();
            LBExpirationDate.Text = DateTime.Now.AddYears(1).ToString();
            LBissueDate.Text = DateTime.Now.ToString();
            LBCreatedBy.Text = Global.CurrentUser.UserName.ToString();

            if (this._LicenseID != -1)
            {
                ctrlDriverLicenseInfoWithFilter1.LoadDriverLicenseInfo(this._LicenseID);
                FillApplicationInfoFilter();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(this._License.DriverID);
            frm.ShowDialog();
        }
        private void FillApplicationInfoFilter()
        {
            this._License = clsLicense.GetLicenseInfoByID(this._LicenseID);
            LBLocalLicenseID.Text = this._LicenseID.ToString();
            LKShowLicensesHistory.Enabled = true;
            LbFees.Text = clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.NewInternationalLicense).ApplicationFees.ToString();
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseIDSelected(int obj)
        {
            int LicenseID = obj;
            int InternationalLicenseID = -1;
            if (clsInternationalLicense.DoesDriverHaveInternationalLicense(clsLicense.GetDriverID(LicenseID),ref InternationalLicenseID))
            {
                MessageBox.Show($"Driver Already have International License = {InternationalLicenseID}");
                return;
            }
            this._LicenseID = LicenseID;
            BTIsuue.Enabled = true;
            FillApplicationInfoFilter();
        }
        private bool AddApplication(ref int ApplicationID)
        {
            clsApplication Application = new clsApplication();
            Application.ApplicantPersonID = this._License.DriverInfo.PersonID;
            Application.ApplicationTypeID = (int)clsApplicationType.enApplicationTypes.NewInternationalLicense;
            Application.ApplicationStatus = (int)clsApplication.enStatus.Completed;
            Application.PaidFees = int.Parse(LbFees.Text);
            Application.CreatedByUserID = Global.CurrentUser.UserID;

            if (Application.Save())
            {
                ApplicationID =  Application.ApplicationID;
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool AddInternationalLicense(int ApplicationID)
        {
            this._InternationalLicense = new clsInternationalLicense();
            this._InternationalLicense.ApplicationID = ApplicationID;
            this._InternationalLicense.DriverID = this._License.DriverID;
            this._InternationalLicense.IssuedUsingLocalLicenseID = this._License.LicenseID;
            this._InternationalLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.GetLicenseClassInfoByID((int)clsLicenseClass.enLicenseClasses.OrdinaryDrivingLicense).DefaultValidityLength);
            this._InternationalLicense.CreatedByUserID = Global.CurrentUser.UserID;
            this._InternationalLicense.IsActive = true;
            return this._InternationalLicense.Save();
        }
        private void BTIsuue_Click(object sender, EventArgs e)
        {
            if (DateTime.Now > this._License.ExpirationDate)
            {
                MessageBox.Show("Can not issue int license because driver license is expired");
                return;
            }
            if (!this._License.IsActive)
            {
                MessageBox.Show("Can not issue int license because driver license is not Active");
                return;
            }
            if (this._License.LicenseClass != (int)clsLicenseClass.enLicenseClasses.OrdinaryDrivingLicense)
            {
                MessageBox.Show("only Ordinary License");
                return;
            }

            int ApplicationID = -1;
            if (!AddApplication(ref ApplicationID))
            {
                MessageBox.Show("Could not create an application record");
                return;
            }
            LBILApplicationID.Text = ApplicationID.ToString();

            if (!AddInternationalLicense(ApplicationID))
            {
                MessageBox.Show("Failed Issuing InternationalLicense");
                return;
            }
            LLShowLicenseInfo.Enabled = true;
            lbILLicense.Text = this._InternationalLicense.InternationalLicenseID.ToString();
            BTIsuue.Enabled = false;
            MessageBox.Show("International License Issued");
        }

        private void LLShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(this._InternationalLicense.InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
