namespace CajeroAutomatico
{
    partial class FrmPin
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lbtitulo = new Label();
            txtPin = new TextBox();
            lblIntentos = new Label();
            lblMensaje = new Label();
            btnNum0 = new Button();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnBorrar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            Tiempo = new System.Windows.Forms.Timer(components);
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(212, 87);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(291, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingrese los 4 dígitos de su clave";
            // 
            // lbtitulo
            // 
            lbtitulo.AutoSize = true;
            lbtitulo.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtitulo.Location = new Point(154, 9);
            lbtitulo.Name = "lbtitulo";
            lbtitulo.Size = new Size(413, 56);
            lbtitulo.TabIndex = 1;
            lbtitulo.Text = "INGRESE SU PIN";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(261, 134);
            txtPin.MaxLength = 4;
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.ReadOnly = true;
            txtPin.Size = new Size(185, 23);
            txtPin.TabIndex = 2;
            txtPin.TextAlign = HorizontalAlignment.Center;
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntentos.Location = new Point(472, 132);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(180, 25);
            lblIntentos.TabIndex = 3;
            lblIntentos.Text = "Intentos restantes: 3";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.FromArgb(192, 255, 192);
            lblMensaje.Location = new Point(527, 169);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 4;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = Color.FromArgb(192, 255, 192);
            btnNum0.Location = new Point(346, 392);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(70, 46);
            btnNum0.TabIndex = 5;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += btnNum0_Click;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = Color.FromArgb(192, 255, 192);
            btnNum1.Location = new Point(261, 209);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(70, 47);
            btnNum1.TabIndex = 6;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = Color.FromArgb(192, 255, 192);
            btnNum2.Location = new Point(346, 209);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(70, 47);
            btnNum2.TabIndex = 7;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum3
            // 
            btnNum3.BackColor = Color.FromArgb(192, 255, 192);
            btnNum3.Location = new Point(433, 209);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(70, 47);
            btnNum3.TabIndex = 8;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = Color.FromArgb(192, 255, 192);
            btnNum4.Location = new Point(261, 273);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(70, 47);
            btnNum4.TabIndex = 9;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = Color.FromArgb(192, 255, 192);
            btnNum5.Location = new Point(346, 273);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(70, 47);
            btnNum5.TabIndex = 10;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = Color.FromArgb(192, 255, 192);
            btnNum6.Location = new Point(433, 273);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(70, 47);
            btnNum6.TabIndex = 11;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = Color.FromArgb(192, 255, 192);
            btnNum7.Location = new Point(261, 335);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(70, 47);
            btnNum7.TabIndex = 12;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = Color.FromArgb(192, 255, 192);
            btnNum8.Location = new Point(346, 335);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(70, 47);
            btnNum8.TabIndex = 13;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = Color.FromArgb(192, 255, 192);
            btnNum9.Location = new Point(433, 335);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(70, 47);
            btnNum9.TabIndex = 14;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Red;
            btnBorrar.Location = new Point(261, 392);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(70, 46);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(0, 192, 0);
            btnAceptar.Location = new Point(433, 388);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(70, 46);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(36, 458);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 39);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Tiempo
            // 
            Tiempo.Enabled = true;
            Tiempo.Interval = 1000;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(692, 482);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(73, 15);
            lblTiempo.TabIndex = 18;
            lblTiempo.Text = "Tiempo: 60 s";
            // 
            // FrmPin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 510);
            Controls.Add(lblTiempo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnBorrar);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnNum0);
            Controls.Add(lblMensaje);
            Controls.Add(lblIntentos);
            Controls.Add(txtPin);
            Controls.Add(lbtitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lbtitulo;
        private TextBox txtPin;
        private Label lblIntentos;
        private Label lblMensaje;
        private Button btnNum0;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnBorrar;
        private Button btnAceptar;
        private Button btnCancelar;
        private System.Windows.Forms.Timer Tiempo;
        private Label lblTiempo;
    }
}