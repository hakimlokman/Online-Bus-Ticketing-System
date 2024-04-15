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
    public partial class frmDeriver : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ");

        public frmDeriver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img =Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image= img;
                txtPicture.Text=openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(txtPicture.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Driver ( driverId, driverName, " +
                    "phone, joindate, picture) values (@i,@n,@p,@j,@ph)";
                cmd.Parameters.AddWithValue("@i", txtId.Text);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.Parameters.AddWithValue("@j", dateTimePicker1.Value);
                cmd.Parameters.Add(new SqlParameter("@ph", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.ExecuteNonQuery();
                lblMsg.Text = "Saved Successfully";
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Type valid Information!!\n" + ex.Message,"Alert",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            dateTimePicker1.Text = "";
            txtPicture.Clear();
        }
    }
}
