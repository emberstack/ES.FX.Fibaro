using ES.FX.Fibaro.Devices.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Devices.Internal.Models
{
    internal class DeviceElementModel : IDeviceElementModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyValue")]
        public string PropertyValue { get; set; }
    }
}