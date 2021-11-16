using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApi.ModelsDbConnections;

namespace WebApi.Models
{
    public class EmpleadoDbConnection
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

        public void Post(string query, IConfiguration configuration, DataTable table, Empleado empleado)
        {
            string sqlDataSource = dbConnection.Connection(configuration);

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    myCommand.Parameters.AddWithValue("@EmpresaId", empleado.EmpresaId);
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
        }

        public void Put(string query, IConfiguration configuration, DataTable table, Empleado empleado)
        {
            string sqlDataSource = dbConnection.Connection(configuration);

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Id", empleado.Id);
                    myCommand.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    myCommand.Parameters.AddWithValue("@EmpresaId", empleado.EmpresaId);
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
