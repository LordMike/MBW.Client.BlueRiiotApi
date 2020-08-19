using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class Notifications
    {
        [JsonProperty("alerts_mail_enabled")]
        public bool AlertsMailEnabled { get; set; }
        
        [JsonProperty("alerts_push_enabled")]
        public bool AlertsPushEnabled { get; set; }
        
        [JsonProperty("measurement_mail_enabled")]
        public bool MeasurementMailEnabled { get; set; }
        
        [JsonProperty("measurement_frequency")]
        public string MeasurementFrequency { get; set; }
        
        [JsonProperty("measurement_push_enabled")]
        public bool MeasurementPushEnabled { get; set; }
        
        [JsonProperty("measurement_hour")]
        public int MeasurementHour { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}