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
        private bool modoEdicion = false;
        public FormCalendario()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            con = new SqlConnection("server=DESKTOP-7OVDKFG; database= DAS;Integrated Security=true"); // Reemplaza con la cadena de conexión de tu base de datos
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Calendario", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void HabilitarControlesEdicion()
        {
            monthCalendar1.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtClublocal.Enabled = true;
            txtClubvisitante.Enabled = true;
            txtEstadio.Enabled = true;

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void DeshabilitarControlesEdicion()
        {
            monthCalendar1.Enabled = false;
            dateTimePicker1.Enabled = false;
            txtClublocal.Enabled = false;
            txtClubvisitante.Enabled = false;
            txtEstadio.Enabled = false;

            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            LimpiarCampos();
            HabilitarControlesEdicion();
            modoEdicion = false; // Cambiar a modo nuevo
        }
        private void HabilitarControles()
        {
            monthCalendar1.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtClublocal.Enabled = true;
            txtClubvisitante.Enabled = true;
            txtEstadio.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            monthCalendar1.SelectionStart = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            txtClublocal.Clear();
            txtClubvisitante.Clear();
            txtEstadio.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            con.Open();

            if (!modoEdicion)
            {
                // Nuevo registro
                cmd = new SqlCommand("INSERT INTO Calendario (fechapartido, horapartido, clublocal, clubvisitante, estadio) VALUES (@fecha, @hora, @local, @visitante, @estadio)", con);
            }
            else
            {
                // Modificar registro existente
                cmd = new SqlCommand("UPDATE Calendario SET fechapartido=@fecha, horapartido=@hora, clublocal=@local, clubvisitante=@visitante, estadio=@estadio WHERE id=@id", con);
                cmd.Parameters.AddWithValue("@id", selectedID);
            }

            cmd.Parameters.AddWithValue("@fecha", monthCalendar1.SelectionStart);
            cmd.Parameters.AddWithValue("@hora", dateTimePicker1.Value.TimeOfDay);
            cmd.Parameters.AddWithValue("@local", txtClublocal.Text);
            cmd.Parameters.AddWithValue("@visitante", txtClubvisitante.Text);
            cmd.Parameters.AddWithValue("@estadio", txtEstadio.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registro guardado correctamente.");

            LimpiarCampos();
            DeshabilitarControlesEdicion();

            MostrarDatos();

            // Habilitar el botón Nuevo después de guardar
            btnNuevo.Enabled = true;
            modoEdicion = true; // Cambiar a modo edición
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["id"].Value);
                monthCalendar1.SelectionStart = Convert.ToDateTime(row.Cells["fechapartido"].Value);
                TimeSpan horapartido = (TimeSpan)row.Cells["horapartido"].Value;
                dateTimePicker1.Value = DateTime.Today.Add(horapartido);
                txtClublocal.Text = row.Cells["clublocal"].Value.ToString();
                txtClubvisitante.Text = row.Cells["clubvisitante"].Value.ToString();
                txtEstadio.Text = row.Cells["estadio"].Value.ToString();

                DeshabilitarControlesEdicion();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarControlesEdicion();
            modoEdicion = true; // Cambiar a modo edición
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM Calendario WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@id", selectedID);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registro eliminado correctamente.");

            LimpiarCampos();
            DeshabilitarControlesEdicion();

            MostrarDatos();
        }
    }
}
