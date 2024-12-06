using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoDVenta.INVENTARIO
{
    public partial class añadirProducto
    {
        public void añadirProductos(string nombre, string descripcion, int stock, double precio, string idCategoria)
        {

            string connectionString = "Server=localhost;Database=puntoDVenta;Uid=root;Pwd=root;";

            try
            {
                // Establecer conexión con la base de datos
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();


                    // Consulta SQL para insertar un nuevo empleado en la base de datos
                    string query = "INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES (@nombre, @descripcion, @stock, @precio,@idCategoria)";

                    // Crear un comando SQL
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Asignar valores a los parámetros

                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);

                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Mostrar mensaje de error si hay un problema con la base de datos
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
            }
        }

    }
}
