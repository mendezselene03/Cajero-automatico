namespace CajeroAutomatico
{
    partial class FrmLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            dgvLog = new DataGridView();
            lblFiltro = new Label();
            cboTipo = new ComboBox();
            btnFiltrar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(207, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE TRANSACCIONES";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvLog
            // 
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AllowUserToDeleteRows = false;
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLog.Location = new Point(90, 56);
            dgvLog.Name = "dgvLog";
            dgvLog.ReadOnly = true;
            dgvLog.Size = new Size(597, 199);
            dgvLog.TabIndex = 1;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltro.Location = new Point(90, 328);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(48, 21);
            lblFiltro.TabIndex = 2;
            lblFiltro.Text = "Tipo:";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(155, 328);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 23);
            cboTipo.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(128, 255, 128);
            btnFiltrar.Location = new Point(373, 323);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(113, 34);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(612, 402);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 36);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // FrmLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnFiltrar);
            Controls.Add(cboTipo);
            Controls.Add(lblFiltro);
            Controls.Add(dgvLog);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLog";
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvLog;
        private Label lblFiltro;
        private ComboBox cboTipo;
        private Button btnFiltrar;
        private Button btnVolver;
    }
}