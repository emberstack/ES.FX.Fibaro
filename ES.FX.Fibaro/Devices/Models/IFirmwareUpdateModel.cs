namespace ES.FX.Fibaro.Devices.Models
{
    public interface IFirmwareUpdateModel
    {
        string Info { get; set; }
        long Progress { get; set; }
        string Status { get; set; }
        string UpdateVersion { get; set; }
    }
}