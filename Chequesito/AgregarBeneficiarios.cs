using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AgregarBeneficiarios : Form
    {
        public AgregarBeneficiarios()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            mainAdmin mainAdmin = new mainAdmin();
            mainAdmin.Show();
            this.Hide();
        }
    }
}
