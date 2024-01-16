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
    //Creating A Delegate To Pass Info To Rent
    public delegate void CarDetails(string carmodel, string capacity, string numberplate, Image carphoto, string User);

    public partial class Available_For_Rent : Form
    {
        

        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");
        int Point = 0, corrupt = 0, Number = 0;
        private Button[] B1;
        private PictureBox[] PB;
        private TextBox[] TB1;
        private TextBox[] TB2;
        private TextBox[] TB3;
        string Username = "";

        public Available_For_Rent(string user)
        {
            InitializeComponent();

            Username = user;

            //Put Focus
            btnBack.TabStop = true;

            //Make Buttons Transparent
            btnBack.FlatStyle = FlatStyle.Flat;

            //Dynamically Display Database
            string query = "Select * From On_Rent";
            SqlCommand cmd = new SqlCommand(query, con);
            string[] plate = new string[20];
            int n = 0;
            
            //Get All Number Plates From On Rent
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    plate[n] = reader["Number_Plate"].ToString();
                    n = n + 1;
                }
            }

            con.Close();

            //Match with Assets
            string Q = "Select * From Assets";
            SqlCommand command = new SqlCommand(Q, con);
            int btn = 0;
            B1 = new Button[20];
            PB = new PictureBox[20];
            TB1 = new TextBox[20];
            TB2 = new TextBox[20];
            TB3 = new TextBox[20];

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bool found = false;
                    for (int i = 0; i < plate.Length; i++)
                    {
                        if (String.Equals(plate[i], reader["Number_Plate"].ToString()))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found == false)
                    {
                        Label L1 = new Label();
                        Label L2 = new Label();
                        Label L3 = new Label();
                        TB1[btn] = new TextBox();
                        TB2[btn] = new TextBox();
                        TB3[btn] = new TextBox();
                        B1[btn] = new Button();
                        PB[btn] = new PictureBox();

                        PB[btn].Size = new Size(366, 222);
                        PB[btn].BackColor = Color.White;
                        PB[btn].SizeMode = PictureBoxSizeMode.StretchImage;
                        PB[btn].Location = new Point(113, Point + 74);

                        L1.BackColor = Color.Transparent;
                        L1.Font = new Font("Times New Roman", 12);
                        L1.ForeColor = Color.Maroon;
                        L1.Text = "Number Plate:";
                        L1.Location = new Point(514, Point + 77);
                        L1.Size = new Size(124, 22);

                        L2.BackColor = Color.Transparent;
                        L2.Font = new Font("Times New Roman", 12);
                        L2.ForeColor = Color.Maroon;
                        L2.Text = "Car Model:";
                        L2.Location = new Point(514, Point + 140);
                        L2.Size = new Size(102, 22);

                        L3.BackColor = Color.Transparent;
                        L3.Font = new Font("Times New Roman", 12);
                        L3.ForeColor = Color.Maroon;
                        L3.Text = "Seat Capacity:";
                        L3.Location = new Point(514, Point + 202);
                        L3.Size = new Size(125, 22);

                        TB1[btn].Font = new Font("Times New Roman", 12);
                        TB1[btn].ForeColor = Color.Maroon;
                        TB1[btn].Enabled = false;
                        TB1[btn].Location = new Point(655, Point + 74);
                        TB1[btn].Size = new Size(275, 23);

                        TB2[btn].Font = new Font("Times New Roman", 12);
                        TB2[btn].ForeColor = Color.Maroon;
                        TB2[btn].Enabled = false;
                        TB2[btn].Location = new Point(655, Point + 137);
                        TB2[btn].Size = new Size(275, 30);

                        TB3[btn].Font = new Font("Times New Roman", 12);
                        TB3[btn].ForeColor = Color.Maroon;
                        TB3[btn].Enabled = false;
                        TB3[btn].Location = new Point(655, Point + 199);
                        TB3[btn].Size = new Size(275, 30);

                        B1[btn].BackColor = Color.RosyBrown;
                        B1[btn].Font = new Font("Times New Roman", 12);
                        B1[btn].ForeColor = Color.Maroon;
                        B1[btn].Text = "RENT";
                        B1[btn].UseVisualStyleBackColor = true;
                        B1[btn].Location = new Point(681, Point + 267);
                        B1[btn].Size = new Size(90, 29);
                        B1[btn].FlatStyle = FlatStyle.Flat;
                        B1[btn].Click += new EventHandler(this.btnRent_Click);
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

                        TB1[btn].Text = reader["Number_Plate"].ToString();
                        TB2[btn].Text = reader["Car_Model"].ToString();
                        TB3[btn].Text = reader["Capacity"].ToString();

                        this.Controls.Add(PB[btn]);
                        this.Controls.Add(L1);
                        this.Controls.Add(L2);
                        this.Controls.Add(L3);
                        this.Controls.Add(TB1[btn]);
                        this.Controls.Add(TB2[btn]);
                        this.Controls.Add(TB3[btn]);
                        this.Controls.Add(B1[btn]);

                        Point = Point + 300;
                        btn = btn + 1;

                    }
                }
            }

            con.Close();

            if (corrupt == 1)
            {
                MessageBox.Show("Couldn't Load Corrupt Images.");
            }
        }

        //Rent Button Created
        private void btnRent_Click(object sender, EventArgs e)
        {
            Button btnRent = (Button)sender;
            Number = int.Parse(btnRent.Name);
            string a = TB2[Number].Text.ToString();
            string b = TB3[Number].Text.ToString();
            string c = TB1[Number].Text.ToString();
            Image d = PB[Number].Image;

            //Go To Rent
            this.Hide();
            Rent R = new Rent(a, b, c, d, Username);
            R.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Go To Customer
            this.Hide();
            Customer Cus = new Customer(Username);
            Cus.ShowDialog();
            this.Close();
        }

        private void Available_For_Rent_Load(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
