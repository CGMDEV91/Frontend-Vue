using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using WebApi.Models;

namespace WebApi.ModelsDbConnections
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidenciaController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IncidenciaDbConnection _conexion = new IncidenciaDbConnection();

        public IncidenciaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                             select i.Id, i.Tipo, i.Descripcion, i.Completada, i.Fecha ,i.EmpleadoId, e.Nombre as Empleado
                             from Incidencias i,
                             Empleado e
                             where i.EmpleadoId = e.Id
                            ";

            DataTable table = new DataTable();
            _conexion.GetAll(query, _configuration, table);

            return new JsonResult(table);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            string query = @"
                             select i.Id, i.Tipo, i.Descripcion, i.Completada, i.Fecha , e.Nombre as Empleado
                             from Incidencias i,
                             Empleado e
                             where i.EmpleadoId = e.Id
                             and i.Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.GetById(query, _configuration, table, id);

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Incidencia incidencia)
        {
            string query = @"
                             insert into Incidencias
                             values (@Tipo,@Descripcion,@Completada,@Fecha,@EmpleadoId)
                            ";

            DataTable table = new DataTable();
            _conexion.Post(query, _configuration, table, incidencia);

            return new JsonResult("Incidencia Creada");
        }

        [HttpPut]
        public JsonResult Put(Incidencia incidencia)
        {
            string query = @"
                             update Incidencias
                             set Tipo = @Tipo,
                             Descripcion = @Descripcion,
                             Completada = @Completada,
                             Fecha = @Fecha,
                             EmpleadoId = @EmpleadoId
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.Put(query, _configuration, table, incidencia);

            return new JsonResult("Incidencia Actualizada");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                             delete from Incidencias
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.Delete(query, _configuration, table, id);

            return new JsonResult("Incidencia Eliminada");
        }
    }
}
