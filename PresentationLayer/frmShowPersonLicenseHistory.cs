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
    public partial class frmShowPersonLicenseHistory : Form
    {
        private clsDriver _Driver;
        public frmShowPersonLicenseHistory(int DriverID)
        {
            InitializeComponent();
            this._Driver = clsDriver.GetDriverInfoByID(DriverID);
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if (this._Driver == null)
            {
                MessageBox.Show("Could not load because Driver is null");
                return;
            }
            ctrlPersonCardWithFitler1.LoadPersonInfo(this._Driver.PersonID);
            ctrlDriverLicenses1.LoadDriverLicenses(this._Driver.DriverID);
        }

        //public void LoadPersonLicenseHistory(int PersonID)
        //{
        //    ctrlPersonCardWithFitler1.LoadPersonInfo(PersonID);
        //}
    }
}
