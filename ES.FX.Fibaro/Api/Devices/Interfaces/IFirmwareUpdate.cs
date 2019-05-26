namespace ES.FX.Fibaro.Api.Devices.Interfaces
{
    public interface IFirmwareUpdate
    {
        string Info { get; }
        long Progress { get; }
        string Status { get; }
        string UpdateVersion { get; }
    }
}