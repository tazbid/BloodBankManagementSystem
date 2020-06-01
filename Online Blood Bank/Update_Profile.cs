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
    public partial class Update_Profile : Form
    {
        public Update_Profile(string pname)
        {
            InitializeComponent();
            label_UpdateProfile_ProfileName.Text = pname;
        }
        string gender;


        private void Update_Profile_Load(object sender, EventArgs e)
        {

            try
            {
                Database db = new Database();
                db.GetSignupInfo(label_UpdateProfile_ProfileName.Text, textBox_UpdatePro_UserName, textBox_UpdatePro_Password, textBox_Updatepro_email);
                db.GetRegisterInfo(label_UpdateProfile_ProfileName.Text, textBox_UpdatePro_FullName, comboBox_BloodGroup, comboBox_division, comboBox_city, textBox_mobile, radioButton_male, radioButton_female);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void comboBox_division_SelectedIndexChanged(object sender, EventArgs e)
        {
            string division = comboBox_division.Text;
            Database db = new Database();
            db.CityChange(comboBox_city, division);
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

        private void comboBox_division_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button_update_info_Click(object sender, EventArgs e)
        {
            string uname = textBox_UpdatePro_UserName.Text;
            string pass = textBox_UpdatePro_Password.Text;
            string email = textBox_Updatepro_email.Text;
            string fullname = textBox_UpdatePro_FullName.Text;
            string bloodgroup = comboBox_BloodGroup.Text;
            string div = comboBox_division.Text;
            string city = comboBox_city.Text;
            string mobi = textBox_mobile.Text;
            
            if(uname.Length==0||pass.Length==0||email.Length==0)
            {
                MessageBox.Show("Please enter all the information correctly!", "Update Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if((textBox_UpdatePro_FullName.Enabled&&fullname.Length==0) || (comboBox_BloodGroup.Enabled&&bloodgroup.Length==0) || ( comboBox_division.Enabled&&div.Length==0) || (comboBox_city.Enabled&&city.Length==0) || (textBox_mobile.Enabled&&mobi.Length==0)  || (textBox_mobile.Enabled&&mobi.Length!=11))
            {
                MessageBox.Show("Please enter all the information correctly!", "Failed!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(pass.Length<6)
            {
                MessageBox.Show("Please choose a password of 6 or more characters.", "Update Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Database db = new Database();
                    db.UpdateSignUpTable(uname, pass, email);
                    db.UpdateRegisterTable(uname, fullname, bloodgroup, gender, div, city, mobi);
                    this.Close();
                    MessageBox.Show("Updated information successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Password already in use.Please choose another one.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
            

        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }
    }
}
