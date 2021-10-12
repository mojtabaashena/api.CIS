using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace api.CIS.Data
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Connection");
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
