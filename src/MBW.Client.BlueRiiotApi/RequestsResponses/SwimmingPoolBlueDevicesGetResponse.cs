using System.Collections.Generic;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class SwimmingPoolBlueDevicesGetResponse
    {
        [JsonProperty("data")]
        public List<SwimmingPoolDevice> Data { get; set; }
    }
}