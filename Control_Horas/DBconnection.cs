using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class DBconnection
    {
        public static String cadena = "Data Source=DESKTOP-P78S0RT; Initial Catalog=AxTrax1; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection(cadena);

        public void conexionbd()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD" + ex.Message);
            }
        }

            public void cerrar()
        {
            conectarbd.Close();
        }

        // Consultas a BD
    }
}
