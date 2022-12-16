namespace Registro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
            }
            else if (txtCorreo.Text.Trim() == "")
            {

                MessageBox.Show("Debe ingresar un correo");

            }
            if (txtContrasena.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una contraseña");
            }
            else if (txtContrasena2.Text.Trim() != txtContrasena.Text.Trim())
            {

                MessageBox.Show("La contraseña no conincide");

            }
            else
            {
                 Usuario u = new Usuario();
                u.setGetCorreo = txtCorreo.Text.Trim();
                u.setGetNombre = txtNombre.Text.Trim();
                u.setGetContrasena = txtContrasena.Text.Trim();
                u.setGetContrasena2 = txtContrasena2.Text.Trim();
                u= UsuarioCAD.guardar(u);

                if(u== null)
                {
                    Form2 es = new Form2();
                    es.Show();
                    MessageBox.Show("Datos Guardados Correctamente ");
                }
                else
                {
                    MessageBox.Show("No hay Datos ");
                    txtContrasena.Text = "";
                    txtContrasena2.Focus();
                }








            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 es = new Form2();
            es.Show();

        }
    }
}