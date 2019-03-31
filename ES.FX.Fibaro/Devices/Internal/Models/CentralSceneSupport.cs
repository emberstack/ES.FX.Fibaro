using ES.FX.Fibaro.Devices.Models;
using Newtonsoft.Json;

namespace ES.FX.Fibaro.Devices.Internal.Models
{
    internal class CentralSceneSupport : ICentralSceneSupportModel
    {
        [JsonProperty("keyAttributes")]
        public string[] KeyAttributes { get; set; }

        [JsonProperty("keyId")]
        public long KeyId { get; set; }
    }
}