using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Converters
{
    internal class TimeSpanDatedConverter : JsonConverter<TimeSpan>
    {
        // Example: 0000-01-01T08:00:00.000, unparseable by DateTime due to year `0000`
        private readonly Regex _parsingRegex = new(@"^[0-9\-]+T([0-9\:\.]+)$", RegexOptions.Compiled);

        public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer)
        {
            // BlueRiiot stores these timespans as datetimes. So any date is just as valid as the next.
            DateTime dateTime = DateTime.UtcNow.Date.Add(value);
            writer.WriteValue(dateTime);
        }

        public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.Value)
            {
                case string asString:
                {
                    Match matched = _parsingRegex.Match(asString);
                    string timespanValue = matched.Groups[1].Value;
                    TimeSpan timespan = TimeSpan.Parse(timespanValue);

                    return timespan;
                }
                case DateTime asDateTime:
                    return asDateTime.TimeOfDay;
                default:
                    // https://github.com/LordMike/MBW.BlueRiiot2MQTT/issues/44
                    throw new Exception($"Unable to parse value as TimeSpan. Received: '{reader.Value}'");
            }
        }
    }
}
