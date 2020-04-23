using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolCharacteristicsUvSanitizing
    {
        [JsonProperty("activated")]
        public bool Activated { get; set; }
    }
}