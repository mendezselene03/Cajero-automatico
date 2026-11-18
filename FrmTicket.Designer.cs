namespace CajeroAutomatico
{
    partial class FrmTicket
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
            txtTicket = new RichTextBox();
            btnImprimir = new Button();
            btnSinTicket = new Button();
            lblEstado = new Label();
            lblFin = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(182, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(376, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "¿DESEA IMPRIMIR EL TICKET?";
            // 
            // txtTicket
            // 
            txtTicket.Location = new Point(200, 58);
            txtTicket.Name = "txtTicket";
            txtTicket.ReadOnly = true;
            txtTicket.Size = new Size(348, 236);
            txtTicket.TabIndex = 1;
            txtTicket.Text = "";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(128, 255, 128);
            btnImprimir.Location = new Point(200, 342);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(142, 41);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "IMPRIMIR TICKET";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click_1;
            // 
            // btnSinTicket
            // 
            btnSinTicket.Location = new Point(406, 342);
            btnSinTicket.Name = "btnSinTicket";
            btnSinTicket.Size = new Size(142, 41);
            btnSinTicket.TabIndex = 3;
            btnSinTicket.Text = "SIN TICKET";
            btnSinTicket.UseVisualStyleBackColor = true;
            btnSinTicket.Click += btnSinTicket_Click_1;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Red;
            lblEstado.Location = new Point(200, 402);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(279, 15);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Impresora fuera de servicio -> se continúa sin ticket";
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(238, 426);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(169, 15);
            lblFin.TabIndex = 5;
            lblFin.Text = "Retire su tarjeta. ¡Hasta pronto!";
            lblFin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(lblFin);
            Controls.Add(lblEstado);
            Controls.Add(btnSinTicket);
            Controls.Add(btnImprimir);
            Controls.Add(txtTicket);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTicket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private RichTextBox txtTicket;
        private Button btnImprimir;
        private Button btnSinTicket;
        private Label lblEstado;
        private Label lblFin;
    }
}