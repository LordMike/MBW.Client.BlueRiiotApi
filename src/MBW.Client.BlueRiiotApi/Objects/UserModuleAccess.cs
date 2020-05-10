using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class UserModuleAccess
    {
        [JsonProperty("va_config")]
        public bool VaConfig { get; set; }
        
        [JsonProperty("autom_targets_config")]
        public bool AutomTargetsConfig { get; set; }
    }
}