using System;
using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.BlueApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.RequestsResponses
{
    public class SwimmingPoolLastMeasurementsGetResponse
    {
        [JsonProperty("blue_device_serial")]
        public string BlueDeviceSerial { get; set; }

        [JsonProperty("data")]
        public List<SwpLastMeasurements> Data { get; set; }

        [JsonProperty("last_blue_measure_timestamp")]
        public DateTime? LastBlueMeasureTimestamp { get; set; }

        [JsonProperty("last_strip_timestamp")]
        public DateTime? LastStripTimestamp { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }
    }
}