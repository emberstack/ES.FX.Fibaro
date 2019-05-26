namespace ES.FX.Fibaro.Api.Devices.Interfaces
{
    public interface IDeviceElement
    {
        long Id { get; }
        string PropertyName { get; }
        string PropertyValue { get; }
    }
}