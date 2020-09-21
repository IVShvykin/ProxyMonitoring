using System.Data.SqlClient;

namespace Common.Database.Dapper.BaseDapper
{
    public interface IBaseDapper
    {
        SqlConnection DapperSqlConnection { get; }
    }
}
