using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro2
{
    public class Usuario
    {

        private string nombre;
        private string correo;
        private string contrasena;
        private string contrasena2;
        private string Codigo;
        private string Aeropuerto_Org;
        private string Aeropuerto_Dtn;
        private string Fecha;

        public Usuario()
        {
            
        }

        public Usuario(string nombre, string correo, string contrasena, string contrasena2, string codigo, string aeropuerto_Org, string aeropuerto_Dtn, string fecha)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.contrasena = contrasena;
            this.contrasena2 = contrasena2;
            this.Codigo = codigo;
            this.Aeropuerto_Org = aeropuerto_Org;
            this.Aeropuerto_Dtn = aeropuerto_Dtn;
            this.Fecha = fecha;
        }

        public string setGetNombre { get => nombre; set => nombre = value; }
        public string setGetCorreo { get => correo; set => correo = value; }
        public string setGetContrasena { get => contrasena; set => contrasena = value; }
        public string setGetContrasena2 { get => contrasena2; set => contrasena2 = value; }
        public string setGetCodigo { get => Codigo; set => Codigo = value; }
        public string setGetAeropuerto_Org { get => Aeropuerto_Org; set => Aeropuerto_Org = value; }
        public string setGetAeropuerto_Dtn { get => Aeropuerto_Dtn; set => Aeropuerto_Dtn = value; }
        public string setGetFecha { get => Fecha; set => Fecha = value; }
    }
}
