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
    public partial class frmReplaceLostOrDamagedLicenseApplication : Form
    {
        private clsLicense _OldLicense;
        private int _ReplacedLicenseID;
        private int _ApplicationID;
        public frmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        private bool LicenseReplaced()
        {
            clsLicense ReplacedLicense = new clsLicense();
            ReplacedLicense.ApplicationID = this._ApplicationID;
            ReplacedLicense.DriverID = this._OldLicense.DriverID;
            ReplacedLicense.LicenseClass = this._OldLicense.LicenseClass;
            ReplacedLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.GetLicenseClassInfoByID(ReplacedLicense.LicenseClass).DefaultValidityLength);
            ReplacedLicense.Notes = this._OldLicense.Notes;
            ReplacedLicense.PaidFees = clsLicenseClass.GetLicenseClassInfoByID(this._OldLicense.LicenseClass).ClassFees;
            ReplacedLicense.IsActive = true;
            if (RBDamagedLicense.Checked)
            {
                ReplacedLicense.IssueReason = (int)clsLicense.enIssueReasons.ReplacementForDamaged;
            }
            else
            {
                ReplacedLicense.IssueReason = (int)clsLicense.enIssueReasons.ReplacementForLost;
            }
            ReplacedLicense.CreatedByUserID = Global.CurrentUser.UserID;
            if (ReplacedLicense.Save())
            {
                this._ReplacedLicenseID = ReplacedLicense.LicenseID;
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool DeactivateOldLicense()
        {
            this._OldLicense.IsActive = false;
            return this._OldLicense.Save();
        }
        private bool CreateApplicationRecord()
        {
            clsApplication Application = new clsApplication();
            Application.ApplicantPersonID = this._OldLicense.DriverInfo.PersonID;
            if (RBDamagedLicense.Checked)
            {
                Application.ApplicationTypeID = (int)clsApplicationType.enApplicationTypes.ReplacementForADamagedDrivingLicense;
            }
            else
            {
                Application.ApplicationTypeID = (int)clsApplicationType.enApplicationTypes.ReplacementForALostDrivingLicense;
            }
            Application.ApplicationStatus = (int)clsApplication.enStatus.Completed;
            Application.PaidFees = int.Parse(LBApplicationFees.Text);
            Application.CreatedByUserID = Global.CurrentUser.UserID;
            if (Application.Save())
            {
                this._ApplicationID = Application.ApplicationID;
                return true;
            }
            return false;
        }
        private void LKShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(this._OldLicense.DriverID);
            frm.ShowDialog();
        }

        private void LKShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(this._ReplacedLicenseID);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTIssueReplacement_Click(object sender, EventArgs e)
        {
            if (!DeactivateOldLicense())
            {
                MessageBox.Show("Could not Deactivate Old License");
                return;
            }
            if (!CreateApplicationRecord())
            {
                MessageBox.Show("Could not Create Application Record");
                return;
            }
            LBLRApplicationID.Text = this._ApplicationID.ToString();
            if (!LicenseReplaced())
            {
                MessageBox.Show("Could not replace license");
                return;
            }
            MessageBox.Show("license Replaced new license ID = " + this._ReplacedLicenseID);
            LBReplacedLicenseID.Text = this._ReplacedLicenseID.ToString();
            BTIssueReplacement.Enabled = false;
            LKShowLicenseInfo.Enabled = true;
        }
        private void FillApplicationInfoForLicenseReplacement()
        {
            LBApplicationDate.Text = DateTime.Now.ToString();
            LBOldLicenseID.Text = this._OldLicense.LicenseID.ToString();
            LBCreatedBy.Text = Global.CurrentUser.UserName;
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseIDSelected(int obj)
        {
            int LicenseID = obj;
            this._OldLicense = clsLicense.GetLicenseInfoByID(LicenseID);

            if (this._OldLicense == null)
            {
                MessageBox.Show("Could not find the license");
                return;
            }
            if (!this._OldLicense.IsActive)
            {
                MessageBox.Show("Could not Replace unactive license");
                return;
            }

            BTIssueReplacement.Enabled = true;
            LKShowLicensesHistory.Enabled = true;

            FillApplicationInfoForLicenseReplacement();
        }

        private void RBDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDamagedLicense.Checked)
            {
                LbLicenseReplacement.Text = "Replacement for Damaged License";
                LBApplicationFees.Text = clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.ReplacementForADamagedDrivingLicense).ApplicationFees.ToString();
            }
        }

        private void RBLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (RBLostLicense.Checked)
            {
                LbLicenseReplacement.Text = "Replacement for Lost License";
                LBApplicationFees.Text = clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.ReplacementForALostDrivingLicense).ApplicationFees.ToString();
            }
        }

        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {
            //nothing
        }
    }
}
