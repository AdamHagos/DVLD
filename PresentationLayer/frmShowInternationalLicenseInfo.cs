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
    public partial class frmShowInternationalLicenseInfo : Form
    {
        private int _InternationalLicenseID;
        public frmShowInternationalLicenseInfo(int internationalLicenseID)
        {
            InitializeComponent();
            this._InternationalLicenseID = internationalLicenseID;
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            if (!ctrlDriverInternationalLicenseInfo1.LoadDriverInternationalLicenseInfo(this._InternationalLicenseID))
            {
                MessageBox.Show("Cant Load Driver International License Info");
            }
        }
    }
}
