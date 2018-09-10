# RadioManager.Api.GenreApi

All URIs are relative to *https://staging.radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGenreById**](GenreApi.md#getgenrebyid) | **GET** /genres/{id} | Get genre by id
[**ListGenres**](GenreApi.md#listgenres) | **GET** /genres | List all genres.


<a name="getgenrebyid"></a>
# **GetGenreById**
> GenreResult GetGenreById (long? id, long? externalStationId = null)

Get genre by id

Get genre by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetGenreByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new GenreApi();
            var id = 789;  // long? | ID of Genre **(Required)**
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get genre by id
                GenreResult result = apiInstance.GetGenreById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GenreApi.GetGenreById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Genre **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**GenreResult**](GenreResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgenres"></a>
# **ListGenres**
> GenreResults ListGenres (long? page = null, long? parentId = null, long? programId = null, long? broadcastId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

List all genres.

List all genres.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListGenresExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new GenreApi();
            var page = 789;  // long? | Current page *(Optional)* (optional) 
            var parentId = 789;  // long? | Search on Parent ID of Genre *(Optional)* (optional) 
            var programId = 789;  // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var broadcastId = 789;  // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // List all genres.
                GenreResults result = apiInstance.ListGenres(page, parentId, programId, broadcastId, limit, orderBy, orderDirection, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GenreApi.ListGenres: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **long?**| Current page *(Optional)* | [optional] 
 **parentId** | **long?**| Search on Parent ID of Genre *(Optional)* | [optional] 
 **programId** | **long?**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | **long?**| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**GenreResults**](GenreResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

