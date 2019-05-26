using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace ES.FX.Fibaro.Api.Devices.Interfaces
{
    public interface IDevice
    {
        long Id { get; }
        string Name { get; }
        long RoomId { get; }
        string Type { get; }
        string BaseType { get; }
        bool Enabled { get; }
        bool Visible { get; }
        bool? IsPlugin { get; }
        long? ParentId { get; }
        long? RemoteGatewayId { get; }
        bool? ViewXml { get; }
        bool? ConfigXml { get; }
        string[] Interfaces { get; }
        IDeviceProperties Properties { get; }
        IReadOnlyDictionary<string, long> Actions { get; }
        long Created { get; }
        long Modified { get; }
        long SortOrder { get; }

        JObject ExtensionData { get; }
        dynamic ExtensionDataDynamic { get; }

        dynamic AsDynamic();
        JObject AsJObject();
        string ToJsonString();
    }
}