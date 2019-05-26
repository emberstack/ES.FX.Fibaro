using ES.FX.Fibaro.Api.Devices.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    internal class Parameter : IParameter
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