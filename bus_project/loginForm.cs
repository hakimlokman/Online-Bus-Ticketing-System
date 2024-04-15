using Microsoft.Win32;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bus_project
{
    public partial class loginForm : Form
    {
        string stringConnection = @"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ";

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginSignUp_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void loginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            loginPass.PasswordChar = loginShowPass.Checked ? '\0' : '*';
        }
        public static string userName;

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectUsername = "select * from users where username = @usern and password=@pass";

                using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                {
                    checkUser.Parameters.AddWithValue("@usern", loginName.Text.Trim());
                    checkUser.Parameters.AddWithValue("@pass", loginPass.Text.Trim());

                    SqlDataAdapter sda = new SqlDataAdapter(checkUser);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        userName = loginName.Text;
                        MessageBox.Show("Login Successfull", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1 main = new Form1();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }
    }
}
