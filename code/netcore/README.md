# Org.OpenAPITools - the C# library for the Handelsregister bevragen

D.m.v. deze toepassing worden meerdere, korte bevragingen op het Handelsregister beschikbaar gesteld.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://github.com/VNG-Realisatie/Haal-Centraal-HR-Bevragen](https://github.com/VNG-Realisatie/Haal-Centraal-HR-Bevragen)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://serverurl/bevragen/v1";
            var apiInstance = new DefaultApi(config);
            var identificatiehandelsregisternatuurlijkpersoon = identificatiehandelsregisternatuurlijkpersoon_example;  // string | Het burgerservicenummer van de persoon die een zakelijk recht op een kadastraal onroerende zaak heeft. Deze persoon is zakelijk gerechtigde van de kadastraal onroerende zaak. Door deze query-parameter te gebruiken worden Kadastraal Onroerende Zaken geretourneerd waar deze persoon een zakelijk recht op heeft. (optional) 
            var rsin = rsin_example;  // string | De identificatie van de NietNatuurlijkPersoon, bijvoorbeel een rechtspersoon (evt in oprichting), een samenwerkingsverband of een eenmanszaak met meerdere eigenaren (optional) 

            try
            {
                // van eigenaren
                CorrespondentieAdresEigenaarHalCollectie result = apiInstance.GetCorrespondentieadresEigenaar(identificatiehandelsregisternatuurlijkpersoon, rsin);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCorrespondentieadresEigenaar: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://serverurl/bevragen/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**GetCorrespondentieadresEigenaar**](docs/DefaultApi.md#getcorrespondentieadreseigenaar) | **GET** /correspondentieadressen | van eigenaren
*DefaultApi* | [**GetMaatschappelijkeActiviteiten**](docs/DefaultApi.md#getmaatschappelijkeactiviteiten) | **GET** /maatschappelijkeactiviteiten | van personen
*DefaultApi* | [**GetVestigingsadresEigenaar**](docs/DefaultApi.md#getvestigingsadreseigenaar) | **GET** /vestigingsadressen | van een persoon


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Adres](docs/Adres.md)
 - [Model.BadRequestFoutbericht](docs/BadRequestFoutbericht.md)
 - [Model.BadRequestFoutberichtAllOf](docs/BadRequestFoutberichtAllOf.md)
 - [Model.CorrespondentieAdresEigenaar](docs/CorrespondentieAdresEigenaar.md)
 - [Model.CorrespondentieAdresEigenaarHalBasis](docs/CorrespondentieAdresEigenaarHalBasis.md)
 - [Model.CorrespondentieAdresEigenaarHalBasisAllOf](docs/CorrespondentieAdresEigenaarHalBasisAllOf.md)
 - [Model.CorrespondentieAdresEigenaarHalCollectie](docs/CorrespondentieAdresEigenaarHalCollectie.md)
 - [Model.CorrespondentieAdresEigenaarHalCollectieEmbedded](docs/CorrespondentieAdresEigenaarHalCollectieEmbedded.md)
 - [Model.CorrespondentieAdresEigenaarLinks](docs/CorrespondentieAdresEigenaarLinks.md)
 - [Model.Foutbericht](docs/Foutbericht.md)
 - [Model.HalCollectionLinks](docs/HalCollectionLinks.md)
 - [Model.HalLink](docs/HalLink.md)
 - [Model.HalPaginationLinks](docs/HalPaginationLinks.md)
 - [Model.HalPaginationLinksAllOf](docs/HalPaginationLinksAllOf.md)
 - [Model.HalPaginationLinksFirst](docs/HalPaginationLinksFirst.md)
 - [Model.HalPaginationLinksNext](docs/HalPaginationLinksNext.md)
 - [Model.HalPaginationLinksPrevious](docs/HalPaginationLinksPrevious.md)
 - [Model.InvalidParams](docs/InvalidParams.md)
 - [Model.MaatschappelijkeActiviteit](docs/MaatschappelijkeActiviteit.md)
 - [Model.MaatschappelijkeActiviteitHalBasis](docs/MaatschappelijkeActiviteitHalBasis.md)
 - [Model.MaatschappelijkeActiviteitHalBasisAllOf](docs/MaatschappelijkeActiviteitHalBasisAllOf.md)
 - [Model.MaatschappelijkeActiviteitHalCollectie](docs/MaatschappelijkeActiviteitHalCollectie.md)
 - [Model.MaatschappelijkeActiviteitHalCollectieEmbedded](docs/MaatschappelijkeActiviteitHalCollectieEmbedded.md)
 - [Model.MaatschappelijkeActiviteitLinks](docs/MaatschappelijkeActiviteitLinks.md)
 - [Model.VestigingsAdresEigenaar](docs/VestigingsAdresEigenaar.md)
 - [Model.VestigingsAdresEigenaarHalBasis](docs/VestigingsAdresEigenaarHalBasis.md)
 - [Model.VestigingsAdresEigenaarHalBasisAllOf](docs/VestigingsAdresEigenaarHalBasisAllOf.md)
 - [Model.VestigingsAdresEigenaarHalCollectie](docs/VestigingsAdresEigenaarHalCollectie.md)
 - [Model.VestigingsAdresEigenaarHalCollectieEmbedded](docs/VestigingsAdresEigenaarHalCollectieEmbedded.md)
 - [Model.VestigingsAdresEigenaarLinks](docs/VestigingsAdresEigenaarLinks.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.