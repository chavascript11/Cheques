namespace Chequesito
{
    partial class GenerarChequeAdmin
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
            comboCuentas = new ComboBox();
            label2 = new Label();
            comboBeneficiarios = new ComboBox();
            label3 = new Label();
            monto = new TextBox();
            label4 = new Label();
            txtFechaActual = new Label();
            label5 = new Label();
            txtFechaVencimiento = new Label();
            btnGenerar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 64);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero de Cuenta";
            // 
            // comboCuentas
            // 
            comboCuentas.FormattingEnabled = true;
            comboCuentas.Location = new Point(246, 56);
            comboCuentas.Name = "comboCuentas";
            comboCuentas.Size = new Size(151, 28);
            comboCuentas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 134);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre de Beneficiario";
            // 
            // comboBeneficiarios
            // 
            comboBeneficiarios.FormattingEnabled = true;
            comboBeneficiarios.Location = new Point(246, 126);
            comboBeneficiarios.Name = "comboBeneficiarios";
            comboBeneficiarios.Size = new Size(151, 28);
            comboBeneficiarios.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 211);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Monto";
            // 
            // monto
            // 
            monto.Location = new Point(246, 204);
            monto.Name = "monto";
            monto.Size = new Size(151, 27);
            monto.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 43);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Emision:";
            // 
            // txtFechaActual
            // 
            txtFechaActual.AutoSize = true;
            txtFechaActual.Location = new Point(666, 43);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(13, 20);
            txtFechaActual.TabIndex = 7;
            txtFechaActual.Text = "|";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 96);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 8;
            label5.Text = "Fecha de Vencimiento";
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.AutoSize = true;
            txtFechaVencimiento.Location = new Point(666, 96);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.Size = new Size(13, 20);
            txtFechaVencimiento.TabIndex = 9;
            txtFechaVencimiento.Text = "|";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(616, 273);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(154, 29);
            btnGenerar.TabIndex = 10;
            btnGenerar.Text = "Generar Cheque";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(480, 273);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // GenerarChequeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 339);
            Controls.Add(btnCancelar);
            Controls.Add(btnGenerar);
            Controls.Add(txtFechaVencimiento);
            Controls.Add(label5);
            Controls.Add(txtFechaActual);
            Controls.Add(label4);
            Controls.Add(monto);
            Controls.Add(label3);
            Controls.Add(comboBeneficiarios);
            Controls.Add(label2);
            Controls.Add(comboCuentas);
            Controls.Add(label1);
            Name = "GenerarChequeAdmin";
            Text = "GenerarChequeAdmin";
            Load += GenerarChequeAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboCuentas;
        private Label label2;
        private ComboBox comboBeneficiarios;
        private Label label3;
        private TextBox monto;
        private Label label4;
        private Label txtFechaActual;
        private Label label5;
        private Label txtFechaVencimiento;
        private Button btnGenerar;
        private Button btnCancelar;
    }
}