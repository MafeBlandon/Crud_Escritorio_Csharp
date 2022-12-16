using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro2
{
    internal class Conexion
    {
        SqlConnection con;

        public SqlConnection conectar()
        {
            string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            con = new SqlConnection(cadena);
            try
            {
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                return null;

            }

        }

        public void cerrarConexion() 
        { 
            con.Close();
        }
    }
}
