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
    public partial class Asignacion : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-7OVDKFG; database=DAS;Integrated Security=true");
        private SqlCommand cmd;
        private int id1 = 0;
        private int id2 = 0;
        private int Calendario = 0;
        public Asignacion()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;

                // Abrir la conexión a la base de datos
                conexion.Open();

                // Obtener dos IDs aleatorios que cumplan con las condiciones
                id1 = ObtenerIdAleatorio();
                id2 = ObtenerIdAleatorio();
                if (id1 == id2)
                {
                    id2 = ObtenerIdAleatorio();
                }
                Calendario = ObtenerCalendario();

                //if (!GetIdPartido(Calendario))
                //{
                // Obtener y mostrar la información para el primer ID
                MostrarInformacion(id1, txtNombres, txtApellidos, txtCorreo);
                // Obtener y mostrar la información para el segundo ID
                MostrarInformacion(id2, txtNombres1, txtApellidos1, txtCorreo1);
                MostrarCalendario(Calendario, txtLocal, txtVisitante, txtFecha, txtLugar, txtHora);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                /*if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }*/
                conexion.Close();
            }
        }
        public int ObtenerTamanoTabla(string nombreTabla)
        {
            // Consulta SQL para obtener el tamaño de la tabla
            string consulta = $"SELECT COUNT(*) FROM {nombreTabla}";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                // Ejecutar la consulta y devolver el resultado
                int tamanoTabla = (int)comando.ExecuteScalar();
                return tamanoTabla;
            }
        }

        private bool GetIdPartido(int IdGame)
        {
            bool flaged = false;
            string consulta = "SELECT * FROM AsignacionArbitros WHERE idPartido = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@id", IdGame);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        //SI EL LECTOR LEE ALGO
                        flaged = true;
                    }
                }
            }

            return flaged;
        }


        private int ObtenerIdAleatorio()
        {
            // Generar una consulta SQL para obtener un ID aleatorio que cumpla con las condiciones
            string consulta = "SELECT TOP 1 id FROM Registroarbitro WHERE nombres IS NOT NULL AND apellidos IS NOT NULL ORDER BY NEWID()";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                // Ejecutar la consulta y devolver el ID obtenido
                return (int)comando.ExecuteScalar();
            }
        }
        private void MostrarInformacion(int id, TextBox txtNombres, TextBox txtApellidos, TextBox txtCorreo)
        {
            // Generar una consulta SQL para obtener la información asociada al ID
            string consulta = "SELECT nombres, apellidos, correo FROM Registroarbitro WHERE id = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                // Agregar parámetro para el ID
                comando.Parameters.AddWithValue("@id", id);

                // Ejecutar la consulta y obtener el lector de datos
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    // Verificar si hay datos y mostrarlos en los TextBox correspondientes
                    if (lector.Read())
                    {
                        txtNombres.Text = lector["nombres"].ToString();
                        txtApellidos.Text = lector["apellidos"].ToString();
                        txtCorreo.Text = lector["correo"].ToString();
                    }
                }
            }
        }
        //THIS FUNCTION IS FOR GET A RANDOM CALENDAR ABOUT A PLAY
        private int ObtenerCalendario()
        {
            string consulta = "SELECT TOP 1 id FROM Calendario WHERE clublocal IS NOT NULL AND clubvisitante IS NOT NULL ORDER BY NEWID()";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                // Ejecutar la consulta y devolver el ID obtenido
                return (int)comando.ExecuteScalar();
            }
        }
        //THIS FUNCTION IS FOR GET THE PARAMETER HOUR
        public string ObtenerHoraPorId(int id)
        {
            // Consulta SQL para obtener la hora por id
            string consulta = "SELECT horapartido FROM Calendario WHERE id = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                // Agregar parámetro para el id
                comando.Parameters.AddWithValue("@id", id);

                // Ejecutar la consulta y devolver el resultado como string
                string horaPartido = comando.ExecuteScalar()?.ToString();
                return horaPartido;
            }
        }

        private void MostrarCalendario(int id, TextBox txtLocal, TextBox txtVisitante, TextBox txtFecha, TextBox txtLugar, TextBox txtHora)
        {
            // Generar una consulta SQL para obtener la información asociada al ID
            string consulta = "SELECT clublocal, clubvisitante, fechapartido, horapartido, estadio FROM Calendario WHERE id = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                // Agregar parámetro para el ID
                comando.Parameters.AddWithValue("@id", id);

                // Ejecutar la consulta y obtener el lector de datos
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    // Verificar si hay datos y mostrarlos en los TextBox correspondientes
                    if (lector.Read())
                    {
                        txtLocal.Text = lector["clublocal"].ToString();
                        txtVisitante.Text = lector["clubvisitante"].ToString();
                        txtLugar.Text = lector["estadio"].ToString();
                        txtFecha.Text = lector["fechapartido"].ToString();
                        txtHora.Text = lector["horapartido"].ToString();
                    }
                }
            }
        }


        private void Asignacion_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                cmd = new SqlCommand(
                    "INSERT INTO AsignacionArbitros (idArbitroPrincipal, idArbitroSustituto, idPartido) VALUES (@idArbitroMain, @idArbitroSupport, @idPlay)", conexion);
                // Establecer parámetros para la actualización
                cmd.Parameters.AddWithValue("@idArbitroMain", id1);
                cmd.Parameters.AddWithValue("@idArbitroSupport", id2);
                cmd.Parameters.AddWithValue("@idPlay", Calendario);

                // Ejecutar la consulta de actualización
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}