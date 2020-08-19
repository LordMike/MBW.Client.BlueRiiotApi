using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
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

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}