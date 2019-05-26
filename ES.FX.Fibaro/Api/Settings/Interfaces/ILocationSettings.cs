namespace ES.FX.Fibaro.Api.Settings.Interfaces
{
    public interface ILocationSettings
    {
        long HouseNumber { get; }
        string Timezone { get; }
        long TimezoneOffset { get; }
        bool Ntp { get; }
        string NtpServer { get; }
        IDate Date { get; }
        ITime Time { get; }
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