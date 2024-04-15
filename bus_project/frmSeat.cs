using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_project
{
    public partial class frmSeat : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ");

        public frmSeat()
        {
            InitializeComponent();
        }

        private void frmSeat_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into  Seat Values (" + txtSeatId.Text + ",'" + txtSeatName.Text + "')", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "submitted SucesssFully!!";
            txtSeatName.Text = "";
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter("select SeatId, SeatName from Seat where SeatId= " + txtSeatId.Text + " ", con);
            DataTable dt = new DataTable();
            Sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtSeatName.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "No Data Found!!";
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update Seat set SeatName=@n where SeatId=@id";
            cmd.Parameters.AddWithValue("@id", txtSeatId.Text);
            cmd.Parameters.AddWithValue("@n", txtSeatName.Text);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Updated  Successfully!!";
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Seat Where SeatId=@i", con);
            cmd.Parameters.AddWithValue("@i", txtSeatId.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Deleted  Successfully";
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSeatName.Clear();
        }
    }
}
