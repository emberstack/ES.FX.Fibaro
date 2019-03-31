using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Fibaro.Devices.Internal.Models
{
    internal class DeviceModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roomID")]
        public long RoomId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("baseType", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseType { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("isPlugin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPlugin { get; set; }

        [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentId { get; set; }

        [JsonProperty("remoteGatewayId", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemoteGatewayId { get; set; }

        [JsonProperty("viewXml", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ViewXml { get; set; }

        [JsonProperty("configXml", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConfigXml { get; set; }

        [JsonProperty("interfaces", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Interfaces { get; set; }

        [JsonProperty("properties")]
        public JObject Properties { get; set; }

        [JsonProperty("actions")]
        public Dictionary<string, long> Actions { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("modified")]
        public long Modified { get; set; }

        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public object[] View { get; set; }
    }
}