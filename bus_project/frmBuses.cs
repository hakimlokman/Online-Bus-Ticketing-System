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
using System.Xml.Linq;

namespace bus_project
{
    public partial class frmBuses : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ");
        public frmBuses()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into buses Values (" + txtBusId.Text + ",'" + txtBusName.Text + "'," + txtTypeID.Text + ")", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data submitted SucesssFully !!";
            LoadGrid();
           txtBusId.Text = "";
            txtBusName.Text = "";
            txtTypeID.Text = "";
            con.Close();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from buses ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter("select busId, busName,typeId from buses where busId= " + txtBusId.Text + " ", con);
            DataTable dt = new DataTable();
            Sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtBusName.Text = dt.Rows[0][1].ToString();
                txtTypeID.Text= dt.Rows[0][2].ToString();
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
            cmd.CommandText = "Update buses set busName=@n,typeId=@t Where busId=@i ";
            cmd.Parameters.AddWithValue("@i", txtBusId.Text);
            cmd.Parameters.AddWithValue("@n", txtBusName.Text);
            cmd.Parameters.AddWithValue("@t", txtTypeID.Text);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Updated  Successfully";
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From buses Where busId=@i", con);
            cmd.Parameters.AddWithValue("@i", txtBusId.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Deleted  Successfully";
            con.Close();
        }

        private void frmBuses_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
            txtBusName.Clear();
            txtTypeID.Clear();
        }
    }
}
