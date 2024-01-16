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
    public partial class Admin_Change_Pass : Form
    {
        public Admin_Change_Pass()
        {
            InitializeComponent();

            //Make Buttons Transparent
            acpback.FlatStyle = FlatStyle.Flat;
            acpSub.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            acpback.TabStop = false;
            acpSA.TabStop = false;
            acpuserName.TabStop = false;
            acpnewPassword.TabStop = false;
            acpSub.TabStop = false;
        }

        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string query = "Select * From Administration Where Username = '" + acpuserName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader reader = cmd.ExecuteReader();

                //Check Username
                if (!reader.HasRows && String.IsNullOrEmpty(acpuserName.Text) == false)
                    MessageBox.Show("Username Not Found.");
                else if (String.IsNullOrEmpty(acpuserName.Text) == true)
                    MessageBox.Show("Please Enter Username.");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Username Found
                        if (acpuserName.Text == reader["Username"].ToString())
                        {
                            btnCheck.Visible = false;
                            label2.Visible = true;
                            acpQ.Visible = true;
                            label3.Visible = true;
                            acpSA.Visible = true;
                            label4.Visible = true;
                            acpnewPassword.Visible = true;
                            acpSub.Visible = true;
                            acpuserName.Enabled = false;

                            acpQ.Text = reader["Security_Questions"].ToString();

                            con.Close();
                            break;
                        }
                    }
                }
            }

            con.Close();
        }

        private void acpback_Click(object sender, EventArgs e)
        {
            //Go To Administration_Management
            this.Hide();
            Administration_Management AdminMan = new Administration_Management();
            AdminMan.ShowDialog();
            this.Close();
        }

        private void acpSub_Click(object sender, EventArgs e)
        {
            //After Username Found
            int a = 0;
            string query = "Select * From Administration Where Security_Questions = '" + acpQ.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader reader = cmd.ExecuteReader();

                //Answer Matched
                while (reader.Read())
                {
                    if (acpSA.Text == reader["Answer"].ToString())
                    {
                        a = 1;
                        con.Close();

                        con.Open();

                        //Update Password
                        if (con.State == ConnectionState.Open)
                        {
                            string Q = "Update Administration set Pass = '" + acpnewPassword.Text + "' Where Answer = '" + acpSA.Text + "'";
                            SqlCommand command = new SqlCommand(Q, con);
                            command.ExecuteNonQuery();
                        }

                        con.Close();

                        break;
                    }
                }

                //Check Answer Match
                if (a == 0 && String.IsNullOrEmpty(acpSA.Text) == false)
                    MessageBox.Show("Answer Did Not Match.");

                //Check Answer Empty
                if (String.IsNullOrEmpty(acpSA.Text) == true)
                    MessageBox.Show("Please Enter An Answer.");

                //Enter New Password
                if (String.IsNullOrEmpty(acpnewPassword.Text) == true)
                    MessageBox.Show("Please Enter A New Password.");
            }

            con.Close();

            if (a == 1 && String.IsNullOrEmpty(acpnewPassword.Text) == false)
            {
                //Go To Administration_Management
                this.Hide();
                Administration_Management AdminMan = new Administration_Management();
                AdminMan.ShowDialog();
                this.Close();
            }
        }

        private void acpsurveyQuestion_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void acpuserName_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void acpnewPassword_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
