using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoDVenta.ORDENES
{
    internal class ordenesMetodos
    {

        private string connectionString = "Server=localhost;Database=puntoDVenta;Uid=root;Pwd=root;";

        public void MostrarOrdena(string idCategoria, DataGridView dataGridView)
        {
            try
            {
                // Crear la conexión y la consulta SQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM PRODUCTOS WHERE idCategoria = @idCategoria";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro para evitar inyección SQL
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);

                        // Cargar los datos en un DataTable
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar los datos al DataGridView
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectarse a la base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
