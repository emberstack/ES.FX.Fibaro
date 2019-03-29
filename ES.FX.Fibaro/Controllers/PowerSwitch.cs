using System.Threading.Tasks;
using ES.FX.Fibaro.Interfaces;

namespace ES.FX.Fibaro.Controllers
{
    internal class PowerSwitch : DeviceInterface, IPowerSwitch
    {
        public PowerSwitch(SmartDevice device) : base(device)
        {
        }

        public async Task TurnOnAsync()
        {
            await Device.ApiClient.PostAsync(
                $"devices/{Device.Id}/action/turnOn", null);
        }

        public async Task TurnOffAsync()
        {
            await Device.ApiClient.PostAsync(
                $"devices/{Device.Id}/action/turnOff", null);
        }

        public Task SwitchAsync(bool on)
        {
            return on ? TurnOnAsync() : TurnOffAsync();
        }

        public Task<bool> GetStatusAsync()
        {
            var status = Device.Info.Properties != null && Device.Info.Properties.Value == "true";
            return Task.FromResult(status);
        }
    }
}