using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class BlueCompatibilitySigfoxCountry
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("region")]
        public SigfoxRc Region { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}