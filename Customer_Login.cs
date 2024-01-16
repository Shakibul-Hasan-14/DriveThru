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
    //Delegate For Customer Information
    public delegate void CustomerInfo(string user);
    public partial class Customer_Management : Form
    {
        public Customer_Management()
        {
            InitializeComponent();

            //Make Buttons Transparent
            Cus_Change_Pass.FlatStyle = FlatStyle.Flat;
            Cus_SignUp.FlatStyle = FlatStyle.Flat;
            Cus_Login.FlatStyle = FlatStyle.Flat;
            Cus_Back_Button.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            Cus_Pass.TabStop = false;
            Cus_Username.TabStop = false;
        }

        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");

        private void Cus_Change_Pass_Click(object sender, EventArgs e)
        {
            //Make Button Transparent
            Cus_Change_Pass.FlatStyle = FlatStyle.Flat;
        }

        private void Cus_Login_Click(object sender, EventArgs e)
        {
            //Make Button Transparent
            Cus_Login.FlatStyle = FlatStyle.Flat;
        }

        private void Cus_Back_Button_Click(object sender, EventArgs e)
        {
            //Make Button Transparent
            Cus_Back_Button.FlatStyle = FlatStyle.Flat;
        }

        private void Cus_SignUp_Click(object sender, EventArgs e)
        {
            //Make Button Transparent
            Cus_SignUp.FlatStyle = FlatStyle.Flat;

            //Go To Cus_Sign_Up
            this.Hide();
            Cus_Sign_Up SignUp = new Cus_Sign_Up();
            SignUp.ShowDialog();
            this.Close();
        }

        private void Cus_Back_Button_Click_1(object sender, EventArgs e)
        {
            //Go To Homepage
            this.Hide();
            Homepage Home = new Homepage();
            Home.ShowDialog();
            this.Close();
        }

        private void Cus_Change_Pass_Click_1(object sender, EventArgs e)
        {
            //Go To Customer_Change_Password
            this.Hide();
            Customer_Change_Password CusChangePass = new Customer_Change_Password();
            CusChangePass.ShowDialog();
            this.Close();
        }

        private void Cus_Login_Click_1(object sender, EventArgs e)
        {
            

            //Valid Customer Login
            string query = "Select * From Customer Where Username = '" + Cus_Username.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                int a = 0;
                SqlDataReader reader = cmd.ExecuteReader();

                //Check Username
                if (!reader.HasRows && String.IsNullOrEmpty(Cus_Username.Text) == false)
                    MessageBox.Show("Username Not Found.");
                else if (String.IsNullOrEmpty(Cus_Username.Text) == true)
                    MessageBox.Show("Please Enter Username.");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Check If Username And Password Match In A Row
                        if (Cus_Username.Text == reader["Username"].ToString() 
                            && Cus_Pass.Text == reader["Pass"].ToString())
                        {
                            a = 1;
                            con.Close();
                            break;
                        }
                    }
                }

                //Check Password
                if (a == 0 && String.IsNullOrEmpty(Cus_Pass.Text) == false)
                    MessageBox.Show("Incorrect Password.");
                else if (String.IsNullOrEmpty(Cus_Pass.Text) == true)
                    MessageBox.Show("Please Enter Password.");

                if(a == 1)
                {
                    string Username = Cus_Username.Text;
                    con.Close();

                    //Go To Customer
                    this.Hide();
                    Customer Cus = new Customer(Username);
                    Cus.ShowDialog();
                    this.Close();
                }
            }

            con.Close();
        }
        private void Cus_Username_TextChanged(object sender, EventArgs e)
        {
            //unused
        }

        private void Cus_Page_Logo_Click(object sender, EventArgs e)
        {
            //Unused
        }

        private void Customer_Management_Load(object sender, EventArgs e)
        {
            //Unused
        }

        private void Cus_Pass_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void Cus_User_Logo_Click(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
