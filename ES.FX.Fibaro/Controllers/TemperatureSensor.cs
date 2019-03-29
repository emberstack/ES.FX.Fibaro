using System.Threading.Tasks;
using ES.FX.Fibaro.Interfaces;

namespace ES.FX.Fibaro.Controllers
{
    internal class TemperatureSensor : DeviceInterface, ITemperatureSensor
    {
        public TemperatureSensor(SmartDevice device) : base(device)
        {
        }

        public Task<double> GetTemperatureAsync()
        {
            if (Device.Info.Properties == null) return Task.FromResult(0.0);
            var temperature = double.TryParse(Device.Info.Properties.Value, out var value) ? value : 0;
            return Task.FromResult(temperature);
        }
    }
}