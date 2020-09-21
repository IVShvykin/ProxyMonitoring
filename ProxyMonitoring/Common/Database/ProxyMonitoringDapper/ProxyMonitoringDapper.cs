using Common.Database.Connection;

namespace Common.Database.ProxyMonitoringDapper
{
    public class ProxyMonitoringDapper : BaseDapper.BaseDapper, IProxyMonitoringDapper
    {
        public ProxyMonitoringDapper(IConnection connection) : base(connection, connection.GetKcmEcmConnectionString())
        {
        }
    }
}
