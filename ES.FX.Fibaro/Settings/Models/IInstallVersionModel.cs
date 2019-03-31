namespace ES.FX.Fibaro.Settings.Models
{
    public interface IInstallVersionModel
    {
        string Version { get; }
        string Type { get; }
        string Status { get; }
        long Progress { get; }
    }
}