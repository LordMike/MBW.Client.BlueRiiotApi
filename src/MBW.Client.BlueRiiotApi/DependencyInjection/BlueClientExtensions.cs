using System;
using System.Net.Http;
using MBW.Client.BlueRiiotApi;
using MBW.Client.BlueRiiotApi.Builder;
using Microsoft.Extensions.Logging;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    // ReSharper disable once UnusedType.Global
    public static class BlueClientExtensions
    {
        public static IServiceCollection AddBlueRiiotClient(this IServiceCollection services, Action<BlueClientBuilder> configure)
        {
            return services.AddBlueRiiotClient((provider, builder) => configure(builder));
        }

        public static IServiceCollection AddBlueRiiotClient(this IServiceCollection services, Action<IServiceProvider, BlueClientBuilder> configure)
        {
            return services
                .AddHttpClient()
                .AddSingleton(x =>
                {
                    BlueClientBuilder builder = new BlueClientBuilder()
                        .UseLogger(x.GetRequiredService<ILogger<BlueClient>>())
                        .UseHttpClientFactory(x.GetRequiredService<IHttpClientFactory>(), string.Empty);

                    configure(x, builder);

                    return builder.Build();
                });
        }
    }
}