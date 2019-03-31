using System;
using System.Threading.Tasks;
using ES.FX.Fibaro.Settings.Internal.Models;
using ES.FX.Fibaro.Settings.Models;

namespace ES.FX.Fibaro.Settings.Internal
{
    internal class LocationSettingsController : ILocationSettingsController
    {
        private readonly Lazy<ApiHttpClient> _apiClient;

        public LocationSettingsController(Lazy<ApiHttpClient> apiClient)
        {
            _apiClient = apiClient;
        }

        private ApiHttpClient ApiClient => _apiClient.Value;


        public async Task<ILocationSettingsModel> Get()
        {
            var response = await ApiClient.GetAsync<LocationSettingsModel>("api/settings/location");
            return response;
        }
    }
}