using System.Threading.Tasks;
using ES.FX.Fibaro.Interfaces;

namespace ES.FX.Fibaro.Controllers
{
    internal class PowerSensor : DeviceInterface, IPowerSensor
    {
        public PowerSensor(SmartDevice device) : base(device)
        {
        }

        public Task<double> GetPowerLevelAsync()
        {
            if (Device.Info.Properties == null) return Task.FromResult(0.0);
            double.TryParse(Device.Info.Properties.Power ?? string.Empty, out var power);
            double.TryParse(Device.Info.Properties.PowerConsumption ?? string.Empty, out var powerConsumption);
            return Task.FromResult(power > 0.0 ? power : powerConsumption);
        }
    }
}