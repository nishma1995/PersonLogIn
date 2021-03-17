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

        string connectionString = "@Server=NISHMA\\SQLEXPRESS02;Database=LoginManagementSystem;Trusted_Connection=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("GetExistingUserName", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("UserName", txtUserName.Text);
            SqlDataReader dataReader = command.ExecuteReader();


            if (dataReader.HasRows == true)
            {
                MessageBox.Show("UserName=" + dataReader[1].ToString() + "Already exist");
            }
            else
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
        }
    }
}
