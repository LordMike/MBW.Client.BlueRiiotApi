using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class BluesGetResponse
    {
        [JsonProperty("data")]
        public List<BlueDeviceFromDevicesList> Data { get; set; }
        
        [JsonProperty("upgradedToPlusCount")]
        public int UpgradedToPlusCount { get; set; }
        
        [JsonProperty("upgradedCount")]
        public int UpgradedCount { get; set; }
    }
}