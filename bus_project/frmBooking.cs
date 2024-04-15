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
    public partial class frmBooking : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ");

        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
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
            comFrom.DataSource= ds.Tables[0];
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassengerName.Text !="")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into passenger(passengerId,passengerName, mobile,email,gender,JourneyDate,reportingTime," +
                    "seatNo,seatFare,busId,superViserId,busType,[From],[To]) values (@i,@n,@m,@e,@g,@jd,@rt,@sn,@sf,@b,@s,@bt,@f,@t)";
                cmd.Parameters.AddWithValue("@i", txtPassengerId.Text);
                cmd.Parameters.AddWithValue("@n", txtPassengerName.Text);
                cmd.Parameters.AddWithValue("@m", txtMobile.Text);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.AddWithValue("@g", radMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@jd", dateJourneyDate.Value);
                cmd.Parameters.AddWithValue("@rt", timeReportingTime.Value);
                cmd.Parameters.AddWithValue("@sn", comSeatNo.SelectedValue);
                cmd.Parameters.AddWithValue("@sf", txtSeatFare.Text);
                cmd.Parameters.AddWithValue("@b", comBusId.Text);
                cmd.Parameters.AddWithValue("@s", comSupId.Text);
                cmd.Parameters.AddWithValue("@bt", comBusType.SelectedValue);
                cmd.Parameters.AddWithValue("@f", comFrom.SelectedValue);
                cmd.Parameters.AddWithValue("@t", comTo.SelectedValue);
                cmd.ExecuteNonQuery();
                lblMsg.Text = "Submitted !!";
                con.Close();
            }
            else
            {
                MessageBox.Show("Passenger Name Must be Write.");
            }
            
        }

        private void comSupId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            dateJourneyDate.Text = "";
            timeReportingTime.Text = "";
            comBusId.SelectedValue = -1;
            comBusType.SelectedValue = -1;
            comFrom.SelectedValue = -1;
            comFrom.SelectedValue = -1;
            comTo.SelectedValue = -1;
            comSupId.SelectedValue = -1;
            comSeatNo.SelectedValue = -1;
            txtSeatFare.Clear();
        }
    }
}
