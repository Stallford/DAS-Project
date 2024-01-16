using System.Data.SqlClient;
namespace Capa_Datos
{
    public class ConnectionDB
    {
        internal SqlConnection cadena_conexion = new SqlConnection("server=DESKTOP-7OVDKFG; database= DAS;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (cadena_conexion.State == System.Data.ConnectionState.Closed)
                cadena_conexion.Open();
            return cadena_conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (cadena_conexion.State == System.Data.ConnectionState.Open)
                cadena_conexion.Close();
            return cadena_conexion;

        }
    }
}
