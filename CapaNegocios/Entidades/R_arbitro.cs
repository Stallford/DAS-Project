using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.Interface;
using Capa_Datos;
using System.Data;

namespace CapaNegocios.Entidades
{
    public class R_arbitro
    {
        private ManageSQL obj_capa_datos = new ManageSQL();
        private InterfaceNegocio obj_interface_datos = new InterfaceNegocio();
        private int id, edad;
        private string nombres, apellidos, correo, contraseña;

        public R_arbitro()
        {
            id = 0;
            edad = 0;
            nombres = string.Empty;
            apellidos = string.Empty;
            correo = string.Empty;
            contraseña = string.Empty;
        }

        public R_arbitro(int id, int edad, string nombres, string apellidos, string correo, string contraseña)
        {
            this.id = id;
            this.edad = edad;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.correo = correo;
            this.contraseña = contraseña;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public bool CrearArbitro(R_arbitro arbitro)
        {
            try
            {
                return obj_interface_datos.AgregarArbitro(arbitro.Nombres, arbitro.Apellidos, arbitro.Correo, arbitro.Contraseña, arbitro.Edad);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Crear Registro del Árbitro: " + e.Message);
            }
        }
        public DataTable getListaArbitro()
        {
            try
            {
                return obj_interface_datos.getListaArbitro();

            }
            catch (Exception e)
            {
                throw new Exception("Error al Obtener Listado de Arbitro", e);

            }
        }

        public DataTable getListaArbitroFiltrada(R_arbitro arbitro)
        {
            try
            {
                return obj_interface_datos.getListaArbitroFiltrada(arbitro.Nombres, arbitro.Apellidos);

            }
            catch (Exception e)
            {
                throw new Exception("Error al Buscar el Arbitro", e);
            }
        }

        public bool ActualizarArbitro(R_arbitro arbitro)
        {
            try
            {
                return obj_interface_datos.ModificarArbitro(arbitro.Id, arbitro.Nombres, arbitro.Apellidos, arbitro.Correo, arbitro.Contraseña, arbitro.Edad);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Actualizar Registro del Árbitro: " + e.Message);
            }
        }

        public bool EliminarArbitro(R_arbitro arbitro)
        {
            try
            {
                return obj_interface_datos.eliminarArbitro(arbitro.Id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Eliminar Árbitro: " + e.Message);
            }
        }
    }
}
