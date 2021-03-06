﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwpLastMeasurements
    {
        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("gauge_max")]
        public float GaugeMax { get; set; }

        [JsonProperty("gauge_min")]
        public float GaugeMin { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ok_max")]
        public float OkMax { get; set; }

        [JsonProperty("ok_min")]
        public float OkMin { get; set; }

        [JsonProperty("priority")]
        public float Priority { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("trend")]
        public string Trend { get; set; }

        [JsonProperty("value")]
        public float Value { get; set; }

        [JsonProperty("warning_high")]
        public float WarningHigh { get; set; }

        [JsonProperty("warning_low")]
        public float WarningLow { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}