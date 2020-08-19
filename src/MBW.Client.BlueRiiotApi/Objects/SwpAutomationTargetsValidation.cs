using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwpAutomationTargetsValidation
    {
        [JsonProperty("orp")]
        public SwpAutomationTargetValidation Orp { get; set; }

        [JsonProperty("ph")]
        public SwpAutomationTargetValidation Ph { get; set; }

        [JsonProperty("temperature")]
        public SwpAutomationTargetValidation Temperature { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}