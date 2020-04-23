using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolDataValidation
    {
        [JsonProperty("automation_targets")]
        public SwpAutomationTargetsValidation AutomationTargets { get; set; }

        [JsonProperty("measure_ranges")]
        public SwpMeasureRangesValidation MeasureRanges { get; set; }
    }
}