namespace Chequesito
{
    partial class VerCuenta
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            comboBox1 = new ComboBox();
            conexionBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            txtTitular = new TextBox();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            CtaModificar = new Button();
            label8 = new Label();
            noCuenta = new Label();
            label10 = new Label();
            saldo = new Label();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 31);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Titular";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(conexion);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 168);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Titular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 252);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 208);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 4;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 164);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(280, 204);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 6;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 31);
            label7.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(337, 323);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(280, 157);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(125, 27);
            txtTitular.TabIndex = 9;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(280, 252);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(280, 204);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 11;
            // 
            // CtaModificar
            // 
            CtaModificar.Location = new Point(472, 321);
            CtaModificar.Margin = new Padding(3, 4, 3, 4);
            CtaModificar.Name = "CtaModificar";
            CtaModificar.Size = new Size(86, 31);
            CtaModificar.TabIndex = 0;
            CtaModificar.Text = "Modificar";
            CtaModificar.Click += CtaModificar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(87, 84);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 14;
            label8.Text = "Numero de Cuenta";
            // 
            // noCuenta
            // 
            noCuenta.AutoSize = true;
            noCuenta.Location = new Point(281, 84);
            noCuenta.Name = "noCuenta";
            noCuenta.Size = new Size(13, 20);
            noCuenta.TabIndex = 15;
            noCuenta.Text = "|";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(87, 122);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 16;
            label10.Text = "Saldo";
            // 
            // saldo
            // 
            saldo.AutoSize = true;
            saldo.Location = new Point(280, 122);
            saldo.Name = "saldo";
            saldo.Size = new Size(13, 20);
            saldo.TabIndex = 17;
            saldo.Text = "|";
            // 
            // VerCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 381);
            Controls.Add(saldo);
            Controls.Add(label10);
            Controls.Add(noCuenta);
            Controls.Add(label8);
            Controls.Add(CtaModificar);
            Controls.Add(txtUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtTitular);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "VerCuenta";
            Text = "VerCuenta";
            Load += VerCuenta_Load;
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private BindingSource conexionBindingSource;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private TextBox txtTitular;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Button CtaModificar;
        private Label label8;
        private Label noCuenta;
        private Label label10;
        private Label saldo;
    }
}