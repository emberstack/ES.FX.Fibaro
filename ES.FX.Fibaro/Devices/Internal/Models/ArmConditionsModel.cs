using ES.FX.Fibaro.Devices.Models;
using ES.FX.Fibaro.Json;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Devices.Internal.Models
{
    internal class ArmConditionsModel : IArmConditionsModel
    {
        [JsonProperty("auto")]
        public bool Auto { get; set; }

        [JsonProperty("devices")]
        [JsonConverter(typeof(ConcreteTypeConverter<DeviceElementModel[]>))]
        public IDeviceElementModel[] Devices { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }
    }
}