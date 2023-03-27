using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chequesito
{
    public partial class UsuarioMain : Form
    {
        public UsuarioMain()
        {
            InitializeComponent();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void agregarChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarChequeUsuario generarChequeUsuario = new GenerarChequeUsuario();
            generarChequeUsuario.Show();
            this.Hide();
        }

        private void UsuarioMain_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\rdiaz\\Pictures\\Saved Pictures\\15252159-2c71-4ad0-b441-494f8c290439.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
    }
}
