using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.BlueApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.RequestsResponses
{
    public class SwimmingPoolGuidanceHistoryGetResponse
    {
        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }

        [JsonProperty("items")]
        public List<SwimmingPoolGuidanceHistoryItem> Items { get; set; }
    }
}