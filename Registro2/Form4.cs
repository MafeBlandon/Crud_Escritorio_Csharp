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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public bool consultado = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo2.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una codigo ");

            }
            else
            {
                Usuario em = UsuarioCAD.Consultar(txtCodigo2.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe el codigo"+ txtCodigo2.Text);
                    consultado = false;

                }
                else
                {
                    lblDestino.Text = em.setGetAeropuerto_Dtn;
                    lblFecha.Text = em.setGetFecha;
                    lblOrigen.Text = em.setGetAeropuerto_Org;



                    consultado = true;
                }







            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
