using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ES.FX.Fibaro
{
    public static class ApiHttpClientExtensions
    {
        public static async Task<T> GetAsync<T>(this HttpClient client, string requestUri, bool ensureSucces = true)
        {
            var response = await client.GetAsync(requestUri);
            if (ensureSucces) response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseContent);
        }
    }
}