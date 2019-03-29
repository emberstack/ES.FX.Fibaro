using System.Threading.Tasks;

namespace ES.FX.Fibaro.Interfaces
{
    public interface IPowerSwitch : IDeviceInterface
    {
        Task TurnOnAsync();
        Task TurnOffAsync();
        Task SwitchAsync(bool on);
        Task<bool> GetStatusAsync();
    }
}