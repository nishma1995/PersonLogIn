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
    public partial class Login : Form
    {
        Person person = new Person();
        string connectionString = "Server=NISHMA\\SQLEXPRESS02;Database=LoginManagementSystem;Trusted_Connection=True";
        public Login()
        {
            InitializeComponent();
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            //SqlCommand command = new SqlCommand("GetExistingUserName", connection);
            //command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("UserName", txtUserName.Text);
            //SqlDataReader dataReader = command.ExecuteReader();

            Person LoginedPerson = _Login(txtUserName.Text, txtPassword.Text);

            if (LoginedPerson != null)


            {

                //if (dataReader.HasRows == true)

                //{
                    MessageBox.Show("valid");
                    this.Hide();
                    Home home = new Home(LoginedPerson);
                    home.Show();
                }
                else
                {
                    MessageBox.Show("No Account");
                }
            //}


        }

        private Person _Login(string username, string password)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SetLogin", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("UserName", username);
            command.Parameters.AddWithValue("Password", password);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            Person person = new Person();

           person.ID = Convert.ToInt32(reader["Id"]);
            person.Name = reader["Name"].ToString();
            person.Left = Convert.ToInt32(Convert.ToInt32(reader["Left"]));
            person.Top = Convert.ToInt32(Convert.ToInt32(reader["Top"]));
            person.Username = reader["UserName"].ToString();
            person.Color = reader["Color"].ToString();
            return person;

           
        }

    }
}
