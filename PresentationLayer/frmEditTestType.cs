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
    public partial class frmEditTestType : Form
    {
        private clsTestType _TestType;
        private int _TestTypeID;
        public frmEditTestType(int TestTypeID)
        {
            InitializeComponent();
            this._TestTypeID = TestTypeID;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            this._TestType.TestTypeTitle = TBTitle.Text;
            this._TestType.TestTypeDescription = RTBDescription.Text;
            this._TestType.TestTypeFees = int.Parse(TBFees.Text);
            this._TestType.Save();
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            this._TestType = clsTestType.GetTestTypeInfoByID(this._TestTypeID);
            LBID.Text = this._TestType.TestTypeID.ToString();
            TBTitle.Text = this._TestType.TestTypeTitle;
            RTBDescription.Text = this._TestType.TestTypeDescription;
            TBFees.Text = this._TestType.TestTypeFees.ToString();
        }
    }
}
