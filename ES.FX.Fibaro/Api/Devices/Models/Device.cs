using System.Collections.Generic;
using System.Runtime.Serialization;
using ES.FX.Fibaro.Api.Devices.Interfaces;
using ES.FX.Fibaro.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    public class Device : IDevice
    {
        [JsonIgnore]
        internal JObject JObject { get; set; }

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
        [JsonConverter(typeof(ConcreteTypeConverter<DeviceProperties>))]
        public IDeviceProperties Properties { get; set; }

        [JsonProperty("actions")]
        [JsonConverter(typeof(ConcreteTypeConverter<Dictionary<string, long>>))]
        public IReadOnlyDictionary<string, long> Actions { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("modified")]
        public long Modified { get; set; }

        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        public dynamic AsDynamic()
        {
            return JObject.ToObject<dynamic>();
        }

        public JObject AsJObject()
        {
            return JObject;
        }

        public string ToJsonString()
        {
            return JObject.ToString(Formatting.Indented);
        }

        [JsonExtensionData]
        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        public JObject ExtensionData { get; set; }

        public dynamic ExtensionDataDynamic { get; private set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            ExtensionDataDynamic = ExtensionData != null ? ExtensionData.ToObject<dynamic>() : new object();
        }
    }
}