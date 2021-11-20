using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ControladorDLL
{
    public class Biblioteca
    {
        public static DataSet herramientas(string cmd)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-31Q7HJFR\SQLEXPRESS;Initial Catalog=puntodeVenta;Persist Security Info=True;User ID=sa;Password=df9dd6848c");
            conexion.Open();

            DataSet dll = new DataSet();
            SqlDataAdapter dll1 = new SqlDataAdapter(cmd, conexion);
            
            dll1.Fill(dll);

            conexion.Close();
            return dll;
        }
    }
}
