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
    public partial class frmRoute : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ");

        public frmRoute()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into routes Values (" + txtRouteId.Text + ",'"+txtRouteName.Text+"')", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "submitted SucesssFully !!";
            LoadGrid();
            txtRouteId.Text = "";
            txtRouteName.Text = "";
            con.Close();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter("select routeId, routeName from routes where routeId= " + txtRouteId.Text + " ", con);
            DataTable dt = new DataTable();
            Sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtRouteName.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "No Data Found!!";
            }
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From routes Where routeId=@i", con);
            cmd.Parameters.AddWithValue("@i", txtRouteId.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Deleted  Successfully";
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update routes set routeName=@n where routeId=@id";
            cmd.Parameters.AddWithValue("@id", txtRouteId.Text);
            cmd.Parameters.AddWithValue("@n", txtRouteName.Text);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Updated  Successfully";
            con.Close();
        }

        private void frmRoute_Load(object sender, EventArgs e)
        {
            LoadGrid();

        }
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from routes ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
