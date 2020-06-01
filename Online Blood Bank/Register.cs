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
    public partial class Register : Form
    {
        public Register(string pname)
        {
            InitializeComponent();
            textBoxReg_username.Text = pname;
        }
        string gender="Male";


        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            string division = comboBox_Division.Text;
            try
            {
                Database db = new Database();
                db.CityChange(comboBox_city, division);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            string fName = textBox_FirstName.Text;
            string lName = textBox_LastName.Text;
            string name = fName + ' ' + lName;
            string Uname = textBoxReg_username.Text;
            string blood_group = comboBox_BloodGroup.Text;
            string division = comboBox_Division.Text;
            string city = comboBox_city.Text;
            string mobile = textBox_MobileNo.Text;

            if (fName.Length == 0 || lName.Length == 0 || blood_group.Length == 0 || division.Length == 0 || city.Length == 0 || mobile.Length == 0)
            {
                MessageBox.Show("Please enter all the information correctly!", "Registration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


            else if (System.Text.RegularExpressions.Regex.IsMatch(mobile, "[^0-9.]"))
            {
                MessageBox.Show("Please use only numbers!", "Registration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (mobile.Length != 11)
            {
                MessageBox.Show("Please enter the mobile number properly!", "Registration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else
            {
                try
                {
                    Database db = new Database();
                    db.Register(name, Uname, blood_group, gender, division, city, mobile);

                    this.Close();
                    MessageBox.Show("Successfully registered as a Blood Donor. Thank You.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                catch (Exception ex)
                {
                    this.Close();
                    MessageBox.Show("You are already registered as a Blood Donor.","Already registered",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }

            }

        }


        private void radioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }



        private void textBox_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void textBox_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_BloodGroup_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBox_Division_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBox_city_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_MobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
          
        }

        private void radioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }
    }
}
