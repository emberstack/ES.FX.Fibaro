using ES.FX.Fibaro.Api.Settings.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Settings.Models
{
    internal class CurrentVersion : ICurrentVersion
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}