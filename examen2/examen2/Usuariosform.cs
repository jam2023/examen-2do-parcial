using entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen2
{
    public partial class Usuariosform : Form
    {
        public Usuariosform()
        {
            InitializeComponent();
        }

        private void Usuariosform_Load(object sender, EventArgs e)
        {

        }
        string tipooperacion = string.Empty;
        private void nuevobutton_Click(object sender, EventArgs e)
        {
            Habilitarcontroles();
            modificarbutton.Enabled = true;
            eliminarbutton.Enabled = true;
            guardarbutton.Enabled = true;
            tipooperacion = "nuevo";
        }
        private void Habilitarcontroles()
        {
            codigotextBox.Enabled= true;
            nombretextBox.Enabled= true;
            contraseñatextBox.Enabled= true;
            correotextBox.Enabled= true;   
            rolcomboBox.Enabled= true;
            estaactivocheckBox.Enabled = true;
            
        }
        private void limpiarcontroles()
        {
            codigotextBox.Clear();
            nombretextBox.Clear();
            contraseñatextBox.Clear();
            correotextBox.Clear();
            rolcomboBox.Text = "";
           estaactivocheckBox.Checked = true;
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            deshabilitarcontroles();
            limpiarcontroles();
            modificarbutton.Enabled = false;
            eliminarbutton.Enabled = false;
            guardarbutton.Enabled = false;
        }
        private void deshabilitarcontroles()
        {
            codigotextBox.Enabled = false;
            nombretextBox.Enabled = false;
            contraseñatextBox.Enabled = false;
            correotextBox.Enabled = false;
            rolcomboBox.Enabled = false;
            estaactivocheckBox.Enabled = false;
        }

        private void modificarbutton_Click(object sender, EventArgs e)
        {
            tipooperacion = "modificar";
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            if (tipooperacion == "nuevo")
            {
                if (string.IsNullOrEmpty(codigotextBox.Text))
                {
                    errorProvider1.SetError(codigotextBox, "ingrese el codigo");
                    codigotextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(nombretextBox.Text))
                {
                    errorProvider1.SetError(nombretextBox, "ingrese el nombre");
                    nombretextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(contraseñatextBox.Text))
                {
                    errorProvider1.SetError(contraseñatextBox, "ngrese una contraseña");
                   contraseñatextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(rolcomboBox.Text))
                {
                    errorProvider1.SetError(rolcomboBox, "selecione un rol");
                    rolcomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                Usuario user = new Usuario();
                user.CodigoUsuario = codigotextBox.Text;
                user.Nombre=nombretextBox.Text;
                user.Contraseña = contraseñatextBox.Text;
                user.Correo = correotextBox.Text;
                user.Estaactivo= estaactivocheckBox.Checked;






            }
            else if (tipooperacion == "modificar") ;

        }
    }
}
