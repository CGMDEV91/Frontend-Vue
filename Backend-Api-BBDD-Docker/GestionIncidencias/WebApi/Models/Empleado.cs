using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Empleado : ClaseBase
    {
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
    }
}
