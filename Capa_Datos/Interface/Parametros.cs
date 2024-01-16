using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Interface
{
    public class Parametros
    {
        public string? Nombre { get; set; }
        public SqlDbType Tipo { get; set; }
        public object? Valor { get; set; }

    }
}
