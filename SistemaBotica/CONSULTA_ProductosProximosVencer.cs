
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CONSULTA_ProductosProximosVencer : Form
    {
        public CONSULTA_ProductosProximosVencer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int daysToExpire = (int)numericUpDown1.Value;
            DataTable dt = GetProductsCloseToExpiration(daysToExpire);
            dataGridView1.DataSource = dt;
        }

        private DataTable GetProductsCloseToExpiration(int daysToExpire)
        {
            DataTable dataTable = new DataTable();

            string connectionString = "your_connection_string_here";
            string query = "SELECT ProductName, ExpiryDate, Quantity " +
                           "FROM Products " +
                           "WHERE DATEDIFF(day, GETDATE(), ExpiryDate) <= @DaysToExpire " +
                           "AND DATEDIFF(day, GETDATE(), ExpiryDate) >= 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DaysToExpire", daysToExpire);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return dataTable;
        }
    }
}
