using ES.FX.Fibaro.Devices.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Devices.Internal.Models
{
    internal class FirmwareUpdateModel : IFirmwareUpdateModel
    {
        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("progress")]
        public long Progress { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updateVersion")]
        public string UpdateVersion { get; set; }
    }
}