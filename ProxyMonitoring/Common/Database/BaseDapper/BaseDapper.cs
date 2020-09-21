using Common.Database.Connection;
using System.Data.SqlClient;

namespace Common.Database.BaseDapper
{
    public class BaseDapper
    {
        protected readonly IConnection _connection;
        public SqlConnection DapperSqlConnection { get; }
        public BaseDapper(IConnection connection, string connectionString)
        {
            _connection = connection;
            DapperSqlConnection = new SqlConnection(connectionString);
        }
    }
}
