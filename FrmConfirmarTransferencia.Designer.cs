namespace CajeroAutomatico
{
    partial class FrmConfirmarTransferencia
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
            pnlResumen = new Panel();
            lblMontoRes = new Label();
            lblTitular = new Label();
            lblDestino = new Label();
            lblOrigen = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lblComprobante = new Label();
            pnlResumen.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(180, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(322, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONFIRME LA OPERACIÓN";
            // 
            // pnlResumen
            // 
            pnlResumen.Controls.Add(lblMontoRes);
            pnlResumen.Controls.Add(lblTitular);
            pnlResumen.Controls.Add(lblDestino);
            pnlResumen.Controls.Add(lblOrigen);
            pnlResumen.Location = new Point(133, 92);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new Size(431, 221);
            pnlResumen.TabIndex = 1;
            // 
            // lblMontoRes
            // 
            lblMontoRes.AutoSize = true;
            lblMontoRes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMontoRes.Location = new Point(12, 141);
            lblMontoRes.Name = "lblMontoRes";
            lblMontoRes.Size = new Size(206, 32);
            lblMontoRes.TabIndex = 3;
            lblMontoRes.Text = "Monto: $ 8.000,00";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitular.Location = new Point(13, 105);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(134, 21);
            lblTitular.TabIndex = 2;
            lblTitular.Text = "Titular: Juan Pérez";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(12, 65);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(171, 21);
            lblDestino.TabIndex = 1;
            lblDestino.Text = "Destino: mi.alias.cuenta";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigen.Location = new Point(12, 13);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(226, 21);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "Cuenta origen: 0001-234567/8";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(192, 255, 192);
            btnConfirmar.Location = new Point(133, 371);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(89, 45);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
           
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(475, 371);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Location = new Point(194, 426);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(325, 15);
            lblComprobante.TabIndex = 4;
            lblComprobante.Text = "Nº de comprobante: TR-000123(aparece luego de confirmar)";
            // 
            // FrmConfirmarTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblComprobante);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(pnlResumen);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConfirmarTransferencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfirmarTransferencia";
            pnlResumen.ResumeLayout(false);
            pnlResumen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlResumen;
        private Label lblDestino;
        private Label lblOrigen;
        private Label lblMontoRes;
        private Label lblTitular;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label lblComprobante;
    }
}