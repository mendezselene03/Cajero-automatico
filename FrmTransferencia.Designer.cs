namespace CajeroAutomatico
{
    partial class FrmTransferencia
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
            lblAlias = new Label();
            txtAliasDestino = new TextBox();
            lblMonto = new Label();
            txtMonto = new TextBox();
            lblMensaje = new Label();
            btnCancelar = new Button();
            btnContinuar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(216, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(206, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "TRANSFERENCIA";
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlias.Location = new Point(216, 103);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(146, 21);
            lblAlias.TabIndex = 1;
            lblAlias.Text = "Alias / CVU destino:";
            // 
            // txtAliasDestino
            // 
            txtAliasDestino.Location = new Point(216, 149);
            txtAliasDestino.Name = "txtAliasDestino";
            txtAliasDestino.Size = new Size(238, 23);
            txtAliasDestino.TabIndex = 2;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(216, 212);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(139, 21);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto a transferir:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(216, 260);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(200, 23);
            txtMonto.TabIndex = 4;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(216, 319);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(287, 15);
            lblMensaje.TabIndex = 5;
            lblMensaje.Text = "Alias inexistente / monto inválido / saldo insuficiente";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(216, 398);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.FromArgb(192, 255, 192);
            btnContinuar.Location = new Point(339, 398);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(96, 40);
            btnContinuar.TabIndex = 7;
            btnContinuar.Text = "CONTINUAR";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(459, 398);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 40);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmConfirmarTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnContinuar);
            Controls.Add(btnCancelar);
            Controls.Add(lblMensaje);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(txtAliasDestino);
            Controls.Add(lblAlias);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConfirmarTransferencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfirmarTransferencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAlias;
        private TextBox txtAliasDestino;
        private Label lblMonto;
        private TextBox txtMonto;
        private Label lblMensaje;
        private Button btnCancelar;
        private Button btnContinuar;
        private Button btnVolver;
    }
}