using ES.FX.Fibaro.Api.Settings.Interfaces;
using ES.FX.Fibaro.Json;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Settings.Models
{
    internal class LocationSettings : ILocationSettings
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
        [JsonConverter(typeof(ConcreteTypeConverter<Date>))]
        public IDate Date { get; set; }

        [JsonProperty("time")]
        [JsonConverter(typeof(ConcreteTypeConverter<Time>))]
        public ITime Time { get; set; }

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