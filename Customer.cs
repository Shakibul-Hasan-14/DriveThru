using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace DriveThru
{
    public partial class Customer : Form
    {
        string Username = "";
        public Customer(string user)
        {
            InitializeComponent();

            Username = user;

            txtBox.Text = "Rental Information:\r\n" +
                "1. The amount charged is depended on 2 factors.\r\n" +
                "       a. According to the capacity of a car, 50 BDT is charged\r\n" +
                "          for per seat per hour.\r\n" +
                "       b. If you require a driver, 100 BDT extra will be charged\r\n" +
                "          per hour.\r\n" +
                "2. To look for your desired Vehicle, go to Available For Rent.\r\n" +
                "3. If you have any comments regarding our services, feel free to\r\n" +
                "   let us know in the Review section.\r\n\r\n" +
                "Safety Features & Facts:\r\n" +
                "1. Please keep your seat belts fasten at all times.\r\n" +
                "2. Follow speed limits throughout your driver.\r\n" +
                "3. Smoking & Drinking is strictly prohibited in our vehicles, the\r\n " +
                "   company holds the rights to charge any customer who is\r\n" +
                "   found violating this term\r\n" +
                "4. In case of any harm to the vehicle, the situation will be\r\n" +
                "   throughly investigated and a customer maybe fined as an end\r\n" +
                "   result.";

            //Make Buttons Transparent
            Available.FlatStyle = FlatStyle.Flat;
            Report.FlatStyle = FlatStyle.Flat;
            C_Back_Button.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            Available.TabStop = false;
            Report.TabStop = false;
            C_Back_Button.TabStop = false;
        }

        private void Report_Click(object sender, EventArgs e)
        {
            //Go To repiss
            this.Hide();
            repiss RI = new repiss(Username);
            RI.ShowDialog();
            this.Close();
        }

        private void C_Back_Button_Click(object sender, EventArgs e)
        {
            //Go To Customer_Management
            this.Hide();
            Customer_Management CusMan = new Customer_Management();
            CusMan.ShowDialog();
            this.Close();
        }

        private void Available_Click(object sender, EventArgs e)
        {
            //Go To Available_For_Rent_Cus
            this.Hide();
            Available_For_Rent A = new Available_For_Rent(Username);
            A.ShowDialog();
            this.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            //Unused
        }

        private void Logo3_Click(object sender, EventArgs e)
        {
            //Unused
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
