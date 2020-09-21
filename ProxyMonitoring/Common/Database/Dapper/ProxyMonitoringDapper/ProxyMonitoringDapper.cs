using Common.Database.Connection;

namespace Common.Database.Dapper.ProxyMonitoringDapper
{
    public class ProxyMonitoringDapper : BaseDapper.BaseDapper, IProxyMonitoringDapper
    {
        public ProxyMonitoringDapper(IConnection connection) : base(connection, connection.GetKcmEcmConnectionString())
        {
        }
    }
}
