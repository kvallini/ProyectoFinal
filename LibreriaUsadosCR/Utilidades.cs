using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUsadosCR
{
    public class Utilidades
    {
        public static DataSet ejecutar(string comando)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CAVALLINI\CURSOSQL2022;
            Initial Catalog=SISTEMA_VENTA_AUTOS_USADOS;Persist Security Info=True;
            User ID=sa;Password=***********;Trust Server Certificate=True");

            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adaptador = new SqlDataAdapter(comando, conn);

            adaptador.Fill(ds);

            conn.Close();

            return ds;


        }
        public static string codificar(string contraseña)
        {
            byte[] datos = Encoding.UTF8.GetBytes(contraseña);
            return System.Convert.ToBase64String(datos);
        }
        public static string decodificar(string contraseña)
        {
            byte[] datos = System.Convert.FromBase64String(contraseña);
            return Encoding.UTF8.GetString(datos, 0, datos.Length);
        }

    }
}


