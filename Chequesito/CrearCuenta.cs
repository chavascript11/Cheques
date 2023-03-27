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
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
            titular.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titularr = titular.Text;
            float saldoo = Convert.ToSingle(saldo.Text);
            string user = usuario.Text;
            string pass = contrasena.Text;

            Random r = new Random();

            //Genera un numero entre 10 y 100 (101 no se incluye)
            int numCuenta = r.Next(10000000, 100000000);

            string cadena = "insert into usuarios (usuario, nombre, contrasena, roll) values ('" + user + "','" + titularr + "','" + pass + "','" + 0 + "');";

            SqlCommand comando = new SqlCommand(cadena, conexion.Conectar());
            comando.ExecuteNonQuery();

            string cad = "SELECT id FROM usuarios WHERE usuario = '" + user + "';";
            SqlCommand comand = new SqlCommand(cad, conexion.Conectar());

            int iduser = (int)comand.ExecuteScalar();

            cadena = "insert into cuentas (num_cuenta,saldo,id_usuario, titular) values ('" + numCuenta + "','" + saldoo + "','" + iduser + "','" + titularr + "');";
            SqlCommand com = new SqlCommand(cadena, conexion.Conectar());
            com.ExecuteNonQuery();

            conexion.Cerrar();

            MessageBox.Show("CUENTA CREADA CON EXITO" + "\n" +
                "Numero de Cuenta: " + numCuenta + "\n" +
                "Titular: " + titularr + "\n" +
                "Saldo: " + saldoo + "\n" +
                "Usuario: " + user
                );

            titular.Text = null;
            saldo.Text = null;
            usuario.Text = null;
            contrasena.Text = null;

            titular.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainAdmin form2 = new mainAdmin();
            form2.Show();
            this.Hide();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            titular.Focus();
        }
    }
}
