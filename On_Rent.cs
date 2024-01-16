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
using System.IO;

namespace DriveThru
{
    public partial class On_Rent : Form
    {
        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");
        int Point = 0, Number = 0, corrupt = 0;

        private Button[] B1;
        private TextBox[] TB1;
        private TextBox[] TB2;
        private TextBox[] TB3;
        private TextBox[] TB4;
        private TextBox[] TB5;
        private TextBox[] TB6;
        private TextBox[] TB7;
        private TextBox[] TB8;
        private PictureBox[] PB;

        public On_Rent()
        {
            InitializeComponent();

            //Put Focus
            btnBack.TabStop = true;

            //Dynamically Display Database
            string query = "Select * From On_Rent";
            SqlCommand cmd = new SqlCommand(query, con);

            int btn = 0;
            B1 = new Button[20];
            TB1 = new TextBox[20];
            TB2 = new TextBox[20];
            TB3 = new TextBox[20];
            TB4 = new TextBox[20];
            TB5 = new TextBox[20];
            TB6 = new TextBox[20];
            TB7 = new TextBox[20];
            TB8 = new TextBox[20];
            PB = new PictureBox[20];

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PB[btn] = new PictureBox();
                    PB[btn].BackColor = Color.White;
                    PB[btn].Size = new Size(360, 191);
                    PB[btn].SizeMode = PictureBoxSizeMode.StretchImage;
                    PB[btn].Location = new Point(510, Point + 79);

                    Label L1 = new Label();
                    L1.BackColor = Color.Transparent;
                    L1.Font = new Font("Times New Roman", 12);
                    L1.ForeColor = Color.White;
                    L1.Text = "Name: ";
                    L1.Size = new Size(66, 23);
                    L1.Location = new Point(75, Point + 83);

                    Label L2 = new Label();
                    L2.BackColor = Color.Transparent;
                    L2.Font = new Font("Times New Roman", 12);
                    L2.ForeColor = Color.White;
                    L2.Text = "Number: ";
                    L2.Size = new Size(84, 23);
                    L2.Location = new Point(75, Point + 144);

                    Label L3 = new Label();
                    L3.BackColor = Color.Transparent;
                    L3.Font = new Font("Times New Roman", 12);
                    L3.ForeColor = Color.White;
                    L3.Text = "Address: ";
                    L3.Size = new Size(85, 23);
                    L3.Location = new Point(75, Point + 210);

                    Label L4 = new Label();
                    L4.BackColor = Color.Transparent;
                    L4.Font = new Font("Times New Roman", 12);
                    L4.ForeColor = Color.White;
                    L4.Text = "Email Address: ";
                    L4.Size = new Size(137, 23);
                    L4.Location = new Point(75, Point + 276);

                    Label L5 = new Label();
                    L5.BackColor = Color.Transparent;
                    L5.Font = new Font("Times New Roman", 12);
                    L5.ForeColor = Color.White;
                    L5.Text = "Temporary Bill: ";
                    L5.Size = new Size(142, 23);
                    L5.Location = new Point(75, Point + 334);

                    Label L6 = new Label();
                    L6.BackColor = Color.Transparent;
                    L6.Font = new Font("Times New Roman", 12);
                    L6.ForeColor = Color.White;
                    L6.Text = "Number Plate: ";
                    L6.Size = new Size(133, 23);
                    L6.Location = new Point(75, Point + 395);

                    Label L7 = new Label();
                    L7.BackColor = Color.Transparent;
                    L7.Font = new Font("Times New Roman", 12);
                    L7.ForeColor = Color.White;
                    L7.Text = "Expected Hour Usage: ";
                    L7.Size = new Size(201, 23);
                    L7.Location = new Point(506, Point + 334);

                    Label L8 = new Label();
                    L8.BackColor = Color.Transparent;
                    L8.Font = new Font("Times New Roman", 12);
                    L8.ForeColor = Color.White;
                    L8.Text = "Rent Date: ";
                    L8.Size = new Size(104, 23);
                    L8.Location = new Point(506, Point + 391);

                    TB1[btn] = new TextBox();
                    TB1[btn].BackColor = Color.MistyRose;
                    TB1[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB1[btn].Font = new Font("Times New Roman", 12);
                    TB1[btn].ForeColor = Color.Maroon;
                    TB1[btn].Enabled = false;
                    TB1[btn].Size = new Size(250, 25);
                    TB1[btn].Location = new Point(221, Point + 81);

                    TB2[btn] = new TextBox();
                    TB2[btn].BackColor = Color.MistyRose;
                    TB2[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB2[btn].Font = new Font("Times New Roman", 12);
                    TB2[btn].ForeColor = Color.Maroon;
                    TB2[btn].Enabled = false;
                    TB2[btn].Size = new Size(250, 25);
                    TB2[btn].Location = new Point(221, Point + 142);

                    TB3[btn] = new TextBox();
                    TB3[btn].BackColor = Color.MistyRose;
                    TB3[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB3[btn].Font = new Font("Times New Roman", 12);
                    TB3[btn].ForeColor = Color.Maroon;
                    TB3[btn].Enabled = false;
                    TB3[btn].Size = new Size(250, 25);
                    TB3[btn].Location = new Point(221, Point + 208);

                    TB4[btn] = new TextBox();
                    TB4[btn].BackColor = Color.MistyRose;
                    TB4[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB4[btn].Font = new Font("Times New Roman", 12);
                    TB4[btn].ForeColor = Color.Maroon;
                    TB4[btn].Enabled = false;
                    TB4[btn].Size = new Size(250, 25);
                    TB4[btn].Location = new Point(221, Point + 274);

                    TB5[btn] = new TextBox();
                    TB5[btn].BackColor = Color.MistyRose;
                    TB5[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB5[btn].Font = new Font("Times New Roman", 12);
                    TB5[btn].ForeColor = Color.Maroon;
                    TB5[btn].Enabled = false;
                    TB5[btn].Size = new Size(250, 25);
                    TB5[btn].Location = new Point(221, Point + 327);

                    TB6[btn] = new TextBox();
                    TB6[btn].BackColor = Color.MistyRose;
                    TB6[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB6[btn].Font = new Font("Times New Roman", 12);
                    TB6[btn].ForeColor = Color.Maroon;
                    TB6[btn].Enabled = false;
                    TB6[btn].Size = new Size(250, 25);
                    TB6[btn].Location = new Point(221, Point + 389);

                    TB7[btn] = new TextBox();
                    TB7[btn].BackColor = Color.MistyRose;
                    TB7[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB7[btn].Font = new Font("Times New Roman", 12);
                    TB7[btn].ForeColor = Color.Maroon;
                    TB7[btn].Enabled = false;
                    TB7[btn].Size = new Size(164, 25);
                    TB7[btn].Location = new Point(712, Point + 332);

                    TB8[btn] = new TextBox();
                    TB8[btn].BackColor = Color.MistyRose;
                    TB8[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB8[btn].Font = new Font("Times New Roman", 12);
                    TB8[btn].ForeColor = Color.Maroon;
                    TB8[btn].Enabled = false;
                    TB8[btn].Size = new Size(164, 25);
                    TB8[btn].Location = new Point(712, Point + 389);

                    B1[btn] = new Button();
                    B1[btn].BackColor = Color.MistyRose;
                    B1[btn].Font = new Font("Times New Roman", 12);
                    B1[btn].ForeColor = Color.Green;
                    B1[btn].FlatStyle = FlatStyle.Flat;
                    B1[btn].Text = "ARRIVED BACK";
                    B1[btn].UseVisualStyleBackColor = false;
                    B1[btn].Size = new Size(360, 33);
                    B1[btn].Location = new Point(510, Point + 271);
                    B1[btn].Click += new EventHandler(this.btnArrive_Click);
                    B1[btn].Name = btn.ToString();

                  
                        byte[] pic = (byte[])reader["Car_Photo"];
                        MemoryStream ms = new MemoryStream(pic);
                        try
                        {
                            PB[btn].Image = Image.FromStream(ms);
                        }
                        catch (System.ArgumentException)
                        {
                            corrupt = 1;
                        }
                    
                    

                    TB1[btn].Text = reader["Customer_Name"].ToString();
                    TB2[btn].Text = reader["Customer_Number"].ToString();
                    TB3[btn].Text = reader["Customer_Address"].ToString();
                    TB4[btn].Text = reader["Email_Address"].ToString();
                    TB5[btn].Text = reader["Temporary_Bill"].ToString();
                    TB6[btn].Text = reader["Number_Plate"].ToString();
                    TB7[btn].Text = reader["Expected_Return_Time"].ToString();
                    TB8[btn].Text = reader["Rent_Date"].ToString();

                    this.Controls.Add(PB[btn]);
                    this.Controls.Add(L1);
                    this.Controls.Add(L2);
                    this.Controls.Add(L3);
                    this.Controls.Add(L4);
                    this.Controls.Add(L5);
                    this.Controls.Add(L6);
                    this.Controls.Add(L7);
                    this.Controls.Add(L8);
                    this.Controls.Add(TB1[btn]);
                    this.Controls.Add(TB2[btn]);
                    this.Controls.Add(TB3[btn]);
                    this.Controls.Add(TB4[btn]);
                    this.Controls.Add(TB5[btn]);
                    this.Controls.Add(TB6[btn]);
                    this.Controls.Add(TB7[btn]);
                    this.Controls.Add(TB8[btn]);
                    this.Controls.Add(B1[btn]);

                    Point = Point + 420;
                    btn = btn + 1;
                }
            }

            con.Close();

            if (corrupt == 1)
            {
                MessageBox.Show("Couldn't Load Corrupt Images.");
            }
        }

        //Arrive Button Created
        private void btnArrive_Click(object sender, EventArgs e)
        {
            Button btnArrive = (Button)sender;
            Number = int.Parse(btnArrive.Name);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                //Move Data To Rent History Table
                string query = "Insert Into Rent_History (Customer_Name, Customer_Number, Customer_Address, Email_Address, Rent_Date, Number_Plate) Values (" +
                    "'" + TB1[Number].Text + "', '" + TB2[Number].Text + "', '" + TB3[Number].Text + "', '" + TB4[Number].Text + "',  '" + TB8[Number].Text + "'," +
                    "'" + TB6[Number].Text + "')";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();

                //Remove Data From On Rent Table 
                string Q = "Delete from On_Rent Where Number_Plate = '"+ TB6[Number].Text +"'";
                SqlCommand cmd = new SqlCommand(Q, con);
                cmd.ExecuteNonQuery();

                //Refresh Form
                this.Hide();
                On_Rent R = new On_Rent();
                R.ShowDialog();
                this.Close();
            }

            con.Close();
        }

        private void On_Rent_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Go To Administration
            this.Hide();
            Administration Admin = new Administration();
            Admin.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
