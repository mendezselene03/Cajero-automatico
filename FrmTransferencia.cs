using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmTransferencia : Form
    {
        public FrmTransferencia()
        {
            InitializeComponent();
            lblMensaje.Text = "";
        }

        // Botón Continuar
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                string aliasDestino = txtAliasDestino.Text.Trim();
                string montoTexto = txtMonto.Text.Replace("$", "").Trim();

                // 1. Validar que el alias/CVU no esté vacío
                if (string.IsNullOrEmpty(aliasDestino))
                {
                    lblMensaje.Text = "Por favor, ingrese un alias o CVU de destino.";
                    return;
                }

                // 2. Validar que el monto sea un número válido y mayor a 0
                if (!decimal.TryParse(montoTexto, out decimal monto) || monto <= 0)
                {
                    lblMensaje.Text = "Por favor, ingrese un monto válido.";
                    return;
                }

                // 3. Validar contra la base de datos que el alias/CVU exista y que haya saldo suficiente
                if (!ValidarDisponibilidadTransferencia(aliasDestino, monto))
                {
                    return; // Los mensajes de error específicos ya se muestran en el método
                }

                // 4. Guardar temporalmente y abrir la pantalla de confirmación
                TransferenciaTemp.AliasDestino = aliasDestino;
                TransferenciaTemp.Monto = monto;

                FrmConfirmarTransferencia frmConfirmar = new FrmConfirmarTransferencia();
                frmConfirmar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la transferencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método auxiliar de validación previa
        private bool ValidarDisponibilidadTransferencia(string aliasDestino, decimal monto)
        {
            try
            {
                // Usamos la cadena de conexión de SucursalDB o consultamos directamente
                // Verificamos saldo origen y existencia de destino
                decimal saldoOrigen = 0;
                bool existeDestino = false;

                // Consulta rápida a la base de datos
                // (Nota: SucursalDB ya tiene métodos robustos, pero aquí validamos ambos lados)
                string cadenaConexion = "Data Source=DESKTOP-DEU1ARC\\Selene;Initial Catalog=CajeroAutomaticoBD;Integrated Security=True;Connect Timeout=5;";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Obtener saldo origen
                    string queryOrigen = @"SELECT C.Saldo FROM Tarjetas T INNER JOIN Cuentas C ON T.IdCuenta = C.IdCuenta WHERE T.NroTarjeta = @NroTarjeta";
                    using (SqlCommand cmd = new SqlCommand(queryOrigen, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NroTarjeta", Sesion.NroTarjetaActual);
                        object res = cmd.ExecuteScalar();
                        if (res != null) saldoOrigen = Convert.ToDecimal(res);
                    }

                    // Verificar saldo
                    if (saldoOrigen < monto)
                    {
                        lblMensaje.Text = "Saldo insuficiente para la transferencia.";
                        return false;
                    }

                    // Verificar existencia de destino
                    string queryDestino = "SELECT COUNT(1) FROM Cuentas WHERE Alias = @Alias OR NumeroCuenta = @Alias";
                    using (SqlCommand cmd = new SqlCommand(queryDestino, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Alias", aliasDestino);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        existeDestino = (count > 0);
                    }

                    if (!existeDestino)
                    {
                        lblMensaje.Text = "Alias inexistente o cuenta de destino inválida.";
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de validación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Botón Volver al Menú
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        // Botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmTicket frmTicket = new FrmTicket();
            frmTicket.Show();
            this.Hide();
        }
    }
}