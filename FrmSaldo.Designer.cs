using System;
using System.Drawing;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    partial class FrmSaldo
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
            pnlSaldo = new Panel();
            btnFinalizar = new Button();
            btnVolver = new Button();
            lblFecha = new Label();
            lblSaldo = new Label();
            lblCuenta = new Label();
            pnlSaldo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(150, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(326, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SALDO DISPONIBLE";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSaldo
            // 
            pnlSaldo.BackColor = Color.FromArgb(192, 255, 192);
            pnlSaldo.Controls.Add(btnFinalizar);
            pnlSaldo.Controls.Add(btnVolver);
            pnlSaldo.Controls.Add(lblFecha);
            pnlSaldo.Controls.Add(lblSaldo);
            pnlSaldo.Controls.Add(lblCuenta);
            pnlSaldo.Location = new Point(126, 98);
            pnlSaldo.Name = "pnlSaldo";
            pnlSaldo.Size = new Size(419, 298);
            pnlSaldo.TabIndex = 1;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Red;
            btnFinalizar.Location = new Point(298, 254);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(101, 41);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "FINALIZAR";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(192, 255, 255);
            btnVolver.Location = new Point(15, 257);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 38);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "VOLVER AL MENÚ";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(129, 167);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(95, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "06/11/2026 15:40";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(109, 89);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(161, 32);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "$ 125.430,50";
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(109, 25);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(145, 20);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "Cuenta: 0001-234567/8";
            // 
            // FrmSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 461);
            Controls.Add(pnlSaldo);
            Controls.Add(lblTitulo);
            Name = "FrmSaldo";
            Text = "Consulta de Saldo";
            pnlSaldo.ResumeLayout(false);
            pnlSaldo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlSaldo;
        private Label lblCuenta;
        private Button btnFinalizar;
        private Button btnVolver;
        private Label lblFecha;
        private Label lblSaldo;
    }
}