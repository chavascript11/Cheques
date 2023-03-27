using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chequesito
{
    public partial class AgregarBeneficiarioUser : Form
    {
        public AgregarBeneficiarioUser()
        {
            InitializeComponent();
        }

        private void BtnAgregarBeneficiario_Click(object sender, EventArgs e)
        {   
            String name = txtNombre.Text;
            String address = txtDireccion.Text;
            String tel = txtContacto.Text;

            string cadena = "insert into beneficiarios (nombre, direccion, contacto) values ('" + name + "','" + address + "','" + tel + "');";

            SqlCommand comando = new SqlCommand(cadena, conexion.Conectar());
            comando.ExecuteNonQuery();

            conexion.Cerrar();

            MessageBox.Show("El beneficiario ha sido agregado con exito :)");

            txtNombre.Text = null;
            txtDireccion.Text = null;
            txtContacto.Text = null;
            txtNombre.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            UsuarioMain usuario = new UsuarioMain();
            usuario.Show();
            this.Hide();
        }
    }
}
