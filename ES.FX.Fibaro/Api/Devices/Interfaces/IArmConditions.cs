namespace ES.FX.Fibaro.Api.Devices.Interfaces
{
    public interface IArmConditions
    {
        bool Auto { get; }
        IDeviceElement[] Devices { get; }
        long Time { get; }
    }
}