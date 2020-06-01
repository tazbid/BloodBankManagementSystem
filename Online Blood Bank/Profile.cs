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
    public partial class Profile : Form
    {
        public Profile(string profile_name)
        {
            InitializeComponent();
            label_Profile_Name.Text = profile_name;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register reg = new Register(label_Profile_Name.Text);
            reg.Show();
        }

 

        private void button_Search_donor_Click(object sender, EventArgs e)
        {
            Search_donor sd = new Search_donor();
            sd.Show();
        }

        private void button_delete_account_Click(object sender, EventArgs e)
        {

            DialogResult res =MessageBox.Show("Are you sure you want to delete your account?", "Delete Account?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                try
                {
                  
                    Database db = new Database();
                    db.DeleteFromSignUpTable(label_Profile_Name.Text);
                    db.DeleteFromRegisterTable(label_Profile_Name.Text);
                    this.Close();                 
                    MessageBox.Show("Your account has been deleted successfully.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    this.Close();
                    MessageBox.Show(ex.Message);

                }

            }

            else if (res == DialogResult.No)
                return;
            

        }

        private void button_unregister_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Are you sure you want to unregister as a Blood Donor?", "Unregister?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    
                    Database db = new Database();
                    bool ab=db.DeleteFromRegisterTable(label_Profile_Name.Text);
                    
                    if(ab==true)
                    {
                        MessageBox.Show("You are unregistered as a Blood Donor.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You are not registered as a Blood Donor yet.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }

            else if (result == DialogResult.No)
                return;


        }

        private void butto_UpdateProfile_Click(object sender, EventArgs e)
        {
            Update_Profile pro = new Update_Profile(label_Profile_Name.Text);
            pro.Show();
        }
    }
}
