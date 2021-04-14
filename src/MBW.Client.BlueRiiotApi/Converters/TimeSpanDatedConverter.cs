using System;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Converters
{
    internal class TimeSpanDatedConverter : JsonConverter<TimeSpan>
    {
        public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer)
        {
            // BlueRiiot stores these timespans as datetimes. So any date is just as valid as the next.
            DateTime dateTime = DateTime.UtcNow.Date.Add(value);
            writer.WriteValue(dateTime);
        }

        public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (!(reader.Value is DateTime asDateTime))
            {
                // https://github.com/LordMike/MBW.BlueRiiot2MQTT/issues/44
                throw new Exception($"Unable to parse value as TimeSpan. Received: '{reader.Value}'");
            }
            
            return asDateTime.TimeOfDay;
        }
    }
}
