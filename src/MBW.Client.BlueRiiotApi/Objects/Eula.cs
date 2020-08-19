using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class Eula
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        
        [JsonProperty("version")]
        public string Version { get; set; }
        
        [JsonProperty("available_languages")]
        public string[] AvailableLanguages { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}