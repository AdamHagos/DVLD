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
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }
        public event Action<int> OnLicenseIDSelected;
        protected virtual void LicenseIDSelected(int licenseID)
        {
            Action<int> handler = OnLicenseIDSelected;
            if (handler != null)
            {
                handler(licenseID);
            }
        }
        public int LicenseIDTextBox;
        private void CheckUserInput()
        {
            if (int.TryParse(textBox1.Text, out int LicenseID))
            {
                if (!ctrlDriverLicenseInfo1.LoadDriverLicenseInfo(LicenseID))
                {
                    MessageBox.Show("License Dont exist");
                    return;
                }
                this.LicenseIDTextBox = LicenseID;
                if (groupBoxFilter.Enabled && OnLicenseIDSelected != null)
                {
                    LicenseIDSelected(LicenseID);
                }
            }
            else
            {
                MessageBox.Show("Enter numbers only");
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUserInput();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
        public bool LoadDriverLicenseInfo(int LicenseID)
        {//be cautous i edited this part
            if (!ctrlDriverLicenseInfo1.LoadDriverLicenseInfo(LicenseID))
            {
                MessageBox.Show("Could not load because license is not found");
                return false;
            }
            groupBoxFilter.Enabled = false;
            textBox1.Text = LicenseID.ToString();
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckUserInput();
        }
    }
}
