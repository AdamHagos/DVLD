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
    public partial class frmTakeTest : Form
    {
        private int _TestAppointmentID;
        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();
            this._TestAppointmentID = TestAppointmentID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.LoadScheduledTestInfo(this._TestAppointmentID);
        }
    }
}
