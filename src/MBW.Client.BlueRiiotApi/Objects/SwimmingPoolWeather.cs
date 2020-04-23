using System;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolWeather
    {
        [JsonProperty("temperature_current")]
        public float TemperatureCurrent { get; set; }

        [JsonProperty("temperature_max")]
        public float TemperatureMax { get; set; }

        [JsonProperty("temperature_min")]
        public string TemperatureMin { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("uv_current")]
        public float UvCurrent { get; set; }

        [JsonProperty("weather_current_code")]
        public float WeatherCurrentCode { get; set; }

        [JsonProperty("weather_current_description")]
        public string WeatherCurrentDescription { get; set; }

        [JsonProperty("weather_current_icon_code")]
        public string WeatherCurrentIconCode { get; set; }

        [JsonProperty("weather_future_icon_code")]
        public string WeatherFutureIconCode { get; set; }

        [JsonProperty("weather_future_temp")]
        public float WeatherFutureTemp { get; set; }

        [JsonProperty("weather_future_timeframe_one_icon_code")]
        public string WeatherFutureTimeframeOneIconCode { get; set; }

        [JsonProperty("weather_future_timeframe_one_timestamp")]
        public DateTime WeatherFutureTimeframeOneTimestamp { get; set; }

        [JsonProperty("weather_future_timeframe_two_icon_code")]
        public string WeatherFutureTimeframeTwoIconCode { get; set; }

        [JsonProperty("weather_future_timeframe_two_timestamp")]
        public DateTime WeatherFutureTimeframeTwoTimestamp { get; set; }

        [JsonProperty("weather_future_timestamp")]
        public DateTime WeatherFutureTimestamp { get; set; }

        [JsonProperty("wind_direction_current")]
        public float WindDirectionCurrent { get; set; }

        [JsonProperty("wind_speed_current")]
        public float WindSpeedCurrent { get; set; }
    }
}