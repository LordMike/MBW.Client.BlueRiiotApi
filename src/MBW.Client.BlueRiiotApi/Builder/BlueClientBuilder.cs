using System.Net.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace MBW.Client.BlueRiiotApi.Builder
{
    public class BlueClientBuilder
    {
        private IBlueRiiotHttpClientFactory _clientFactory;
        private IRequestSigner _requestSigner;
        private ILogger<BlueClient> _logger = NullLogger<BlueClient>.Instance;

        public BlueClientBuilder()
        {
            _clientFactory = new ConstantBlueRiiotHttpClientFactory(new HttpClient());
        }

        internal BlueClientBuilder UseHttpClientProducer(IBlueRiiotHttpClientFactory factory)
        {
            _clientFactory = factory;
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
            return new BlueClient(_logger, _clientFactory, _requestSigner);
        }
    }
}