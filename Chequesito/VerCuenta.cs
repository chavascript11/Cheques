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
    public partial class VerCuenta : Form
    {
        public VerCuenta()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int iduser = 1;
            SqlCommand cmd = new SqlCommand("SELECT * FROM usuarios WHERE nombre = @titular", conexion.Conectar());
            cmd.Parameters.AddWithValue("@titular", comboBox1.SelectedItem.ToString());

            SqlDataReader reader = cmd.ExecuteReader();

            // Si se encontraron resultados, muestra los datos en los campos correspondientes
            if (reader.Read())
            {
                iduser = (int)reader["id"];
                txtTitular.Text = reader["nombre"].ToString();
                txtUsuario.Text = reader["usuario"].ToString();
                txtContrasena.Text = reader["contrasena"].ToString();

            }
            reader.Close();
            conexion.Cerrar();

            SqlCommand comnd = new SqlCommand("select * from cuentas where " + iduser + " = " + "id_usuario;", conexion.Conectar());
            SqlDataReader lector = comnd.ExecuteReader();



            if (lector.Read())
            {
                noCuenta.Text = lector["num_cuenta"].ToString();
                saldo.Text = lector["saldo"].ToString();
            }
            lector.Close();


            // Cierra la conexión y el lector

            conexion.Cerrar();


        }

        private void VerCuenta_Load(object sender, EventArgs e)
        {
            string cadena = "select nombre from usuarios";
            SqlCommand comando = new SqlCommand(cadena, conexion.Conectar());


            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["nombre"].ToString());
            }

            conexion.Cerrar();
        }

        private void CtaModificar_Click(object sender, EventArgs e)
        {

            // Crear un objeto SqlCommand que actualice el registro en la base de datos
            SqlCommand cmdUpdate = new SqlCommand("UPDATE usuarios SET usuario = @usuario, contrasena = @contrasena WHERE nombre = @titular", conexion.Conectar());

            // Asignar los valores actualizados a los parámetros del comando
            cmdUpdate.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmdUpdate.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
            cmdUpdate.Parameters.AddWithValue("@titular", txtTitular.Text);

            // Ejecutar el comando con el método ExecuteNonQuery para actualizar el registro en la base de datos
            int rowsAffected = cmdUpdate.ExecuteNonQuery();

            // Verificar si se actualizaron filas en la tabla
            if (rowsAffected > 0)
            {
                MessageBox.Show("El registro ha sido actualizado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el registro.");
            }

            // Cierra la conexión
            conexion.Cerrar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainAdmin mainAdmin = new mainAdmin();
            mainAdmin.Show();
            this.Hide();
        }
    }
}
