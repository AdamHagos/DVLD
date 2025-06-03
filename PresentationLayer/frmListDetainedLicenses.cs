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
    public partial class frmListDetainedLicenses : Form
    {
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
            clsLicense License = clsLicense.GetLicenseInfoByID(int.Parse(dGVListDetainedLicenses.CurrentRow.Cells[1].Value.ToString()));
            frmShowPersonInfo frm = new frmShowPersonInfo(License.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(int.Parse(dGVListDetainedLicenses.CurrentRow.Cells[1].Value.ToString()));
            frm.ShowDialog();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clsLicense License = clsLicense.GetLicenseInfoByID(int.Parse(dGVListDetainedLicenses.CurrentRow.Cells[1].Value.ToString()));
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(License.DriverID);
            frm.ShowDialog();
        }

        private void tsmReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication(int.Parse(dGVListDetainedLicenses.CurrentRow.Cells[1].Value.ToString()));
            frm.ShowDialog();
            _RefreshDetainedList();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            tsmReleaseDetainedLicense.Enabled = !bool.Parse(dGVListDetainedLicenses.CurrentRow.Cells[5].Value.ToString());
            
        }
        private void _RefreshDetainedList()
        {
            dGVListDetainedLicenses.DataSource = clsDetainedLicense.GetAllDetainedLicenses();
        }
        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            _RefreshDetainedList();
        }

        private void BTDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
            _RefreshDetainedList();
        }

        private void BTRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication(-1);
            frm.ShowDialog();
            _RefreshDetainedList();
        }
    }
}
