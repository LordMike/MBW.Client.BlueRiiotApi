using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}