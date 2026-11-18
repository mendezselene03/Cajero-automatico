namespace CajeroAutomatico
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new System.Windows.Forms.Label();
            lblInstruccion = new System.Windows.Forms.Label();
            txtTarjeta = new System.Windows.Forms.TextBox();
            btnInsertar = new System.Windows.Forms.Button();
            lblMensaje = new System.Windows.Forms.Label();
            btnSalir = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(230, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(284, 52);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIENVENIDO";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblInstruccion.ForeColor = System.Drawing.Color.White;
            lblInstruccion.Location = new System.Drawing.Point(180, 115);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new System.Drawing.Size(350, 21);
            lblInstruccion.TabIndex = 1;
            lblInstruccion.Text = "Inserte su tarjeta (ingrese el número de 16 dígitos)";
            // 
            // txtTarjeta
            // 
            txtTarjeta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTarjeta.Location = new System.Drawing.Point(180, 160);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new System.Drawing.Size(350, 32);
            txtTarjeta.TabIndex = 2;
            txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = System.Drawing.Color.Gold;
            btnInsertar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnInsertar.Location = new System.Drawing.Point(215, 220);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new System.Drawing.Size(280, 50);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "INSERTAR TARJETA";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = System.Drawing.Color.Orange;
            lblMensaje.Location = new System.Drawing.Point(180, 290);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new System.Drawing.Size(68, 20);
            lblMensaje.TabIndex = 4;
            lblMensaje.Text = "Mensaje";
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSalir.Location = new System.Drawing.Point(600, 400);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(80, 35);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 51, 102);
            ClientSize = new System.Drawing.Size(720, 460);
            Controls.Add(btnSalir);
            Controls.Add(lblMensaje);
            Controls.Add(btnInsertar);
            Controls.Add(txtTarjeta);
            Controls.Add(lblInstruccion);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmInsertarTarjeta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnSalir;
    }
}