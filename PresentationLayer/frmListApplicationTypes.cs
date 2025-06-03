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
    public partial class frmListApplicationTypes : Form
    {
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }
        private void _RefreshApplicationTypes()
        {
            dGVApplicationTypes.DataSource = clsApplicationType.GetAllApplicationTypes();
        }
        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypes();
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frm = new frmEditApplicationType(int.Parse(dGVApplicationTypes.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
            _RefreshApplicationTypes();
        }
    }
}
