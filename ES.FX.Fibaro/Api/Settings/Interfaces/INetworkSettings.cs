namespace ES.FX.Fibaro.Api.Settings.Interfaces
{
    public interface INetworkSettings
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