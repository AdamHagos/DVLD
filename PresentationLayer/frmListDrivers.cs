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
    public partial class frmListDrivers : Form
    {
        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void tsmShowPersonInfo_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.GetDriverInfoByID(int.Parse(dGVListDrivers.CurrentRow.Cells[0].Value.ToString()));
            frmShowPersonInfo frm = new frmShowPersonInfo(Driver.PersonID);
            frm.ShowDialog();
        }

        private void tsmIssueInternationalLicense_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication(clsLicense.GetActiveOrdinaryLicenseID(int.Parse(dGVListDrivers.CurrentRow.Cells[0].Value.ToString())));
            frm.ShowDialog();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(int.Parse(dGVListDrivers.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            dGVListDrivers.DataSource = clsDriver.GetAllDrivers();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int InternationalLicenseID = -1;

            tsmIssueInternationalLicense.Enabled = !clsInternationalLicense.DoesDriverHaveInternationalLicense(int.Parse(dGVListDrivers.CurrentRow.Cells[0].Value.ToString()), ref InternationalLicenseID);

            if (clsInternationalLicense.DoesDriverHaveInternationalLicense(int.Parse(dGVListDrivers.CurrentRow.Cells[0].Value.ToString()), ref InternationalLicenseID))
            {
                tsmIssueInternationalLicense.Enabled = false;
            }
            else
            {
                int LicenseID = clsLicense.GetActiveOrdinaryLicenseID(int.Parse(dGVListDrivers.CurrentRow.Cells[0].Value.ToString()));

                tsmIssueInternationalLicense.Enabled = LicenseID != -1;
            }
        }
    }
}
