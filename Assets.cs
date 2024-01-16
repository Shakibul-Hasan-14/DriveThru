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
    public partial class Assets : Form
    {
        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");
        int Point = 0, corrupt = 0, Number = 0;
        private Button[] B1;
        private Button[] B2;
        private Button[] B3;
        private TextBox[] TB1;
        private TextBox[] TB2;
        private TextBox [] TB3;

        public Assets()
        {
            InitializeComponent();
            
            //Put Focus
            btnBack.TabStop = true;

            //Make Buttons Transparent
            btnBack.FlatStyle = FlatStyle.Flat;
            btnAddAsset.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            btnAddAsset.TabStop = false;
            btnRefresh.TabStop = false;

            //Dynamically Display Database
            string query = "Select * From Assets";
            SqlCommand cmd = new SqlCommand(query, con);
            int btn = 0;
            B1 = new Button[20];
            B2 = new Button[20];
            B3 = new Button[20];
            TB1 = new TextBox[20];
            TB2 = new TextBox[20];
            TB3 = new TextBox[20];

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PictureBox PB = new PictureBox();
                    Label L1 = new Label();
                    Label L2 = new Label();
                    Label L3 = new Label();
                    TB1[btn] = new TextBox();
                    TB2[btn] = new TextBox();
                    TB3[btn] = new TextBox();
                    B1[btn] = new Button();
                    B2[btn] = new Button();
                    B3[btn] = new Button();

                    PB.Size = new Size(366, 222);
                    PB.BackColor = Color.White;
                    PB.SizeMode = PictureBoxSizeMode.StretchImage;
                    PB.Location = new Point(113, Point + 74);

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
                    B1[btn].Enabled = false;
                    B1[btn].Text = "SAVE";
                    B1[btn].UseVisualStyleBackColor = true;
                    B1[btn].Location = new Point(518, Point + 267);
                    B1[btn].Size = new Size(90, 29);
                    B1[btn].FlatStyle = FlatStyle.Flat;
                    B1[btn].Click += new EventHandler(this.btnSave_Click);
                    B1[btn].Name = btn.ToString();

                    B2[btn].BackColor = Color.RosyBrown;
                    B2[btn].Font = new Font("Times New Roman", 12);
                    B2[btn].ForeColor = Color.Green;
                    B2[btn].Text = "EDIT";
                    B2[btn].UseVisualStyleBackColor = true;
                    B2[btn].Location = new Point(681, Point + 267);
                    B2[btn].Size = new Size(90, 29);
                    B2[btn].FlatStyle = FlatStyle.Flat;
                    B2[btn].Click += new EventHandler(this.btnEdit_Click);
                    B2[btn].Name = btn.ToString();

                    B3[btn].BackColor = Color.RosyBrown;
                    B3[btn].Font = new Font("Times New Roman", 12);
                    B3[btn].ForeColor = Color.Maroon;
                    B3[btn].Enabled = false;
                    B3[btn].Text = "DELETE";
                    B3[btn].UseVisualStyleBackColor = true;
                    B3[btn].Location = new Point(840, Point + 267);
                    B3[btn].Size = new Size(90, 29);
                    B3[btn].FlatStyle = FlatStyle.Flat;
                    B3[btn].Click += new EventHandler(this.btnDelete_Click);
                    B3[btn].Name = btn.ToString();

                    byte[] pic = (byte[])reader["Car_Photo"];
                    MemoryStream ms = new MemoryStream(pic);
                    try
                    {
                        PB.Image = Image.FromStream(ms);
                    }
                    catch(System.ArgumentException)
                    {
                        corrupt = 1;
                    }

                    TB1[btn].Text = reader["Number_Plate"].ToString();
                    TB2[btn].Text = reader["Car_Model"].ToString();
                    TB3[btn].Text = reader["Capacity"].ToString();

                    this.Controls.Add(PB);
                    this.Controls.Add(L1);
                    this.Controls.Add(L2);
                    this.Controls.Add(L3);
                    this.Controls.Add(TB1[btn]);
                    this.Controls.Add(TB2[btn]);
                    this.Controls.Add(TB3[btn]);
                    this.Controls.Add(B1[btn]);
                    this.Controls.Add(B2[btn]);
                    this.Controls.Add(B3[btn]);

                    Point = Point + 300;
                    btn = btn + 1;
                }
            }

            con.Close();

            if(corrupt == 1)
            {
                MessageBox.Show("Couldn't Load Corrupt Images.");
            }
        }

        //Save Button Created
        private void btnSave_Click(object sender, EventArgs e)
        {
            int Save = 0;
            Button btnSave = (Button)sender;
            Number = int.Parse(btnSave.Name);

            string NP = TB1[Number].Text;

            if (String.IsNullOrEmpty(TB1[Number].Text) == false && String.IsNullOrEmpty(TB2[Number].Text) == false && String.IsNullOrEmpty(TB3[Number].Text) == false)
            {
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    string query = "Update Assets set Car_Model = '" + TB2[Number].Text + "', Capacity = '" + TB3[Number].Text + "' Where Number_Plate = '" + TB1[Number].Text + "'";
                    SqlCommand command = new SqlCommand(query, con);

                    command.ExecuteNonQuery();
                    Save = 1;
                }

                con.Close();

                if (Save == 1)
                {
                    //Refresh
                    this.Hide();
                    Assets As = new Assets();
                    As.ShowDialog();
                    this.Close();
                }
            }
        }

        //Edit Button Created
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Button btnEdit = (Button)sender;
            Number = int.Parse(btnEdit.Name);
            B1[Number].Enabled = true;
            B1[Number].ForeColor = Color.Green;
            B2[Number].Enabled = false;
            B2[Number].ForeColor = Color.Maroon;
            B3[Number].Enabled = true;
            B3[Number].ForeColor = Color.Green;
            TB2[Number].Enabled = true;
            TB3[Number].Enabled = true;
        }

        //Delete Button Created
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Deleted = 0;

            Button btnDelete = (Button)sender;
            Number = int.Parse(btnDelete.Name);

            string query = "Delete From Assets Where Number_Plate = '" + TB1[Number].Text + "'";
            SqlCommand command = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                command.ExecuteNonQuery();
                Deleted = 1;
                
            }
            
            con.Close();

            if (Deleted == 1)
            {
                //Refresh
                this.Hide();
                Assets As = new Assets();
                As.ShowDialog();
                this.Close();
            }
        }

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            //TextBox Focus Removed
            btnBack.TabStop = false;

            //Go To Administration
            this.Hide();
            Administration Admin = new Administration();
            Admin.ShowDialog();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Make Buttons Transparent
            btnRefresh.FlatStyle = FlatStyle.Flat;
            
            //Refresh
            this.Hide();
            Assets As = new Assets();
            As.ShowDialog();
            this.Close();
        }

        private void btnAddAsset_Click_1(object sender, EventArgs e)
        {
            //TextBox Focus Removed
            btnAddAsset.TabStop = false;

            //Go To Add_New_Car
            this.Hide();
            Add_New_Car Add = new Add_New_Car();
            Add.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
