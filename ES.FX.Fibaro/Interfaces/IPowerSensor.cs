using System.Threading.Tasks;

namespace ES.FX.Fibaro.Interfaces
{
    public interface IPowerSensor : IDeviceInterface
    {
        Task<double> GetPowerLevelAsync();
    }
}