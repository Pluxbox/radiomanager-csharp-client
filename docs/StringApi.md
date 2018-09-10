# RadioManager.Api.StringApi

All URIs are relative to *https://staging.radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStringsByName**](StringApi.md#getstringsbyname) | **GET** /strings/{name} | Get Strings (formatted)


<a name="getstringsbyname"></a>
# **GetStringsByName**
> TextString GetStringsByName (string name, bool? fullModel)

Get Strings (formatted)

Get Strings (formatted)

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetStringsByNameExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new StringApi();
            var name = name_example;  // string | Name of Strings **(Required)**
            var fullModel = true;  // bool? | Full model or content only **(Required)** (default to true)

            try
            {
                // Get Strings (formatted)
                TextString result = apiInstance.GetStringsByName(name, fullModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StringApi.GetStringsByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of Strings **(Required)** | 
 **fullModel** | **bool?**| Full model or content only **(Required)** | [default to true]

### Return type

[**TextString**](TextString.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

