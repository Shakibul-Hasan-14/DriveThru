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
    public partial class Customer_Change_Password : Form
    {
        public Customer_Change_Password()
        {
            InitializeComponent();

            //Make Buttons Transparent
            ccpback.FlatStyle = FlatStyle.Flat;
            ccpSub.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            ccpSA.TabStop = false;
            ccpuserName.TabStop = false;
            ccpnewPassword.TabStop = false;
            ccpSub.TabStop = false;
        }

        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");

        private void ccpback_Click_1(object sender, EventArgs e)
        {
            //Go To Customer_Management
            this.Hide();
            Customer_Management CusMan = new Customer_Management();
            CusMan.ShowDialog();
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string query = "Select * From Customer Where Username = '" + ccpuserName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader reader = cmd.ExecuteReader();

                //Check Username
                if (!reader.HasRows && String.IsNullOrEmpty(ccpuserName.Text) == false)
                    MessageBox.Show("Username Not Found.");
                else if (String.IsNullOrEmpty(ccpuserName.Text) == true)
                    MessageBox.Show("Please Enter Username.");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Username Found
                        if (ccpuserName.Text == reader["Username"].ToString())
                        {
                            btnCheck.Visible = false;
                            label2.Visible = true;
                            ccpSQ.Visible = true;
                            label3.Visible = true;
                            ccpSA.Visible = true;
                            label4.Visible = true;
                            ccpnewPassword.Visible = true;
                            ccpSub.Visible = true;
                            ccpuserName.Enabled = false;

                            ccpSQ.Text = reader["Security_Questions"].ToString();

                            con.Close();
                            break;
                        }
                    }
                }
            }

            con.Close();
        }

        private void ccpSub_Click_1(object sender, EventArgs e)
        {
            //After Username Found
            int a = 0;
            string query = "Select * From Customer Where Security_Questions = '" + ccpSQ.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader reader = cmd.ExecuteReader();

                //Answer Matched
                while (reader.Read())
                {
                    if (ccpSA.Text == reader["Answer"].ToString())
                    {
                        a = 1;
                        con.Close();

                        con.Open();

                        //Update Password
                        if (con.State == ConnectionState.Open)
                        {
                            string Q = "Update Customer set Pass = '" + ccpnewPassword.Text + "' Where Answer = '" + ccpSA.Text + "'";
                            SqlCommand command = new SqlCommand(Q, con);
                            command.ExecuteNonQuery();
                        }

                        con.Close();

                        break;
                    }
                }

                //Check Answer Match
                if(a == 0 && String.IsNullOrEmpty(ccpSA.Text) == false)
                    MessageBox.Show("Answer Did Not Match.");

                //Check Answer Empty
                if (String.IsNullOrEmpty(ccpSA.Text) == true)
                    MessageBox.Show("Please Enter An Answer.");

                //Enter New Password
                if (String.IsNullOrEmpty(ccpnewPassword.Text) == true)
                    MessageBox.Show("Please Enter A New Password.");
            }

            con.Close();

            if(a == 1 && String.IsNullOrEmpty(ccpnewPassword.Text) == false)
            {
                //Go To Customer_Management
                this.Hide();
                Customer_Management CusMan = new Customer_Management();
                CusMan.ShowDialog();
                this.Close();
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Unused
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Unused
        }

        private void ccpsurveyQuestion_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void ccpuserName_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
