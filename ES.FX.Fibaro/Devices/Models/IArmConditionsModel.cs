namespace ES.FX.Fibaro.Devices.Models
{
    public interface IArmConditionsModel
    {
        bool Auto { get; set; }
        IDeviceElementModel[] Devices { get; set; }
        long Time { get; set; }
    }
}