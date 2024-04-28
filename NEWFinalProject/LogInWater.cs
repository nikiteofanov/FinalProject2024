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

namespace NEWFinalProject
{
    public partial class LogInWater : Form
    {
        string connection = @"Data Source=DESKTOP-S3RQ5UI\SQLEXPRESS;Initial Catalog=RestaurantMangSystem;Integrated Security=True;Encrypt=False";
        public string Username { get; private set; }

        public LogInWater()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringConnection = @"Data Source=DESKTOP-S3RQ5UI\SQLEXPRESS;Initial Catalog=RestaurantMangSystem;Integrated Security=True;Encrypt=False";

            Username = textBox1.Text;


            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = "SELECT COUNT(*) FROM WaitersLogIn WHERE Username = @Username AND [Password] = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        // Proceed with your application logic here after successful login

                       
                        WaiterForm3 waiterForm3 = new WaiterForm3(username);
                        waiterForm3.Show();
                        waiterForm3.username = username; // Assign the username to the username property of WaiterForm3
                        this.Hide();
                        waiterForm3.Show();


                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LogInWater_Load(object sender, EventArgs e)
        {

        }
    }
}
