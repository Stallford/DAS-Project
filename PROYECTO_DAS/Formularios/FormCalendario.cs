using Capa_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DAS
{
    public partial class FormCalendario : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private int selectedID = 0;
        private bool isnuevo = false;
        private ConnectionDB conexionDB = new ConnectionDB();
        public FormCalendario()
        {
            InitializeComponent();
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;
            con = conexionDB.ObtenerConexion();
            MostrarDatos();
            HabilitarCampos(false);
            LimpiarCampos();
            ReiniciarBotones();
        }
        //Funciones
        private void MostrarDatos()
        {
            conexionDB.AbrirConexion(); // Abre la conexión antes de ejecutar la consulta
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Calendario", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conexionDB.CerrarConexion(); // Cierra la conexión después de ejecutar la consulta
        }
        private void HabilitarCampos(bool estado)
        {
            monthCalendar1.Enabled = estado;
            dtpHora.Enabled = estado;
            txtClublocal.Enabled = estado;
            txtClubvisitante.Enabled = estado;
            txtEstadio.Enabled = estado;
        }
        private void LimpiarCampos()
        {
            monthCalendar1.SelectionStart = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            txtClublocal.Text = string.Empty;
            txtClubvisitante.Text = string.Empty;
            txtEstadio.Text = string.Empty;
        }
        private void ReiniciarBotones()
        {
            btnCancelar.Visible = false;
            btnNuevo.Visible = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //Eventos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            HabilitarCampos(true);
            LimpiarCampos();
            isnuevo = true; // Cambiar a modo nuevo
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexionDB.AbrirConexion(); // Abre la conexión antes de ejecutar las consultas

            try
            {
                if (string.IsNullOrWhiteSpace(txtEstadio.Text) ||
                    string.IsNullOrWhiteSpace(txtClublocal.Text) ||
                    string.IsNullOrWhiteSpace(txtClubvisitante.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (isnuevo)
                {
                    // Nuevo registro
                    cmd = new SqlCommand("INSERT INTO Calendario (fechapartido, horapartido, clublocal, clubvisitante, estadio) VALUES (@fecha, @hora, @local, @visitante, @estadio)", conexionDB.ObtenerConexion());

                    // Establecer parámetros para la inserción
                    cmd.Parameters.AddWithValue("@fecha", monthCalendar1.SelectionStart);
                    cmd.Parameters.AddWithValue("@hora", dtpHora.Value.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@local", txtClublocal.Text);
                    cmd.Parameters.AddWithValue("@visitante", txtClubvisitante.Text);
                    cmd.Parameters.AddWithValue("@estadio", txtEstadio.Text);

                    // Ejecutar la consulta de inserción
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro guardado correctamente.");
                }
                else
                {
                    // Modificar registro existente
                    cmd = new SqlCommand("UPDATE Calendario SET fechapartido=@fecha, horapartido=@hora, clublocal=@local, clubvisitante=@visitante, estadio=@estadio WHERE id=@id", conexionDB.ObtenerConexion());

                    // Establecer parámetros para la actualización
                    cmd.Parameters.AddWithValue("@id", selectedID);
                    cmd.Parameters.AddWithValue("@fecha", monthCalendar1.SelectionStart);
                    cmd.Parameters.AddWithValue("@hora", dtpHora.Value.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@local", txtClublocal.Text);
                    cmd.Parameters.AddWithValue("@visitante", txtClubvisitante.Text);
                    cmd.Parameters.AddWithValue("@estadio", txtEstadio.Text);

                    // Ejecutar la consulta de actualización
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro actualizado correctamente.");
                }

                conexionDB.CerrarConexion(); // Cierra la conexión después de ejecutar las consultas

                LimpiarCampos();
                ReiniciarBotones();
                HabilitarCampos(false);
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["id"].Value);
                monthCalendar1.SelectionStart = Convert.ToDateTime(row.Cells["fechapartido"].Value);
                TimeSpan horapartido = (TimeSpan)row.Cells["horapartido"].Value;
                dtpHora.Value = DateTime.Today.Add(horapartido);
                txtClublocal.Text = row.Cells["clublocal"].Value.ToString();
                txtClubvisitante.Text = row.Cells["clubvisitante"].Value.ToString();
                txtEstadio.Text = row.Cells["estadio"].Value.ToString();
                isnuevo = false;
                HabilitarCampos(true);
                btnNuevo.Visible = false;
                btnCancelar.Visible = true;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionDB.AbrirConexion(); // Abre la conexión antes de ejecutar las consultas

            cmd = new SqlCommand("DELETE FROM Calendario WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@id", selectedID);
            cmd.ExecuteNonQuery();

            conexionDB.CerrarConexion(); // Cierra la conexión después de ejecutar las consultas

            MessageBox.Show("Registro eliminado correctamente.");

            LimpiarCampos();
            ReiniciarBotones();
            HabilitarCampos(false);
            MostrarDatos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ReiniciarBotones();
            HabilitarCampos(false);
        }
        private void soloAlfabeto(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es una letra, un espacio o no es un control (como la tecla de retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

    }
}