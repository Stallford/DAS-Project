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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presentacion.Formularios
{
    public partial class FrmSituaciones : Form
    {
        private string connectionString = "server=DESKTOP-7OVDKFG; database=DAS;Integrated Security=true";
        public FrmSituaciones()
        {
            InitializeComponent();
        }


        private void FrmSituaciones_Load(object sender, EventArgs e)
        {
            CargarNombresEnComboBox();
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombre.SelectedItem != null)
            {
                ArbitroItem selectedArbitro = (ArbitroItem)cmbNombre.SelectedItem;
                CargarLugarEnComboBox(selectedArbitro.Id);
                MostrarDatosArbitro(selectedArbitro.Id);
            }
        }
        private void CargarNombresEnComboBox()
        {
            cmbNombre.Items.Clear(); // Limpiar el ComboBox antes de cargar nuevos datos

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, nombres FROM Registroarbitro";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            cmbNombre.Items.Add(new ArbitroItem(id, nombre)); // Puedes definir una clase ArbitroItem para almacenar id y nombre
                        }
                    }
                }
            }
        }
        private void MostrarDatosArbitro(int idArbitro)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT apellidos, correo FROM Registroarbitro WHERE id = @idArbitro";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idArbitro", idArbitro);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtApellidos.Text = reader.GetString(0);
                            txtCorreo.Text = reader.GetString(1);
                        }
                    }
                }
            }
        }
        public class ArbitroItem
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public ArbitroItem(int id, string nombre)
            {
                Id = id;
                Nombre = nombre;
            }

            public override string ToString()
            {
                return Nombre;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbLugar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLugar1.SelectedItem != null)
            {
                LugarItem selectedLugar = (LugarItem)cmbLugar1.SelectedItem;
                MostrarDatosLugar(selectedLugar.Id);
            }
        }
        private void CargarLugarEnComboBox(int idArbitro)
        {
            cmbLugar1.Items.Clear(); // Limpiar el ComboBox antes de cargar nuevos datos

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Modificar la consulta para filtrar por el idArbitro
                string query = "SELECT c.id, c.estadio FROM Calendario c " +
                               "INNER JOIN AsignacionArbitros a ON c.id = a.idPartido " +
                               "WHERE a.idArbitroPrincipal = @idArbitro";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idArbitro", idArbitro);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string estadio = reader.GetString(1);
                            cmbLugar1.Items.Add(new LugarItem(id, estadio));
                        }
                    }
                }
            }
        }
        private void MostrarDatosLugar(int idLugar)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT clublocal, clubvisitante FROM Calendario WHERE id = @idLugar";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idLugar", idLugar);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtVisitante.Text = reader.GetString(0);
                            txtLocal.Text = reader.GetString(1);
                        }
                    }
                }
            }
        }
        public class LugarItem
        {
            public int Id { get; set; }
            public string Estadio { get; set; }

            public LugarItem(int id, string estadio)
            {
                Id = id;
                Estadio = estadio;
            }

            public override string ToString()
            {
                return Estadio;
            }
        }
        private void ReiniciarControles()
        {
            // Reiniciar ComboBox cmbNombre
            cmbNombre.SelectedIndex = -1;
            cmbNombre.Items.Clear();
            CargarNombresEnComboBox();  // Volver a cargar los nombres en el ComboBox

            // Reiniciar ComboBox cmbLugar1
            cmbLugar1.SelectedIndex = -1;
            cmbLugar1.Items.Clear();

            // Reiniciar TextBoxes
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtLocal.Text = "";
            txtVisitante.Text = "";
            txtJustifiacion.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (cmbNombre.SelectedItem != null && cmbLugar1.SelectedItem != null)
            {
                ArbitroItem selectedArbitro = (ArbitroItem)cmbNombre.SelectedItem;
                LugarItem selectedLugar = (LugarItem)cmbLugar1.SelectedItem;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO DatosGuardados (idarbitro, idlugar, apellidos, correo, clublocal, clubvisitante, justificacion) " +
                                   "VALUES (@idarbitro, @idlugar, @apellidos, @correo, @clublocal, @clubvisitante, @justificacion)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idarbitro", selectedArbitro.Id);
                        command.Parameters.AddWithValue("@idlugar", selectedLugar.Id);
                        command.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                        command.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        command.Parameters.AddWithValue("@clublocal", txtLocal.Text);
                        command.Parameters.AddWithValue("@clubvisitante", txtVisitante.Text);
                        command.Parameters.AddWithValue("@justificacion", txtJustifiacion.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Se Registro Correctamente");
                        ReiniciarControles();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
