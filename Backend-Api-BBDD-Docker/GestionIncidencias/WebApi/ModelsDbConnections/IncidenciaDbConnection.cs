using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApi.Models;

namespace WebApi.ModelsDbConnections
{
    public class IncidenciaDbConnection
    {
        public void GetAll(string query, IConfiguration configuration, DataTable table)
        {
            string sqlDataSource = dbConnection.Connection(configuration);

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
        }
        public void GetById(string query, IConfiguration configuration, DataTable table, int id)
        {
            string sqlDataSource = dbConnection.Connection(configuration);

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id);
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
        }

        public void Post(string query, IConfiguration configuration, DataTable table, Incidencia incidencia)
        {
            string sqlDataSource = dbConnection.Connection(configuration);

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Tipo", incidencia.Tipo);
                    myCommand.Parameters.AddWithValue("@Descripcion", incidencia.Descripcion);
                    myCommand.Parameters.AddWithValue("@Completada", incidencia.Completada);
                    myCommand.Parameters.AddWithValue("@Fecha", incidencia.Fecha);
                    myCommand.Parameters.AddWithValue("@EmpleadoId", incidencia.EmpleadoId);
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
        }

        public void Put(string query, IConfiguration configuration, DataTable table, Incidencia incidencia)
        {
            string sqlDataSource = dbConnection.Connection(configuration);

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Id", incidencia.Id);
                    myCommand.Parameters.AddWithValue("@Tipo", incidencia.Tipo);
                    myCommand.Parameters.AddWithValue("@Descripcion", incidencia.Descripcion);
                    myCommand.Parameters.AddWithValue("@Completada", incidencia.Completada);
                    myCommand.Parameters.AddWithValue("@Fecha", incidencia.Fecha);
                    myCommand.Parameters.AddWithValue("@EmpleadoId", incidencia.EmpleadoId);
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
        }

        public void Delete(string query, IConfiguration configuration, DataTable table, int id)
        {
            string sqlDataSource = dbConnection.Connection(configuration);

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id);
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
        }
    }
}
