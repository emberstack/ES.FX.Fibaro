using ES.FX.Fibaro.Devices.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Devices.Internal.Models
{
    internal class IconModel : IIconModel
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}