using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class CartItem
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("product_label")]
        public string ProductLabel { get; set; }

        [JsonProperty("product_ref")]
        public string ProductRef { get; set; }

        [JsonProperty("quantity")]
        public float Quantity { get; set; }

        [JsonProperty("unit_price")]
        public float UnitPrice { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}