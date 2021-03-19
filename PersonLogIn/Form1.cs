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

namespace PersonLogIn
{
    public partial class RegistrationPage : Form
    {
        string connectionString = " Server = NISHMA\\SQLEXPRESS02; Database=LoginManagementSystem;Trusted_Connection=True";
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != string.Empty && txtPassword.Text != string.Empty && txtName.Text != string.Empty && txtMaths.Text != string.Empty && txtMalayalam.Text != string.Empty && txtEnglish.Text != string.Empty)
            {


                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();


                SqlCommand command = new SqlCommand("SELECT * FROM Login where UserName='" + txtUserName.Text + "'", connection);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    dataReader.Close();
                    MessageBox.Show("Username Already exist..");
                    txtName.Text = txtUserName.Text = txtPassword.Text = txtMalayalam.Text = txtEnglish.Text = txtMaths.Text = " ";
                    connection.Close();
                }


                //SqlCommand command = new SqlCommand("GetExistingUserName", connection);
                //command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("UserName", txtUserName.Text);
                //SqlDataReader dataReader = command.ExecuteReader();


                //if (dataReader.HasRows == true)
                //{
                //    MessageBox.Show("UserName=" + dataReader[1].ToString() + "Already exist");
                //}

                else
                {

                    dataReader.Close();
                    command = new SqlCommand("PersonRegistrationSave", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("Name", txtName.Text);
                    command.Parameters.AddWithValue("UserName", txtUserName.Text);
                    command.Parameters.AddWithValue("Password", txtPassword.Text);
                    command.Parameters.AddWithValue("Malayalam", txtMalayalam.Text);
                    command.Parameters.AddWithValue("English", txtEnglish.Text);
                    command.Parameters.AddWithValue("Maths", txtMaths.Text);


                    command.ExecuteNonQuery();
                    connection.Close();
                    txtName.Text = txtUserName.Text = txtPassword.Text = txtMalayalam.Text = txtEnglish.Text = txtMaths.Text = " ";

                    MessageBox.Show("Registered Successfully");
                    Login obj = new Login();
                    obj.Show();
                    this.Hide();
                }

            }

            else
            {
                MessageBox.Show("Please enter value in all fields");
            } 
            
        }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        
    }
}
