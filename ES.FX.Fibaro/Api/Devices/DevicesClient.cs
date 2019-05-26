using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ES.FX.Fibaro.Api.Devices.Interfaces;
using ES.FX.Fibaro.Api.Devices.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Fibaro.Api.Devices
{
    public class DevicesClient : IDevicesClient
    {
        public DevicesClient(HttpClient http)
        {
            Http = http;
        }

        public HttpClient Http { get; }

        public async Task<string> GetJson(long id)
        {
            var result = await Http.GetStringAsync($"api/devices/{id}");
            return result;
        }

        public async Task<IDevice> Get(long id)
        {
            var response = await GetJson(id);
            var jObject = JsonConvert.DeserializeObject<JObject>(response);
            var result = JObjectToDevice(jObject);
            return result;
        }


        public async Task<string> ListJson()
        {
            var response = await Http.GetStringAsync("api/devices");
            return response;
        }

        public async Task<IReadOnlyList<IDevice>> List()
        {
            var response = await ListJson();
            var listJObject = JsonConvert.DeserializeObject<List<JObject>>(response);
            var result = listJObject.Select(JObjectToDevice).ToList();
            return result;
        }

        public async Task<IReadOnlyDictionary<long, IDevice>> ListAsDictionary()
        {
            var items = await List();
            var result = items.ToDictionary(s => s.Id, s => s);
            return result;
        }

        public async Task<IDevice> Update(long id, object patch)
        {
            var patchJson = JsonConvert.SerializeObject(patch,Formatting.Indented);
            var httpResponse = await Http.PutAsync($"api/devices/{id}",
                new StringContent(patchJson, Encoding.UTF8, "application/json"));
            httpResponse.EnsureSuccessStatusCode();
            var response = await httpResponse.Content.ReadAsStringAsync();
            var jObject = JsonConvert.DeserializeObject<JObject>(response);
            var result = JObjectToDevice(jObject);
            return result;
        }

        public async Task CallAction(long id, string action)
        {
            var result = await Http.PostAsync($"api/devices/{id}/action/{action}", null);
            result.EnsureSuccessStatusCode();
        }

        private Device JObjectToDevice(JObject jObject)
        {
            var device = jObject.ToObject<Device>();
            device.JObject = jObject;
            return device;
        }
    }
}