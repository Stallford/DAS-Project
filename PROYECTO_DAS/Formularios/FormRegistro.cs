using CapaNegocios.Entidades;
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
    public partial class FormRegistro : Form
    {
        R_arbitro obj_arbitro = new R_arbitro();
        private bool is_nuevo = false;
        // Variable global para guardar el ID seleccionado
        int idSeleccionado;
        public FormRegistro()
        {
            InitializeComponent();
            ActualizarDataGridViewArbitro();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void ResetearBotones()
        {
            btnNuevo.Visible = true;
            btnNuevo.Enabled = true;
            btnCancelar.Visible = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        private void setearControladoresTexto(bool setear)
        {
            txtNombres.Enabled = setear;
            txtApellidos.Enabled = setear;
            txtCorreo.Enabled = setear;
            txtContraseña.Enabled = setear;
            txtEdad.Enabled = setear;
        }
        private void limpiarControladoresTexto()
        {
            txtId.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtEdad.Text = "";
        }
        private void ActualizarDataGridViewArbitro()
        {
            try
            {
                DataTable resultado = obj_arbitro.getListaArbitro();

                // Usar un BindingSource para evitar la fila en blanco.
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = resultado;

                dgvArbitro.DataSource = bindingSource;

                // Opcionalmente, puedes ocultar la columna de ID si no la necesitas en la interfaz gráfica.
                dgvArbitro.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades.
                MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
            }
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            btnCancelar.Visible = true;
            setearControladoresTexto(true);
            limpiarControladoresTexto();
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            is_nuevo = true;
        }

        private void dgvArbitro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            is_nuevo = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Visible = false;
            btnCancelar.Visible = true;
            setearControladoresTexto(true);
            if (e.RowIndex >= 0 && e.RowIndex < dgvArbitro.Rows.Count)
            {

                DataGridViewRow row = dgvArbitro.Rows[e.RowIndex];

                int idArbitro = Convert.ToInt32(row.Cells["id"].Value);
                string correo = row.Cells["correo"].Value.ToString();
                string nombres = row.Cells["nombres"].Value.ToString();
                string apellidos = row.Cells["apellidos"].Value.ToString();
                string contraseña = row.Cells["contraseña"].Value.ToString();
                // al seleccionar una celda vacia ocurria un error con la edad mostrada
                int edad;
                if (row.Cells["edad"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["edad"].Value.ToString()))
                {
                    edad = Convert.ToInt32(row.Cells["edad"].Value);
                }
                else
                {
                    edad = 0;
                }

                // Asignar los datos al formulario o hacer lo que necesites con ellos.
                // Por ejemplo, podrías asignar los valores a TextBox en tu formulario.
                txtId.Text = idArbitro.ToString();
                txtCorreo.Text = correo;
                txtNombres.Text = nombres;
                txtApellidos.Text = apellidos;
                txtContraseña.Text = contraseña;
                txtEdad.Text = edad.ToString();
            }
            else
            {
                MessageBox.Show("Se ha seleccionado una fila válida", "Advertencia");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro de que desea eliminar este Arbitro?", "Eliminar Arbitro"
                , botones, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    obj_arbitro.Id = Convert.ToInt32(txtId.Text);
                    if (obj_arbitro.EliminarArbitro(obj_arbitro))
                    {
                        MessageBox.Show("Registro Eliminado con Exito");
                        setearControladoresTexto(false);
                        ResetearBotones();
                        limpiarControladoresTexto();
                        ActualizarDataGridViewArbitro();
                    }
                    else
                        MessageBox.Show("Registro No Pudo ser Eliminado");
                    ResetearBotones();
                    setearControladoresTexto(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                    string.IsNullOrWhiteSpace(txtEdad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (is_nuevo)
                {
                    obj_arbitro.Nombres = txtNombres.Text;
                    obj_arbitro.Apellidos = txtApellidos.Text;
                    obj_arbitro.Correo = txtCorreo.Text;
                    obj_arbitro.Contraseña = txtContraseña.Text;
                    obj_arbitro.Edad = Convert.ToInt32(txtEdad.Text);

                    var resultado = obj_arbitro.CrearArbitro(obj_arbitro);
                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Exito");
                        setearControladoresTexto(false);
                        limpiarControladoresTexto();
                        ActualizarDataGridViewArbitro();
                        ResetearBotones();
                    }
                    else
                        MessageBox.Show("No se Creo el Registro");
                }
                else
                {
                    obj_arbitro.Id = Convert.ToInt32(txtId.Text);
                    obj_arbitro.Nombres = txtNombres.Text;
                    obj_arbitro.Apellidos = txtApellidos.Text;
                    obj_arbitro.Correo = txtCorreo.Text;
                    obj_arbitro.Contraseña = txtContraseña.Text;
                    obj_arbitro.Edad = Convert.ToInt32(txtEdad.Text);

                    if (obj_arbitro.ActualizarArbitro(obj_arbitro))
                    {
                        MessageBox.Show("Registro Actualizado");
                        ActualizarDataGridViewArbitro();
                        limpiarControladoresTexto();
                        setearControladoresTexto(false);
                        ResetearBotones();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setearControladoresTexto(false);
            limpiarControladoresTexto();
            ResetearBotones();
        }
        private void soloAlfabeto(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es una letra, un espacio o no es un control (como la tecla de retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir solo números y teclas de control (por ejemplo, retroceso)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                // Limitar a 2 caracteres
                if (txtEdad.Text.Length >= 2 && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        private void noEspacio(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es diferente de un espacio
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
