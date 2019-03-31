namespace ES.FX.Fibaro.Settings.Models
{
    public interface ILocationSettingsModel
    {
        long HouseNumber { get; }
        string Timezone { get; }
        long TimezoneOffset { get; }
        bool Ntp { get; }
        string NtpServer { get; }
        IDateModel Date { get; }
        ITimeModel Time { get; }
        double Latitude { get; }
        double Longitude { get; }
        string City { get; }
        string TemperatureUnit { get; }
        string WindUnit { get; }
        long TimeFormat { get; }
        string DateFormat { get; }
        string DecimalMark { get; }
    }
}