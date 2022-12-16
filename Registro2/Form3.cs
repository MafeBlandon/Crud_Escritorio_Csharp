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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un codigo de vuelo");
            }
            else if (txtDestino.Text.Trim() == "")
            {

                MessageBox.Show("Debe ingresar un aeropuerto de destino");

            }
            if (txtOrigen.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un  aeropuerto de origen");
            }
            else if (txtFecha.Text.Trim() == "")
            {

                MessageBox.Show("Debe ingresar una fecha ");

            }
            else
            {
                Usuario u = new Usuario();
                u.setGetCodigo = txtCodigo.Text.Trim();
                u.setGetAeropuerto_Dtn = txtDestino.Text.Trim();
                u.setGetAeropuerto_Org = txtOrigen.Text.Trim();
                u.setGetFecha = txtFecha.Value.Year + "-" + txtFecha.Value.Month + "-" + txtFecha.Value.Day;

                u = UsuarioCAD.guardar2(u);

                if (u == null)
                {
                    Form4 es = new Form4();
                    es.Show();
                    MessageBox.Show("Datos Guardados Correctamente ");
                }
                else
                {
                    
                    
                    MessageBox.Show("No hay Datos ");
                    txtCodigo.Text = "";
                    txtDestino.Focus();
                    txtOrigen.Focus();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 es = new Form4();
            es.Show();
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
