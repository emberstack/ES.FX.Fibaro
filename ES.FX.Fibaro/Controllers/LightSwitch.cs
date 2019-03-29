using ES.FX.Fibaro.Interfaces;

namespace ES.FX.Fibaro.Controllers
{
    internal class LightSwitch : PowerSwitch, ILightSwitch
    {
        public LightSwitch(SmartDevice device) : base(device)
        {
        }
    }
}