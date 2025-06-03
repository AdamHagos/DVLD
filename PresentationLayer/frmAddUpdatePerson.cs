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
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void SaveCompletedEventHandler(object sender, int PersonID);
        public event SaveCompletedEventHandler SaveCompleted;
        private clsPerson _Person;
        private int _PersonID;
        private enum enMode {Add,Update }
        private enMode Mode;
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            this._PersonID = PersonID;
            if (PersonID == -1)
            {
                Mode = enMode.Add;
            }
            else
            {
                Mode = enMode.Update;
            }
        }
        private void _FillCountriesComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                comboBox1.Items.Add(row["CountryName"]);
            }
        }
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _FillCountriesComboBox();
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            if (Mode == enMode.Add)
            {
                this._Person = new clsPerson();
                return;
            }

            this._Person = clsPerson.GetPersonInfoByID(this._PersonID);

            LbTitle.Text = "Update Person";
            LbPersonID.Text = this._Person.PersonID.ToString();
            TbFirst.Text = this._Person.FirstName.ToString();
            TbSeond.Text = this._Person.SecondName.ToString();
            TbThird.Text = this._Person.ThirdName.ToString();
            TbLast.Text = this._Person.LastName.ToString();
            tbNationalNo.Text = this._Person.NationalNo.ToString();
            if (this._Person.Gendor == 0)
            {
                radioButton0.Checked = true;
            }
            else
            {
                radioButton0.Checked = false;
            }
            dateTimePicker1.Value = this._Person.DateOfBirth;
            tbEmail.Text = this._Person.Email.ToString();
            RTBAddress.Text = this._Person.Address.ToString();
            tbPhone.Text = this._Person.Phone.ToString();
            comboBox1.SelectedItem = this._Person.CountryInfo.CountryName;
        }
        private void FillPersonObject()
        {
            this._Person.NationalNo = tbNationalNo.Text;
            this._Person.FirstName = TbFirst.Text;
            this._Person.SecondName = TbSeond.Text;
            this._Person.ThirdName = TbThird.Text;
            this._Person.LastName = TbLast.Text;
            if (radioButton0.Checked)
            {
                this._Person.Gendor = 0;
            }
            else
            {
                this._Person.Gendor = 1;
            }
            this._Person.NationalityCountryID = clsCountry.GetCountryID(comboBox1.SelectedItem.ToString());
            this._Person.DateOfBirth = dateTimePicker1.Value;
            this._Person.Email = tbEmail.Text;
            this._Person.Address = RTBAddress.Text;
            this._Person.Phone = tbPhone.Text;
        }
        private void BtSave_Click(object sender, EventArgs e)
        {
            FillPersonObject();
            if (this._Person.Save())
            {
                MessageBox.Show("Saved Successfully");
                LbTitle.Text = "Update Person";
                LbPersonID.Text = this._Person.PersonID.ToString();
                SaveCompleted?.Invoke(this, this._Person.PersonID);
                Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("Person wasnt saved");
            }
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (Mode == enMode.Add)
            {
                if (clsPerson.DoesNationalNoExists(tbNationalNo.Text))
                {
                    errorProvider1.SetError(tbNationalNo, "National No already exists");
                    return;
                }
                else
                {
                    errorProvider1.SetError(tbNationalNo, "");
                    return;
                }
            }
            

        }
    }
}
