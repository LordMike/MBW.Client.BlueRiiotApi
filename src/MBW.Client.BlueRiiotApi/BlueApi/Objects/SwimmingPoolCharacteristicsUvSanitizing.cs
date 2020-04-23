using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolCharacteristicsUvSanitizing
    {
        [JsonProperty("activated")]
        public bool Activated { get; set; }
    }
}