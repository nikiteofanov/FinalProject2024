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
    public partial class WaiterForm3 : Form
    {
        public string username;
        public WaiterForm3(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateNewOrderForm createNewOrderForm = new CreateNewOrderForm(username);
            createNewOrderForm.ShowDialog();
        }

        private void WaiterForm3_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S3RQ5UI\SQLEXPRESS;Initial Catalog=RestaurantMangSystem;Integrated Security=True;Encrypt=False";
            string query = "SELECT FirstName, LastName, WaiterID FROM Waiters WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string FirstName = reader["FirstName"].ToString();
                        string LastName = reader["LastName"].ToString();
                        int waiterID = Convert.ToInt32(reader["WaiterID"]);

                        // Display the retrieved information
                        label1.Text = FirstName + " " + LastName;
                        label2.Text = "WaiterID: " + waiterID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Waiter not found in the database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            string query2 = "SELECT FirstName, LastName, WaiterID, WorkDays, Shift FROM Waiters WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query2, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName_ = reader["FirstName"].ToString();
                        string lastName_ = reader["LastName"].ToString();
                        int waiterID_ = Convert.ToInt32(reader["WaiterID"]);
                        string workDays_ = reader["WorkDays"].ToString();
                        string shift_ = reader["Shift"].ToString();

                        firstName.Text = firstName_;
                        lastName.Text = lastName_;
                        waiterID.Text = waiterID_.ToString();
                        workDays.Text = workDays_;
                        if (shift_ == "Breakfast")
                        {
                            breakfastButton.Checked = true;
                        }
                        else if (shift_ == "Lunch")
                        {
                            lunchButton.Checked = true;
                        }
                        else if (shift_ == "Dinner")
                        {
                            dinnerButton.Checked = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Waiter not found in the database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

    private void button5_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrdersForm = new ViewOrdersForm();
            viewOrdersForm.Show();
        }
    }
}
