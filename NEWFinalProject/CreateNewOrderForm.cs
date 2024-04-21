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

namespace NEWFinalProject
{
    public partial class CreateNewOrderForm : Form
    {
        public string username;
        public CreateNewOrderForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void CreateNewOrderForm_Load(object sender, EventArgs e)
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
        }
    }
}
