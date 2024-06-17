
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CRUD_FormasDePago : Form
    {
        public CRUD_FormasDePago()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombreFormaPago = textBoxNombre.Text;
            AgregarFormaDePago(nombreFormaPago);
            CargarFormasDePago();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int idFormaPago = int.Parse(textBoxId.Text);
            string nombreFormaPago = textBoxNombre.Text;
            ModificarFormaDePago(idFormaPago, nombreFormaPago);
            CargarFormasDePago();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int idFormaPago = int.Parse(textBoxId.Text);
            EliminarFormaDePago(idFormaPago);
            CargarFormasDePago();
        }

        private void CargarFormasDePago()
        {
            DataTable dt = ObtenerFormasDePago();
            dataGridView1.DataSource = dt;
        }

        private DataTable ObtenerFormasDePago()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "your_connection_string_here";
            string query = "SELECT * FROM FormasDePago";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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

        private void AgregarFormaDePago(string nombre)
        {
            string connectionString = "your_connection_string_here";
            string query = "INSERT INTO FormasDePago (Nombre) VALUES (@Nombre)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void ModificarFormaDePago(int id, string nombre)
        {
            string connectionString = "your_connection_string_here";
            string query = "UPDATE FormasDePago SET Nombre = @Nombre WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // CRUD_FormasDePago
            // 
            ClientSize = new Size(793, 440);
            Name = "CRUD_FormasDePago";
            ResumeLayout(false);
        }

        private void EliminarFormaDePago(int id)
        {
            string connectionString = "your_connection_string_here";
            string query = "DELETE FROM FormasDePago WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
