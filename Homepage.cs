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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

            //Make Buttons Transparent
            btnCus.FlatStyle = FlatStyle.Flat;
            btnAdmin.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            btnCus.TabStop = false;
            btnAdmin.TabStop = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Go To Administration Login
            this.Hide();
            Administration_Management AdminMan = new Administration_Management();
            AdminMan.ShowDialog();
            this.Close();
        }

        private void btnCus_Click_1(object sender, EventArgs e)
        {
            //Go To Customer Login
            this.Hide();
            Customer_Management CusMan = new Customer_Management();
            CusMan.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
