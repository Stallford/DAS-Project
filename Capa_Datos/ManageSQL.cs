using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa_Datos;
using System.Data;
using Capa_Datos.Interface;

namespace Capa_Datos
{
    public class ManageSQL
    {
        private ConnectionDB conn = new ConnectionDB();
        //ejecuta sentencias SQL insert, update, delete
        public bool EjecutarSQL(string sql)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn.AbrirConexion();
            var resultado = command.ExecuteNonQuery();
            conn.CerrarConexion();
            if (resultado > 0)
                return true;
            else return false;


        }

        public DataTable EjecutarSelect(string sql)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        public DataTable EjecutarSPselect(string nombre_sp)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombre_sp;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        public DataTable EjecutarSPSelectParametro(string nombre_sp, int p_id_alumno)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombre_sp;
            command.Parameters.Add("IdAlumno", SqlDbType.Int).Value = p_id_alumno;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        public DataTable ejecutaSP_Query(string nombre_sp, List<Parametros> lista)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombre_sp;
            foreach (var parametro in lista)
            {
                command.Parameters.Add(parametro.Nombre, parametro.Tipo).Value = parametro.Valor;
            }
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        public bool ejecutaSP_NonQuery(string nombre_sp, List<Parametros> lista)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombre_sp;
            foreach (var parametro in lista)
            {
                command.Parameters.Add(parametro.Nombre, parametro.Tipo).Value = parametro.Valor;
            }
            command.Connection = conn.AbrirConexion();
            var resultado = command.ExecuteNonQuery();
            conn.CerrarConexion();
            if (resultado > 0)
                return true;
            else return false;
        }
    }
}
