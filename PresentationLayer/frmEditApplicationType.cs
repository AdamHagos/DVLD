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
    public partial class frmEditApplicationType : Form
    {
        private clsApplicationType _ApplicationType;
        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            this._ApplicationType = clsApplicationType.GetApplicationTypeInfoByID(ApplicationTypeID);
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            LBID.Text = this._ApplicationType.ApplicationTypeID.ToString();
            TBTitle.Text = this._ApplicationType.ApplicationTypeTitle.ToString();
            TBFees.Text = this._ApplicationType.ApplicationFees.ToString();
        }

        private void BTClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            this._ApplicationType.ApplicationTypeTitle = TBTitle.Text;
            this._ApplicationType.ApplicationFees = int.Parse(TBFees.Text);
            this._ApplicationType.Save();
        }
    }
}
