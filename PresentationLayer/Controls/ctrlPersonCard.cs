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
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson Person;
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private int PersonID;
        private void RefreshPersonInfo(object sender, int PersonID)
        {
            LoadPersonInfo(PersonID);
        }
        public bool LoadPersonInfo(int PersonID)
        {
            Person = clsPerson.GetPersonInfoByID(PersonID);
            if (Person != null)
            {
                this.PersonID = PersonID;
                lbPersonID.Text = PersonID.ToString();
                lbName.Text = Person.FullName();
                lbNationalNo.Text = Person.NationalNo;
                if (Person.Gendor == 0)
                {
                    lbGendor.Text = "Male";
                }
                else
                {
                    lbGendor.Text = "Female";
                }
                lbEmail.Text = Person.Email;
                lbAddress.Text = Person.Address;
                lbDateOfBirth.Text = Person.DateOfBirth.ToString();
                lbPhone.Text = Person.Phone;
                lbCountry.Text = Person.CountryInfo.CountryName;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LKEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(this.PersonID);
            frm.SaveCompleted += RefreshPersonInfo;
            frm.ShowDialog();
        }
    }
}
