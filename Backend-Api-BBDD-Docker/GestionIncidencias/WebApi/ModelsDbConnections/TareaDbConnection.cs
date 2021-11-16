using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApi.Models;

namespace WebApi.ModelsDbConnections
{
    public class TareaDbConnection
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

        public void Post(string query, IConfiguration configuration, DataTable table, Tarea tarea)
        {
            string sqlDataSource = dbConnection.Connection(configuration);

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Descripcion", tarea.Descripcion);
                    myCommand.Parameters.AddWithValue("@Completada", tarea.Completada);
                    myCommand.Parameters.AddWithValue("@Fecha", tarea.Fecha);
                    myCommand.Parameters.AddWithValue("@EmpleadoId", tarea.EmpleadoId);
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
        }

        public void Put(string query, IConfiguration configuration, DataTable table, Tarea tarea)
        {
            string sqlDataSource = dbConnection.Connection(configuration);

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Id", tarea.Id);
                    myCommand.Parameters.AddWithValue("@Descripcion", tarea.Descripcion);
                    myCommand.Parameters.AddWithValue("@Completada", tarea.Completada);
                    myCommand.Parameters.AddWithValue("@Fecha", tarea.Fecha);
                    myCommand.Parameters.AddWithValue("@EmpleadoId", tarea.EmpleadoId);
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
