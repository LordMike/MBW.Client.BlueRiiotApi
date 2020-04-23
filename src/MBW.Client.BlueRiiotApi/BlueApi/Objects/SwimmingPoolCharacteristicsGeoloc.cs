using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
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
    }
}