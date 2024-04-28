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

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S3RQ5UI\SQLEXPRESS;Initial Catalog=RestaurantMangSystem;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get data from the form
                string tableId = TableIDComboBox.SelectedItem?.ToString() ?? ""; // Assuming TableIDComboBox is the name of your ComboBox
                int tableID = Convert.ToInt32(tableId);

                string appetizer = AppetizerComboBox.SelectedItem?.ToString() ?? ""; // Assuming AppetizerComboBox is the name of your ComboBox
                string mainDish = MainDishComboBox.SelectedItem?.ToString() ?? ""; // Assuming MainDishComboBox is the name of your ComboBox
                string dessert = DessertComboBox.SelectedItem?.ToString() ?? ""; // Assuming DessertComboBox is the name of your ComboBox

                string softDrink = SoftDrinkComboBox.SelectedItem?.ToString() ?? ""; // Assuming SoftDrinkComboBox is the name of your ComboBox
                string alcoholicDrink = AlcoholicDrinkComboBox.SelectedItem?.ToString() ?? ""; // Assuming AlcoholicDrinkComboBox is the name of your ComboBox
                string hotDrink = HotDrinkComboBox.SelectedItem?.ToString() ?? ""; // Assuming HotDrinkComboBox is the name of your ComboBox

                // Insert data into the Orders table
                using (SqlConnection insertConnection = new SqlConnection(connectionString))
                {
                    insertConnection.Open();

                    string insertQuery = "INSERT INTO Orders (TableID, Meals, Drinks) VALUES (@TableID, @Meals, @Drinks); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, insertConnection))
                    {
                        insertCmd.Parameters.AddWithValue("@TableID", tableID);
                        insertCmd.Parameters.AddWithValue("@Meals", $"{appetizer}, {mainDish}, {dessert}");
                        insertCmd.Parameters.AddWithValue("@Drinks", $"{softDrink}, {alcoholicDrink}, {hotDrink}");

                        //insertCmd.ExecuteNonQuery();

                        int orderID = Convert.ToInt32(insertCmd.ExecuteScalar());

                        MessageBox.Show($"Order #{orderID} was made successfully!");

                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WaiterForm3 waiterForm3 = new WaiterForm3(username);
            waiterForm3.Show();
            this.Hide();
        }
    }
    }
