# RadioManager.Api.ModelTypeApi

All URIs are relative to *https://radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetModelTypeById**](ModelTypeApi.md#getmodeltypebyid) | **GET** /model_types/{id} | Get modelType by id
[**ListModelTypes**](ModelTypeApi.md#listmodeltypes) | **GET** /model_types | Get all modelTypes.

<a name="getmodeltypebyid"></a>
# **GetModelTypeById**
> ModelTypeResult GetModelTypeById (long? id, long? externalStationId = null)

Get modelType by id

Get modelType by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetModelTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ModelTypeApi();
            var id = 789;  // long? | ID of ModelType **(Required)**
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get modelType by id
                ModelTypeResult result = apiInstance.GetModelTypeById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelTypeApi.GetModelTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of ModelType **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ModelTypeResult**](ModelTypeResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listmodeltypes"></a>
# **ListModelTypes**
> Object ListModelTypes (long? page = null, long? programId = null, long? broadcastId = null, long? itemId = null, long? campaignId = null, long? presenterId = null, long? contactId = null, string model = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

Get all modelTypes.

List all modelTypes.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListModelTypesExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ModelTypeApi();
            var page = 789;  // long? | Current page *(Optional)* (optional) 
            var programId = 789;  // long? | Search on Program ID *(Optional)* (optional) 
            var broadcastId = 789;  // long? | Search on Broadcast ID *(Optional)* (optional) 
            var itemId = 789;  // long? | Search on Item ID *(Optional)* (optional) 
            var campaignId = 789;  // long? | Search on Campaign ID *(Optional)* (optional) 
            var presenterId = 789;  // long? | Search on Presenter ID *(Optional)* (optional) 
            var contactId = 789;  // long? | Search on Contact ID *(Optional)* (optional) 
            var model = model_example;  // string | Search Modeltypes for certain Model *(Optional)* (optional) 
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get all modelTypes.
                Object result = apiInstance.ListModelTypes(page, programId, broadcastId, itemId, campaignId, presenterId, contactId, model, limit, orderBy, orderDirection, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelTypeApi.ListModelTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **long?**| Current page *(Optional)* | [optional] 
 **programId** | **long?**| Search on Program ID *(Optional)* | [optional] 
 **broadcastId** | **long?**| Search on Broadcast ID *(Optional)* | [optional] 
 **itemId** | **long?**| Search on Item ID *(Optional)* | [optional] 
 **campaignId** | **long?**| Search on Campaign ID *(Optional)* | [optional] 
 **presenterId** | **long?**| Search on Presenter ID *(Optional)* | [optional] 
 **contactId** | **long?**| Search on Contact ID *(Optional)* | [optional] 
 **model** | **string**| Search Modeltypes for certain Model *(Optional)* | [optional] 
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

**Object**

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
