using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoDVenta.VENTA
{
    internal class metodosVenta
    {
        private string connectionString = "Server=localhost;Database=puntoDVenta;Uid=root;Pwd=root;";

        public bool AgregarProducto( int idProducto, int cantidad, Label lblMensaje)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Validar que el producto existe y tiene stock
                    string queryProducto = "SELECT precio, stock FROM PRODUCTOS WHERE IDproducto = @IDproducto";
                    using (MySqlCommand cmd = new MySqlCommand(queryProducto, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDproducto", idProducto);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                lblMensaje.Text = "El ID del producto no es válido.";
                                lblMensaje.ForeColor = System.Drawing.Color.Red;
                                return false;
                            }

                            decimal precio = reader.GetDecimal("precio");
                            int stock = reader.GetInt16("stock");

                            if (stock < cantidad)
                            {
                                lblMensaje.Text = "Stock insuficiente para este producto.";
                                lblMensaje.ForeColor = System.Drawing.Color.Red;
                                return false;
                            }
                        }
                    }

                    // Insertar el producto en la tabla DETALLES_ORDENES
                    string queryInsertar = "INSERT INTO DETALLES_ORDENES (IDproducto, precioVenta, cantidad) " +
                                           "VALUES (@IDproducto, (SELECT precio FROM PRODUCTOS WHERE IDproducto = @IDproducto), @cantidad)";
                    using (MySqlCommand cmd = new MySqlCommand(queryInsertar, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDproducto", idProducto);
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);

                        cmd.ExecuteNonQuery();
                    }

                    lblMensaje.Text = "Producto agregado con éxito.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    return true;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = $"Error: {ex.Message}";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }

        public void CargarProductosEnGrid(DataGridView gridView)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT IDorden, IDproducto, precioVenta, cantidad, " +
                                   "(precioVenta * cantidad) AS monto, " +
                                   "(precioVenta * cantidad * 0.16) AS iva, " +
                                   "((precioVenta * cantidad) + (precioVenta * cantidad * 0.16)) AS subtotal " +
                                   "FROM DETALLES_ORDENES WHERE IDorden = @IDorden";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        gridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}");
            }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT SUM((precioVenta * cantidad) + (precioVenta * cantidad * 0.16)) AS total ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        total = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular total: {ex.Message}");
            }

            return total;
        }

        public void ConfirmarVenta(Label lblMensaje)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Actualizar el total en la tabla ORDENES
                    string queryTotal = "UPDATE ORDENES SET total = (SELECT SUM((precioVenta * cantidad) + (precioVenta * cantidad * 0.16)) ";

                    using (MySqlCommand cmd = new MySqlCommand(queryTotal, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    lblMensaje.Text = "Venta confirmada.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = $"Error al confirmar venta: {ex.Message}";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }  



    }
}
