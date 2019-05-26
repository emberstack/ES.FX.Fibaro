namespace ES.FX.Fibaro.Api.Devices.Interfaces
{
    public interface IRowElement
    {
        long Id { get; }
        bool Lua { get; }
        bool WaitForResponse { get; }
        string Caption { get; }
        string Name { get; }
        bool Favorite { get; }
        bool Main { get; }
        bool? Empty { get; }
        string Msg { get; }
        long? ButtonIcon { get; }
    }
}