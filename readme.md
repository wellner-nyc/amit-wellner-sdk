# Overview

## Base URL

All endpoints in the documentation starts with the following URL:

https://the-one-api.dev/v2

### How to use the SDK

## Authentication

Create your API Key https://the-one-api.dev/sign-up

Add your key to pacakge
```csharp
Configuration configuration = Configuration.Default;
configuration.ApiKeyPrefix["Bearer"] = "Bearer";
configuration.ApiKey["Bearer"] = "{PUT YOUR API KEY}"; 
```

## Sample code how to use SDK

```csharp
// authentication setting Bearer Token
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
}
catch (Exception ex)
{
	Console.WriteLine(ex.ToString());
}
```
	
# SDK Deployment

My SDK was deployed to Nuget. 
1. See instructions on how to create a Nuget pacakge https://learn.microsoft.com/en-us/nuget/create-packages/creating-a-package

The current project build generate nuget package.

2. Instruction to publish Nuget pacakge https://learn.microsoft.com/en-us/nuget/nuget-org/publish-a-package

Link to deployed Nuget package - https://www.nuget.org/packages/TheOneSDK.Amit.Wellner.Jan.2023/1.0.1


# Testing

TheOneApiTest.cs has working unit test. It only covers unauthorized api calls.
To run unit test:
1.	Open the solution in Visual Studio 2019 or higher
2.	Build all the projects
3.	Right click the test project and select ‘Run Tests’

For testing the SDK over Http use the SDKClient project. Remember to PUT YOUR API KEY.

# Comment
The `design.md` is in folder design