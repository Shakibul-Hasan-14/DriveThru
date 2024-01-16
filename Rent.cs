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
    public partial class Rent : Form
    {
        //Connecting Database
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PAAG389U\\SQLEXPRESS; Initial Catalog = DriveThru Database; Integrated Security = True");
        string Cname = "", CNum = "", CAdd = "", CEmail = "", Username = "";
        Image photo = null;

        public Rent(string cm, string cap, string np, Image cp, string un)
        {
            InitializeComponent();

            Username = un;

            //Retrieve Data From
            string Q = "Select * from Customer where Username = '" + Username + "'";
            SqlCommand Command = new SqlCommand(Q, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                SqlDataReader R = Command.ExecuteReader();

                while (R.Read())
                {
                    Cname = R["Customer_Name"].ToString();
                    CNum = R["Customer_Number"].ToString();
                    CAdd = R["Customer_Address"].ToString();
                    CEmail = R["Email_Address"].ToString();
                }
            }

            con.Close();

            //Make Button Transparent
            btnRentBack.FlatStyle = FlatStyle.Flat;

            //TextBox Focus Removed
            btnRentBack.TabStop = false;
            ShowModeltxt.TabStop = false;
            ShowCaptxt.TabStop = false;
            ShowPlatetxt.TabStop = false;
            ShowDatetxt.TabStop = false;
            ShowBilltxt.TabStop = false;
            Hourtxt.TabStop = false;
            btnConfirm.TabStop = false;

            string a = cm.ToString();
            string b = cap.ToString();
            string c = np.ToString();

            ShowModeltxt.Text = a;
            ShowCaptxt.Text = b;
            ShowPlatetxt.Text = c;
            ShowPic.Image = cp;

            photo = cp;
        }

        private void btnRentBack_Click(object sender, EventArgs e)
        {
            //Go To Available_For_Rent_Cus
            this.Hide();
            Available_For_Rent Cus = new Available_For_Rent(Username);
            Cus.ShowDialog();
            this.Close();
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            

            //byte[] imageData = null;

            //using (MemoryStream ms = new MemoryStream())
            //{
            //    photo.Save(ms, ShowPic.Image.RawFormat);
            //    imageData = ms.ToArray();
            //}

            string query = "Insert into On_Rent (Rent_date, Expected_Return_Time, Number_Plate, Temporary_Bill, Customer_Name," +
                "Customer_Address, Customer_Number, Email_Address, Car_Photo)  Values (@RD, @ETA, @NP, @TB, @CName, @CADDress, @CNum, @E, @Photo)";
            
            SqlCommand cmd = new SqlCommand(query, con);

            // Add parameters for the values
            cmd.Parameters.Add("@RD", SqlDbType.VarChar).Value = ShowDatetxt.Text;
            cmd.Parameters.Add("@ETA", SqlDbType.VarChar).Value = Hourtxt.Text;
            cmd.Parameters.Add("@NP", SqlDbType.VarChar).Value = ShowPlatetxt.Text;
            cmd.Parameters.Add("@TB", SqlDbType.VarChar).Value = ShowBilltxt.Text;
            cmd.Parameters.Add("@CName", SqlDbType.VarChar).Value = Cname;
            cmd.Parameters.Add("@CADDress", SqlDbType.VarChar).Value = CAdd;
            cmd.Parameters.Add("@CNum", SqlDbType.VarChar).Value = CNum;
            cmd.Parameters.Add("@E", SqlDbType.VarChar).Value = CEmail;
            cmd.Parameters.Add("@Photo", SqlDbType.VarBinary, -1).Value = ImageToByte(photo);

            con.Open();
            if (con.State == ConnectionState.Open)
            {
                cmd.ExecuteNonQuery();

                //Go To Customer
                MessageBox.Show("Confirmation Successful!!");
                this.Hide();
                Customer Cus = new Customer(Username);
                Cus.ShowDialog();
                this.Close();
            }
            con.Close();
        }

        float bill = 1;
        private void Hourtxt_TextChanged(object sender, EventArgs e)
        {
            if ((ShowCaptxt.Text != "") && (Hourtxt.Text != "") && rbYes.Checked == true)
            {
                bill = (float.Parse(ShowCaptxt.Text) * 50) * float.Parse(Hourtxt.Text) + (100 * float.Parse(Hourtxt.Text));
                ShowBilltxt.Text = bill.ToString();
            }
            else if ((ShowCaptxt.Text != "") && (Hourtxt.Text != "") && rbNo.Checked == true)
            {
                bill = (float.Parse(ShowCaptxt.Text) * 50) * float.Parse(Hourtxt.Text);
                ShowBilltxt.Text = bill.ToString();
            }
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if ((ShowCaptxt.Text != "") && (Hourtxt.Text != ""))
            {
                bill = (float.Parse(ShowCaptxt.Text) * 50) * float.Parse(Hourtxt.Text) + (100 * float.Parse(Hourtxt.Text));
                ShowBilltxt.Text = bill.ToString();
            }
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if ((ShowCaptxt.Text != "") && (Hourtxt.Text != ""))
            {
                bill = (float.Parse(ShowCaptxt.Text) * 50) * float.Parse(Hourtxt.Text);
                ShowBilltxt.Text = bill.ToString();
            }
        }

        private void ShowBilltxt_TextChanged_1(object sender, EventArgs e)
        {
            //Unused
        }
    }
}
