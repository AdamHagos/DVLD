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
    public partial class frmDetainLicenseApplication : Form
    {
        public frmDetainLicenseApplication()
        {
            InitializeComponent();
        }
        private clsLicense _License;
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseIDSelected(int obj)
        {
            int LicenseID = obj;
            if (clsDetainedLicense.IsDetained(LicenseID))
            {
                MessageBox.Show("Driver License is Already Detained");
                return;
            }
            this._License = clsLicense.GetLicenseInfoByID(LicenseID);
            if (this._License == null)
            {
                MessageBox.Show("Driver License is null or could not be found");
                return;
            }
            LLShowLicenseInfo.Enabled = true;
            LLShowLicensesHistory.Enabled = true;
            BTDetain.Enabled = true;
            LBDetainDate.Text = DateTime.Now.ToString();
            LBLicenseID.Text = LicenseID.ToString();
            LBCreatedBy.Text = Global.CurrentUser.UserName;
        }

        private void BTClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTDetain_Click(object sender, EventArgs e)
        {
            clsDetainedLicense DetainedLicense = new clsDetainedLicense();
            DetainedLicense.LicenseID = this._License.LicenseID;
            if (int.TryParse(TBFineFees.ToString(), out int FineFees))
            {
                DetainedLicense.FineFees = FineFees;
            }
            else
            {
                if (string.IsNullOrEmpty(TBFineFees.Text))
                {
                    MessageBox.Show("FineFees cant be empty");
                    return;
                }
                else
                {
                    MessageBox.Show("enter valid Fine fees");
                    return;
                }
            }
            DetainedLicense.CreatedByUserID = Global.CurrentUser.UserID;
            if (!DetainedLicense.Save())
            {
                MessageBox.Show("Could not issue detain record");
            }
            LBDetainID.Text = DetainedLicense.DetainID.ToString();
            BTDetain.Enabled = false;
        }

        private void LLShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(this._License.LicenseID);
            frm.ShowDialog();
        }

        private void LLShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(this._License.DriverID);
            frm.ShowDialog();
        }
    }
}
