using System;
using System.Threading.Tasks;
using ES.FX.Fibaro.Settings.Internal.Models;
using ES.FX.Fibaro.Settings.Models;

namespace ES.FX.Fibaro.Settings.Internal
{
    internal class NetworkSettingsController : INetworkSettingsController
    {
        private readonly Lazy<ApiHttpClient> _apiClient;

        public NetworkSettingsController(Lazy<ApiHttpClient> apiClient)
        {
            _apiClient = apiClient;
        }

        private ApiHttpClient ApiClient => _apiClient.Value;


        public async Task<INetworkSettingsModel> Get()
        {
            var response = await ApiClient.GetAsync<NetworkSettingsModel>("api/settings/network");
            return response;
        }
    }
}