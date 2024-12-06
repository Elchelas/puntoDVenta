using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoDVenta.INVENTARIO
{
    internal class cambiarNombre
    {
        private string connectionString = "Server=localhost;Database=puntoDVenta;Uid=root;Pwd=root;";

        public void ModificarNombre(int idProducto, string nuevoNombre, Label labeel)
        {
            try
            {
                // Validar que el nuevo nombre no esté vacío
                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    labeel.Text = "El nombre no puede estar vacío.";
                    return;
                }

                // Crear la conexión y el comando SQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE PRODUCTOS SET nombre = @nuevoNombre WHERE IDproducto = @IDproducto";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar parámetros para prevenir inyección SQL
                        cmd.Parameters.AddWithValue("@IDproducto", idProducto);
                        cmd.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);

                        // Ejecutar la consulta
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Mostrar mensaje según el resultado
                        if (rowsAffected > 0)
                        {
                            labeel.Text = "El nombre del producto se ha actualizado correctamente.";
                        }
                        else
                        {
                            labeel.Text = "No se encontró un producto con el ID especificado.";
                        }
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
