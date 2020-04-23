using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.BlueApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.RequestsResponses
{
    public class SwimmingPoolBlueDevicesGetResponse
    {
        [JsonProperty("data")]
        public List<SwimmingPoolDevice> Data { get; set; }
    }
}