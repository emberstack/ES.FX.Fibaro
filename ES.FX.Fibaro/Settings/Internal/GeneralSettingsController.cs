using System;
using System.Threading.Tasks;
using ES.FX.Fibaro.Settings.Internal.Models;
using ES.FX.Fibaro.Settings.Models;

namespace ES.FX.Fibaro.Settings.Internal
{
    internal class GeneralSettingsController : IGeneralSettingsController
    {
        private readonly Lazy<ApiHttpClient> _apiClient;

        public GeneralSettingsController(Lazy<ApiHttpClient> apiClient)
        {
            _apiClient = apiClient;
        }

        private ApiHttpClient ApiClient => _apiClient.Value;


        public async Task<IGeneralSettingsModel> Get()
        {
            var response = await ApiClient.GetAsync<GeneralSettingsModel>("api/settings/info");
            return response;
        }
    }
}