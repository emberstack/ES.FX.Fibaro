using ES.FX.Fibaro.Api.Devices.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    internal class DeviceElement : IDeviceElement
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyValue")]
        public string PropertyValue { get; set; }
    }
}