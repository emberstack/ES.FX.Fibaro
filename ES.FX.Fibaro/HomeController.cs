using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ES.FX.Fibaro.Remote;
using Newtonsoft.Json;

namespace ES.FX.Fibaro
{
    public class HomeController
    {
        public HomeController(string hostAddress, string username, string password)
        {
            HostAddress = hostAddress;
            Username = username;
            ApiClient = new HttpClient {BaseAddress = new Uri(HostAddress)};
            ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}")));
        }

        private string HostAddress { get; }
        internal string Username { get; }


        internal HttpClient ApiClient { get; }

        public async Task<List<SmartDevice>> GetDevicesAsync()
        {
            var devices = new List<SmartDevice>();

            var rawResponse = await ApiClient.GetStringAsync("devices");
            var remoteDevices = JsonConvert.DeserializeObject<List<DeviceInfo>>(rawResponse);
            foreach (var remoteDevice in remoteDevices)
                devices.Add(new SmartDevice(remoteDevice.Id, this) {Info = remoteDevice});
            return devices;
        }

        public async Task<SmartDevice> GetDeviceAsync(long id)
        {
            var rawResponse = await ApiClient.GetStringAsync($"devices/{id}");
            var remoteDevice = JsonConvert.DeserializeObject<DeviceInfo>(rawResponse);
            return new SmartDevice(remoteDevice.Id, this) {Info = remoteDevice};
        }

        public async Task<LoginStatus> GetLoginStatus()
        {
            var rawResponse = await ApiClient.GetStringAsync("loginStatus");
            var response = JsonConvert.DeserializeObject<LoginStatus>(rawResponse);
            return response;
        }
    }
}