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
    public partial class VerCheque : Form
    {
        public VerCheque()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerCheque_Load(object sender, EventArgs e)
        {
            // Crear un objeto SqlDataAdapter para recuperar los datos de la tabla
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT num_cheque,monto,fecha_emision,fecha_vencimiento FROM cheques", conexion.Conectar());

            // Crear un objeto DataTable y llenarlo con los datos de la tabla
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            // Configurar la propiedad DataSource del control DataGridView
            dataGridView1.DataSource = tabla;

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            mainAdmin mainAdmin = new mainAdmin();
            mainAdmin.Show();
            this.Hide();
        }
    }
}
