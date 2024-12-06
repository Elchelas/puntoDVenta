using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace puntoDVenta.LOGGEOS
{
    internal class metodosValidacion
    {

        public void GuardarEmpleadoEnBaseDeDatos(string nombre, string clave, string claveEmp, string rango)
        {

            string connectionString = "Server=localhost;Database=puntoDVenta;Uid=root;Pwd=root;";

            try
            {
                // Establecer conexión con la base de datos
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Consulta SQL para insertar un nuevo empleado en la base de datos
                    string query = "INSERT INTO EMPLEADOS (NOMBRE, IDempleado, CLAVE_EMP, RANGO) VALUES (@NOMBRE, @IDempleado, @CLAVE_EMP, @RANGO)";

                    // Crear un comando SQL
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Asignar valores a los parámetros
                        cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                        cmd.Parameters.AddWithValue("@IDempleado", clave);
                        cmd.Parameters.AddWithValue("@CLAVE_EMP", claveEmp);
                        cmd.Parameters.AddWithValue("@RANGO", rango);

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

        public string HashClave(string clave)
        {
            // Usar BCrypt para encriptar la contraseña
            return BCrypt.Net.BCrypt.HashPassword(clave);
        }

        public bool ValidarEmpleado(string nombre, string claveEmp)
        {
            string connectionString = "Server=localhost;Database=puntoDVenta;Uid=root;Pwd=root;";
            string sql = "SELECT CLAVE_EMP FROM EMPLEADOS WHERE nombre = @NOMBRE";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // Asignar el valor del nombre de usuario al parámetro SQL
                        cmd.Parameters.AddWithValue("@NOMBRE", nombre);

                        // Ejecutar la consulta SQL
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Obtener la contraseña encriptada almacenada en la base de datos
                            string calveHa = reader["CLAVE_EMP"].ToString();


                            {
                                return true;  // Credenciales válidas
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
            }

            return false;  // Credenciales no válidas o no encontradas
        }



    }

}
