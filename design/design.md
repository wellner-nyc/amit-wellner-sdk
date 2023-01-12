# **Amit Wellner - The Lord of the Rings SDK – Design**


## High Levlel Arch

The SDK design is based of Swagger Codegen - https://github.com/swagger-api/swagger-codegen . This design allows code reuse. 
MovieApi is a collection of functions that interact with the API endpoints. This is the class the client mainly interacts with. MovieApi utilize client and Model class for making the HTTP call to the API backend and parsing results


## TheOneApi.Api class diagram
![](Aspose.Words.67b0d0fd-9b00-4487-b04e-58c401bb198c.001.png)

## TheOneApi.Client class diagram
![](Aspose.Words.67b0d0fd-9b00-4487-b04e-58c401bb198c.002.png)

## TheOneApi.Model class diagram
![](Aspose.Words.67b0d0fd-9b00-4487-b04e-58c401bb198c.003.png)

The SDK architecture design has the following structure:

![](Aspose.Words.67b0d0fd-9b00-4487-b04e-58c401bb198c.004.png)


