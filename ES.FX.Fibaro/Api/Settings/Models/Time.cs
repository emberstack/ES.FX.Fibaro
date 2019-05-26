using ES.FX.Fibaro.Api.Settings.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Settings.Models
{
    internal class Time : ITime
    {
        [JsonProperty("hour")]
        public long Hour { get; set; }

        [JsonProperty("minute")]
        public long Minute { get; set; }
    }
}