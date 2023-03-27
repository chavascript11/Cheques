namespace Chequesito
{
    partial class mainAdmin
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
            btnCerrarSesion = new Button();
            menuStrip1 = new MenuStrip();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            crearCuentaToolStripMenuItem = new ToolStripMenuItem();
            verCuentasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            crearReporteToolStripMenuItem = new ToolStripMenuItem();
            chequesToolStripMenuItem = new ToolStripMenuItem();
            generarChequeToolStripMenuItem = new ToolStripMenuItem();
            verChequeToolStripMenuItem = new ToolStripMenuItem();
            beneficiariosToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 177);
            label1.Name = "label1";
            label1.Size = new Size(715, 41);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la App de Bancomer con dinero infinito";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Teal;
            btnCerrarSesion.Location = new Point(631, 391);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(157, 48);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cuentaToolStripMenuItem, reportesToolStripMenuItem, chequesToolStripMenuItem, beneficiariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearCuentaToolStripMenuItem, verCuentasToolStripMenuItem });
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(69, 24);
            cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // crearCuentaToolStripMenuItem
            // 
            crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            crearCuentaToolStripMenuItem.Size = new Size(177, 26);
            crearCuentaToolStripMenuItem.Text = "Crear Cuenta";
            crearCuentaToolStripMenuItem.Click += crearCuentaToolStripMenuItem_Click;
            // 
            // verCuentasToolStripMenuItem
            // 
            verCuentasToolStripMenuItem.Name = "verCuentasToolStripMenuItem";
            verCuentasToolStripMenuItem.Size = new Size(177, 26);
            verCuentasToolStripMenuItem.Text = "Ver Cuentas";
            verCuentasToolStripMenuItem.Click += verCuentasToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearReporteToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // crearReporteToolStripMenuItem
            // 
            crearReporteToolStripMenuItem.Name = "crearReporteToolStripMenuItem";
            crearReporteToolStripMenuItem.Size = new Size(184, 26);
            crearReporteToolStripMenuItem.Text = "Crear Reporte";
            // 
            // chequesToolStripMenuItem
            // 
            chequesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarChequeToolStripMenuItem, verChequeToolStripMenuItem });
            chequesToolStripMenuItem.Name = "chequesToolStripMenuItem";
            chequesToolStripMenuItem.Size = new Size(79, 24);
            chequesToolStripMenuItem.Text = "Cheques";
            // 
            // generarChequeToolStripMenuItem
            // 
            generarChequeToolStripMenuItem.Name = "generarChequeToolStripMenuItem";
            generarChequeToolStripMenuItem.Size = new Size(224, 26);
            generarChequeToolStripMenuItem.Text = "Generar cheque";
            generarChequeToolStripMenuItem.Click += generarChequeToolStripMenuItem_Click;
            // 
            // verChequeToolStripMenuItem
            // 
            verChequeToolStripMenuItem.Name = "verChequeToolStripMenuItem";
            verChequeToolStripMenuItem.Size = new Size(224, 26);
            verChequeToolStripMenuItem.Text = "Ver cheque";
            verChequeToolStripMenuItem.Click += verChequeToolStripMenuItem_Click;
            // 
            // beneficiariosToolStripMenuItem
            // 
            beneficiariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, consultarToolStripMenuItem });
            beneficiariosToolStripMenuItem.Name = "beneficiariosToolStripMenuItem";
            beneficiariosToolStripMenuItem.Size = new Size(108, 24);
            beneficiariosToolStripMenuItem.Text = "Beneficiarios";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(224, 26);
            agregarToolStripMenuItem.Text = "Agregar ";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(224, 26);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // mainAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnCerrarSesion);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainAdmin";
            Text = "Admin Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCerrarSesion;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cuentaToolStripMenuItem;
        private ToolStripMenuItem crearCuentaToolStripMenuItem;
        private ToolStripMenuItem verCuentasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem crearReporteToolStripMenuItem;
        private ToolStripMenuItem chequesToolStripMenuItem;
        private ToolStripMenuItem generarChequeToolStripMenuItem;
        private ToolStripMenuItem beneficiariosToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem verChequeToolStripMenuItem;
    }
}