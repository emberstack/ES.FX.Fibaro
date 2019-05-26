namespace ES.FX.Fibaro.Api.Settings.Interfaces
{
    public interface IInstallVersion
    {
        string Version { get; }
        string Type { get; }
        string Status { get; }
        long Progress { get; }
    }
}