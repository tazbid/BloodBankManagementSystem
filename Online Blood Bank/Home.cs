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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            textBox_User_Id.Clear();
            textBox_Password.Clear();
            Sign_Up sup = new Sign_Up();
            sup.Show();
        }

        private void button_Log_in_Click(object sender, EventArgs e)
        {
            string UserId = textBox_User_Id.Text;
            string password = textBox_Password.Text;

            if(UserId.Length==0 || password.Length==0)
            {
                MessageBox.Show("Please enter all the information correctly!", "Log-In failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    
                    Database db=new Database();
                    db.LogIn(UserId, password,textBox_User_Id,textBox_Password);                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }




        private void textBox_User_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
