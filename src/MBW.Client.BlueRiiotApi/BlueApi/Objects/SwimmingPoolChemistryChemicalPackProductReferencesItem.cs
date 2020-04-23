using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
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
    }
}