using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bus_project
{
    public partial class frmTicketCancel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ");

        public frmTicketCancel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From passenger Where passengerId=@i", con);
            cmd.Parameters.AddWithValue("@i", txtPassengerId.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Deleted  Successfully";
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter("select passengerId,passengerName,mobile,email,gender,JourneyDate," +
                "reportingTime,seatNo,seatFare,busId,superViserId,busType,[From],[To] " +
                "from passenger where  passengerId=" + txtPassengerId.Text + "", con);
            DataTable dt = new DataTable();
            Sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtPassengerName.Text = dt.Rows[0][1].ToString();
                txtMobile.Text = dt.Rows[0][2].ToString();
                txtEmail.Text = dt.Rows[0][3].ToString();
                lblGender.Text = dt.Rows[0][4].ToString();
                dateJourneyDate.Value = Convert.ToDateTime(dt.Rows[0][5].ToString());
                timeReportingTime.Value = Convert.ToDateTime(dt.Rows[0][6].ToString());
                comSeatNo.SelectedValue = dt.Rows[0][7].ToString();
                comBusId.SelectedValue = dt.Rows[0][8].ToString();
                comSupId.SelectedValue = dt.Rows[0][9].ToString();
                comBusType.SelectedValue = dt.Rows[0][10].ToString();
                comFrom.SelectedValue= dt.Rows[0][11].ToString();
                comTo.SelectedValue = dt.Rows[0][12].ToString();

            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "No Data Found!!";
            }
            con.Close();
        }

        private void frmTicketCancel_Load(object sender, EventArgs e)
        {
            LoadCombo1();
            LoadCombo2();
            LoadComboBusType();
            LoadComboSeat();
            LoadbusId();
            LoadSupId();
        }
        private void LoadCombo1()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from routes ", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comFrom.DataSource = ds.Tables[0];
            comFrom.DisplayMember = "routeName";
            comFrom.ValueMember = "routeName";
            con.Close();
        }
        private void LoadCombo2()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from routes ", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comTo.DataSource = ds.Tables[0];
            comTo.DisplayMember = "routeName";
            comTo.ValueMember = "routeName";
            con.Close();
        }

        private void LoadComboBusType()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from busType ", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comBusType.DataSource = ds.Tables[0];
            comBusType.DisplayMember = "type";
            comBusType.ValueMember = "type";
            con.Close();
        }
        private void LoadComboSeat()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Seat ", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comSeatNo.DataSource = ds.Tables[0];
            comSeatNo.DisplayMember = "SeatName";
            comSeatNo.ValueMember = "SeatName";
            con.Close();
        }
        private void LoadbusId()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from buses ", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comBusId.DataSource = ds.Tables[0];
            comBusId.DisplayMember = "busId";
            comBusId.ValueMember = "busName";
            con.Close();
        }
        private void LoadSupId()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select superViserId from superViser ", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comSupId.DataSource = ds.Tables[0];
            comSupId.DisplayMember = "superViserId";
            comSupId.ValueMember = "superViserId";
            con.Close();
        }
    }
}
