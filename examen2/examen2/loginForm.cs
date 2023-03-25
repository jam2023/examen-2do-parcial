using datos;
using entidades;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace examen2
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_Activated(object sender, EventArgs e)
        {
            codigousuariotextBox.Focus();

        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aceptarbutton_Click(object sender, EventArgs e)
        {
            if (codigousuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(codigousuariotextBox, "Ingrese un usuario");
                return;

            }
            errorProvider1.Clear();
            if (contraseñatextBox.Text == string.Empty)
            {
                errorProvider1.SetError(contraseñatextBox, "Ingrese una contraseña");
                return;
            }
            errorProvider1.Clear();

            //validar usuario en la base de datos
            login login = new login(codigousuariotextBox.Text, contraseñatextBox.Text);
            UsuarioDB usuarioDB = new UsuarioDB();
            Usuario usuario = new Usuario();

            usuario = usuarioDB.Autenticar(login);

            if(usuario != null) 
            {
                //Mandar al menu
                Menu menuformulario = new Menu();
                this.Hide();
                menuformulario.Show();
            }
           else
            {
                MessageBox.Show("Datos de usuario incorrectos");
            }
        }
    }
}
