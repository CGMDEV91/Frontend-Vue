using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using WebApi.Models;
using WebApi.ModelsDbConnections;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private EmpresaDbConnection _conexion = new EmpresaDbConnection();

        public EmpresaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                             select Id, Nombre
                             from Empresa
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
                             from Empresa
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.GetById(query, _configuration, table, id);

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Empresa empresa)
        {
            string query = @"
                             insert into Empresa
                             values (@Nombre)
                            ";

            DataTable table = new DataTable();
            _conexion.Post(query, _configuration, table, empresa);

            return new JsonResult("Empresa Creada");
        }

        [HttpPut]
        public JsonResult Put(Empresa empresa)
        {
            string query = @"
                             update Empresa
                             set Nombre = @Nombre
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.Put(query, _configuration, table, empresa);

            return new JsonResult("Empresa Actualizada");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                             delete from Empresa
                             where Id = @Id
                            ";

            DataTable table = new DataTable();
            _conexion.Delete(query, _configuration, table, id);

            return new JsonResult("Empresa Eliminada");
        }
    }
}
