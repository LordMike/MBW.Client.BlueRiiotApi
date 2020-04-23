using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SigfoxCoverage
    {
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("margins")]
        public float[] Margins { get; set; }

        [JsonProperty("redundancy")]
        public float Redundancy { get; set; }

        [JsonProperty("robustness")]
        public float Robustness { get; set; }

        [JsonProperty("score")]
        public float Score { get; set; }
    }
}