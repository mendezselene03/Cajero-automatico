namespace CajeroAutomatico
{
    partial class FrmMenu
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
            lblCliente = new Label();
            btnConsultaSaldo = new Button();
            btnExtraer = new Button();
            btnTransferir = new Button();
            btnLog = new Button();
            btnFinalizar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(128, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(427, 44);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "¿QUÉ DESEA HACER?";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(202, 77);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(208, 21);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Tarjeta: 4509-xxxx-xxxx-1234";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConsultaSaldo
            // 
            btnConsultaSaldo.BackColor = Color.FromArgb(192, 255, 192);
            btnConsultaSaldo.Location = new Point(128, 153);
            btnConsultaSaldo.Name = "btnConsultaSaldo";
            btnConsultaSaldo.Size = new Size(177, 45);
            btnConsultaSaldo.TabIndex = 2;
            btnConsultaSaldo.Text = "CONSULTAR SALDO";
            btnConsultaSaldo.UseVisualStyleBackColor = false;
            btnConsultaSaldo.Click += btnConsultaSaldo_Click;
            // 
            // btnExtraer
            // 
            btnExtraer.BackColor = Color.FromArgb(192, 255, 192);
            btnExtraer.Location = new Point(378, 153);
            btnExtraer.Name = "btnExtraer";
            btnExtraer.Size = new Size(177, 45);
            btnExtraer.TabIndex = 3;
            btnExtraer.Text = "EXTRAER DINERO";
            btnExtraer.UseVisualStyleBackColor = false;
            btnExtraer.Click += btnExtraer_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.FromArgb(192, 255, 192);
            btnTransferir.Location = new Point(378, 256);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(177, 45);
            btnTransferir.TabIndex = 4;
            btnTransferir.Text = "TRANSFERENCIA";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(192, 255, 192);
            btnLog.Location = new Point(128, 256);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(177, 45);
            btnLog.TabIndex = 5;
            btnLog.Text = "VER MOVIMIENTOS (LOG)";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Red;
            btnFinalizar.Location = new Point(252, 372);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(177, 45);
            btnFinalizar.TabIndex = 6;
            btnFinalizar.Text = "FINALIZAR";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizar);
            Controls.Add(btnLog);
            Controls.Add(btnTransferir);
            Controls.Add(btnExtraer);
            Controls.Add(btnConsultaSaldo);
            Controls.Add(lblCliente);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCliente;
        private Button btnConsultaSaldo;
        private Button btnExtraer;
        private Button btnTransferir;
        private Button btnLog;
        private Button btnFinalizar;
    }
}