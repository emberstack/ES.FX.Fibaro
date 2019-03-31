using ES.FX.Fibaro.Settings.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Settings.Internal.Models
{
    internal class NetworkSettingsModel : INetworkSettingsModel
    {
        [JsonProperty("dhcp")]
        public bool Dhcp { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("mask")]
        public string Mask { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("dns")]
        public string Dns { get; set; }

        [JsonProperty("remoteAccess")]
        public bool RemoteAccess { get; set; }

        [JsonProperty("remoteAccessSupport")]
        public long RemoteAccessSupport { get; set; }
    }
}