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
    public partial class repiss : Form
    {
        string Username = "";
        public repiss(string user)
        {
            InitializeComponent();

            Username = user;

            //Make Buttons Transparent
            repback.FlatStyle = FlatStyle.Flat;
            repSub.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            repback.TabStop = false;
            desBox.TabStop = false;
            repSub.TabStop = false;
        }

        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");

        private void repSub_Click(object sender, EventArgs e)
        {
            string name = "", number = "";

            int Re = 0;
            if (String.IsNullOrEmpty(desBox.Text) == false)
            {
                string Q = "Select * From Customer Where Username = '" + Username + "'";
                SqlCommand command = new SqlCommand(Q, con);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        name = reader["Customer_Name"].ToString();
                        number = reader["Customer_Number"].ToString();
                    }
                }

                con.Close();

                string query = "Update Rent_History set Review = '" + desBox.Text + "' " +
                    "where Customer_Name = '"+ name +"' and Customer_Number = '" + number + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    Re = 1;
                }

                con.Close();
            }
            else
                MessageBox.Show("No Comments Entered.");

            if (Re == 1)
            {
                MessageBox.Show("Thank You For Your Valuable Words.");

                //Go To Customer
                this.Hide();
                Customer Cus = new Customer(Username);
                Cus.ShowDialog();
                this.Close();
            }
        }

        private void repback_Click_1(object sender, EventArgs e)
        {
            //Go To Customer
            this.Hide();
            Customer Cus = new Customer(Username);
            Cus.ShowDialog();
            this.Close();
        }

        private void repiss_Load(object sender, EventArgs e)
        {
            //Unused
        }

        private void desBox_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
