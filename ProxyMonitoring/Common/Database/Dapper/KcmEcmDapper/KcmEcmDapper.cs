using Common.Database.Connection;

namespace Common.Database.Dapper.KcmEcmDapper
{
    public class KcmEcmDapper : BaseDapper.BaseDapper, IKcmEcmDapper
    {
        public KcmEcmDapper(IConnection connection) : base(connection, connection.GetKcmEcmConnectionString())
        {
        }
    }
}
