using System.Data.SqlClient;

namespace Chequesito
{
    public partial class GenerarChequeUsuario : Form
    {
        public GenerarChequeUsuario()
        {
            InitializeComponent();
        }

        private void GenerarChequeUsuario_Load(object sender, EventArgs e)
        {

            string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");

            txtEmision.Text = fechaActual;

            DateTime fechaEn4Meses = DateTime.Now.AddMonths(4);
            string fechaEn4MesesString = fechaEn4Meses.ToString("yyyy-MM-dd");

            txtVencimiento.Text = fechaEn4MesesString;

            int userId = Login.userId;

            string cadena = "select num_cuenta from cuentas where id_usuario  = '" + userId + "';";
            SqlCommand comando = new SqlCommand(cadena, conexion.Conectar());

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                txtNumCuenta.Text = reader["num_cuenta"].ToString();
            }

            conexion.Cerrar();

            cadena = "select nombre from beneficiarios";
            SqlCommand comnd = new SqlCommand(cadena, conexion.Conectar());


            SqlDataReader lector = comnd.ExecuteReader();

            while (lector.Read())
            {
                comboBeneficiario.Items.Add(lector["nombre"].ToString());
            }

            conexion.Cerrar();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(1000000, 9999999);

            string selectedAcount = txtNumCuenta.Text;
            string selectedBeneficiario = comboBeneficiario.SelectedItem.ToString();

            string cad = "SELECT id FROM cuentas WHERE num_cuenta = '" + selectedAcount + "';";
            SqlCommand comand = new SqlCommand(cad, conexion.Conectar());

            int idcuenta = (int)comand.ExecuteScalar();
            conexion.Cerrar();

            cad = "SELECT id FROM beneficiarios WHERE nombre = '" + selectedBeneficiario + "';";
            SqlCommand comnd = new SqlCommand(cad, conexion.Conectar());

            int idbeneficiario = (int)comnd.ExecuteScalar();
            conexion.Cerrar();


            //saber cuanto dinero hay en la cuenta 
            cad = "SELECT saldo FROM cuentas WHERE num_cuenta = '" + selectedAcount + "';";
            SqlCommand comandox = new SqlCommand(cad, conexion.Conectar());

            float montocuenta = Convert.ToSingle(comandox.ExecuteScalar());
            conexion.Cerrar();

            float montoFloat = float.Parse(txtMonto.Text);
            if (montocuenta > montoFloat)
            {

                float restante = montocuenta - montoFloat;
                // Crear un objeto SqlCommand que actualice el registro en la base de datos
                SqlCommand cmdUpdate = new SqlCommand("UPDATE cuentas SET saldo = " + restante + " WHERE num_cuenta = " + selectedAcount + " ;", conexion.Conectar());


                // Ejecutar el comando con el método ExecuteNonQuery para actualizar el registro en la base de datos
                int rowsAffected = cmdUpdate.ExecuteNonQuery();

                // Verificar si se actualizaron filas en la tabla
                if (rowsAffected > 0)
                {
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.");
                    mainAdmin mainAdmin = new mainAdmin();
                    mainAdmin.Show();
                    this.Hide();
                }

                // Cierra la conexión
                conexion.Cerrar();


                // restante del código
                string cadena = "insert into cheques (num_cheque, monto, fecha_emision, fecha_vencimiento, estado, id_beneficiario, id_cuenta) values (@num_cheque, @monto, @fecha_emision, @fecha_vencimiento, @estado, @id_beneficiario, @id_cuenta)";
                SqlCommand comando = new SqlCommand(cadena, conexion.Conectar());
                comando.Parameters.AddWithValue("@num_cheque", numeroAleatorio);
                comando.Parameters.AddWithValue("@monto", Convert.ToDecimal(txtMonto.Text));
                comando.Parameters.AddWithValue("@fecha_emision", Convert.ToDateTime(txtEmision.Text));
                comando.Parameters.AddWithValue("@fecha_vencimiento", Convert.ToDateTime(txtVencimiento.Text));
                comando.Parameters.AddWithValue("@estado", "Por cobrar");
                comando.Parameters.AddWithValue("@id_beneficiario", idbeneficiario);
                comando.Parameters.AddWithValue("@id_cuenta", idcuenta);
                comando.ExecuteNonQuery();

                conexion.Cerrar();

            }
            else
            {
                MessageBox.Show("No se ha podido realizar la transaccion \n" + "Fondos insuficientes");
                return;
            }
            MessageBox.Show("Cheque agregado con exito :)");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            UsuarioMain usuario = new UsuarioMain();
            usuario.Show();
            this.Hide();
        }

        private void BtnAgregarBeneficiario_Click(object sender, EventArgs e)
        {
            AgregarBeneficiarioUser beneficiarioUser = new AgregarBeneficiarioUser();
            beneficiarioUser.Show();
            this.Hide();
        }
    }
}
