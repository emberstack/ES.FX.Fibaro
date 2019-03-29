using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ES.FX.Fibaro.Controllers;
using ES.FX.Fibaro.Interfaces;
using ES.FX.Fibaro.Remote;
using Newtonsoft.Json;

namespace ES.FX.Fibaro
{
    public class SmartDevice
    {
        public const string Provider = "com_fibaro_hc";


        private readonly List<IDeviceInterface> _deviceInterfaces = new List<IDeviceInterface>();

        private DeviceInfo _info;

        internal SmartDevice(long id, HomeController controller)
        {
            Id = id;
            ApiClient = controller.ApiClient;
        }

        public long Id { get; }

        public string Endpoint => $"{Provider}:{Id}";


        internal HttpClient ApiClient { get; }

        public DeviceInfo Info
        {
            get => _info;
            internal set
            {
                _info = value;
                OnInfoUpdated();
            }
        }

        public IReadOnlyList<IDeviceInterface> Interfaces => _deviceInterfaces;

        public async Task RefreshAsync()
        {
            var rawResponse = await ApiClient.GetStringAsync($"devices/{Id}");
            var remoteDevice = JsonConvert.DeserializeObject<DeviceInfo>(rawResponse);
            Info = remoteDevice;
        }

        public override string ToString()
        {
            return $"[{Id}]{Info.Name}";
        }

        private void OnInfoUpdated()
        {
            _deviceInterfaces.Clear();
            if (Info.Actions != null && Info.Actions.ContainsKey("turnOn") && Info.Actions.ContainsKey("turnOff"))
                _deviceInterfaces.Add(Info.Properties.IsLight != null && Info.Properties.IsLight.ToLower() == "true"
                    ? new LightSwitch(this)
                    : new PowerSwitch(this));

            if (Info.Interfaces != null && Info.Interfaces.Contains("power"))
            {
                var hasValues = Info.Properties.Power != null || Info.Properties.PowerConsumption != null;
                if (hasValues) _deviceInterfaces.Add(new PowerSensor(this));
            }

            if (Info.Type == "com.fibaro.temperatureSensor") _deviceInterfaces.Add(new TemperatureSensor(this));
        }
    }
}