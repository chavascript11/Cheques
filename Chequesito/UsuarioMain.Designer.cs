namespace Chequesito
{
    partial class UsuarioMain
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
            BtnCerrarSesion = new Button();
            menuStrip1 = new MenuStrip();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            chequesToolStripMenuItem = new ToolStripMenuItem();
            agregarChequesToolStripMenuItem = new ToolStripMenuItem();
            buscarChequesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.BackColor = Color.Crimson;
            BtnCerrarSesion.Location = new Point(635, 373);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(153, 65);
            BtnCerrarSesion.TabIndex = 0;
            BtnCerrarSesion.Text = "Cerrar Sesion";
            BtnCerrarSesion.UseVisualStyleBackColor = false;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reportesToolStripMenuItem, chequesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(117, 450);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(104, 32);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // chequesToolStripMenuItem
            // 
            chequesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarChequesToolStripMenuItem, buscarChequesToolStripMenuItem });
            chequesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chequesToolStripMenuItem.Name = "chequesToolStripMenuItem";
            chequesToolStripMenuItem.Size = new Size(104, 32);
            chequesToolStripMenuItem.Text = "Cheques";
            // 
            // agregarChequesToolStripMenuItem
            // 
            agregarChequesToolStripMenuItem.Name = "agregarChequesToolStripMenuItem";
            agregarChequesToolStripMenuItem.Size = new Size(258, 32);
            agregarChequesToolStripMenuItem.Text = "Generar Cheques";
            agregarChequesToolStripMenuItem.Click += agregarChequesToolStripMenuItem_Click;
            // 
            // buscarChequesToolStripMenuItem
            // 
            buscarChequesToolStripMenuItem.Name = "buscarChequesToolStripMenuItem";
            buscarChequesToolStripMenuItem.Size = new Size(258, 32);
            buscarChequesToolStripMenuItem.Text = "Buscar Cheques";
            // 
            // UsuarioMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UsuarioMain";
            Text = "UsuarioMain";
            Load += UsuarioMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCerrarSesion;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem chequesToolStripMenuItem;
        private ToolStripMenuItem agregarChequesToolStripMenuItem;
        private ToolStripMenuItem buscarChequesToolStripMenuItem;
    }
}