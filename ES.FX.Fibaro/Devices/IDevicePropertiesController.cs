using System.Collections.Generic;
using ES.FX.Fibaro.Devices.Models;

namespace ES.FX.Fibaro.Devices
{
    public interface IDevicePropertiesController : IReadOnlyDictionary<string, object>
    {
        dynamic Dynamic { get; }
        IDevicePropertiesModel Managed { get; }
    }
}