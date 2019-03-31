using ES.FX.Fibaro.Settings.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Settings.Internal.Models
{
    internal class DateModel : IDateModel
    {
        [JsonProperty("day")]
        public long Day { get; set; }

        [JsonProperty("month")]
        public long Month { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }
    }
}