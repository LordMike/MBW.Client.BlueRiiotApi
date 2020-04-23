using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class SwimmingPoolGetResponse
    {
        [JsonProperty("data")]
        public List<UserSwimmingPool> Data { get; set; }
    }
}