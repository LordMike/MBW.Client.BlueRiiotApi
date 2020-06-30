# MBW.Client.BlueRiiotAPI

[![Nuget](https://img.shields.io/nuget/v/MBW.Client.BlueRiiotAPI)](https://nuget.org/packages/MBW.Client.BlueRiiotAPI)


Reverse engineered client library for Blue Riiots pool API.

## Basic usage

```csharp
var bc = new BlueClientBuilder()
    .UseUsernamePassword("user", "pass")
    .Build();

var pools = await bc.GetSwimmingPools();
```

## Using an HTTP Client Factory

```csharp
var bc = new BlueClientBuilder()
    .UseHttpClientFactory(myFactory)
    ...
```

## Using an HTTP proxy

```csharp
var bc = new BlueClientBuilder()
    // Add a special HttpClient to control the proxy
    .UseHttpClient(new HttpClient(new SocketsHttpHandler
    {
        // Set a proxy if available. Suggestion: Fiddler.
        Proxy = new WebProxy(new Uri("http://127.0.0.1:8888"))
    }))
    ...
```

## Using Microsoft DI


```csharp
services
    // Note: the AddHttpClient() call is not necessary, but it is possibly to again configure the client here
    .AddHttpClient("blueriiot")
    .AddBlueRiiot((provider, builder) =>
    {
        IHttpClientFactory httpFactory = provider.GetRequiredService<IHttpClientFactory>();

        // Set required options on the BlueClientBuilder
        builder
            .UseUsernamePassword(config.Username, config.Password)
            // Only necessary if a special HttpClientFactory name is needed
            .UseHttpClientFactory(httpFactory, "blueriiot"); 
    })

// Usage
var bc = serviceProvider.GetService<BlueClient>();
var pools = await bc.GetSwimmingPools();
```

# Note on logging

The library uses Microsofts logging extensions. It is possible to log all requests (and responses), by enabling Trace logging for `MBW.Client.BlueRiiotApi.BlueClient`.

```csharp
services.AddLogging(builder =>
{
    builder.AddFilter("MBW.Client.BlueRiiotApi.BlueClient", LogLevel.Trace);
});
```
