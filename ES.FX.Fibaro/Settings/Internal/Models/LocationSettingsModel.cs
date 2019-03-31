using ES.FX.Fibaro.Json;
using ES.FX.Fibaro.Settings.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Settings.Internal.Models
{
    internal class LocationSettingsModel : ILocationSettingsModel
    {
        [JsonProperty("houseNumber")]
        public long HouseNumber { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezoneOffset")]
        public long TimezoneOffset { get; set; }

        [JsonProperty("ntp")]
        public bool Ntp { get; set; }

        [JsonProperty("ntpServer")]
        public string NtpServer { get; set; }

        [JsonProperty("date")]
        [JsonConverter(typeof(ConcreteTypeConverter<DateModel>))]
        public IDateModel Date { get; set; }

        [JsonProperty("time")]
        [JsonConverter(typeof(ConcreteTypeConverter<TimeModel>))]
        public ITimeModel Time { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("temperatureUnit")]
        public string TemperatureUnit { get; set; }

        [JsonProperty("windUnit")]
        public string WindUnit { get; set; }

        [JsonProperty("timeFormat")]
        public long TimeFormat { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("decimalMark")]
        public string DecimalMark { get; set; }
    }
}