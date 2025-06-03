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
    public partial class frmShowPersonInfo : Form
    {
        private int PersonID;
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(this.PersonID);
        }
    }
}
