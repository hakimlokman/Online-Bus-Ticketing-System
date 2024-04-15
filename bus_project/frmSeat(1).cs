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
    }
}
