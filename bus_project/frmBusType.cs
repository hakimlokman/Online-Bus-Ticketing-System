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
using System.Xml.Linq;

namespace bus_project
{
    public partial class frmBusType : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ");
        public frmBusType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into busType Values ('"+txtType.Text+"')", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data submitted SucesssFully !!";
            LoadGrid();
            txtType.Text = "";
            con.Close();
        }

        private void frmBusType_Load(object sender, EventArgs e)
        {

            LoadGrid();
        }
        private void LoadGrid()
        {
          
            SqlDataAdapter sda = new SqlDataAdapter( "Select * from busType",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter("select id, type from busType where type= '" + txtType.Text + "'", con);
            DataTable dt = new DataTable();
            Sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtType.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "No Data Found!!";
            }
            con.Close();
        }
    }
}
