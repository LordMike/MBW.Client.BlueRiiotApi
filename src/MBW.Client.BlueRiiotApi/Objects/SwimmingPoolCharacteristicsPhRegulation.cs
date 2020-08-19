using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolCharacteristicsPhRegulation
    {
        [JsonProperty("automatic_type")]
        public string AutomaticType { get; set; }

        [JsonProperty("process")]
        public string Process { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}