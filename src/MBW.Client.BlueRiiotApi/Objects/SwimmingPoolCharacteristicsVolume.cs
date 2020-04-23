using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolCharacteristicsVolume
    {
        [JsonProperty("area")]
        public float Area { get; set; }

        [JsonProperty("depth2")]
        public float Depth2 { get; set; }

        [JsonProperty("length")]
        public float Length { get; set; }

        [JsonProperty("width")]
        public float Width { get; set; }

        [JsonProperty("depth")]
        public float Depth { get; set; }

        [JsonProperty("shape")]
        public string Shape { get; set; }

        [JsonProperty("diameter")]
        public float Diameter { get; set; }

        [JsonProperty("capacity")]
        public float Capacity { get; set; }
    }
}