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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }


        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            string user_name = textBox_SignUp_UserName.Text;
            string email = textBox_Email.Text;
            string password = textBox_SignUp_Password.Text;
            string confirm_pass = textBox_SignUp_ConfirmPassword.Text;

            if (user_name.Length == 0  || password.Length == 0 || confirm_pass.Length == 0)
            {
                MessageBox.Show("Please enter all the information correctly!", "Log-In failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (password.Length < 6)
            {
                MessageBox.Show("Please choose a password of 6 or more characters!", "Sign Up Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (password != confirm_pass)
            {
                MessageBox.Show("Your Passwords do not match.", "Sign-Up Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    Database db = new Database();
                    db.SignUp(user_name, password, email,this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Password already in use.Please choose another one.","Failed!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void textBox_SignUp_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
