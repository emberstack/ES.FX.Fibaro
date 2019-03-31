namespace ES.FX.Fibaro.Settings.Models
{
    public interface INetworkSettingsModel
    {
        bool Dhcp { get; }
        string Ip { get; }
        string Mask { get; }
        string Gateway { get; }
        string Dns { get; }
        bool RemoteAccess { get; }
        long RemoteAccessSupport { get; }
    }
}