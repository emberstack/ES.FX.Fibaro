using System.Net.Http;
using System.Threading.Tasks;
using ES.FX.Fibaro.Api.Settings.Interfaces;
using ES.FX.Fibaro.Api.Settings.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Settings
{
    public class SettingsClient : ISettingsClient
    {
        public SettingsClient(HttpClient http)
        {
            Http = http;
        }

        public HttpClient Http { get; }

        public async Task<string> GetGeneralSettingsJson()
        {
            var response = await Http.GetStringAsync("api/settings/info");
            return response;
        }

        public async Task<IGeneralSettings> GetGeneralSettings()
        {
            var response = await GetGeneralSettingsJson();
            var result = JsonConvert.DeserializeObject<GeneralSettings>(response);
            return result;
        }


        public async Task<string> GetLocationSettingsJson()
        {
            var response = await Http.GetStringAsync("api/settings/location");
            return response;
        }

        public async Task<ILocationSettings> GetLocationSettings()
        {
            var response = await GetLocationSettingsJson();
            var result = JsonConvert.DeserializeObject<LocationSettings>(response);
            return result;
        }

        public async Task<string> GetNetworkSettingsJson()
        {
            var response = await Http.GetStringAsync("api/settings/network");
            return response;
        }

        public async Task<INetworkSettings> GetNetworkSettings()
        {
            var response = await GetNetworkSettingsJson();
            var result = JsonConvert.DeserializeObject<NetworkSettings>(response);
            return result;
        }
    }
}