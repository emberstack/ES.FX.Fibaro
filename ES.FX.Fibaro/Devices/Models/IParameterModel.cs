namespace ES.FX.Fibaro.Devices.Models
{
    public interface IParameterModel
    {
        long Id { get; set; }
        long Size { get; set; }
        long Value { get; set; }
        long? LastReportedValue { get; set; }
        long? LastSetValue { get; set; }
    }
}