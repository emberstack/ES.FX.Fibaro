using ES.FX.Fibaro.Api.Devices.Interfaces;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    internal class CentralSceneSupport : ICentralSceneSupport
    {
        [JsonProperty("keyAttributes")]
        public string[] KeyAttributes { get; set; }

        [JsonProperty("keyId")]
        public long KeyId { get; set; }
    }
}