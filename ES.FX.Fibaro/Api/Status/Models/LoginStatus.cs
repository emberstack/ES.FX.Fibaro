using ES.FX.Fibaro.Api.Status.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Status.Models
{
    internal class LoginStatus : ILoginStatus
    {
        [JsonProperty("status")]
        public bool LoggedIn { get; set; }

        [JsonProperty("userID")]
        public long UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("analyticsUserIdHash")]
        public string AnalyticsUserIdHash { get; set; }
    }
}