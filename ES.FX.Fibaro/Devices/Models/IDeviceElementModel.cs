namespace ES.FX.Fibaro.Devices.Models
{
    public interface IDeviceElementModel
    {
        long Id { get; set; }
        string PropertyName { get; set; }
        string PropertyValue { get; set; }
    }
}