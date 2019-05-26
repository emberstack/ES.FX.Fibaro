using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ES.FX.Fibaro.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddHomeCenterClient(this IServiceCollection services,
            HomeCenterConnectionStringBuilder connectionStringBuilder)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (connectionStringBuilder == null) throw new ArgumentNullException(nameof(connectionStringBuilder));
            services.AddHomeCenterClientFactory();
            services.AddScoped(provider =>
                provider.GetRequiredService<HomeCenterClientFactory>().CreateClient(connectionStringBuilder));
            return services;
        }

        public static IServiceCollection AddHomeCenterClientFactory(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddLogging();
            services.TryAddSingleton<IHomeCenterClientFactory, HomeCenterClientFactory>();
            return services;
        }
    }
}