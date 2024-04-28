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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEWFinalProject
{
    public partial class ViewOrdersForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-S3RQ5UI\SQLEXPRESS;Initial Catalog=RestaurantMangSystem;Integrated Security=True;Encrypt=False";
        private DataTable ordersTable;
        private int count;
        public string username;


        public ViewOrdersForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    ordersTable = new DataTable();
                    adapter.Fill(ordersTable);
                    ordersDataGridView.DataSource = ordersTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL error occurred. Please try again." + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown error occurred. Please try again." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            string connectionString2 = @"Data Source=DESKTOP-S3RQ5UI\SQLEXPRESS;Initial Catalog=RestaurantMangSystem;Integrated Security=True;Encrypt=False";
            string query = "SELECT FirstName, LastName, WaiterID FROM Waiters WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString2))
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

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (count == 1 && !columnNameTextBox.Text.Equals("OrderID") && !columnNameTextBox.Text.Equals("TableID"))
            {
                DataView dv = ordersTable.DefaultView;
                dv.RowFilter = columnNameTextBox.Text + " Like '%" + filterTextBox.Text + "%'";

            //dv.RowFilter = textBox1.Text + " Like '%" + textBox2.Text + "%' AND " + "last_name Like '%At%'"; //dataGridView1.DataSource = dv;//no need



            }
        }
        private void columnTextBox_Leave(object sender, EventArgs e)//lost Focus
        {
            count = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Orders' AND COLUMN_NAME = @column", con);
                cmd.Parameters.AddWithValue("@column", columnNameTextBox.Text);
                con.Open();
                count = (Int32)cmd.ExecuteScalar();
            }
            filterTextBox_TextChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WaiterForm3 waiterForm3 = new WaiterForm3(username);
            waiterForm3.Show();
            this.Hide();
        }
    }
}
