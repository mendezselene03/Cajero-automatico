using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public static class SucursalDB
    {
        // Conexión corregida para que funcione directo en tu instancia local
        private static string cadenaConexion = "Data Source=DESKTOP-DEU1ARC;Initial Catalog=CajeroAutomaticoBD;Integrated Security=True;Connect Timeout=5;";
        // 1. Método para validar las credenciales del PIN y la tarjeta
        public static bool ValidarCredenciales(string nroTarjeta, string pinIngresado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT COUNT(1) FROM Tarjetas WHERE NroTarjeta = @NroTarjeta AND PinHash = @Pin AND Bloqueada = 0";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@NroTarjeta", nroTarjeta ?? "");
                        comando.Parameters.AddWithValue("@Pin", pinIngresado ?? "");

                        int resultado = Convert.ToInt32(comando.ExecuteScalar());
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 2. Método para bloquear la tarjeta al agotar los intentos
        public static void BloquearTarjeta(string nroTarjeta)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "UPDATE Tarjetas SET Bloqueada = 1 WHERE NroTarjeta = @NroTarjeta";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NroTarjeta", nroTarjeta ?? "");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al bloquear la tarjeta: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Método para registrar operaciones en el Log de Auditoría
        public static bool RegistrarTransaccion(string tipoOperacion, string nroTransaccion, string resultado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO LogTransacciones (FechaHora, TipoOperacion, NroTransaccion, Resultado) VALUES (@Fecha, @Tipo, @Nro, @Res)";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Tipo", tipoOperacion);
                        cmd.Parameters.AddWithValue("@Nro", nroTransaccion);
                        cmd.Parameters.AddWithValue("@Res", resultado);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el log: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 4. Método para obtener el historial del Log (Auditoría) con filtro opcional
        public static DataTable ObtenerHistorialLog(string filtroTipo = "Todos")
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT idRegistro, fechaHora, tipoOperacion, nroTransaccion, resultado FROM LogTransacciones";

                    if (!string.IsNullOrEmpty(filtroTipo) && filtroTipo != "Todos")
                    {
                        query += " WHERE tipoOperacion = @Tipo";
                    }
                    query += " ORDER BY fechaHora DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        if (!string.IsNullOrEmpty(filtroTipo) && filtroTipo != "Todos")
                        {
                            cmd.Parameters.AddWithValue("@Tipo", filtroTipo);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el log de transacciones: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // 5. Método para obtener los datos de la cuenta y saldo de la tarjeta actual
        public static bool ObtenerSaldoCuenta(string nroTarjeta, out string numeroCuenta, out decimal saldo)
        {
            numeroCuenta = string.Empty;
            saldo = 0;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = @"SELECT C.NumeroCuenta, C.Saldo 
                                   FROM Tarjetas T 
                                   INNER JOIN Cuentas C ON T.IdCuenta = C.IdCuenta 
                                   WHERE T.NroTarjeta = @NroTarjeta";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NroTarjeta", nroTarjeta ?? "");
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                numeroCuenta = reader.GetString(0);
                                saldo = reader.GetDecimal(1);
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el saldo: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        // 6. Método para obtener saldo y límite diario para extracciones
        public static bool ObtenerDatosExtraccion(string nroTarjeta, out decimal saldo, out decimal limiteDiario)
        {
            saldo = 0;
            limiteDiario = 0;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = @"SELECT C.Saldo, C.LimiteDiario 
                                   FROM Tarjetas T 
                                   INNER JOIN Cuentas C ON T.IdCuenta = C.IdCuenta 
                                   WHERE T.NroTarjeta = @NroTarjeta";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NroTarjeta", nroTarjeta ?? "");
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                saldo = reader.GetDecimal(0);
                                limiteDiario = reader.GetDecimal(1);
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos para extracción: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        // 7. Método para procesar la extracción de dinero de forma segura (con transacciones SQL)
        public static bool RealizarExtraccion(string nroTarjeta, decimal monto)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string queryCuenta = @"SELECT C.IdCuenta, C.Saldo 
                                               FROM Tarjetas T 
                                               INNER JOIN Cuentas C ON T.IdCuenta = C.IdCuenta 
                                               WHERE T.NroTarjeta = @NroTarjeta";

                        int idCuenta = 0;
                        decimal saldoActual = 0;

                        using (SqlCommand cmd = new SqlCommand(queryCuenta, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@NroTarjeta", nroTarjeta);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    idCuenta = reader.GetInt32(0);
                                    saldoActual = reader.GetDecimal(1);
                                }
                            }
                        }

                        if (saldoActual < monto)
                        {
                            transaccion.Rollback();
                            MessageBox.Show("Saldo insuficiente en la cuenta.", "Fondos Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        string updateSaldo = "UPDATE Cuentas SET Saldo = Saldo - @Monto WHERE IdCuenta = @IdCuenta";
                        using (SqlCommand cmdUpd = new SqlCommand(updateSaldo, conexion, transaccion))
                        {
                            cmdUpd.Parameters.AddWithValue("@Monto", monto);
                            cmdUpd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                            cmdUpd.ExecuteNonQuery();
                        }

                        string insertLog = @"INSERT INTO LogTransacciones (FechaHora, TipoOperacion, NroTransaccion, Resultado) 
                                             VALUES (@FechaHora, 'Extracción', @NroTransaccion, 'OK')";
                        using (SqlCommand cmdLog = new SqlCommand(insertLog, conexion, transaccion))
                        {
                            cmdLog.Parameters.AddWithValue("@FechaHora", DateTime.Now);
                            cmdLog.Parameters.AddWithValue("@NroTransaccion", "EXT-" + new Random().Next(100000, 999999));
                            cmdLog.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Error en la transacción de extracción: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        // 8. Método para realizar transferencias de forma segura (con transacciones SQL)
        public static bool RealizarTransferencia(string nroTarjetaOrigen, string aliasDestino, decimal monto)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string queryOrigen = @"SELECT C.IdCuenta, C.Saldo 
                                               FROM Tarjetas T 
                                               INNER JOIN Cuentas C ON T.IdCuenta = C.IdCuenta 
                                               WHERE T.NroTarjeta = @NroTarjeta";

                        int idCuentaOrigen = 0;
                        decimal saldoOrigen = 0;

                        using (SqlCommand cmdOrigen = new SqlCommand(queryOrigen, conexion, transaccion))
                        {
                            cmdOrigen.Parameters.AddWithValue("@NroTarjeta", nroTarjetaOrigen);
                            using (var reader = cmdOrigen.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    idCuentaOrigen = reader.GetInt32(0);
                                    saldoOrigen = reader.GetDecimal(1);
                                }
                            }
                        }

                        if (saldoOrigen < monto)
                        {
                            transaccion.Rollback();
                            MessageBox.Show("Saldo insuficiente en la cuenta de origen.", "Fondos Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        string queryDestino = "SELECT IdCuenta FROM Cuentas WHERE Alias = @Alias OR NumeroCuenta = @Alias";
                        int idCuentaDestino = 0;

                        using (SqlCommand cmdDestino = new SqlCommand(queryDestino, conexion, transaccion))
                        {
                            cmdDestino.Parameters.AddWithValue("@Alias", aliasDestino);
                            object resultadoDestino = cmdDestino.ExecuteScalar();

                            if (resultadoDestino != null)
                            {
                                idCuentaDestino = Convert.ToInt32(resultadoDestino);
                            }
                            else
                            {
                                transaccion.Rollback();
                                MessageBox.Show("El alias o cuenta de destino no existe.", "Destino Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }

                        string updateOrigen = "UPDATE Cuentas SET Saldo = Saldo - @Monto WHERE IdCuenta = @IdCuenta";
                        using (SqlCommand cmdUpd1 = new SqlCommand(updateOrigen, conexion, transaccion))
                        {
                            cmdUpd1.Parameters.AddWithValue("@Monto", monto);
                            cmdUpd1.Parameters.AddWithValue("@IdCuenta", idCuentaOrigen);
                            cmdUpd1.ExecuteNonQuery();
                        }

                        string updateDestino = "UPDATE Cuentas SET Saldo = Saldo + @Monto WHERE IdCuenta = @IdCuenta";
                        using (SqlCommand cmdUpd2 = new SqlCommand(updateDestino, conexion, transaccion))
                        {
                            cmdUpd2.Parameters.AddWithValue("@Monto", monto);
                            cmdUpd2.Parameters.AddWithValue("@IdCuenta", idCuentaDestino);
                            cmdUpd2.ExecuteNonQuery();
                        }

                        string insertLog = @"INSERT INTO LogTransacciones (FechaHora, TipoOperacion, NroTransaccion, Resultado) 
                                             VALUES (@FechaHora, 'Transferencia', @NroTransaccion, 'OK')";
                        using (SqlCommand cmdLog = new SqlCommand(insertLog, conexion, transaccion))
                        {
                            cmdLog.Parameters.AddWithValue("@FechaHora", DateTime.Now);
                            cmdLog.Parameters.AddWithValue("@NroTransaccion", "TR-" + new Random().Next(100000, 999999));
                            cmdLog.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Error en la transacción de base de datos: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}