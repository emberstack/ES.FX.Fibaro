using ES.FX.Fibaro.Json;
using ES.FX.Fibaro.Settings.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Settings.Internal.Models
{
    internal class GeneralSettingsModel : IGeneralSettingsModel
    {
        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("hcName")]
        public string HcName { get; set; }

        [JsonProperty("mac")]
        public string Mac { get; set; }

        [JsonProperty("zwaveVersion")]
        public string ZwaveVersion { get; set; }

        [JsonProperty("timeFormat")]
        public long TimeFormat { get; set; }

        [JsonProperty("zwaveRegion")]
        public string ZwaveRegion { get; set; }

        [JsonProperty("serverStatus")]
        public long ServerStatus { get; set; }

        [JsonProperty("defaultLanguage")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("sunsetHour")]
        public string SunsetHour { get; set; }

        [JsonProperty("sunriseHour")]
        public string SunriseHour { get; set; }

        [JsonProperty("hotelMode")]
        public bool HotelMode { get; set; }

        [JsonProperty("temperatureUnit")]
        public string TemperatureUnit { get; set; }

        [JsonProperty("batteryLowNotification")]
        public bool BatteryLowNotification { get; set; }

        [JsonProperty("smsManagement")]
        public bool SmsManagement { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("softVersion")]
        public string SoftVersion { get; set; }

        [JsonProperty("beta")]
        public bool Beta { get; set; }

        [JsonProperty("currentVersion")]
        [JsonConverter(typeof(ConcreteTypeConverter<CurrentVersionModel>))]
        public ICurrentVersionModel CurrentVersion { get; set; }

        [JsonProperty("installVersion")]
        [JsonConverter(typeof(ConcreteTypeConverter<InstallVersionModel>))]
        public IInstallVersionModel InstallVersion { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("updateStableAvailable")]
        public bool UpdateStableAvailable { get; set; }

        [JsonProperty("updateBetaAvailable")]
        public bool UpdateBetaAvailable { get; set; }

        [JsonProperty("newestStableVersion")]
        public string NewestStableVersion { get; set; }

        [JsonProperty("newestBetaVersion")]
        public string NewestBetaVersion { get; set; }
    }
}