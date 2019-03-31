using ES.FX.Fibaro.Settings.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Settings.Internal.Models
{
    internal class CurrentVersionModel : ICurrentVersionModel
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}