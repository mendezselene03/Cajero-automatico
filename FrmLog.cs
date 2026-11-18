using System;
using System.Data;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
            ConfigurarGrilla();
            CargarFiltrosYDatos();
        }

        private void ConfigurarGrilla()
        {

            dgvLog.ReadOnly = true;
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AllowUserToDeleteRows = false;
            dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgvLog.AutoGenerateColumns = true;


            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarFiltrosYDatos()
        {
            if (cboTipo.Items.Count == 0)
            {
                cboTipo.Items.Add("Todos");
                cboTipo.Items.Add("Consulta");
                cboTipo.Items.Add("Extracción");
                cboTipo.Items.Add("Transferencia");
            }
            cboTipo.SelectedItem = "Todos";

            ActualizarGrilla("Todos");
        }

        private void ActualizarGrilla(string filtro)
        {
            DataTable datosLog = SucursalDB.ObtenerHistorialLog(filtro);


            dgvLog.DataSource = null;
            dgvLog.DataSource = datosLog;


            if (dgvLog.Columns["idRegistro"] != null) dgvLog.Columns["idRegistro"].HeaderText = "ID";
            if (dgvLog.Columns["fechaHora"] != null) dgvLog.Columns["fechaHora"].HeaderText = "Fecha y Hora";
            if (dgvLog.Columns["tipoOperacion"] != null) dgvLog.Columns["tipoOperacion"].HeaderText = "Operación";
            if (dgvLog.Columns["nroTransaccion"] != null) dgvLog.Columns["nroTransaccion"].HeaderText = "Nº Transacción";
            if (dgvLog.Columns["resultado"] != null) dgvLog.Columns["resultado"].HeaderText = "Resultado";
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            string seleccionado = cboTipo.SelectedItem?.ToString() ?? "Todos";
            ActualizarGrilla(seleccionado);
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
    }
}