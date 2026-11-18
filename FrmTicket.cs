using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmTicket : Form
    {
        public FrmTicket()
        {
            InitializeComponent();
            CargarDetalleTicket();
        }

        private void CargarDetalleTicket()
        {
            try
            {
                // Generar el formato visual del ticket como se ve en la especificación
                string ticketTexto =
                    "BANCO ISFT 93\r\n" +
                    "Cajero Nº 001 · San Vicente\r\n" +
                    DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\r\n" +
                    "-----------------------------\r\n" +
                    "Operación: Finalización / Retiro\r\n" +
                    "Nº Operación: " + new Random().Next(10000, 99999) + "\r\n" +
                    "Estado: Exitoso\r\n" +
                    "-----------------------------\r\n" +
                    "Gracias por operar";

                // Si usas un TextBox multilínea o un Label
                if (txtTicket != null)
                {
                    txtTicket.Text = ticketTexto;
                    txtTicket.ReadOnly = true;
                }

                if (lblEstado != null)
                {
                    lblEstado.Text = "Impresora operativa";
                }

                if (lblFin != null)
                {
                    lblFin.Text = "Retire su tarjeta. ¡Hasta pronto!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        // Método común para cerrar sesión y volver al inicio
        private void FinalizarYExpulsar()
        {
            try
            {
                // Limpiar la sesión actual
                Sesion.NroTarjetaActual = string.Empty;

                MessageBox.Show("Por favor, retire su tarjeta del lector. Gracias.", "Fin de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Volver a la pantalla inicial de inserción de tarjeta (Form1)
                Form1 frmInicio = new Form1();
                frmInicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al finalizar la sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo ticket...", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FinalizarYExpulsar();
        }

        private void btnSinTicket_Click_1(object sender, EventArgs e)
        {
            FinalizarYExpulsar();
        }
    }
}