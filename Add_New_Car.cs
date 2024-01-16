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
    public partial class Add_New_Car : Form
    {
        public Add_New_Car()
        {
            InitializeComponent();

            //Make Button Transparent
            btnAddBack.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            btnAddBack.TabStop = false;
            btnAdd.TabStop = false;
            btnUpload.TabStop = false;
            AddModeltxt.TabStop = false;
            AddCaptxt.TabStop = false;
            AddPlatetxt.TabStop = false;
        }

        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            //Make Button Transparent
            btnAddBack.FlatStyle = FlatStyle.Flat;

            //Go to Assets
            this.Hide();
            Assets A = new Assets();
            A.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a1 = 0, a2 = 0, a3 = 0, a4 = 0;
            byte[] imageData = null;

            //Checking Car Model
            if (String.IsNullOrEmpty(AddModeltxt.Text) == false)
                a1 = 1;
            else
                MessageBox.Show("Please Provide The Car's Model.");

            //Checking Number Plate
            if (String.IsNullOrEmpty(AddPlatetxt.Text) == false)
            {
                string query = "Select Number_Plate From Assets Where Number_Plate = '" + AddPlatetxt.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                //Checking if Number Plate Already Exists 
                if (con.State == ConnectionState.Open)
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        MessageBox.Show("This Number Plate Already Exists In The Inventory.");
                    else
                        a2 = 1;
                }

                con.Close();
            }
            else
                MessageBox.Show("Please Provide The Car's Plate Number.");

            //Checking Capacity
            int n;
            bool isNumeric = int.TryParse(AddCaptxt.Text, out n);
            if (String.IsNullOrEmpty(AddCaptxt.Text) == false && isNumeric == true)
                a3 = 1;
            else if(isNumeric == false && String.IsNullOrEmpty(AddCaptxt.Text) == false)
                MessageBox.Show("Please Provide Numbers In Capacity.");
            else
                MessageBox.Show("Please Provide The Car's Capacity.");

            //Checking Car Photo
            if (UpPic.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    UpPic.Image.Save(ms, UpPic.Image.RawFormat);
                    imageData = ms.ToArray();
                }

                a4 = 1;
            }
            else
                MessageBox.Show("Please Provide The Car's Photo.");

            if (a1 == 1 && a2 == 1 && a3 == 1 && a4 == 1)
            {
                //Add New Asset
                string query = "INSERT INTO Assets (Car_model, Capacity, Number_Plate, Car_Photo) VALUES (@CarModel, @Capacity, @NumberPlate, @CarPhoto)";
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameters for the values
                cmd.Parameters.Add("@CarModel", SqlDbType.VarChar).Value = AddModeltxt.Text;
                cmd.Parameters.Add("@Capacity", SqlDbType.VarChar).Value = AddCaptxt.Text;
                cmd.Parameters.Add("@NumberPlate", SqlDbType.VarChar).Value = AddPlatetxt.Text;
                cmd.Parameters.Add("@CarPhoto", SqlDbType.VarBinary, -1).Value = imageData;

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Asset Added Successfully!");
                    con.Close();

                    // Go to Assets
                    this.Hide();
                    Assets A = new Assets();
                    A.ShowDialog();
                    this.Close();
                }

                con.Close();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Upload Picture && Checking Image Size
            OpenDialog.ShowDialog();

            try
            {
                UpPic.Image = Image.FromFile(OpenDialog.FileName);
                Messagelbl.Visible = false;
            }
            catch(System.OutOfMemoryException)
            {
                MessageBox.Show("Image Size Too Large.");
            }
        }

        private void Add_New_Car_Load(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
