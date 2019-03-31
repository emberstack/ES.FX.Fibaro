using System.Collections.Generic;
using System.Threading.Tasks;

namespace ES.FX.Fibaro.Devices
{
    public interface IDeviceController
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
        IReadOnlyDictionary<string, long> Actions { get; }
        long Created { get; }
        long Modified { get; }
        long SortOrder { get; }
        object[] View { get; }
        IDevicePropertiesController Properties { get; }

        Task RunAction(string actionName);
    }
}