using ES.FX.Fibaro.Devices.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Devices.Internal.Models
{
    internal class ParameterModel : IParameterModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("lastReportedValue", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastReportedValue { get; set; }

        [JsonProperty("lastSetValue", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastSetValue { get; set; }
    }
}