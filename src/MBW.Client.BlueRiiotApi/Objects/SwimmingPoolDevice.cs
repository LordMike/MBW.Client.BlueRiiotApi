using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolDevice
    {
        [JsonProperty("blue_device_serial")]
        public string BlueDeviceSerial { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }
        
        [JsonProperty("blue_device")]
        public BlueDeviceFromDevicesList BlueDevice { get; set; }
        
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}