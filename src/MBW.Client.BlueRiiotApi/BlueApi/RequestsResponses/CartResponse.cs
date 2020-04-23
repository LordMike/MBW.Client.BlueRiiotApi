using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.RequestsResponses
{
    public class CartResponse
    {
        [JsonProperty("cart_items")]
        public object[] CartItems { get; set; }
    }
}