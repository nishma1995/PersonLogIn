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
    public partial class Home : Form
    {
        string connectionString = "Server=NISHMA\\SQLEXPRESS02;Database=LoginManagementSystem;Trusted_Connection=True";
        Person _person = new Person();
        private int _ticks;

        public Home(Person person)
        {
            InitializeComponent();
    
            _person = person;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            timer.Start();
           
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            this.BackColor = Color.FromArgb(Convert.ToInt32(_person.Color));

            this.Top = _person.Top;
            this.Left = _person.Left;


        }


        private void UpdateWindowPosition(int left, int top, int personId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("UpdateWindowPosition", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id", personId);
            command.Parameters.AddWithValue("Left", left);
            command.Parameters.AddWithValue("Top", top);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateWindowPosition(this.Left, this.Top, _person.ID);
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            SetColor(_person.ID);
        }
        private void SetColor(int personId)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            this.BackColor = Color.FromArgb(colorDialog.Color.ToArgb());

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SetColor", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id", personId);
            command.Parameters.AddWithValue("Color", colorDialog.Color.ToArgb().ToString());
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //timer.Enabled = true;
            //timer.Interval = 50;
            _ticks--;
            lblTimerHour.Text = _ticks.ToString();

        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            lblTimerHour.Text = "0.00";
            
            timer.Start();
        }
    }
}
