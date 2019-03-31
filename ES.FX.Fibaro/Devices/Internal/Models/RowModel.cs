using ES.FX.Fibaro.Devices.Models;
using ES.FX.Fibaro.Json;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Devices.Internal.Models
{
    internal class RowModel : IRowModel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("elements")]
        [JsonConverter(typeof(ConcreteTypeConverter<RowElementModel[]>))]
        public IRowElementModel[] Elements { get; set; }
    }
}