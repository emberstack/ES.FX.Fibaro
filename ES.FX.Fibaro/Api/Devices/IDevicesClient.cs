using System.Collections.Generic;
using System.Threading.Tasks;
using ES.FX.Fibaro.Api.Devices.Interfaces;
using ES.FX.Fibaro.Api.Status.Models;

namespace ES.FX.Fibaro.Api.Devices
{
    public interface IDevicesClient
    {
        Task<string> GetJson(long id);
        Task<IDevice> Get(long id);
        Task<string> ListJson();
        Task<IReadOnlyList<IDevice>> List();
        Task<IReadOnlyDictionary<long, IDevice>> ListAsDictionary();

        Task<IDevice> Update(long id, object patch);
        Task CallAction(long id, string action);
    }
}