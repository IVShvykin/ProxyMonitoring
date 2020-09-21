using Common.Database.Connection;
using System.Data.SqlClient;

namespace Common.Database.Dapper.BaseDapper
{
    public class BaseDapper : IBaseDapper
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
