using ES.FX.Fibaro.Api.Devices.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    internal class Icon : IIcon
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}