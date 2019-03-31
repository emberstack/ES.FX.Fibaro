using ES.FX.Fibaro.Devices.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Devices.Internal.Models
{
    internal class RowElementModel : IRowElementModel
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

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }

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