namespace ES.FX.Fibaro.Api.Devices.Interfaces
{
    public interface IRow
    {
        string Type { get; }
        IRowElement[] Elements { get; }
    }
}