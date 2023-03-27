namespace Chequesito
{
    partial class CrearCuenta
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
            label2 = new Label();
            saldo = new TextBox();
            titular = new TextBox();
            label3 = new Label();
            contrasena = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            usuario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 43);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Titular:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 105);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Saldo:";
            // 
            // saldo
            // 
            saldo.Location = new Point(165, 101);
            saldo.Name = "saldo";
            saldo.Size = new Size(125, 27);
            saldo.TabIndex = 2;
            // 
            // titular
            // 
            titular.Location = new Point(165, 43);
            titular.Name = "titular";
            titular.Size = new Size(125, 27);
            titular.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 221);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // contrasena
            // 
            contrasena.Location = new Point(165, 219);
            contrasena.Name = "contrasena";
            contrasena.Size = new Size(125, 27);
            contrasena.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(194, 339);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(59, 339);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 165);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 8;
            label4.Text = "Usuario";
            // 
            // usuario
            // 
            usuario.Location = new Point(165, 161);
            usuario.Name = "usuario";
            usuario.Size = new Size(125, 27);
            usuario.TabIndex = 9;
            // 
            // CrearCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 411);
            Controls.Add(usuario);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(contrasena);
            Controls.Add(label3);
            Controls.Add(titular);
            Controls.Add(saldo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearCuenta";
            Text = "CrearCuenta";
            Load += CrearCuenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox saldo;
        private TextBox titular;
        private Label label3;
        private TextBox contrasena;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox usuario;
    }
}