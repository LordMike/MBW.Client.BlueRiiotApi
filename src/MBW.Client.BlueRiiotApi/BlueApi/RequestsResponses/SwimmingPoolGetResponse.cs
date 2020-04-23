using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.BlueApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.RequestsResponses
{
    public class SwimmingPoolGetResponse
    {
        [JsonProperty("data")]
        public List<UserSwimmingPool> Data { get; set; }
    }
}