using ES.FX.Fibaro.Api.Devices.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    internal class FirmwareUpdate : IFirmwareUpdate
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