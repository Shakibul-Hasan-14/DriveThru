using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DriveThru
{
    public partial class Administration_Management : Form
    {
        public Administration_Management()
        {
            InitializeComponent();

            //Make Buttons Transparent
            Admin_Change_Pass.FlatStyle = FlatStyle.Flat;
            Admin_Login.FlatStyle = FlatStyle.Flat;
            Admin_Back_Button.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            Admin_Pass.TabStop = false;
            Admin_Username.TabStop = false;
        }

        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");

        private void Change_Pass_Click(object sender, EventArgs e)
        {
            //Make Button Transparent
            Admin_Change_Pass.FlatStyle = FlatStyle.Flat;

            //Go To Admin_Change_Pass
            this.Hide();
            Admin_Change_Pass AdminChangePass = new Admin_Change_Pass();
            AdminChangePass.ShowDialog();
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Make Button Transparent
            Admin_Login.FlatStyle = FlatStyle.Flat;

            //Valid Admin Login
            string query = "Select * From Administration Where Username = '" + Admin_Username.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                int a = 0;
                SqlDataReader reader = cmd.ExecuteReader();

                //Check Username
                if (!reader.HasRows && String.IsNullOrEmpty(Admin_Username.Text) == false)
                    MessageBox.Show("Username Not Found.");
                else if (String.IsNullOrEmpty(Admin_Username.Text) == true)
                    MessageBox.Show("Please Enter Username.");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Check If Username And Password Match In A Row
                        if (Admin_Username.Text == reader["Username"].ToString()
                            && Admin_Pass.Text == reader["Pass"].ToString())
                        {
                            a = 1;
                            con.Close();
                            break;
                        }
                    }
                }

                //Check Password
                if (a == 0 && String.IsNullOrEmpty(Admin_Pass.Text) == false)
                    MessageBox.Show("Incorrect Password.");
                else if (String.IsNullOrEmpty(Admin_Pass.Text) == true)
                    MessageBox.Show("Please Enter Password.");

                if (a == 1)
                {
                    //Go To Administration
                    this.Hide();
                    Administration Admin = new Administration();
                    Admin.ShowDialog();
                    this.Close();
                }
            }

            con.Close();
        }

        private void Admin_Back_Button_Click(object sender, EventArgs e)
        {
            //Make Button Transparent
            Admin_Back_Button.FlatStyle = FlatStyle.Flat;

            //Go To Homepage
            this.Hide();
            Homepage Home = new Homepage();
            Home.ShowDialog();
            this.Close();
        }

        private void Administration_Management_Load(object sender, EventArgs e)
        {
            //Unsed
        }

        private void Admin_Username_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Unused
        }

        private void Admin_Pass_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
