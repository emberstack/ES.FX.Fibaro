namespace ES.FX.Fibaro.Api.Devices.Interfaces
{
    public interface IParameter
    {
        long Id { get; }
        long Size { get; }
        long Value { get; }
        long? LastReportedValue { get; }
        long? LastSetValue { get; }
    }
}