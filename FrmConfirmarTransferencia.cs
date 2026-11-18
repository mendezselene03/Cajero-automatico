using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmConfirmarTransferencia : Form
    {
        private string cuentaOrigenStr = string.Empty;
        private string titularDestinoStr = "Titular no especificado";

        public FrmConfirmarTransferencia()
        {
            InitializeComponent();
            CargarResumenTransferencia();
        }

        private void CargarResumenTransferencia()
        {
            try
            {
                // 1. Mostrar los datos temporales guardados en el paso anterior
                lblDestino.Text = $"Destino: {TransferenciaTemp.AliasDestino}";
                lblMontoRes.Text = $"Monto: $ {TransferenciaTemp.Monto.ToString("N2")}";
                lblComprobante.Text = "";

                // 2. Consultar detalles de la cuenta de origen y el titular del destino en la BD
                string cadenaConexion = "Data Source=DESKTOP-DEU1ARC\\Selene;Initial Catalog=CajeroAutomaticoBD;Integrated Security=True;Connect Timeout=5;";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Obtener número de cuenta de origen
                    string queryOrigen = @"SELECT C.NumeroCuenta FROM Tarjetas T INNER JOIN Cuentas C ON T.IdCuenta = C.IdCuenta WHERE T.NroTarjeta = @NroTarjeta";
                    using (SqlCommand cmd = new SqlCommand(queryOrigen, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NroTarjeta", Sesion.NroTarjetaActual);
                        object res = cmd.ExecuteScalar();
                        if (res != null)
                        {
                            cuentaOrigenStr = res.ToString();
                            lblOrigen.Text = $"Cuenta origen: {cuentaOrigenStr}";
                        }
                    }

                    // Obtener titular de la cuenta destino si está disponible
                    string queryTitular = @"SELECT C.Titular FROM Cuentas C WHERE C.Alias = @Alias OR C.NumeroCuenta = @Alias";
                    using (SqlCommand cmd = new SqlCommand(queryTitular, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Alias", TransferenciaTemp.AliasDestino);
                        object resTitular = cmd.ExecuteScalar();
                        if (resTitular != null && resTitular != DBNull.Value)
                        {
                            titularDestinoStr = resTitular.ToString();
                        }
                    }
                    lblTitular.Text = $"Titular: {titularDestinoStr}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el resumen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón CONFIRMAR
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar al método centralizado en SucursalDB para ejecutar la transacción en la BD
                bool exito = SucursalDB.RealizarTransferencia(Sesion.NroTarjetaActual, TransferenciaTemp.AliasDestino, TransferenciaTemp.Monto);

                if (exito)
                {
                    string nroComprobante = "TR-" + new Random().Next(100000, 999999);
                    lblComprobante.Text = $"Nº de comprobante: {nroComprobante}";

                    MessageBox.Show($"¡Transferencia realizada con éxito!\nComprobante: {nroComprobante}", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver al menú principal
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo completar la transferencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al confirmar la transferencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón CANCELAR (vuelve al menú)
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
    }
}