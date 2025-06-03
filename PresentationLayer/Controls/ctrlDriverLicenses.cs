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
    public partial class ctrlDriverLicenses : UserControl
    {
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDriverLicenses(int DriverID)
        {
            DGVLocalLicenses.DataSource = clsLicense.GetDriverLicenses(DriverID);
            DGVInternational.DataSource = clsInternationalLicense.GetDriverInternationalLicenses(DriverID);
            LbRecords.Text = DGVLocalLicenses.Rows.Count.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                LbRecords.Text = DGVLocalLicenses.Rows.Count.ToString();
            }
            else
            {
                LbRecords.Text = DGVInternational.Rows.Count.ToString();
            }
        }

        private void LbRecords_Click(object sender, EventArgs e)
        {

        }

        private void tsmShowLicenseInfo_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                frmShowLicenseInfo frm = new frmShowLicenseInfo(int.Parse(DGVLocalLicenses.CurrentRow.Cells[0].Value.ToString()));
                frm.ShowDialog();
            }
            else
            {
                frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(int.Parse(DGVInternational.CurrentRow.Cells[0].Value.ToString()));
                frm.ShowDialog();
            }
        }
    }
}
