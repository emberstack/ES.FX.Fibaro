using ES.FX.Fibaro.Api.Devices.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    internal class RowElement : IRowElement
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("lua")]
        public bool Lua { get; set; }

        [JsonProperty("waitForResponse")]
        public bool WaitForResponse { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        // ReSharper disable once StringLiteralTypo
        [JsonProperty("favourite")]
        public bool Favorite { get; set; }

        [JsonProperty("main")]
        public bool Main { get; set; }

        [JsonProperty("empty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Empty { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("buttonIcon", NullValueHandling = NullValueHandling.Ignore)]
        public long? ButtonIcon { get; set; }
    }
}