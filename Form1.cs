using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nroTarjeta = txtTarjeta.Text.Trim();

           
            if (!Validador.EsTarjetaValida(nroTarjeta))
            {
                MessageBox.Show("Por favor, ingrese el número de tarjeta.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Sesion.NroTarjetaActual = nroTarjeta;
            Sesion.Estado = "EsperandoPIN";

           
            FrmPin frmPin = new FrmPin();
            frmPin.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}