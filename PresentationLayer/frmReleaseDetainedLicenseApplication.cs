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
    public partial class frmReleaseDetainedLicenseApplication : Form
    {
        private clsDetainedLicense _DetainedLicense;
        private int _LicenseID;
        private void fillDetainInfoFilter()
        {
            LBDetainID.Text = _DetainedLicense.DetainID.ToString();
            LBDetainDate.Text = _DetainedLicense.DetainDate.ToString();
            LBApplicationFees.Text = clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.ReleaseDetainedDrivingLicense).ApplicationFees.ToString();
            LBTotalFees.Text = (clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.ReleaseDetainedDrivingLicense).ApplicationFees + this._DetainedLicense.FineFees).ToString();
            LBLicenseID.Text = _DetainedLicense.LicenseID.ToString();
            LBCreatedBy.Text = _DetainedLicense.CreatedByUserID.ToString();
            LBFineFees.Text = _DetainedLicense.FineFees.ToString();
            
        }
        public frmReleaseDetainedLicenseApplication(int LicenseID)
        {
            InitializeComponent();
            this._LicenseID = LicenseID;
        }
        //public frmReleaseDetainedLicenseApplication()
        //{
        //    InitializeComponent();
        //}
        private void LKShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(this._DetainedLicense.LicenseInfo.DriverID);
            frm.ShowDialog();
        }

        private void LKShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(this._DetainedLicense.LicenseID);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseIDSelected(int obj)
        {
            int LicenseID = obj;
            if (!clsDetainedLicense.IsDetained(LicenseID))
            {
                MessageBox.Show("License is not detained");
                return;
            }
            this._DetainedLicense = clsDetainedLicense.GetDetainedLicenseInfoByLicenseID(LicenseID);

            fillDetainInfoFilter();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsApplication Application = new clsApplication();
            Application.ApplicantPersonID = this._DetainedLicense.LicenseInfo.DriverInfo.PersonID;
            Application.ApplicationTypeID = (int)clsApplicationType.enApplicationTypes.ReleaseDetainedDrivingLicense;
            Application.ApplicationStatus = (int)clsApplication.enStatus.Completed;
            Application.PaidFees = int.Parse(LBTotalFees.Text);
            Application.CreatedByUserID = Global.CurrentUser.UserID;
            if (!Application.Save())
            {
                MessageBox.Show("Could not issue Application record");
                return;
            }
            LBApplicationID.Text = Application.ApplicationID.ToString();

            this._DetainedLicense.IsReleased = true;
            this._DetainedLicense.ReleaseDate = DateTime.Now;
            this._DetainedLicense.ReleasedByUserID = Global.CurrentUser.UserID;
            this._DetainedLicense.ReleaseApplicationID = Application.ApplicationID;
            if (!this._DetainedLicense.Save())
            {
                MessageBox.Show("Could not issue Detained License record");
                return;
            }
            MessageBox.Show("License Released");
            button1.Enabled = false;
        }

        private void frmReleaseDetainedLicenseApplication_Load(object sender, EventArgs e)
        {
            if (this._LicenseID != -1)
            {
                if (!ctrlDriverLicenseInfoWithFilter1.LoadDriverLicenseInfo(this._LicenseID))
                {
                    MessageBox.Show("Could not Find License info");
                    this.Close();
                }
                this._DetainedLicense = clsDetainedLicense.GetDetainedLicenseInfoByLicenseID(this._LicenseID); ;
                fillDetainInfoFilter();
                button1.Enabled = true;
            }
        }
    }
}
