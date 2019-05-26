using ES.FX.Fibaro.Api.Devices.Interfaces;
using ES.FX.Fibaro.Json;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    internal class ArmConditions : IArmConditions
    {
        [JsonProperty("auto")]
        public bool Auto { get; set; }

        [JsonProperty("devices")]
        [JsonConverter(typeof(ConcreteTypeConverter<DeviceElement[]>))]
        public IDeviceElement[] Devices { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }
    }
}