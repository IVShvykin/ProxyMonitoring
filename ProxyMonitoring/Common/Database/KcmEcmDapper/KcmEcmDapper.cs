using Common.Database.Connection;

namespace Common.Database.KcmEcmDapper
{
    public class KcmEcmDapper : BaseDapper.BaseDapper, IKcmEcmDapper
    {
        public KcmEcmDapper(IConnection connection) : base(connection, connection.GetKcmEcmConnectionString())
        {
        }
    }
}
