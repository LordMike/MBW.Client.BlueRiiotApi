using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolChemical
    {
        [JsonProperty("default_brand")]
        public string DefaultBrand { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}