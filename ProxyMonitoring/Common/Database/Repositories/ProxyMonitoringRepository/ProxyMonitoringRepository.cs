using Common.Database.Dapper.ProxyMonitoringDapper;
using Common.Database.Models.ProxyMonitroingModel;

namespace Common.Database.Repositories.ProxyMonitoringRepository
{
    public class ProxyMonitoringRepository : IProxyMonitoringRepository
    {
        private readonly IProxyMonitoringDapper _proxyMonitoringDapper;

        public ProxyMonitoringRepository(IProxyMonitoringDapper proxyMonitoringDapper)
        {
            _proxyMonitoringDapper = proxyMonitoringDapper;
        }
    }
}
