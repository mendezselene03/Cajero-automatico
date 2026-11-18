using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {
            // Mostrar los datos de la tarjeta enmascarados o el titular actual si aplica
            if (!string.IsNullOrEmpty(Sesion.NroTarjetaActual))
            {
                string nro = Sesion.NroTarjetaActual;
                if (nro.Length >= 12)
                {
                    lblCliente.Text = $"Tarjeta: {nro.Substring(0, 4)}-xxxx-xxxx-{nro.Substring(nro.Length - 4)}";
                }
                else
                {
                    lblCliente.Text = $"Tarjeta: {nro}";
                }
            }
            else
            {
                lblCliente.Text = "Tarjeta: Sin sesión activa";
            }
        }

        // 1. Consultar Saldo
        private void btnConsultaSaldo_Click(object sender, EventArgs e)
        {
            FrmSaldo frmSaldo = new FrmSaldo();
            frmSaldo.Show();
            this.Hide();
        }

        // 2. Extraer Dinero
        private void btnExtraer_Click(object sender, EventArgs e)
        {
            FrmExtraccion frmExtraccion = new FrmExtraccion();
            frmExtraccion.Show();
            this.Hide();
        }

        // 3. Transferencia
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            FrmTransferencia frmTransferencia = new FrmTransferencia();
            frmTransferencia.Show();
            this.Hide();
        }

        // 4. Ver Movimientos (Log)
        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmLog frmLog = new FrmLog();
            frmLog.Show();
            this.Hide();
        }

        // 5. Finalizar (Emitir Ticket y salir)
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FrmTicket frmTicket = new FrmTicket();
            frmTicket.Show();
            this.Hide();
        }
    }
}