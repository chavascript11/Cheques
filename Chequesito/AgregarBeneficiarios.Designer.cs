namespace Chequesito
{
    partial class AgregarBeneficiarios
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
            label3 = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtContacto = new TextBox();
            Cancelar = new Button();
            Agregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 55);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 102);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 143);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Contacto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(207, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(207, 99);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 4;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(207, 140);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(125, 27);
            txtContacto.TabIndex = 5;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(83, 213);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(94, 29);
            Cancelar.TabIndex = 6;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Agregar
            // 
            Agregar.Location = new Point(238, 213);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(94, 29);
            Agregar.TabIndex = 7;
            Agregar.Text = "Guardar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // AgregarBeneficiarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 299);
            Controls.Add(Agregar);
            Controls.Add(Cancelar);
            Controls.Add(txtContacto);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarBeneficiarios";
            Text = "AgregarBeneficiarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtContacto;
        private Button Cancelar;
        private Button Agregar;
    }
}