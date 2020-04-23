using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwpAutomationTargetsValidation
    {
        [JsonProperty("orp")]
        public SwpAutomationTargetValidation Orp { get; set; }

        [JsonProperty("ph")]
        public SwpAutomationTargetValidation Ph { get; set; }

        [JsonProperty("temperature")]
        public SwpAutomationTargetValidation Temperature { get; set; }
    }
}