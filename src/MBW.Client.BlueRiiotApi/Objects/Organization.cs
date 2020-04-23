using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class Organization
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}