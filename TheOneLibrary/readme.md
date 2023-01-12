Warning, this package is a test for publishing an SDK to Nuget.

TheOneAPI Nuget package is based of https://the-one-api.dev/v2 API.

The Nuget package has a dependency  on RestSharp version="106.15.0"

Please remember to create your API Key and add it for authentication. https://the-one-api.dev/sign-up

### Example
```csharp
Configuration configuration = Configuration.Default;
configuration.ApiKeyPrefix["Bearer"] = "Bearer";
configuration.ApiKey["Bearer"] = "{PUT YOUR API KEY}";

try
{
    // first arguemnt 'basePath' is optional or pass an instance of the Configuration class
    MovieApi movieApi = new MovieApi(configuration);

    Docs response = movieApi.Get();
    Console.WriteLine(response);

    string movieId = "5cd95395de30eff6ebccde57";

    Id id = movieApi.Id(movieId);
    Console.WriteLine(id);

    Quote quote = movieApi.Quote(movieId);
    Console.WriteLine(quote);