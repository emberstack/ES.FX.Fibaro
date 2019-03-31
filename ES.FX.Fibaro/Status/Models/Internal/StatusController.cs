using System;
using System.Threading.Tasks;
using ES.FX.Fibaro.Status.Models.Internal.Models;

namespace ES.FX.Fibaro.Status.Models.Internal
{
    internal class StatusController : IStatusController
    {
        private readonly Lazy<ApiHttpClient> _apiClient;

        public StatusController(Lazy<ApiHttpClient> apiClient)
        {
            _apiClient = apiClient;
        }

        private ApiHttpClient ApiClient => _apiClient.Value;


        public async Task<ILoginStatus> GetLoginStatus()
        {
            return await ApiClient.GetAsync<LoginStatus>("api/loginStatus");
        }
    }
}