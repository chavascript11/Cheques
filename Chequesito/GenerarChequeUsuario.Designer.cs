namespace Chequesito
{
    partial class GenerarChequeUsuario
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
            txtMonto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtNumCuenta = new Label();
            txtEmision = new Label();
            txtVencimiento = new Label();
            comboBeneficiario = new ComboBox();
            BtnGenerar = new Button();
            BtnCancelar = new Button();
            BtnAgregarBeneficiario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 68);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero de cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 147);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre beneficiario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 246);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(197, 239);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 68);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha Emision";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(490, 150);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 7;
            label5.Text = "Fecha vencimiento";
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.AutoSize = true;
            txtNumCuenta.Location = new Point(197, 68);
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(13, 20);
            txtNumCuenta.TabIndex = 8;
            txtNumCuenta.Text = "l";
            // 
            // txtEmision
            // 
            txtEmision.AutoSize = true;
            txtEmision.Location = new Point(641, 68);
            txtEmision.Name = "txtEmision";
            txtEmision.Size = new Size(13, 20);
            txtEmision.TabIndex = 9;
            txtEmision.Text = "l";
            // 
            // txtVencimiento
            // 
            txtVencimiento.AutoSize = true;
            txtVencimiento.Location = new Point(641, 150);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.Size = new Size(13, 20);
            txtVencimiento.TabIndex = 10;
            txtVencimiento.Text = "l";
            // 
            // comboBeneficiario
            // 
            comboBeneficiario.FormattingEnabled = true;
            comboBeneficiario.Location = new Point(197, 147);
            comboBeneficiario.Name = "comboBeneficiario";
            comboBeneficiario.Size = new Size(151, 28);
            comboBeneficiario.TabIndex = 11;
            // 
            // BtnGenerar
            // 
            BtnGenerar.Location = new Point(470, 365);
            BtnGenerar.Name = "BtnGenerar";
            BtnGenerar.Size = new Size(123, 42);
            BtnGenerar.TabIndex = 12;
            BtnGenerar.Text = "Generar";
            BtnGenerar.UseVisualStyleBackColor = true;
            BtnGenerar.Click += BtnGenerar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(299, 365);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(117, 42);
            BtnCancelar.TabIndex = 13;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAgregarBeneficiario
            // 
            BtnAgregarBeneficiario.Location = new Point(629, 346);
            BtnAgregarBeneficiario.Name = "BtnAgregarBeneficiario";
            BtnAgregarBeneficiario.Size = new Size(136, 61);
            BtnAgregarBeneficiario.TabIndex = 14;
            BtnAgregarBeneficiario.Text = "Agregar beneficiario";
            BtnAgregarBeneficiario.UseVisualStyleBackColor = true;
            BtnAgregarBeneficiario.Click += BtnAgregarBeneficiario_Click;
            // 
            // GenerarChequeUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAgregarBeneficiario);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGenerar);
            Controls.Add(comboBeneficiario);
            Controls.Add(txtVencimiento);
            Controls.Add(txtEmision);
            Controls.Add(txtNumCuenta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GenerarChequeUsuario";
            Text = "GenerarChequeUsuario";
            Load += GenerarChequeUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMonto;
        private Label label4;
        private Label label5;
        private Label txtNumCuenta;
        private Label txtEmision;
        private Label txtVencimiento;
        private ComboBox comboBeneficiario;
        private Button BtnGenerar;
        private Button BtnCancelar;
        private Button BtnAgregarBeneficiario;
    }
}