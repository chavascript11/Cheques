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
    public partial class mainAdmin : Form
    {
        public mainAdmin()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCuenta crearCuenta = new CrearCuenta();
            crearCuenta.Show();
            this.Hide();
        }

        private void verCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCuenta verCuenta = new VerCuenta();
            verCuenta.Show();
            this.Hide();
        }

        private void generarChequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarChequeAdmin generarChequeAdmin = new GenerarChequeAdmin();
            generarChequeAdmin.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarBeneficiarios agregarBeneficiarios = new AgregarBeneficiarios();
            agregarBeneficiarios.Show();
            this.Hide();
        }

        private void verChequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCheque vercheque = new VerCheque();
            vercheque.Show();
            this.Hide();
        }
    }
}
