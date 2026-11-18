namespace CajeroAutomatico
{
    partial class FrmExtraccion
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
            label1 = new Label();
            lblInstr = new Label();
            btnMonto1 = new Button();
            btnMonto2 = new Button();
            btnMonto3 = new Button();
            btnMonto4 = new Button();
            lblLimite = new Label();
            lblOtro = new Label();
            txtMonto = new TextBox();
            lblMensaje = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 20);
            label1.Name = "label1";
            label1.Size = new Size(271, 34);
            label1.TabIndex = 0;
            label1.Text = "EXTRAER DINERO";
            // 
            // lblInstr
            // 
            lblInstr.AutoSize = true;
            lblInstr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstr.Location = new Point(214, 70);
            lblInstr.Name = "lblInstr";
            lblInstr.Size = new Size(270, 21);
            lblInstr.TabIndex = 1;
            lblInstr.Text = "Elija un monto o ingrese otro importe";
            // 
            // btnMonto1
            // 
            btnMonto1.BackColor = Color.FromArgb(128, 255, 128);
            btnMonto1.Location = new Point(212, 119);
            btnMonto1.Name = "btnMonto1";
            btnMonto1.Size = new Size(94, 42);
            btnMonto1.TabIndex = 2;
            btnMonto1.Text = "2.000";
            btnMonto1.UseVisualStyleBackColor = false;
            btnMonto1.Click += btnMonto1_Click;
            // 
            // btnMonto2
            // 
            btnMonto2.BackColor = Color.FromArgb(128, 255, 128);
            btnMonto2.Location = new Point(390, 119);
            btnMonto2.Name = "btnMonto2";
            btnMonto2.Size = new Size(94, 42);
            btnMonto2.TabIndex = 3;
            btnMonto2.Text = "5.000";
            btnMonto2.UseVisualStyleBackColor = false;
            btnMonto2.Click += btnMonto2_Click;
            // 
            // btnMonto3
            // 
            btnMonto3.BackColor = Color.FromArgb(128, 255, 128);
            btnMonto3.Location = new Point(214, 206);
            btnMonto3.Name = "btnMonto3";
            btnMonto3.Size = new Size(94, 42);
            btnMonto3.TabIndex = 4;
            btnMonto3.Text = "10.000";
            btnMonto3.UseVisualStyleBackColor = false;
            btnMonto3.Click += btnMonto3_Click;
            // 
            // btnMonto4
            // 
            btnMonto4.BackColor = Color.FromArgb(128, 255, 128);
            btnMonto4.Location = new Point(390, 206);
            btnMonto4.Name = "btnMonto4";
            btnMonto4.Size = new Size(94, 42);
            btnMonto4.TabIndex = 5;
            btnMonto4.Text = "20.000";
            btnMonto4.UseVisualStyleBackColor = false;
            btnMonto4.Click += btnMonto4_Click;
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Location = new Point(216, 324);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(169, 15);
            lblLimite.TabIndex = 6;
            lblLimite.Text = "Limite diario restante: $100.000";
            // 
            // lblOtro
            // 
            lblOtro.AutoSize = true;
            lblOtro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOtro.Location = new Point(216, 284);
            lblOtro.Name = "lblOtro";
            lblOtro.Size = new Size(92, 21);
            lblOtro.TabIndex = 7;
            lblOtro.Text = "Otro Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(342, 282);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(143, 23);
            txtMonto.TabIndex = 8;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(216, 354);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(305, 15);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "Monto superior al limite/ sin efectivo/ saldo insuficiente.";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(165, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 38);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(128, 255, 128);
            btnConfirmar.Location = new Point(313, 400);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(111, 38);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(454, 400);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 38);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // FrmExtraccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblMensaje);
            Controls.Add(txtMonto);
            Controls.Add(lblOtro);
            Controls.Add(lblLimite);
            Controls.Add(btnMonto4);
            Controls.Add(btnMonto3);
            Controls.Add(btnMonto2);
            Controls.Add(btnMonto1);
            Controls.Add(lblInstr);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmExtraccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmExtraccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblInstr;
        private Button btnMonto1;
        private Button btnMonto2;
        private Button btnMonto3;
        private Button btnMonto4;
        private Label lblLimite;
        private Label lblOtro;
        private TextBox txtMonto;
        private Label lblMensaje;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Button btnVolver;
    }
}