using Microsoft.Extensions.DependencyInjection;
using Common.Database.Connection;
using Common.Database.KcmEcmDapper;
using Common.Database.ProxyMonitoringDapper;

namespace Common
{
    public static class DependencyHelper
    {
        public static void RegisterCommonBase(this IServiceCollection serviceCollection) 
        {
            serviceCollection.AddSingleton<IConnection, Connection>();
            serviceCollection.AddTransient<IKcmEcmDapper, KcmEcmDapper>();
            serviceCollection.AddTransient<IProxyMonitoringDapper, ProxyMonitoringDapper>();
        }
    }
}
