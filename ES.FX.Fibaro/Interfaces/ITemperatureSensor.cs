using System.Threading.Tasks;

namespace ES.FX.Fibaro.Interfaces
{
    public interface ITemperatureSensor : IDeviceInterface
    {
        Task<double> GetTemperatureAsync();
    }
}