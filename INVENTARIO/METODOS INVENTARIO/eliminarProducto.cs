using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoDVenta.INVENTARIO
{
    internal class eliminarProducto
    {

        private string connectionString = "Server=localhost;Database=puntoDVenta;Uid=root;Pwd=root;";

        public void EliminarProducto(int idProducto, string nombre, Label labeel)
        {
            try
            {
                // Validar que el nombre no esté vacío
                if (string.IsNullOrWhiteSpace(nombre )|| idProducto < 0)
                {
                    labeel.Text="El nombre o ID del producto no puede estar vacío.";
                    return;
                }

                // Crear la conexión y el comando SQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM PRODUCTOS WHERE IDproducto = @IDproducto AND nombre = @nombre";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar parámetros para prevenir inyección SQL
                        cmd.Parameters.AddWithValue("@IDproducto", idProducto);
                        cmd.Parameters.AddWithValue("@nombre", nombre);

                        // Ejecutar la consulta
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Mostrar mensaje según el resultado
                        if (rowsAffected > 0)
                        {
                            labeel.Text = "Producto eliminado con éxito.";
                        }
                        else
                        {
                            labeel.Text = "No se encontró un producto con el ID y nombre especificados.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                labeel.Text = $"Error al conectarse a la base de datos: {ex.Message}";
            }
            catch (Exception ex)
            {
                labeel.Text = $"Ocurrió un error: {ex.Message}";
            }
        }
    }
}
