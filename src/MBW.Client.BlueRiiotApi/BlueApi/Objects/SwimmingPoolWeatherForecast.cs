using System;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolWeatherForecast
    {
        [JsonProperty("temperature_max")]
        public float temperature_max { get; set; }

        [JsonProperty("temperature_min")]
        public float temperature_min { get; set; }

        [JsonProperty("timestamp")]
        public DateTime timestamp { get; set; }

        [JsonProperty("uv")]
        public float? uv { get; set; }

        [JsonProperty("weather_code")]
        public float weather_code { get; set; }

        [JsonProperty("weather_description")]
        public string weather_description { get; set; }

        [JsonProperty("weather_icon_code")]
        public string weather_icon_code { get; set; }

        [JsonProperty("wind_direction")]
        public float wind_direction { get; set; }

        [JsonProperty("wind_speed")]
        public float wind_speed { get; set; }
    }
}