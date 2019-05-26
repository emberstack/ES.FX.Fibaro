using ES.FX.Fibaro.Api.Settings.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Settings.Models
{
    internal class Date : IDate
    {
        [JsonProperty("day")]
        public long Day { get; set; }

        [JsonProperty("month")]
        public long Month { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }
    }
}