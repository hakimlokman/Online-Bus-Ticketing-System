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
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = DESKTOP-2KRLH3S\LOKMAN; initial Catalog=busBD; Integrated Security = True; ");

        public RegisterForm()
        {
            InitializeComponent();
        }
        public bool CheckConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (regiName.Text == "" || regiPass.Text == "" || regiConfirmPass.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "select * from users where username = @usern";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", regiName.Text.Trim());

                            SqlDataAdapter sda = new SqlDataAdapter(checkUser);
                            DataTable dt = new DataTable();

                            sda.Fill(dt);
                            if (dt.Rows.Count != 0)
                            {
                                string tempUsern = regiName.Text.Substring(0, 1).ToUpper() + regiName.Text.Substring(1);
                                MessageBox.Show(tempUsern + "is existing alredy", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (regiPass.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Password, at least 8 character are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (regiPass.Text != regiConfirmPass.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "insert into users (username,password,dateCreate) values (@usern, @pass,@date)";
                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", regiName.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", regiPass.Text.Trim());
                                    DateTime today = DateTime.Now;
                                    insertUser.Parameters.AddWithValue("@date", today);

                                    insertUser.ExecuteNonQuery();
                                    MessageBox.Show("Registered SucessFully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    loginForm loginForm = new loginForm();
                                    loginForm.Show();
                                    this.Hide();

                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Faild Connection:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    { connect.Close(); }
                }
            }
        }

        private void regiSignUp_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void regiShowPass_CheckedChanged(object sender, EventArgs e)
        {
            regiPass.PasswordChar = regiShowPass.Checked ? '\0' : '*';
            regiConfirmPass.PasswordChar = regiShowPass.Checked ? '\0' : '*';
        }
    }
}
