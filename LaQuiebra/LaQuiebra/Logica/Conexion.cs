using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaQuiebra.Logica
{
    public class Conexion
    {
            private static string nombreBD = "LaQuiebraBD";

            public static SqlConnection conectar(string nomBD)
            {
                SqlConnection objConectar = new SqlConnection("Data Source=localhost;Initial " +
                "Catalog = " + nomBD + "; Integrated Security = SSPI; ");
                try
                {
                    objConectar.Open();
                    MessageBox.Show("Se realizo la conexion...");
                    return objConectar;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo la conexión " + ex.ToString());
                    return null;
                }
            }

            public static SqlDataReader consulta(string conSQL, SqlConnection objConector)
            {
                try
                {
                    SqlCommand objComando = new SqlCommand(conSQL, objConector);
                    SqlDataReader tabla = objComando.ExecuteReader();
                    return tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo la consulta " + ex.ToString());
                    return null;
                }
            }

            public static int operar(string conSQL, SqlConnection conector)
            {
                int num = 0;
                try
                {
                    SqlCommand objComando = new SqlCommand(conSQL, conector);
                    num = objComando.ExecuteNonQuery();
                    return num;
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Fallo la consulta" + e.ToString());
                    return num;
                }
            }

            public static void cerrar(SqlConnection objConector)
            {
            try
            {
                objConector.Close();
            }
            catch (SqlException eq) {
                MessageBox.Show("Error al cerrar la conexión " + eq.ToString());
            }

        }

            public static DataTable ConsultarClientePorCodigo(int codigo)
            {
                DataTable tabla = new DataTable();
                SqlConnection con = conectar(nombreBD);

                if (con != null)
                {
                    string sql = "SELECT codigo AS Código, nombre AS Nombre, telefono AS Teléfono, " +
                                 "correo AS Correo, direccion AS Dirección " +
                                 "FROM Clientes WHERE codigo = " + codigo;

                    SqlDataReader lector = consulta(sql, con);
                    if (lector != null)
                    {
                        tabla.Load(lector);
                        lector.Close();
                    }
                    cerrar(con);
                }
                return tabla;
            }

            public static DataTable ConsultarClientePorNombre(string nombre)
            {
                DataTable tabla = new DataTable();
                SqlConnection con = conectar(nombreBD);

                if (con != null)
                {
                    string sql = "SELECT codigo AS Código, nombre AS Nombre, telefono AS Teléfono, " +
                                 "correo AS Correo, direccion AS Dirección " +
                                 "FROM Clientes WHERE nombre LIKE '%" + nombre.Trim() + "%'";

                    SqlDataReader lector = consulta(sql, con);
                    if (lector != null)
                    {
                        tabla.Load(lector);
                        lector.Close();
                    }
                    cerrar(con);
                }
                return tabla;
            }

            public static DataTable ConsultarCreditosPorCliente(int codigoCliente)
            {
                DataTable tabla = new DataTable();
                SqlConnection con = conectar(nombreBD);

                if (con != null)
                {
                    string sql = "SELECT id_credito AS [ID Crédito], codigo_cliente AS [Código Cliente], " +
                                 "monto_inicial AS [Monto Inicial], saldo_actual AS [Saldo Actual], " +
                                 "estado AS Estado, fecha_otorgamiento AS Fecha " +
                                 "FROM Creditos WHERE codigo_cliente = " + codigoCliente;

                    SqlDataReader lector = consulta(sql, con);
                    if (lector != null)
                    {
                        tabla.Load(lector);
                        lector.Close();
                    }
                    cerrar(con);
                }
                return tabla;
            }

            public static int IngresarCredito(int codigoCliente, double montoInicial, DateTime fechaOtorgamiento)
            {
                SqlConnection con = conectar(nombreBD);
                if (con == null) return 0;

                string monto = montoInicial.ToString();
                string fecha = fechaOtorgamiento.ToString("yyyy-MM-dd");

                string sql = "INSERT INTO Creditos (codigo_cliente, monto_inicial, saldo_actual, estado, fecha_otorgamiento) " +
                             "VALUES (" + codigoCliente + ", " + monto + ", " + monto + ", 'Activo', '" + fecha + "')";

                int filasAfectadas = operar(sql, con);
                cerrar(con);

                if (filasAfectadas > 0)
                {
                    return filasAfectadas;
                }
                else
                {
                    return -1;
                }
            }

            public static int ModificarCredito(int idCredito, double montoInicial, double saldoActual, string estado)
            {
                SqlConnection con = conectar(nombreBD);
                if (con == null) return 0;

                string monto = montoInicial.ToString();
                string saldo = saldoActual.ToString();

                string sql = "UPDATE Creditos SET " +
                             "monto_inicial = " + monto + ", " +
                             "saldo_actual = " + saldo + ", " +
                             "estado = '" + estado + "' " +
                             "WHERE id_credito = " + idCredito;

                int filasAfectadas = operar(sql, con);
                cerrar(con);

                if (filasAfectadas > 0)
                {
                    return filasAfectadas;
                }
                else
                {
                    return -1;
                }
        }

            public static int RetirarCreditoCumplido(int idCredito)
            {
                SqlConnection con = conectar(nombreBD);
                if (con == null) return 0;

                //Primero se borran los pagos del crédito (si está Cumplido), porque la llave
                //foránea de Pagos no deja borrar un crédito que tenga pagos
                string sqlPagos = "DELETE FROM Pagos WHERE id_credito IN " +
                                  "(SELECT id_credito FROM Creditos WHERE id_credito = " + idCredito + " AND estado = 'Cumplido')";
                operar(sqlPagos, con);

                string sql = "DELETE FROM Creditos WHERE id_credito = " + idCredito + " AND estado = 'Cumplido'";

                int filasAfectadas = operar(sql, con);
                cerrar(con);

                if (filasAfectadas > 0)
                {
                    return filasAfectadas;
                }
                else
                {
                    return -1;
                }
        }

            public static int RegistrarPagoCuota(int idCredito, double valorCuota, string observacion)
            {
                SqlConnection con = conectar(nombreBD);
                if (con == null) return 0;

                string valorStr = valorCuota.ToString();

                string sql = "INSERT INTO Pagos (id_credito, valor_cuota, observacion) " +
                             "VALUES (" + idCredito + ", " + valorStr + ", '" + observacion.Trim() + "')";

                int filasAfectadas = operar(sql, con);
                cerrar(con);

                if (filasAfectadas > 0)
                {
                    return filasAfectadas;
                }
                else
                {
                    return -1;
                }
            }
    }
}

