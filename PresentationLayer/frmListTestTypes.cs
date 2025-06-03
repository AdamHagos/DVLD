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
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }
        private void _RefreshTestTypes()
        {
            dGVTestTypes.DataSource = clsTestType.GetAllTestTypes();
        }
        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypes();
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType(int.Parse(dGVTestTypes.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
            _RefreshTestTypes();
        }
    }
}
