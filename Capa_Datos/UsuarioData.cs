using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class UsuarioData
    {
        private readonly ConnectionDB conexion = new ConnectionDB();

        public bool VerificarCredenciales(string usuario, string contraseña)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT COUNT(*) FROM Usuario WHERE usuario = @Usuario AND contraseña = @Contraseña";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar credenciales: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
