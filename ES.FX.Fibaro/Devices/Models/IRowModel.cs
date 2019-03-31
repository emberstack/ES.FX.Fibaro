namespace ES.FX.Fibaro.Devices.Models
{
    public interface IRowModel
    {
        string Type { get; set; }
        IRowElementModel[] Elements { get; set; }
    }
}