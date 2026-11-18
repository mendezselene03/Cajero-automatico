using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmExtraccion : Form
    {
        private decimal saldoDisponible = 0;
        private decimal limiteDiarioRestante = 100000;

        public FrmExtraccion()
        {
            InitializeComponent();
            CargarInformacionLimite();
        }

        private void CargarInformacionLimite()
        {
            try
            {
                bool exito = SucursalDB.ObtenerDatosExtraccion(Sesion.NroTarjetaActual, out saldoDisponible, out limiteDiarioRestante);
                if (exito)
                {
                    lblLimite.Text = $"Límite diario restante: $ {limiteDiarioRestante.ToString("N2")}";
                }
                else
                {
                    lblLimite.Text = "Límite diario restante: $ 0,00";
                }
                lblMensaje.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar límites: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método auxiliar para plasmar el monto elegido en el TextBox
        private void AsignarMonto(decimal monto)
        {
            txtMonto.Text = monto.ToString("0");
            lblMensaje.Text = "";
        }

        // Asocia estos eventos a cada botón de monto rápido en el diseñador
        private void btnMonto1_Click(object sender, EventArgs e) => AsignarMonto(2000);
        private void btnMonto2_Click(object sender, EventArgs e) => AsignarMonto(5000);
        private void btnMonto3_Click(object sender, EventArgs e) => AsignarMonto(10000);
        private void btnMonto4_Click(object sender, EventArgs e) => AsignarMonto(20000);

        // Botón Confirmar Extracción
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtMonto.Text.Trim(), out decimal montoSolicitado) || montoSolicitado <= 0)
                {
                    lblMensaje.Text = "Por favor, ingrese o seleccione un monto válido.";
                    return;
                }

                // Validar múltiplo de 1000
                if (montoSolicitado % 1000 != 0)
                {
                    lblMensaje.Text = "El monto debe ser múltiplo de $ 1.000.";
                    return;
                }

                // Validar límite diario
                if (montoSolicitado > limiteDiarioRestante)
                {
                    lblMensaje.Text = "Monto superior al límite diario permitido.";
                    return;
                }

                // Validar saldo disponible
                if (montoSolicitado > saldoDisponible)
                {
                    lblMensaje.Text = "Saldo insuficiente en la cuenta.";
                    return;
                }

                // Ejecutar la extracción en la base de datos
                bool exito = SucursalDB.RealizarExtraccion(Sesion.NroTarjetaActual, montoSolicitado);

                if (exito)
                {
                    MessageBox.Show($"Extracción exitosa por $ {montoSolicitado.ToString("N2")}", "Retiro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmTicket frmTicket = new FrmTicket();
                    frmTicket.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la extracción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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