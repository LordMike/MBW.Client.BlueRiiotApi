using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolUserAccess
    {
        [JsonProperty("canCreateInviteToken")]
        public bool CanCreateInviteToken { get; set; }

        [JsonProperty("canDeleteSwimmingPool")]
        public bool CanDeleteSwimmingPool { get; set; }

        [JsonProperty("canModifySwimmingPool")]
        public bool CanModifySwimmingPool { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}