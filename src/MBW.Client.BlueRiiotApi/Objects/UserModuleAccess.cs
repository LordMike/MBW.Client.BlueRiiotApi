using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class UserModuleAccess
    {
        [JsonProperty("va_config")]
        public bool VaConfig { get; set; }
        
        [JsonProperty("autom_targets_config")]
        public bool AutomTargetsConfig { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}