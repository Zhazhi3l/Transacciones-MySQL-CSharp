using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Transacciones_MySQL_CSharp.modelos;

namespace Transacciones_MySQL_CSharp.accesoDatos
{
    public class ConexionBD
    {
        private readonly string connectionString =
            "Server=localhost;Database=transacciones_C_Sharp;Uid=root;Pwd=root;";

        private MySqlConnection GetConnection()
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la BD: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Producto BuscarProductoPorClave(string claveENA)
        {
            Producto producto = null;
            string query =
                """
                select * from productos
                    where claveENA_13 = @claveENA;
                """;

            using (MySqlConnection conx = GetConnection())
            {
                if (conx == null) return null;

                MySqlCommand comando = new MySqlCommand(query, conx);
                comando.Parameters.AddWithValue("@claveENA", claveENA);

                try
                {
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            producto = new Producto
                            {
                                Id = lector.GetInt32("id"),
                                ClaveENA_13 = lector.GetString("claveENA_13"),
                                Nombre = lector.GetString("nombre"),
                                Existencia = lector.GetInt32("existencia"),
                                Precio = lector.GetDecimal("precio"),
                                Descontinuado = lector.GetBoolean("descontinuado"),

                                Descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? null : lector.GetString("descripcion"),
                                ContenidoNetogr = lector.IsDBNull(lector.GetOrdinal("contenidoNetogr")) ? (int?)null : lector.GetInt32("contenidoNetogr")
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar producto: {ex.Message}", "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return producto;
        }

        public List<Producto> ObtenerTodosLosProductos()
        {
            List<Producto> productos = new List<Producto>();
            string query = "SELECT * FROM productos";

            using (MySqlConnection conn = GetConnection())
            {
                if (conn == null) return productos;

                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                Id = reader.GetInt32("id"),
                                ClaveENA_13 = reader.GetString("claveENA_13"),
                                Nombre = reader.GetString("nombre"),
                                Existencia = reader.GetInt32("existencia"),
                                Precio = reader.GetDecimal("precio"),
                                Descontinuado = reader.GetBoolean("descontinuado"),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? null : reader.GetString("descripcion"),
                                ContenidoNetogr = reader.IsDBNull(reader.GetOrdinal("contenidoNetogr")) ? (int?)null : reader.GetInt32("contenidoNetogr")
                            };

                            productos.Add(producto);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener productos: {ex.Message}", "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return productos;
        }

        public bool DescontinuarProductos(List<Producto> listaProductos)
        {
            string query = "UPDATE productos SET descontinuado = true WHERE claveENA_13 = @clave;";

            using(MySqlConnection conx = GetConnection())
            {
                if (conx == null) return false;

                MySqlTransaction transaction = conx.BeginTransaction();
                try
                {
                    foreach (Producto producto in listaProductos)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, conx, transaction))
                        {
                            cmd.Parameters.AddWithValue("@clave", producto.ClaveENA_13);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error en la transacción: {ex.Message}\nSe revirtieron los cambios.", "Error de Transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
        }


        /*
        public bool DescontinuarUnProducto(string claveEna)
        {
            int filasModificadas = 0;
            string query = "UPDATE productos SET descontinuado = true WHERE claveENA_13 = @clave";

            using (MySqlConnection conx = GetConnection())
            {
                if (conx == null) return false;

                MySqlTransaction transaction =  conx.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand(query, conx, transaction);
                cmd.Parameters.AddWithValue("@clave", claveEna);

                try
                {
                    filasModificadas = cmd.ExecuteNonQuery();

                    if (filasModificadas > 0)
                    {
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error en la transacción: {ex.Message}\nSe revirtieron los cambios.", "Error de Transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        */
    }
}
