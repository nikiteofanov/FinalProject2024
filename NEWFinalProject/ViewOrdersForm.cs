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

namespace NEWFinalProject
{
    public partial class ViewOrdersForm : Form
    {
        string connectionString = @"Data Source=LAB108PC18\SQLEXPRESS;Initial Catalog=RestaurantMangSystem;Integrated Security=True";
        private DataTable ordersTable;
        private int count;

        public ViewOrdersForm()
        {
            InitializeComponent();
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
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (count == 1 && !columnNameTextBox.Text.Equals("id"))
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
    }
}
