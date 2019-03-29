using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Remote
{
    public class DeviceInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roomID")]
        public long RoomId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("baseType")]
        public string BaseType { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("isPlugin")]
        public bool? IsPlugin { get; set; }

        [JsonProperty("parentId")]
        public long? ParentId { get; set; }

        [JsonProperty("remoteGatewayId")]
        public long? RemoteGatewayId { get; set; }

        [JsonProperty("viewXml")]
        public bool? ViewXml { get; set; }

        [JsonProperty("configXml")]
        public bool? ConfigXml { get; set; }

        [JsonProperty("interfaces")]
        public string[] Interfaces { get; set; }

        [JsonProperty("actions")]
        public Dictionary<string, long> Actions { get; set; } = new Dictionary<string, long>();

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("modified")]
        public long Modified { get; set; }

        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("view")]
        public object[] View { get; set; }

        [JsonProperty("properties")]
        public DeviceProperties Properties { get; set; } = new DeviceProperties();

        public override string ToString()
        {
            return $"[{Id}]{Name}";
        }
    }
}