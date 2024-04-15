using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_project
{
    public partial class frmDriverUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ");

        public frmDriverUpdateDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter("Select driverId, driverName, phone, joindate, picture from Driver Where driverId=" + txtId.Text + "", con);
            DataTable dt = new DataTable();
            Sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0][1].ToString();
                txtPhone.Text= dt.Rows[0][2].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                MemoryStream ms= new MemoryStream((byte[])dt.Rows[0][4]);
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;

            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "No Data Found!!";
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            dateTimePicker1.Text = "";
            txtPicture.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtPicture.Text !="")
            {
                Image img = Image.FromFile(txtPicture.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update Driver Set driverName=@n,phone=@n,joindate=@j,picture=@ph Where driverId=@i";
                cmd.Parameters.AddWithValue("@i", txtId.Text);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.Parameters.AddWithValue("@j", dateTimePicker1.Value);
                cmd.Parameters.Add(new SqlParameter("@ph", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.ExecuteNonQuery();
                lblMsg.Text = "Data Updated  Successfully";
                con.Close();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update Driver Set driverName=@n,phone=@n,joindate=@j Where driverId=@i";
                cmd.Parameters.AddWithValue("@i", txtId.Text);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.Parameters.AddWithValue("@j", dateTimePicker1.Value);
                cmd.ExecuteNonQuery();
                lblMsg.Text = "Data Updated  Successfully";
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Driver Where driverId=@i",con);
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Deleted  Successfully";
            con.Close();
        }
    }
}
