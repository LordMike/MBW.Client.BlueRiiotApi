using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolDataValidation
    {
        [JsonProperty("automation_targets")]
        public SwpAutomationTargetsValidation AutomationTargets { get; set; }

        [JsonProperty("measure_ranges")]
        public SwpMeasureRangesValidation MeasureRanges { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}