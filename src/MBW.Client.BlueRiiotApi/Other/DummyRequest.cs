using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Genbox.SimpleS3.Core.Abstracts;

namespace MBW.Client.BlueRiiotApi.Other
{
    class DummyRequest : IRequest
    {
        private readonly HttpRequestMessage _request;

        public DummyRequest(HttpRequestMessage request)
        {
            _request = request;
        }

        public void SetQueryParameter(string key, string value)
        {
            throw new NotImplementedException();
        }

        public void SetHeader(string key, string value)
        {
            throw new NotImplementedException();
        }

        public Guid RequestId { get; set; } = Guid.NewGuid();
        public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.UtcNow;
        public Genbox.SimpleS3.Core.Abstracts.Enums.HttpMethod Method => Enum.Parse<Genbox.SimpleS3.Core.Abstracts.Enums.HttpMethod>(_request.Method.Method, true);
        public IReadOnlyDictionary<string, string> Headers => _request.Headers.ToDictionary(s => s.Key, s => s.Value.First());
        public IReadOnlyDictionary<string, string> QueryParameters { get; } = new Dictionary<string, string>();
    }
}