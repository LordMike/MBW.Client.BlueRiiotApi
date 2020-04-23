using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolCharacteristicsPhRegulation
    {
        [JsonProperty("automatic_type")]
        public string AutomaticType { get; set; }

        [JsonProperty("process")]
        public string Process { get; set; }
    }
}