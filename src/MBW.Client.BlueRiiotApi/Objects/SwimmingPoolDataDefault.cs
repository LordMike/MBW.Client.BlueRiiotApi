using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolDataDefault
    {
        [JsonProperty("automation_targets")]
        public SwpAutomationTargets AutomationTargets { get; set; }

        [JsonProperty("measure_ranges")]
        public SwpMeasureRanges MeasureRanges { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}