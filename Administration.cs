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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();

            //Make Buttons Transparent
            A_Back_Button.FlatStyle = FlatStyle.Flat;
            Assets.FlatStyle = FlatStyle.Flat;
            On_Rent.FlatStyle = FlatStyle.Flat;
            History.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            Assets.TabStop = false;
            On_Rent.TabStop = false;
            History.TabStop = false;
            A_Back_Button.TabStop = false;
        }

        private void A_Back_Button_Click(object sender, EventArgs e)
        {
            //Go To Administration_Management
            this.Hide();
            Administration_Management AdminMan = new Administration_Management();
            AdminMan.ShowDialog();
            this.Close();
        }

        private void Assets_Click(object sender, EventArgs e)
        {
            //Go To Assets
            this.Hide();
            Assets A = new Assets();
            A.ShowDialog();
            this.Close();
        }

        private void History_Click(object sender, EventArgs e)
        {
            //Go To Rent_History
            this.Hide();
            Rent_History His = new Rent_History();
            His.ShowDialog();
            this.Close();
        }

        private void On_Rent_Click(object sender, EventArgs e)
        {
            //Go To On_Rent
            this.Hide();
            On_Rent R = new On_Rent();
            R.ShowDialog();
            this.Close();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
