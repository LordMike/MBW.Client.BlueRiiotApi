using System;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolDevice
    {
        [JsonProperty("blue_device_serial")]
        public string BlueDeviceSerial { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }
    }
}