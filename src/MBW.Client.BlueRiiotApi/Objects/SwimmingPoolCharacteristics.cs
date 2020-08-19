using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolCharacteristics
    {
        [JsonProperty("volume")]
        public SwimmingPoolCharacteristicsVolume Volume { get; set; }

        [JsonProperty("uv_sanitizing")]
        public SwimmingPoolCharacteristicsUvSanitizing UvSanitizing { get; set; }

        [JsonProperty("configuration")]
        public SwimmingPoolCharacteristicsConfiguration Configuration { get; set; }

        [JsonProperty("sanitizer")]
        public SwimmingPoolCharacteristicsSanitizer Sanitizer { get; set; }

        [JsonProperty("geoloc")]
        public SwimmingPoolCharacteristicsGeoloc Geoloc { get; set; }

        [JsonProperty("equipment")]
        public SwimmingPoolCharacteristicsEquipment Equipment { get; set; }

        [JsonProperty("ph_regulation")]
        public SwimmingPoolCharacteristicsPhRegulation PhRegulation { get; set; }

        [JsonProperty("filter_pump")]
        public SwimmingPoolCharacteristicsFilterPump FilterPump { get; set; }

        [JsonProperty("picture")]
        public SwimmingPoolCharacteristicsPicture Picture { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}