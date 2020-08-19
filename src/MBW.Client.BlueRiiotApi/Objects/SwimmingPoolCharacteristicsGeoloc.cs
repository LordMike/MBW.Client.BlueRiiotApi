using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolCharacteristicsGeoloc
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("lon")]
        public float Lon { get; set; }

        [JsonProperty("lat")]
        public float Lat { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}