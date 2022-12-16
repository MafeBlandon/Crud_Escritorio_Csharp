using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool consultado = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCorreoInicio.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un correo ");
            }else if (txtContrasenaInicio.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una contrasena  ");

            }
            else
            {
                Usuario em =UsuarioCAD.Consultar2(txtCorreoInicio.Text.Trim(), txtContrasenaInicio.Text.Trim());
                if(em == null)
                {
                    MessageBox.Show("Contrasena o correo incorrecto");
                    consultado = false;

                }
                else
                {
                    txtContrasenaInicio.Text = em.setGetContrasena2;
                    txtCorreoInicio.Text = em.setGetCorreo;
                    Form3 es = new Form3();
                    es.Show();
                    
                    consultado = true;
                }







            }
        }
    }
}
