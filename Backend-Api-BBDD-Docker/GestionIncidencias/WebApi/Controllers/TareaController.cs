using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using WebApi.Models;

namespace WebApi.ModelsDbConnections
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private TareaDbConnection _conexion = new TareaDbConnection();

        public TareaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                             select t.Id, t.Descripcion, t.Completada, t.Fecha , e.Nombre as Empleado
                             from Tareas t,
                             Empleado e
                             where t.EmpleadoId = e.Id
                            ";

            DataTable table = new DataTable();
            _conexion.GetAll(query, _configuration, table);

            return new JsonResult(table);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            string query = @"
                             select t.Id, t.Descripcion, t.Completada, t.Fecha , e.Nombre as Empleado
                             from Tareas t,
                             Empleado e
                             where t.EmpleadoId = e.Id
                             and t.Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.GetById(query, _configuration, table, id);

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Tarea tarea)
        {
            string query = @"
                             insert into Tareas
                             values (@Descripcion,@Completada,@Fecha,@EmpleadoId)
                            ";

            DataTable table = new DataTable();
            _conexion.Post(query, _configuration, table, tarea);

            return new JsonResult("Tarea Creada");
        }

        [HttpPut]
        public JsonResult Put(Tarea tarea)
        {
            string query = @"
                             update Tareas
                             set Descripcion = @Descripcion,
                             Completada = @Completada,
                             Fecha = @Fecha,
                             EmpleadoId = @EmpleadoId
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.Put(query, _configuration, table, tarea);

            return new JsonResult("Tarea Actualizada");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                             delete from Tareas
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.Delete(query, _configuration, table, id);

            return new JsonResult("Tarea Eliminada");
        }
    }
}
