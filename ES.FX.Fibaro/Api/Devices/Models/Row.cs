using ES.FX.Fibaro.Api.Devices.Interfaces;
using ES.FX.Fibaro.Json;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    internal class Row : IRow
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("elements")]
        [JsonConverter(typeof(ConcreteTypeConverter<RowElement[]>))]
        public IRowElement[] Elements { get; set; }
    }
}