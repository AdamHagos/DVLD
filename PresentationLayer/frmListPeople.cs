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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedItem = "None";
            //dGVListPeople.DataSource = clsPerson.GetAllPeople(comboBox1.SelectedItem.ToString());
            dGVListPeople.DataSource = clsPerson.GetAllPeople("None");
            //LbRecords.Text = dGVListPeople.RowCount.ToString();
            textBox1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Person ID")
            {
                if (!char.IsDigit(e.KeyChar) || !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
            dGVListPeople.DataSource = clsPerson.GetAllPeople(comboBox1.SelectedItem.ToString(), textBox1.Text);
            LbRecords.Text = dGVListPeople.RowCount.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != "None")
            {
                textBox1.Visible = true;
            }
        }
        private void _RefreshPeopleList()
        {
            dGVListPeople.DataSource = clsPerson.GetAllPeople();
            LbRecords.Text = dGVListPeople.RowCount.ToString();
        }
        private void RefreshDataGridView(object sender, int PersonID)
        {
            //dGVListPeople.DataSource = clsPerson.GetAllPeople(comboBox1.SelectedItem.ToString(), textBox1.Text);
            _RefreshPeopleList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.SaveCompleted += RefreshDataGridView;
            frm.ShowDialog();
        }

        private void toolStripShowDetails_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dGVListPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void toolStripAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.SaveCompleted += RefreshDataGridView;
            frm.ShowDialog();

        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            if (clsPerson.DeletePersonByID((int)dGVListPeople.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Person Can not be Deleted");
            }
            _RefreshPeopleList();
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson((int)dGVListPeople.CurrentRow.Cells[0].Value);
            frm.SaveCompleted += RefreshDataGridView;
            frm.ShowDialog();
        }
    }
}
