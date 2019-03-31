﻿namespace ES.FX.Fibaro.Settings.Models
{
    public interface IGeneralSettingsModel
    {
        string SerialNumber { get; }
        string HcName { get; }
        string Mac { get; }
        string ZwaveVersion { get; }
        long TimeFormat { get; }
        string ZwaveRegion { get; }
        long ServerStatus { get; }
        string DefaultLanguage { get; }
        string SunsetHour { get; }
        string SunriseHour { get; }
        bool HotelMode { get; }
        string TemperatureUnit { get; }
        bool BatteryLowNotification { get; }
        bool SmsManagement { get; }
        string Date { get; }
        string SoftVersion { get; }
        bool Beta { get; }
        ICurrentVersionModel CurrentVersion { get; }
        IInstallVersionModel InstallVersion { get; }
        long Timestamp { get; }
        bool Online { get; }
        bool UpdateStableAvailable { get; }
        bool UpdateBetaAvailable { get; }
        string NewestStableVersion { get; }
        string NewestBetaVersion { get; }
    }
}