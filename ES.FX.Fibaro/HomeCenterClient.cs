using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using ES.FX.Fibaro.Api.Devices;
using ES.FX.Fibaro.Api.Settings;
using ES.FX.Fibaro.Api.Status;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ES.FX.Fibaro
{
    public class HomeCenterClient : IHomeCenterClient
    {
        private readonly ServiceProvider _serviceProvider;

        public HomeCenterClient(HomeCenterConnectionStringBuilder builder, ILoggerFactory loggerFactory)
        {
            void ConfigureApiHttpClient(HttpClient client)
            {
                client.BaseAddress = new Uri(builder.Endpoint);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(
                        $"{builder.Username}:{builder.Password}")));
                client.DefaultRequestHeaders.Add("X-Fibaro-Version", "2");
            }

            var services = new ServiceCollection();
            services.AddSingleton(loggerFactory ?? new LoggerFactory());

            services.AddHttpClient(nameof(HttpClient), ConfigureApiHttpClient);
            services.AddHttpClient<IDevicesClient, DevicesClient>(ConfigureApiHttpClient);
            services.AddHttpClient<IStatusClient, StatusClient>(ConfigureApiHttpClient);
            services.AddHttpClient<ISettingsClient, SettingsClient>(ConfigureApiHttpClient);

            _serviceProvider = services.BuildServiceProvider();
        }

        public HttpClient HttpClient => _serviceProvider.GetRequiredService<IHttpClientFactory>()
            .CreateClient(nameof(HttpClient));

        public IDevicesClient Devices => _serviceProvider.GetRequiredService<IDevicesClient>();
        public IStatusClient Status => _serviceProvider.GetRequiredService<IStatusClient>();
        public ISettingsClient Settings => _serviceProvider.GetRequiredService<ISettingsClient>();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (disposing) _serviceProvider?.Dispose();
        }
    }
}