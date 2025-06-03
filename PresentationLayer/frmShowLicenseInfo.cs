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
    public partial class frmShowLicenseInfo : Form
    {
        private int _LicenseID;
        public frmShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            this._LicenseID = LicenseID;
        }

        private void frmShowLicenseInfo_Load(object sender, EventArgs e)
        {
            if (!ctrlDriverLicenseInfo1.LoadDriverLicenseInfo(this._LicenseID))
            {
                MessageBox.Show("License could not be loaded");
            }
        }
    }
}
