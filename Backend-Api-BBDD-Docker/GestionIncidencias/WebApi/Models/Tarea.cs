using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Tarea : ClaseBase
    {
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        public DateTime Fecha { get; set; }
        public int EmpleadoId { get; set; }
    }
}
