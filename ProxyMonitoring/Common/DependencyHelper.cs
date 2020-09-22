using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Common.Database.Connection;
using Common.Database.Dapper.KcmEcmDapper;
using Common.Database.Dapper.ProxyMonitoringDapper;
using Common.Database.Repositories.KcmEcmRepository;
using Common.Database.Repositories.ProxyMonitoringRepository;
using Common.Helpers;

namespace Common
{
    public static class DependencyHelper
    {
        private static MapperConfiguration mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<AutoMapperProfile>();
        });
        public static void AddCommonBase(this IServiceCollection serviceCollection) 
        {
            serviceCollection.AddSingleton<IConnection, Connection>();
            serviceCollection.AddScoped<IKcmEcmDapper, KcmEcmDapper>();
            serviceCollection.AddScoped<IProxyMonitoringDapper, ProxyMonitoringDapper>();
            serviceCollection.AddScoped<IKcmEcmRepository, KcmEcmRepository>();
            serviceCollection.AddScoped<IProxyMonitoringRepository, ProxyMonitoringRepository>();
        }

        public static void AddMapping(this IServiceCollection serviceCollection)
        {
            mapperConfig.AssertConfigurationIsValid();
            IMapper mapper = mapperConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);
            MapperHelper.Mapper = mapper;
        }
    }
}
