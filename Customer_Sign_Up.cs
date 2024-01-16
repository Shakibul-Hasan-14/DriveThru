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
    public partial class Cus_Sign_Up : Form
    {
        public Cus_Sign_Up()
        {
            InitializeComponent();

            //Make Buttons Transparent
            Sign_Up.FlatStyle = FlatStyle.Flat;
            Cus_Back_Button.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            Cus_Name.TabStop = false;
            Cus_Address.TabStop = false;
            Cus_Number.TabStop = false;
            Cus_Email.TabStop = false;
            Cus_Pass.TabStop = false;
            Cus_Username.TabStop = false;
            SQ.TabStop = false;
            SQ_Ans.TabStop = false;
        }

        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0;

            //Checking Name
            if (String.IsNullOrEmpty(Cus_Name.Text) == false && Cus_Name.Text != "Name")
                a1 = 1;
            else
                MessageBox.Show("Invalid Name.");

            //Chcecking Address
            if (String.IsNullOrEmpty(Cus_Address.Text) == false && Cus_Address.Text != "Address")
                a2 = 1;
            else
                MessageBox.Show("Invalid Address.");

            //Checking Number
            if (String.IsNullOrEmpty(Cus_Number.Text) == false && Cus_Number.Text != "Number")
            {
                bool isNumber = int.TryParse(Cus_Number.Text, out int n);
                
                //Checking if the string contains numbers
                if (isNumber == true)
                    a3 = 1;
                else
                    MessageBox.Show("Number must be in digits.");
            }
            else
                MessageBox.Show("Invalid Number.");

            //Checking Email Address
            if (String.IsNullOrEmpty(Cus_Email.Text) == false && Cus_Email.Text != "Email Address")
                a4 = 1;
            else
                MessageBox.Show("Invalid Email Address.");

            //Checking Username
            if (String.IsNullOrEmpty(Cus_Username.Text) == false && Cus_Username.Text != "Username")
            {
                string query = "Select Username From Customer Where Username = '" + Cus_Username.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                //Checking if Username Already Exists 
                if (con.State == ConnectionState.Open)
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        MessageBox.Show("Username Already Exists.");
                    else
                        a5 = 1;
                }

                con.Close();
            }
            else
                MessageBox.Show("Invalid Username.");

            //Checking Password
            if (String.IsNullOrEmpty(Cus_Pass.Text) == false && Cus_Pass.Text != "Password")
                a6 = 1;
            else
                MessageBox.Show("Invalid Password.");

            //Checking Security Question
            if (String.IsNullOrEmpty(SQ.Text) == false && SQ.Text != "Security Question")
            {
                //Check If Question Selected From ComboBox
                if(SQ.SelectedIndex > -1)
                    a7 = 1;
                else
                    MessageBox.Show("PLease Select A Provided Security Question.");
            }   
            else
                MessageBox.Show("Invalid Security Question.");

            //Checking Answer
            if (String.IsNullOrEmpty(SQ_Ans.Text) == false && SQ_Ans.Text != "Answer")
                a8 = 1;
            else
                MessageBox.Show("Invalid Answer");

            //If All Inputs Valid, Store Data In Database
            if (a1 == 1 && a2 == 1 && a3 == 1 && a4 == 1 && a5 == 1 && a6 == 1 && a7 == 1 && a8 == 1)
            {
                string query = "insert into Customer (Username, Pass, Security_Questions, Customer_Name, Customer_Address, Customer_Number, Email_Address, Answer) values " +
                    "('" + Cus_Username.Text + "', '" + Cus_Pass.Text + "', '" + SQ.Text + "', '" + Cus_Name.Text + "', '" + Cus_Address.Text + "', '" + Cus_Number.Text + "', '" + Cus_Email.Text + "', '" + SQ_Ans.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up Successfull!!");
                    con.Close();

                    //Go To Customer_Management
                    this.Hide();
                    Customer_Management CusMan = new Customer_Management();
                    CusMan.ShowDialog();
                    this.Close();
                }

                con.Close();
            }
        }

        private void Cus_Back_Button_Click(object sender, EventArgs e)
        {
            //Go To Customer_Management
            this.Hide();
            Customer_Management CusMan = new Customer_Management();
            CusMan.ShowDialog();
            this.Close();
        }

        private void Cus_Name_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void SQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Unused
        }

        private void SQ_Ans_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void Cus_Email_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void Cus_Sign_Up_Load(object sender, EventArgs e)
        {
            //Unused
        }

        private void Cus_Username_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void Cus_Pass_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
