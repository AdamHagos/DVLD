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
    public partial class frmScheduleTest : Form
    {
        public enum Mode { AddNew, Update }
        private Mode _enMode;
        private int _LocalDrivingLicenseApplicationID;
        private int _TestTypeID;
        private int _TestAppointmentID = -1;
        public frmScheduleTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            InitializeComponent();
            this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this._TestTypeID = TestTypeID;
            this._enMode = Mode.AddNew;
        }
        public frmScheduleTest(int TestAppointmentID)
        {
            InitializeComponent();
            this._TestAppointmentID = TestAppointmentID;
            this._enMode = Mode.Update;
        }
        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            if (this._enMode == Mode.AddNew)
            {
                ctrlScheduleTest1._SetAppointment(this._LocalDrivingLicenseApplicationID, this._TestTypeID);
            }
            else
            {
                ctrlScheduleTest1.LoadScheduleTest(this._TestAppointmentID);
            }
        }
    }
}
