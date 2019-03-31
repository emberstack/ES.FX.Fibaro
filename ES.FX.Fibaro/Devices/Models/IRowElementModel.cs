namespace ES.FX.Fibaro.Devices.Models
{
    public interface IRowElementModel
    {
        long Id { get; set; }
        bool Lua { get; set; }
        bool WaitForResponse { get; set; }
        string Caption { get; set; }
        string Name { get; set; }
        bool Favourite { get; set; }
        bool Main { get; set; }
        bool? Empty { get; set; }
        string Msg { get; set; }
        long? ButtonIcon { get; set; }
    }
}