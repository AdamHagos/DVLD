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
    public partial class frmListInternationalLicenseApplications : Form
    {
        public frmListInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.GetDriverInfoByID(int.Parse(dGVListInternationalLicenses.CurrentRow.Cells[2].Value.ToString()));
            frmShowPersonInfo frm = new frmShowPersonInfo(Driver.PersonID);
            frm.ShowDialog();
        }

        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            clsInternationalLicense InternationalLicense = clsInternationalLicense.GetInternationalLicenseInfoByID(int.Parse(dGVListInternationalLicenses.CurrentRow.Cells[0].Value.ToString()));
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(InternationalLicense.InternationalLicenseID);
            frm.ShowDialog();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.GetDriverInfoByID(int.Parse(dGVListInternationalLicenses.CurrentRow.Cells[2].Value.ToString()));
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(Driver.DriverID);
            frm.ShowDialog();
        }
    }
}
