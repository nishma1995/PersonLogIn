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
        int seconds,minutes,hours;

        public Home(Person person)
        {
            InitializeComponent();
    
            _person = person;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            timer.Start();
            seconds = minutes = hours = 0;
           
        }

        private void Home_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(Convert.ToInt32(_person.Color));

            this.Top = _person.Top;
            this.Left = _person.Left;
            this.Text = lblName.Text = _person.Name;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("GetPersonRegister", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Name", lblName.Text);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            {
                lstBoxDetails.Items.Add("Name:" + reader["Name"].ToString());
                lstBoxDetails.Items.Add("Username:" + reader["UserName"].ToString());
                lstBoxDetails.Items.Add("English:" + reader["English"].ToString());
                lstBoxDetails.Items.Add("Maths:" + reader["Maths"].ToString());
                lstBoxDetails.Items.Add("Malayalam:" + reader["Malayalam"].ToString());
                lstBoxDetails.Items.Add("Total Marks:" + reader["Total"].ToString());


            }
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

        private void Home_MouseLeave(object sender, EventArgs e)
        {
            //timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //timer.Enabled = true;
            //timer.Interval = 50;
            //_ticks++;
            seconds++;
            if (seconds>59)
            {
                minutes++;
                seconds = 0;

            }
            if (minutes>59)
            {
                hours++;
                minutes = 0;
            }

            lblTimerHour.Text = hours.ToString();
            lblTimerMinutes.Text = minutes.ToString() ;
            lblTimerSeconds.Text = seconds.ToString() ;


        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            lblTimerHour.Text = "00";
            lblTimerMinutes.Text= "00";
            lblTimerSeconds.Text = "00";
           // timer.Stop();
            //seconds++;
            //if (seconds > 59)
            //{
            //    minutes++;
            //    seconds = 0;

            //}
            //if (minutes > 59)
            //{
            //    hours++;
            //    minutes = 0;
            //}

            //lblTimerHour.Text = hours.ToString();
            //lblTimerMinutes.Text = minutes.ToString();
            //lblTimerSeconds.Text = seconds.ToString();
            //timer.Start();

        }  
    }
}
