using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Interface
{
    public class InterfaceNegocio
    {
        private ManageSQL obj = new ManageSQL();
        public bool AgregarArbitro(string nombres, string apellidos, string correo, string contrasena, int edad)
        {
            try
            {
                var listaParametros = new List<Parametros>
        {
            new() { Nombre = "nombres", Tipo = SqlDbType.VarChar, Valor = nombres },
            new() { Nombre = "apellidos", Tipo = SqlDbType.VarChar, Valor = apellidos },
            new() { Nombre = "correo", Tipo = SqlDbType.VarChar, Valor = correo },
            new() { Nombre = "contraseña", Tipo = SqlDbType.VarChar, Valor = contrasena },
            new() { Nombre = "edad", Tipo = SqlDbType.Int, Valor = edad }
        };

                return obj.ejecutaSP_NonQuery("SP_CREA_ARBITRO", listaParametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar árbitro: " + ex.Message);
            }
        }

        public DataTable getListaArbitro()
        {
            var listaParametros = new List<Parametros>();
            return obj.ejecutaSP_Query("SP_GET_LISTA_ARBITRO", listaParametros);
        }
        public DataTable getListaArbitroFiltrada(string nombres, string apellidos)
        {
            var listaParametros = new List<Parametros>
            {
                new() { Nombre = "nombres", Tipo = SqlDbType.VarChar, Valor = nombres },
                new() { Nombre = "apellidos", Tipo = SqlDbType.VarChar, Valor = apellidos }
            };
            return obj.ejecutaSP_Query("SP_GET_LISTA_ARBITRO_FILTRADA", listaParametros);
        }
        public bool ModificarArbitro(int id, string nombres, string apellidos, string correo, string contraseña, int edad)
        {
            try
            {
                var listaParametros = new List<Parametros>
                {
                    new() { Nombre = "id", Tipo = SqlDbType.Int, Valor = id },
                    new() { Nombre = "nombres", Tipo = SqlDbType.VarChar, Valor = nombres },
                    new() { Nombre = "apellidos", Tipo = SqlDbType.VarChar, Valor = apellidos },
                    new() { Nombre = "correo", Tipo = SqlDbType.VarChar, Valor = correo },
                    new() { Nombre = "contraseña", Tipo = SqlDbType.VarChar, Valor = contraseña },
                    new() { Nombre = "edad", Tipo = SqlDbType.Int, Valor = edad }
                };

                return obj.ejecutaSP_NonQuery("SP_ACTUALIZA_ARBITRO", listaParametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar árbitro: " + ex.Message);
            }
        }
        public bool eliminarArbitro(int id)
        {
            var listaParametros = new List<Parametros>
            {
                new() { Nombre = "id", Tipo = SqlDbType.Int, Valor = id }
            };

            return obj.ejecutaSP_NonQuery("SP_ELIMINA_ARBITRO", listaParametros);
        }
    }
}
