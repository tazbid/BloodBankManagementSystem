using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;



namespace Online_Blood_Bank
{
    class Database
    {

        public string constring= "datasource=localhost;port=3306;username=hossaintaz;password=hossain.taz";
        public MySqlDataReader reader;
        public string qry;
        public MySqlConnection con;
        public MySqlCommand cmd;


        public void LogIn(string uname,string pass,TextBox txtUid,TextBox txtPassword)
        {

            qry = "select * from blood_bank_info.sign_up_table where UserName='" + uname + "' and Password='" + pass + "' ";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                Profile pro = new Profile(uname);
                pro.Show();
                MessageBox.Show("Log in successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUid.Clear();
                txtPassword.Clear();
            }
            else
                MessageBox.Show("Incorrect username or password!", "Log in failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();

        }



        public void DeleteFromSignUpTable(string proname)
        {

            qry = "delete from blood_bank_info.sign_up_table where UserName='" + proname + "' ";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {

            }
            reader.Close();
            con.Close();
        }


        public bool DeleteFromRegisterTable(string proname)
        {

            qry = "select * from blood_bank_info.register_table where UserName='" + proname + "' ";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            reader.Close();
            con.Close();
            if (count == 1)
            {
                qry = "delete from blood_bank_info.register_table where UserName='" + proname + "' ";
                con = new MySqlConnection(constring);
                cmd = new MySqlCommand(qry, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }


       
        public void Register(string name,string Uname, string blood_group,string gender,string division,string city,string mobile)
        {

            qry = "insert into blood_bank_info.register_table (FullName,UserName,BloodGroup,Gender,Division,City,MobileNo) values ( '" + name + "', '" + Uname + "','" + blood_group + "','" + gender + "','" + division + "' ,'" + city + "' , '" + mobile + "' );";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

            }
            reader.Close();
            con.Close();

        }


        public void SeeDonorList(string bgroup,string div,string city,DataGridView dataGridView1)
        {

            qry = "select * from blood_bank_info.register_table where BloodGroup = '" + bgroup + "' and Division = '" + div + "' and City='" + city + "' ";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable table = new DataTable();
            sda.Fill(table);
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridView1.DataSource = source;
            sda.Update(table);
        }


        public void CityChange(ComboBox city,string div)
        {
            city.Text = null;
            city.Items.Clear();
            qry = "select * from blood_bank_info.address_table where Division='" + div + "'  ;";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string sArea = reader.GetString("City");
                city.Items.Add(sArea);
            }
            con.Close();

        }


        public void SignUp(string uname,string pass,string email,Sign_Up sp)
        {

            qry = "select * from blood_bank_info.sign_up_table where  UserName='" + uname + "' ";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            reader.Close();
            if(count==1)
            {
                MessageBox.Show("User Name already in use.Please choose another.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                qry="insert into blood_bank_info.sign_up_table (UserName,Password,Email) values ( '" + uname + "', '" + pass + "','" + email + "'  );";
                con = new MySqlConnection(constring);
                cmd = new MySqlCommand(qry, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                con.Close();
                sp.Close();
                Profile pro = new Profile(uname);
                pro.Show();
                MessageBox.Show("Sign Up Complete!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void GetSignupInfo(string uname,TextBox UserName,TextBox Password,TextBox Email)
        {
            qry= "select * from blood_bank_info.sign_up_table where UserName =  '" + uname + "' ";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString("UserName");
                string pass = reader.GetString("Password");
                string email = reader.GetString("Email");
                UserName.Text = username;
                Password.Text = pass;
                Email.Text = email;
            }
            reader.Close();
            con.Close();
        }

        public void GetRegisterInfo(string uname,TextBox FullName,ComboBox BloodGroup,ComboBox Div,ComboBox City,TextBox Mobile,RadioButton male,RadioButton female)
        {

            qry = "select * from blood_bank_info.register_table where UserName =  '" + uname + "' ";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            reader.Close();
            if(count==1)
            {
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string fullname = reader.GetString("FullName");
                    string bgroup = reader.GetString("BloodGroup");
                    string gender = reader.GetString("Gender");
                    string div = reader.GetString("Division");
                    string city = reader.GetString("City");
                    string mobileno = reader.GetString("MobileNo");

                    FullName.Text = fullname;
                    BloodGroup.Text = bgroup;
                    Div.Text = div;
                    City.Text = city;
                    Mobile.Text = mobileno;

                    if (gender == "Male")
                    {
                        male.Checked = true;
                    }
                    else
                        female.Checked = true;


                }


            }
            else
            {
                FullName.Enabled = false;
                BloodGroup.Enabled = false;
                Div.Enabled = false;
                City.Enabled = false;
                Mobile.Enabled = false;
                male.Enabled = false;
                female.Enabled = false;

            }
            con.Close();

        }

        public void UpdateSignUpTable(string uname,string pass,string email)
        {
           
            qry = "update blood_bank_info.sign_up_table set  Password='" + pass + "' , Email='" + email + "' where UserName = '" + uname + "' ";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {              

            }
            con.Close();
            
        }

        public void UpdateRegisterTable(string uname,string FullName,string BloodGroup,string Gender,string Division,string City,string Mobile)
        {
            qry = "update blood_bank_info.register_table set FullName='" + FullName + "'  , BloodGroup='" + BloodGroup + "' , Gender='" + Gender + "', Division='" + Division + "' , City='" + City + "' , MobileNo='" + Mobile + "' where UserName ='" + uname + "';";
            con = new MySqlConnection(constring);
            cmd = new MySqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

            }
            reader.Close();
            con.Close();

        }
    }
}
