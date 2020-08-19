using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class VpcFollowupSettings
    {
        [JsonProperty("guidance_displayed")]
        public bool GuidanceDisplayed { get; set; }

        [JsonProperty("organization_turns_guidance_off")]
        public bool OrganizationTurnsGuidanceOff { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}