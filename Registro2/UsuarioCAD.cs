using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro2
{
    internal class UsuarioCAD
    {
        public  static Usuario guardar (Usuario u)
        {
            Conexion con= new Conexion();
            string sql = "insert into Registro (correo,nombre,contrasena) values ('" + u.setGetCorreo + "','" + u.setGetNombre + "','" + u.setGetContrasena2 + "')";
            SqlCommand comando = new SqlCommand(sql,con.conectar());
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                u = new Usuario();
                u.setGetCorreo = reader["correo"].ToString();
                u.setGetNombre = reader["nombre"].ToString();
                u.setGetContrasena = reader["contrasena"].ToString();
                

                return u;
            }
            else
            {
                return null;
            }
        }

        public static Usuario guardar2(Usuario u)
        {
            Conexion con = new Conexion();
            string sql = "insert into Programa_V (Codigo,Aeropuerto_Org,Aeropuerto_Dtn,Fecha) values ('" + u.setGetCodigo + "','" + u.setGetAeropuerto_Org + "','" + u.setGetAeropuerto_Dtn + "','" + u.setGetFecha + "')";
            SqlCommand comando = new SqlCommand(sql, con.conectar());
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                u = new Usuario();
                u.setGetCodigo = reader["Codigo"].ToString();
                u.setGetAeropuerto_Org = reader["Aeropuerto_Org"].ToString();
                u.setGetAeropuerto_Dtn = reader["Aeropuerto_Dtn"].ToString();
                u.setGetFecha = reader["Fecha"].ToString();

                return u;
            }
            else
            {
                return null;
            }
        }

        public static Usuario Consultar( string codigo)
        {
            Conexion con = new Conexion();
            string sql = "SELECT*FROM Programa_V WHERE Codigo = '" + codigo + "';";
            SqlCommand comando = new SqlCommand(sql, con.conectar());
            SqlDataReader rd = comando.ExecuteReader();

            Usuario em = new Usuario();
            if (rd.Read())
            {
                em = new Usuario();
                em.setGetCodigo = rd["Codigo"].ToString();
                em.setGetAeropuerto_Org = rd["Aeropuerto_Org"].ToString();
                em.setGetAeropuerto_Dtn = rd["Aeropuerto_Dtn"].ToString();
                em.setGetFecha = rd["Fecha"].ToString();

                con.conectar();
                return em;
            }
            else
            {
                con.cerrarConexion();
                return null;
            }
        }

        public static Usuario Consultar2(string correo ,string contrasena )
        {
            Conexion con = new Conexion();
            string sql = "SELECT*FROM Registro WHERE correo = '" + correo +"'and contrasena ='"+contrasena+ "';";
            SqlCommand comando = new SqlCommand(sql, con.conectar());
            SqlDataReader rd = comando.ExecuteReader();

            Usuario em = new Usuario();
            if (rd.Read())
            {
                em = new Usuario();
                em.setGetNombre = rd["nombre"].ToString();
                em.setGetCorreo = rd["correo"].ToString();
                em.setGetContrasena2 = rd["contrasena"].ToString();
                

                con.conectar();
                return em;
            }
            else
            {
                con.cerrarConexion();
                return null;
            }
        }




    }
}
