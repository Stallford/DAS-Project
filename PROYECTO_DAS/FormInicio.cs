using Capa_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DAS
{
    public partial class FormInicio : Form
    {
        private readonly UsuarioData usuarioData = new UsuarioData();
        public FormInicio()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                bool credencialesCorrectas = usuarioData.VerificarCredenciales(usuario, contraseña);

                if (credencialesCorrectas)
                {
                    FormMenu formularioMenu = new FormMenu();
                    MessageBox.Show("Inicio de sesión exitoso");
                    formularioMenu.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.");
                    txtUsuario.Text = string.Empty;
                    txtContraseña.Text = string.Empty;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
