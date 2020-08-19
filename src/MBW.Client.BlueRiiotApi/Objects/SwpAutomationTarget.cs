using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwpAutomationTarget
    {
        [JsonProperty("custom_applied")]
        public bool CustomApplied { get; set; }

        [JsonProperty("repeat_too_high")]
        public bool RepeatTooHigh { get; set; }

        [JsonProperty("repeat_too_low")]
        public bool RepeatTooLow { get; set; }

        [JsonProperty("target")]
        public float Target { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}