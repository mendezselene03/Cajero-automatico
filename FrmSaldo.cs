using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmSaldo : Form
    {
        public FrmSaldo()
        {
            InitializeComponent();
            CargarDatosSaldo();
        }

        private void CargarDatosSaldo()
        {
            try
            {
                string numeroCuenta;
                decimal saldo;

                // Consultar saldo y cuenta usando la tarjeta activa en Sesion
                bool exito = SucursalDB.ObtenerSaldoCuenta(Sesion.NroTarjetaActual, out numeroCuenta, out saldo);

                if (exito)
                {
                    lblCuenta.Text = $"Cuenta: {numeroCuenta}";
                    lblSaldo.Text = $"$ {saldo.ToString("N2")}"; // Formato con separadores de miles y decimales
                    lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                    // Registrar la consulta en la tabla LogTransacciones
                    string nroTransaccion = "CONS-" + new Random().Next(100000, 999999);
                    SucursalDB.RegistrarTransaccion("Consulta", nroTransaccion, "EXITOSO");
                }
                else
                {
                    lblCuenta.Text = "Cuenta: No encontrada";
                    lblSaldo.Text = "$ 0,00";
                    lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la pantalla de saldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            FrmTicket frmTicket = new FrmTicket();
            frmTicket.Show();
            this.Hide();
        }
    }
}