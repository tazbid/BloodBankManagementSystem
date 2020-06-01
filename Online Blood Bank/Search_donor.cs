using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Online_Blood_Bank
{
    public partial class Search_donor : Form
    {
        public Search_donor()
        {
            InitializeComponent();
        }

        private void comboBox_SearchDonor_SelectDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sdivision = comboBox_SearchDonor_SelectDivision.Text;
            try
            {
                Database db = new Database();
                db.CityChange(comboBox_SearchDonor_SelectCity, sdivision);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_SearchDonor_Click(object sender, EventArgs e)
        {

            string SelectBloodGroup = comboBox_SearchDonor_BloodGroup.Text;
            string SelectDivision = comboBox_SearchDonor_SelectDivision.Text;
            string SelectCity = comboBox_SearchDonor_SelectCity.Text;

            if(SelectBloodGroup.Length==0)
            {
                MessageBox.Show("Please select a Blood Group!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(SelectDivision.Length==0)
            {
                MessageBox.Show("Please select a Division!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(SelectCity.Length==0)
            {
                MessageBox.Show("Please select a City !", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                try
                {
                    Database db = new Database();
                    db.SeeDonorList(SelectBloodGroup, SelectDivision, SelectCity, dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_SearchDonor_BloodGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_SearchDonor_SelectDivision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_SearchDonor_SelectCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
