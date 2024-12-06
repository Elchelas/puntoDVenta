using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoDVenta.INVENTARIO
{
    internal class cambiarPrecio
    {

        private string connectionString = "Server=localhost;Database=puntoDVenta;Uid=root;Pwd=root;";

        public void ModificarPrecio(int idProducto, double nuevoPrecio, Label labeel)
        {
            try
            {
                // Validar que el nuevo precio sea mayor o igual a cero
                if (nuevoPrecio < 0)
                {
                    labeel.Text = "El precio no puede ser un valor negativo.";
                    return;
                }

                // Crear la conexión y el comando SQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE PRODUCTOS SET precio = @nuevoPrecio WHERE IDproducto = @IDproducto";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar parámetros para prevenir inyección SQL
                        cmd.Parameters.AddWithValue("@IDproducto", idProducto);
                        cmd.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);

                        // Ejecutar la consulta
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Mostrar mensaje según el resultado
                        if (rowsAffected > 0)
                        {
                            labeel.Text = "El precio se ha actualizado correctamente.";
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
                labeel.Text = $"Error al conectarse a la base de datos: {ex.Message}";
            }
            catch (Exception ex)
            {
                labeel.Text = $"Ocurrió un error: {ex.Message}";
            }
        }
    }
}
