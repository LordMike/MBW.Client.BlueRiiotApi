using System.Net.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace MBW.Client.BlueRiiotApi.Builder
{
    public class BlueClientBuilder
    {
        private IHttpClientProducer _clientProducer;
        private IRequestSigner _requestSigner;
        private ILogger<BlueClient> _logger = NullLogger<BlueClient>.Instance;

        public BlueClientBuilder()
        {
            _clientProducer = new ConstantHttpClientProducer(new HttpClient());
        }

        public BlueClientBuilder UseHttpClientFactory(IHttpClientFactory factory, string clientName)
        {
            _clientProducer = new HttpClientFactoryProducer(factory, clientName);
            return this;
        }

        public BlueClientBuilder UseHttpClient(HttpClient client)
        {
            _clientProducer = new ConstantHttpClientProducer(client);
            return this;
        }

        public BlueClientBuilder UseUsernamePassword(string username, string password)
        {
            _requestSigner = new UsernamePasswordRequestSigner(username, password);
            return this;
        }

        public BlueClientBuilder UseLogger(ILogger<BlueClient> logger)
        {
            _logger = logger;
            return this;
        }

        public BlueClient Build()
        {
            return new BlueClient(_logger, _clientProducer, _requestSigner);
        }
    }
}