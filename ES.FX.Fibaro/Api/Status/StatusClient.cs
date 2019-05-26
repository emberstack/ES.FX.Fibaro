using System.Net.Http;
using System.Threading.Tasks;
using ES.FX.Fibaro.Api.Status.Interfaces;
using ES.FX.Fibaro.Api.Status.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Status
{
    public class StatusClient : IStatusClient
    {
        public StatusClient(HttpClient http)
        {
            Http = http;
        }

        public HttpClient Http { get; }


        public async Task<string> GetLoginStatusJson()
        {
            var response = await Http.GetStringAsync("api/loginStatus");
            return response;
        }

        public async Task<ILoginStatus> GetLoginStatus()
        {
            var response = await GetLoginStatusJson();
            var result = JsonConvert.DeserializeObject<LoginStatus>(response);
            return result;
        }
    }
}