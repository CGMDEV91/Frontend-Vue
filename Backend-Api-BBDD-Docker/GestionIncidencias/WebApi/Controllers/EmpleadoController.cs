using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private EmpleadoDbConnection _conexion = new EmpleadoDbConnection();

        public EmpleadoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                             select emp.Id,emp.Nombre, e.Nombre as Empresa
                             from Empleado emp,
                             Empresa e
                             where emp.EmpresaId = e.Id
                            ";

            DataTable table = new DataTable();
            _conexion.GetAll(query, _configuration, table);

            return new JsonResult(table);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            string query = @"
                             select *
                             from Empleado
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.GetById(query, _configuration, table, id);

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Empleado empleado)
        {
            string query = @"
                             insert into Empleado
                             values (@Nombre,@EmpresaId)
                            ";

            DataTable table = new DataTable();
            _conexion.Post(query, _configuration, table, empleado);

            return new JsonResult("Empleado Creado");
        }

        [HttpPut]
        public JsonResult Put(Empleado empleado)
        {
            string query = @"
                             update Empleado
                             set Nombre = @Nombre,EmpresaId = @EmpresaId
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.Put(query, _configuration, table, empleado);

            return new JsonResult("Empleado Actualizado");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                             delete from Empleado
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.Delete(query, _configuration, table, id);

            return new JsonResult("Empleado Eliminado");
        }
    }
}
