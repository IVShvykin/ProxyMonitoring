using Microsoft.Extensions.Configuration;

namespace Common.Database.Connection
{
    public class Connection : IConnection
    {
        private static string KcmEcmConnectionString = "KcmEcmConnectionString";
        private static string ProxyMonitroingConnectionString = "ProxyMonitoringConnectionString";

        private readonly IConfiguration _configuration;

        public Connection(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetKcmEcmConnectionString()
        {
            return _configuration.GetConnectionString(KcmEcmConnectionString);
        }

        public string GetProxyMonitoringConnectionString()
        {
            return _configuration.GetConnectionString(ProxyMonitroingConnectionString);
        }
    }
}
