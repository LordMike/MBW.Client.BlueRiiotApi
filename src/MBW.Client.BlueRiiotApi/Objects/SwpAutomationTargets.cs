using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwpAutomationTargets
    {
        [JsonProperty("orp")]
        public SwpAutomationTarget Orp { get; set; }

        [JsonProperty("ph")]
        public SwpAutomationTarget Ph { get; set; }

        [JsonProperty("salinity")]
        public SwpAutomationTarget Salinity { get; set; }

        [JsonProperty("temperature")]
        public SwpAutomationTarget Temperature { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}