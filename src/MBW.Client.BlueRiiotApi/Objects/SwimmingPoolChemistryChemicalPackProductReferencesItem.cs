using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolChemistryChemicalPackProductReferencesItem
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}