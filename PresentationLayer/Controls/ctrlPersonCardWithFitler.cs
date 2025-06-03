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
    public partial class ctrlPersonCardWithFitler : UserControl
    {
        public int _PersonID {  get; private set; }
        public ctrlPersonCardWithFitler()
        {
            InitializeComponent();
        }
        private void SearchForPerson()
        {
            if (comboBox1.SelectedItem.ToString() == "Person ID")
            {
                bool IsSuccess = int.TryParse(textBox1.Text, out int PersonID);
                if (IsSuccess)
                {
                    if (!ctrlPersonCard1.LoadPersonInfo(PersonID))
                    {
                        MessageBox.Show("could not Load Person info");
                        return;
                    }
                    this._PersonID = PersonID;
                }
                else
                {
                    MessageBox.Show("enter a valid input");
                    return;
                }
            }
            if (comboBox1.SelectedItem.ToString() == "National No")
            {
                int PersonID = clsPerson.GetPersonID(textBox1.Text);
                if (PersonID != -1)
                {
                    if (!ctrlPersonCard1.LoadPersonInfo(PersonID))
                    {
                        MessageBox.Show("could not Load Person info");
                        return;
                    }
                    this._PersonID = PersonID;
                }
                else
                {
                    MessageBox.Show("Person Do not Exist");
                }
            }

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchForPerson();
            }
        }

        private void ctrlPersonCardWithFitler_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = clsPerson.GetFilterPeopleByOptions();
            comboBox1.DisplayMember = "Person ID";
            comboBox1.SelectedItem = "Person ID";
        }
        public void LoadPersonInfo(int PersonID)
        {
            GBFilter.Enabled = false;
            textBox1.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
            this._PersonID = PersonID;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Person ID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void BTOkay_Click(object sender, EventArgs e)
        {
            SearchForPerson();
        }
        //private void Recieve
        private void _RefreshPersonControl(object sender, int PersonID)
        {
            LoadPersonInfo(PersonID);
            this._PersonID = PersonID;
        }
        private void BTAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.SaveCompleted += _RefreshPersonControl;
            frm.ShowDialog();
        }
    }
}
