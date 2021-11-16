using Microsoft.Extensions.Configuration;
using System;

namespace WebApi.ModelsDbConnections
{
    public class dbConnection
    {
        public static string Connection(IConfiguration configuration)
        {
            IConfiguration _configuration = configuration;
            string sqlDataSource = _configuration.GetConnectionString("DatabaseConnection");
            return sqlDataSource;
        }
    }
}
