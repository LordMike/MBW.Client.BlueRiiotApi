﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class UserPreferences
    {
        [JsonProperty("display_temperature_unit")]
        public string DisplayTemperatureUnit { get; set; }
        
        [JsonProperty("display_unit_system")]
        public string DisplayUnitSystem { get; set; }
        
        [JsonProperty("notifications")]
        public Notifications Notifications { get; set; }
        
        [JsonProperty("main_swimming_pool_id")]
        public string MainSwimmingPoolId { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}