using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Helpers
{
    internal class JsonContent<T> : HttpContent
    {
        private static readonly Encoding _encoding = new UTF8Encoding(false);
        private readonly JsonSerializer _serializer;
        private readonly T _obj;

        public JsonContent(T obj) : this((JsonSerializer)null, obj)
        {
        }

        public JsonContent(JsonSerializerSettings settings, T obj)
        {
            _serializer = JsonSerializer.Create(settings);
            _obj = obj;
        }

        public JsonContent(JsonSerializer serializer, T obj)
        {
            _serializer = serializer ?? JsonSerializer.Create();
            _obj = obj;
        }

        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            using StreamWriter sw = new StreamWriter(stream, _encoding, 4096, true);
            using JsonTextWriter jw = new JsonTextWriter(sw);

            _serializer.Serialize(jw, _obj);

            return Task.CompletedTask;
        }

        protected override bool TryComputeLength(out long length)
        {
            length = default;
            return false;
        }
    }
}