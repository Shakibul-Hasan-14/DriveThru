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
using System.Data.SqlClient;

namespace DriveThru
{
    public partial class Rent_History : Form
    {
        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");
        int Point = 0, Number = 0;

        private Button[] B1;
        private Button[] B2;
        private TextBox[] TB1;
        private TextBox[] TB2;
        private TextBox[] TB3;
        private TextBox[] TB4;
        private TextBox[] TB5;
        private TextBox[] TB6;
        private TextBox[] TB7;
        private TextBox[] TB8;
        private TextBox[] TB9;
        private string[] NP;

        public Rent_History()
        {
            InitializeComponent();

            //Put Focus
            btnBack.TabStop = true;

            //Dynamically Display Database
            string query = "Select * From Rent_History";
            SqlCommand cmd = new SqlCommand(query, con);

            int btn = 0;
            B1 = new Button[20];
            B2 = new Button[20];
            TB1 = new TextBox[20];
            TB2 = new TextBox[20];
            TB3 = new TextBox[20];
            TB4 = new TextBox[20];
            TB5 = new TextBox[20];
            TB6 = new TextBox[20];
            TB7 = new TextBox[20];
            TB8 = new TextBox[20];
            TB9 = new TextBox[20];
            NP = new string[20];

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Label L1 = new Label();
                    L1.BackColor = Color.Transparent;
                    L1.Font = new Font("Times New Roman", 12);
                    L1.ForeColor = Color.White;
                    L1.Text = "Name: ";
                    L1.Size = new Size(62, 22);
                    L1.Location = new Point(85, Point + 71);

                    Label L2 = new Label();
                    L2.BackColor = Color.Transparent;
                    L2.Font = new Font("Times New Roman", 12);
                    L2.ForeColor = Color.White;
                    L2.Text = "Number: ";
                    L2.Size = new Size(79, 22);
                    L2.Location = new Point(447, Point + 71);

                    Label L3 = new Label();
                    L3.BackColor = Color.Transparent;
                    L3.Font = new Font("Times New Roman", 12);
                    L3.ForeColor = Color.White;
                    L3.Text = "Address: ";
                    L3.Size = new Size(82, 22);
                    L3.Location = new Point(85, Point + 149);

                    Label L4 = new Label();
                    L4.BackColor = Color.Transparent;
                    L4.Font = new Font("Times New Roman", 12);
                    L4.ForeColor = Color.White;
                    L4.Text = "Email Address: ";
                    L4.Size = new Size(133, 22);
                    L4.Location = new Point(447, Point + 149);

                    Label L5 = new Label();
                    L5.BackColor = Color.Transparent;
                    L5.Font = new Font("Times New Roman", 12);
                    L5.ForeColor = Color.White;
                    L5.Text = "Rent Date: ";
                    L5.Size = new Size(94, 22);
                    L5.Location = new Point(85, Point + 226);

                    Label L6 = new Label();
                    L6.BackColor = Color.Transparent;
                    L6.Font = new Font("Times New Roman", 12);
                    L6.ForeColor = Color.White;
                    L6.Text = "Rent Time (in Hours): ";
                    L6.Size = new Size(184, 22);
                    L6.Location = new Point(447, Point + 226);

                    Label L7 = new Label();
                    L7.BackColor = Color.Transparent;
                    L7.Font = new Font("Times New Roman", 12);
                    L7.ForeColor = Color.White;
                    L7.Text = "Amount Paid (in BDT): ";
                    L7.Size = new Size(196, 22);
                    L7.Location = new Point(88, Point + 305);

                    Label L8 = new Label();
                    L8.BackColor = Color.Transparent;
                    L8.Font = new Font("Times New Roman", 12);
                    L8.ForeColor = Color.White;
                    L8.Text = "Amount Due (in BDT): ";
                    L8.Size = new Size(192, 22);
                    L8.Location = new Point(447, Point + 305);

                    Label L9 = new Label();
                    L9.BackColor = Color.Transparent;
                    L9.Font = new Font("Times New Roman", 12);
                    L9.ForeColor = Color.White;
                    L9.Text = "Review: ";
                    L9.Size = new Size(78, 22);
                    L9.Location = new Point(88, Point + 384);

                    TB1[btn] = new TextBox();
                    TB1[btn].BackColor = Color.MistyRose;
                    TB1[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB1[btn].Font = new Font("Times New Roman", 12);
                    TB1[btn].ForeColor = Color.Maroon;
                    TB1[btn].Enabled = false;
                    TB1[btn].Size = new Size(311, 30);
                    TB1[btn].Location = new Point(89, Point + 97);

                    TB2[btn] = new TextBox();
                    TB2[btn].BackColor = Color.MistyRose;
                    TB2[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB2[btn].Font = new Font("Times New Roman", 12);
                    TB2[btn].ForeColor = Color.Maroon;
                    TB2[btn].Enabled = false;
                    TB2[btn].Size = new Size(311, 30);
                    TB2[btn].Location = new Point(451, Point + 97);

                    TB3[btn] = new TextBox();
                    TB3[btn].BackColor = Color.MistyRose;
                    TB3[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB3[btn].Font = new Font("Times New Roman", 12);
                    TB3[btn].ForeColor = Color.Maroon;
                    TB3[btn].Enabled = false;
                    TB3[btn].Size = new Size(311, 30);
                    TB3[btn].Location = new Point(89, Point + 175);

                    TB4[btn] = new TextBox();
                    TB4[btn].BackColor = Color.MistyRose;
                    TB4[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB4[btn].Font = new Font("Times New Roman", 12);
                    TB4[btn].ForeColor = Color.Maroon;
                    TB4[btn].Enabled = false;
                    TB4[btn].Size = new Size(311, 30);
                    TB4[btn].Location = new Point(451, Point + 175);

                    TB5[btn] = new TextBox();
                    TB5[btn].BackColor = Color.MistyRose;
                    TB5[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB5[btn].Font = new Font("Times New Roman", 12);
                    TB5[btn].ForeColor = Color.Maroon;
                    TB5[btn].Enabled = false;
                    TB5[btn].Size = new Size(311, 30);
                    TB5[btn].Location = new Point(89, Point + 253);

                    TB6[btn] = new TextBox();
                    TB6[btn].BackColor = Color.MistyRose;
                    TB6[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB6[btn].Font = new Font("Times New Roman", 12);
                    TB6[btn].ForeColor = Color.Maroon;
                    TB6[btn].Enabled = false;
                    TB6[btn].Size = new Size(311, 30);
                    TB6[btn].Location = new Point(451, Point + 253);

                    TB7[btn] = new TextBox();
                    TB7[btn].BackColor = Color.MistyRose;
                    TB7[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB7[btn].Font = new Font("Times New Roman", 12);
                    TB7[btn].ForeColor = Color.Maroon;
                    TB7[btn].Enabled = false;
                    TB7[btn].Size = new Size(311, 30);
                    TB7[btn].Location = new Point(89, Point + 331);

                    TB8[btn] = new TextBox();
                    TB8[btn].BackColor = Color.MistyRose;
                    TB8[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB8[btn].Font = new Font("Times New Roman", 12);
                    TB8[btn].ForeColor = Color.Maroon;
                    TB8[btn].Enabled = false;
                    TB8[btn].Size = new Size(311, 30);
                    TB8[btn].Location = new Point(451, Point + 331);

                    TB9[btn] = new TextBox();
                    TB9[btn].BackColor = Color.MistyRose;
                    TB9[btn].BorderStyle = BorderStyle.FixedSingle;
                    TB9[btn].Font = new Font("Times New Roman", 12);
                    TB9[btn].Multiline = true;
                    TB9[btn].ForeColor = Color.Maroon;
                    TB9[btn].Enabled = false;
                    TB9[btn].Size = new Size(877, 60);
                    TB9[btn].Location = new Point(89, Point + 410);

                    B1[btn] = new Button();
                    B1[btn].BackColor = Color.MistyRose;
                    B1[btn].Font = new Font("Times New Roman", 12);
                    B1[btn].ForeColor = Color.Green;
                    B1[btn].FlatStyle = FlatStyle.Flat;
                    B1[btn].Text = "EDIT";
                    B1[btn].UseVisualStyleBackColor = false;
                    B1[btn].Size = new Size(153, 38);
                    B1[btn].Location = new Point(813, Point + 167);
                    B1[btn].Click += new EventHandler(this.btnEdit_Click);
                    B1[btn].Name = btn.ToString();

                    B2[btn] = new Button();
                    B2[btn].BackColor = Color.MistyRose;
                    B2[btn].Font = new Font("Times New Roman", 12);
                    B2[btn].ForeColor = Color.Maroon;
                    B2[btn].FlatStyle = FlatStyle.Flat;
                    B2[btn].Enabled = false;
                    B2[btn].Text = "SAVE";
                    B2[btn].UseVisualStyleBackColor = false;
                    B2[btn].Size = new Size(153, 38);
                    B2[btn].Location = new Point(813, Point + 253);
                    B2[btn].Click += new EventHandler(this.btnSave_Click);
                    B2[btn].Name = btn.ToString();

                    TB1[btn].Text = reader["Customer_Name"].ToString();
                    TB2[btn].Text = reader["Customer_Number"].ToString();
                    TB3[btn].Text = reader["Customer_Address"].ToString();
                    TB4[btn].Text = reader["Email_Address"].ToString();
                    TB5[btn].Text = reader["Rent_Date"].ToString();
                    TB6[btn].Text = reader["Return_Time"].ToString();
                    TB7[btn].Text = reader["Amount_Paid"].ToString();
                    TB8[btn].Text = reader["Amount_Due"].ToString();
                    TB9[btn].Text = reader["Review"].ToString();
                    NP[btn] = reader["Number_Plate"].ToString();

                    this.Controls.Add(L1);
                    this.Controls.Add(L2);
                    this.Controls.Add(L3);
                    this.Controls.Add(L4);
                    this.Controls.Add(L5);
                    this.Controls.Add(L6);
                    this.Controls.Add(L7);
                    this.Controls.Add(L8);
                    this.Controls.Add(L9);
                    this.Controls.Add(TB1[btn]);
                    this.Controls.Add(TB2[btn]);
                    this.Controls.Add(TB3[btn]);
                    this.Controls.Add(TB4[btn]);
                    this.Controls.Add(TB5[btn]);
                    this.Controls.Add(TB6[btn]);
                    this.Controls.Add(TB7[btn]);
                    this.Controls.Add(TB8[btn]);
                    this.Controls.Add(TB9[btn]);
                    this.Controls.Add(B1[btn]);
                    this.Controls.Add(B2[btn]);

                    Point = Point + 450;
                    btn = btn + 1;
                }
            }

            con.Close();
        }

        //Save Button Created
        private void btnSave_Click(object sender, EventArgs e)
        {
            Button btnSave = (Button)sender;
            Number = int.Parse(btnSave.Name);
            int Save = 0;

            if (String.IsNullOrEmpty(TB1[Number].Text) == false && String.IsNullOrEmpty(TB2[Number].Text) == false && String.IsNullOrEmpty(TB3[Number].Text) == false
                && String.IsNullOrEmpty(TB4[Number].Text) == false && String.IsNullOrEmpty(TB5[Number].Text) == false)
            {
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    string query = "Update Rent_History set Customer_Name = '" + TB1[Number].Text + "', Customer_Number = '" + TB2[Number].Text + "', Customer_Address = '" + TB3[Number].Text + "'," +
                        "Email_Address = '" + TB4[Number].Text + "', Return_Time = '" + TB6[Number].Text + "'," +
                        "Amount_Paid = '" + TB7[Number].Text + "', Amount_Due = '" + TB8[Number].Text + "' " +
                        "where Number_Plate = '"+ NP[Number] +"' and Rent_Date = '"+ TB5[Number].Text + "'";
                    SqlCommand command = new SqlCommand(query, con);

                    command.ExecuteNonQuery();
                    Save = 1;
                }

                con.Close();

                if (Save == 1)
                {
                    //Refresh
                    this.Hide();
                    Rent_History As = new Rent_History();
                    As.ShowDialog();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please Fill Up The Mising Boxes.");
        }

        //Edit Button Created
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Button btnEdit = (Button)sender;
            Number = int.Parse(btnEdit.Name);
            B1[Number].Enabled = false;
            B1[Number].ForeColor = Color.Maroon;
            B2[Number].Enabled = true;
            B2[Number].ForeColor = Color.Green;
            TB1[Number].Enabled = true;
            TB2[Number].Enabled = true;
            TB3[Number].Enabled = true;
            TB4[Number].Enabled = true;
            TB6[Number].Enabled = true;
            TB7[Number].Enabled = true;
            TB8[Number].Enabled = true;
        }

        private void C_Back_Button_Click(object sender, EventArgs e)
        {
            //Go To Administration
            this.Hide();
            Administration Admin = new Administration();
            Admin.ShowDialog();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Refresh Form
            this.Hide();
            Rent_History His = new Rent_History();
            His.ShowDialog();
            this.Close();
        }

        private void Rent_History_Load(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
