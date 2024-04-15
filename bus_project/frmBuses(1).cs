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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from buses ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       
    }
}
