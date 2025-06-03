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
        private int _ApplicationTypeID = -1;
        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            this._ApplicationTypeID = ApplicationTypeID;
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            this._ApplicationType = clsApplicationType.GetApplicationTypeInfoByID(this._ApplicationTypeID);
            LBID.Text = this._ApplicationType.ApplicationTypeID.ToString();
            TBTitle.Text = this._ApplicationType.ApplicationTypeTitle;
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
