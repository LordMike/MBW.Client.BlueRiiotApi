using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class VpcFollowupSettings
    {
        [JsonProperty("guidance_displayed")]
        public bool GuidanceDisplayed { get; set; }

        [JsonProperty("organization_turns_guidance_off")]
        public bool OrganizationTurnsGuidanceOff { get; set; }
    }
}