namespace Chequesito
{
    partial class AgregarBeneficiarioUser
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
            BtnAgregarBeneficiario = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtContacto = new TextBox();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // BtnAgregarBeneficiario
            // 
            BtnAgregarBeneficiario.Location = new Point(290, 331);
            BtnAgregarBeneficiario.Name = "BtnAgregarBeneficiario";
            BtnAgregarBeneficiario.Size = new Size(94, 29);
            BtnAgregarBeneficiario.TabIndex = 0;
            BtnAgregarBeneficiario.Text = "Agregar";
            BtnAgregarBeneficiario.UseVisualStyleBackColor = true;
            BtnAgregarBeneficiario.Click += BtnAgregarBeneficiario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 49);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 123);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 203);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Contacto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(228, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(228, 120);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 5;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(228, 196);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(125, 27);
            txtContacto.TabIndex = 6;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(149, 331);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 29);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // AgregarBeneficiarioUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 396);
            Controls.Add(BtnCancelar);
            Controls.Add(txtContacto);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnAgregarBeneficiario);
            Name = "AgregarBeneficiarioUser";
            Text = "AgregarBeneficiarioUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregarBeneficiario;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtContacto;
        private Button BtnCancelar;
    }
}