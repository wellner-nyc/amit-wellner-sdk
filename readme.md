To do:
how to install, use and test the SDK

The SDK should be deployed to a package manager like npm, pip, maven etc…
Please add a file in the root directory `design.md` with information about your SDK design

Delivery:Once your SDK is ready, please send us a link to a Git repo named “{your_name}-SDK”.

Fix unit test

Done:

# Overview

## Base URL

All endpoints in the documentation starts with the following URL:

https://the-one-api.dev/v2

## Authentication

Create your API Key https://the-one-api.dev/sign-up

Add your key to pacakge
```csharp
Configuration configuration = Configuration.Default;
configuration.ApiKeyPrefix["Bearer"] = "Bearer";
configuration.ApiKey["Bearer"] = "{PUT YOUR API KEY}"; 
```

# SDK Deployment

My SDK was deployed to Nuget. 
1. See instructions on how to create a Nuget pacakge https://learn.microsoft.com/en-us/nuget/create-packages/creating-a-package

The current project build generate nuget package.

2. Instruction to publish Nuget pacakge https://learn.microsoft.com/en-us/nuget/nuget-org/publish-a-package

Link to deployed Nuget package - https://www.nuget.org/packages/TheOneSDK.Amit.Wellner.Jan.2023/1.0.1


# Testing

TheOneApiTest.cs has working unit test. It only covers unauthrize api calls.

To test the SDK you can use the SDKClient. 




# Comment
The `design.md` is in folder design