using System.Configuration;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Chequesito
{
    public partial class Login : Form
    {
        public static int userId;
        public Login()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            String usuario = txtUser.Text;
            String pwd = txtPassword.Text;


            //SqlCommand cmd = new SqlCommand("select usuario, contrasena, roll from usuarios where usuario = '" + usuario + "' and contrasena = '" + pwd + "'", conexion.Conectar()); 
            SqlCommand cmd = new SqlCommand("SELECT id, nombre as nombre, usuario, contrasena, roll " +
                                  "FROM usuarios " +
                                  "WHERE usuario = @usuario and contrasena = @contrasena ", conexion.Conectar());
            //"UNION ALL " +
            //"SELECT titular as nombre, usuario, contrasena " +
            //"FROM cuentas " +
            //"WHERE usuario = @usuario AND contrasena = @contrasena;", conexion.Conectar());
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contrasena", pwd);

            cmd.CommandType = System.Data.CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                userId = reader.GetInt32(reader.GetOrdinal("id")); // assuming the ID column is named "id"
                int rol = reader.GetInt16(4);

                if (rol == 1)
                {
                    // Redirigir a la vista de Administrador
                    mainAdmin mainAdm = new mainAdmin();
                    mainAdm.Show();
                    this.Hide();
                }
                else if (rol == 0)
                {
                    // Redirigir a la vista de usuario
                    UsuarioMain main = new UsuarioMain();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario  y/o contraseña incorrectos ");
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Focus();
            }
            reader.Close();
            conexion.Cerrar();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }


}
