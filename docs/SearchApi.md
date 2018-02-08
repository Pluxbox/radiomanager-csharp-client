# RadioManager.Api.SearchApi

All URIs are relative to *https://radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSearch**](SearchApi.md#getsearch) | **POST** /search | Search.


<a name="getsearch"></a>
# **GetSearch**
> void GetSearch (SearchDataInput data = null)

Search.

You know. For search.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetSearchExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new SearchApi();
            var data = new SearchDataInput(); // SearchDataInput | Data *(Optional)* (optional) 

            try
            {
                // Search.
                apiInstance.GetSearch(data);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**SearchDataInput**](SearchDataInput.md)| Data *(Optional)* | [optional] 

### Return type

void (empty response body)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

