namespace ES.FX.Fibaro.Settings
{
    public interface ISettingsController
    {
        IGeneralSettingsController General { get; }
        ILocationSettingsController Location { get; }
        INetworkSettingsController Network { get; }
    }
}