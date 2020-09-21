﻿using Microsoft.Extensions.DependencyInjection;
using Common.Database.Connection;
using Common.Database.Dapper.KcmEcmDapper;
using Common.Database.Dapper.ProxyMonitoringDapper;
using Common.Database.Repositories.KcmEcmRepository;
using Common.Database.Repositories.ProxyMonitoringRepository;

namespace Common
{
    public static class DependencyHelper
    {
        public static void RegisterCommonBase(this IServiceCollection serviceCollection) 
        {
            serviceCollection.AddSingleton<IConnection, Connection>();
            serviceCollection.AddScoped<IKcmEcmDapper, KcmEcmDapper>();
            serviceCollection.AddScoped<IProxyMonitoringDapper, ProxyMonitoringDapper>();
            serviceCollection.AddScoped<IKcmEcmRepository, KcmEcmRepository>();
            serviceCollection.AddScoped<IProxyMonitoringRepository, ProxyMonitoringRepository>();
        }
    }
}
