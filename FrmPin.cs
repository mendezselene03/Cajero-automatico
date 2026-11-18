using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmPin : Form
    {
        private int intentosRestantes = 3;

        public FrmPin()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            txtPin.PasswordChar = '●';
            txtPin.MaxLength = 4;
            txtPin.ReadOnly = true;
            lblMensaje.Text = "";
            lblIntentos.Text = $"Intentos restantes: {intentosRestantes}";
            if (lblTiempo != null) lblTiempo.Text = "Tiempo: 60 s";
        }

        private void AgregarDigito(string digito)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += digito;
            }
        }

        // Eventos del teclado numérico (0 al 9)
        private void btnNum1_Click(object sender, EventArgs e) => AgregarDigito("1");
        private void btnNum2_Click(object sender, EventArgs e) => AgregarDigito("2");
        private void btnNum3_Click(object sender, EventArgs e) => AgregarDigito("3");
        private void btnNum4_Click(object sender, EventArgs e) => AgregarDigito("4");
        private void btnNum5_Click(object sender, EventArgs e) => AgregarDigito("5");
        private void btnNum6_Click(object sender, EventArgs e) => AgregarDigito("6");
        private void btnNum7_Click(object sender, EventArgs e) => AgregarDigito("7");
        private void btnNum8_Click(object sender, EventArgs e) => AgregarDigito("8");
        private void btnNum9_Click(object sender, EventArgs e) => AgregarDigito("9");
        private void btnNum0_Click(object sender, EventArgs e) => AgregarDigito("0");

        // Botón Borrar (<x)
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length > 0)
            {
                txtPin.Text = txtPin.Text.Substring(0, txtPin.Text.Length - 1);
            }
        }

        // Botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 frmInicio = new Form1();
            frmInicio.Show();
            this.Hide();
        }

        
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            string pinIngresado = txtPin.Text.Trim();

            if (pinIngresado.Length < 4)
            {
                lblMensaje.Text = "Ingrese los 4 dígitos.";
                return;
            }

            bool pinValido = SucursalDB.ValidarCredenciales(Sesion.NroTarjetaActual, pinIngresado);

            if (pinValido)
            {
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                intentosRestantes--;
                lblIntentos.Text = $"Intentos restantes: {intentosRestantes}";
                lblMensaje.Text = "PIN incorrecto";
                txtPin.Clear();

                if (intentosRestantes <= 0)
                {
                    SucursalDB.BloquearTarjeta(Sesion.NroTarjetaActual);
                    MessageBox.Show("Su tarjeta ha sido bloqueada por seguridad.", "Tarjeta Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Form1 frmInicio = new Form1();
                    frmInicio.Show();
                    this.Hide();
                }
            }
        }
    }
}