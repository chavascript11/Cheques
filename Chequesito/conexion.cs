using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chequesito
{
    public class conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI;DATABASE=Banco;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            return con;

        }

        public static void Cerrar()
        {
            SqlConnection cerrar = new SqlConnection();
            cerrar.Close();
        }
            
}
}
