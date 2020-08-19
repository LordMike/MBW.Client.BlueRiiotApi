using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolChemistryChemicalPack
    {
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("buy_process")]
        public string BuyProcess { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("img_banner")]
        public string ImgBanner { get; set; }

        [JsonProperty("img_logo")]
        public string ImgLogo { get; set; }

        [JsonProperty("is_fake")]
        public bool IsFake { get; set; }

        [JsonProperty("is_generic")]
        public bool IsGeneric { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("products")]
        public List<SwimmingPoolChemistryChemicalPackProduct> Products { get; set; }

        [JsonProperty("service_plan")]
        public string ServicePlan { get; set; }

        [JsonProperty("subscription_status")]
        public string SubscriptionStatus { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}