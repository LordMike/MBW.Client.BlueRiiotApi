using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class SwimmingPoolBlueDevicesGetResponse
    {
        [JsonProperty("data")]
        public List<SwimmingPoolDevice> Data { get; set; }
    }
}