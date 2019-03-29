using System.Net.Http;

namespace ES.FX.Fibaro.Controllers
{
    internal abstract class DeviceInterface
    {
        protected DeviceInterface(SmartDevice device)
        {
            Device = device;
        }

        protected SmartDevice Device { get; }
        protected HttpClient ApiClient => Device.ApiClient;
    }
}