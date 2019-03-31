using System.Collections.Generic;
using System.Threading.Tasks;

namespace ES.FX.Fibaro.Devices
{
    public interface IDevicesController
    {
        Task<IReadOnlyList<IDeviceController>> List();
        Task<IReadOnlyDictionary<long, IDeviceController>> ListKeyed();
        Task<IDeviceController> GetById(long id);
    }
}