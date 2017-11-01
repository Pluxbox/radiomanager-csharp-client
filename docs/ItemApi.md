# RadioManager.Api.ItemApi

All URIs are relative to *https://staging.radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateItem**](ItemApi.md#createitem) | **POST** /items | Create an new item.
[**CurrentItemPostStructure**](ItemApi.md#currentitempoststructure) | **POST** /items/current/structure | Post a current playing item, keep structure
[**CurrentItemPostTiming**](ItemApi.md#currentitemposttiming) | **POST** /items/current/timing | Post a current playing item
[**DeleteItemById**](ItemApi.md#deleteitembyid) | **DELETE** /items/{id} | Delete item by ID.
[**GetItemById**](ItemApi.md#getitembyid) | **GET** /items/{id} | Get extended item details by ID.
[**ListItems**](ItemApi.md#listitems) | **GET** /items | Get a list of all the items currently in your station.
[**PlaylistPostStructure**](ItemApi.md#playlistpoststructure) | **POST** /items/playlist/structure | Post a playlist, keep current structure
[**PlaylistPostTiming**](ItemApi.md#playlistposttiming) | **POST** /items/playlist/timing | Post a playlist
[**UpdateItemById**](ItemApi.md#updateitembyid) | **PATCH** /items/{id} | Update extended item details by ID.


<a name="createitem"></a>
# **CreateItem**
> PostSuccess CreateItem (ItemDataInput data = null)

Create an new item.

Create item.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class CreateItemExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var data = new ItemDataInput(); // ItemDataInput | Data *(Optional)* (optional) 

            try
            {
                // Create an new item.
                PostSuccess result = apiInstance.CreateItem(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.CreateItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ItemDataInput**](ItemDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**PostSuccess**](PostSuccess.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="currentitempoststructure"></a>
# **CurrentItemPostStructure**
> Success CurrentItemPostStructure (ImportItem data = null)

Post a current playing item, keep structure

Post a current playing item, keep structure

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class CurrentItemPostStructureExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var data = new ImportItem(); // ImportItem | Data *(Optional)* (optional) 

            try
            {
                // Post a current playing item, keep structure
                Success result = apiInstance.CurrentItemPostStructure(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.CurrentItemPostStructure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ImportItem**](ImportItem.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="currentitemposttiming"></a>
# **CurrentItemPostTiming**
> Success CurrentItemPostTiming (ImportItem data = null)

Post a current playing item

Post a current playing item

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class CurrentItemPostTimingExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var data = new ImportItem(); // ImportItem | Data *(Optional)* (optional) 

            try
            {
                // Post a current playing item
                Success result = apiInstance.CurrentItemPostTiming(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.CurrentItemPostTiming: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ImportItem**](ImportItem.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitembyid"></a>
# **DeleteItemById**
> Success DeleteItemById (long? id)

Delete item by ID.

Delete item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class DeleteItemByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var id = 789;  // long? | ID of Item **(Required)**

            try
            {
                // Delete item by ID.
                Success result = apiInstance.DeleteItemById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.DeleteItemById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Item **(Required)** | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitembyid"></a>
# **GetItemById**
> ItemResult GetItemById (long? id, long? externalStationId = null)

Get extended item details by ID.

Read item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetItemByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var id = 789;  // long? | ID of Item **(Required)**
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get extended item details by ID.
                ItemResult result = apiInstance.GetItemById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetItemById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Item **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ItemResult**](ItemResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listitems"></a>
# **ListItems**
> ItemResults ListItems (long? page = null, long? blockId = null, long? broadcastId = null, long? modelTypeId = null, long? tagId = null, long? campaignId = null, long? contactId = null, long? programDraftId = null, long? userDraftId = null, long? stationDraftId = null, long? programId = null, DateTime? startMin = null, DateTime? startMax = null, int? durationMin = null, int? durationMax = null, string status = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

Get a list of all the items currently in your station.

Get a list of all the items currently in your station. This feature supports pagination and will give a maximum results of 50 items back.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListItemsExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var page = 789;  // long? | Current page *(Optional)* (optional) 
            var blockId = 789;  // long? | Search on Block ID *(Optional)* `(Relation)` (optional) 
            var broadcastId = 789;  // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var modelTypeId = 789;  // long? | Search on ModelType ID *(Optional)* `(Relation)` (optional) 
            var tagId = 789;  // long? | Search on Tag ID *(Optional)* `(Relation)` (optional) 
            var campaignId = 789;  // long? | Search on Campaign ID *(Optional)* `(Relation)` (optional) 
            var contactId = 789;  // long? | Search on Contact ID *(Optional)* `(Relation)` (optional) 
            var programDraftId = 789;  // long? | Search on Program Draft ID *(Optional)* (optional) 
            var userDraftId = 789;  // long? | Search on User Draft ID *(Optional)* (optional) 
            var stationDraftId = 789;  // long? | Search on Station Draft ID *(Optional)* (optional) 
            var programId = 789;  // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var startMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Minimum start date *(Optional)* (optional) 
            var startMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Maximum start date *(Optional)* (optional) 
            var durationMin = 56;  // int? | Minimum duration (seconds) *(Optional)* (optional) 
            var durationMax = 56;  // int? | Maximum duration (seconds) *(Optional)* (optional) 
            var status = status_example;  // string | Play Status of item *(Optional)* (optional) 
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get a list of all the items currently in your station.
                ItemResults result = apiInstance.ListItems(page, blockId, broadcastId, modelTypeId, tagId, campaignId, contactId, programDraftId, userDraftId, stationDraftId, programId, startMin, startMax, durationMin, durationMax, status, limit, orderBy, orderDirection, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.ListItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **long?**| Current page *(Optional)* | [optional] 
 **blockId** | **long?**| Search on Block ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | **long?**| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **modelTypeId** | **long?**| Search on ModelType ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **tagId** | **long?**| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **campaignId** | **long?**| Search on Campaign ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **contactId** | **long?**| Search on Contact ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **programDraftId** | **long?**| Search on Program Draft ID *(Optional)* | [optional] 
 **userDraftId** | **long?**| Search on User Draft ID *(Optional)* | [optional] 
 **stationDraftId** | **long?**| Search on Station Draft ID *(Optional)* | [optional] 
 **programId** | **long?**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **startMin** | **DateTime?**| Minimum start date *(Optional)* | [optional] 
 **startMax** | **DateTime?**| Maximum start date *(Optional)* | [optional] 
 **durationMin** | **int?**| Minimum duration (seconds) *(Optional)* | [optional] 
 **durationMax** | **int?**| Maximum duration (seconds) *(Optional)* | [optional] 
 **status** | **string**| Play Status of item *(Optional)* | [optional] 
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ItemResults**](ItemResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playlistpoststructure"></a>
# **PlaylistPostStructure**
> InlineResponse202 PlaylistPostStructure (Data1 data = null)

Post a playlist, keep current structure

Post a playlist, keep current structure

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class PlaylistPostStructureExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var data = new Data1(); // Data1 | Data *(Optional)* (optional) 

            try
            {
                // Post a playlist, keep current structure
                InlineResponse202 result = apiInstance.PlaylistPostStructure(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.PlaylistPostStructure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Data1**](Data1.md)| Data *(Optional)* | [optional] 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playlistposttiming"></a>
# **PlaylistPostTiming**
> InlineResponse202 PlaylistPostTiming (Data data = null)

Post a playlist

Post a playlist

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class PlaylistPostTimingExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var data = new Data(); // Data | Data *(Optional)* (optional) 

            try
            {
                // Post a playlist
                InlineResponse202 result = apiInstance.PlaylistPostTiming(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.PlaylistPostTiming: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Data**](Data.md)| Data *(Optional)* | [optional] 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitembyid"></a>
# **UpdateItemById**
> Success UpdateItemById (long? id, Item data = null)

Update extended item details by ID.

Update item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class UpdateItemByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var id = 789;  // long? | ID of Item **(Required)**
            var data = new Item(); // Item | Data *(Optional)* (optional) 

            try
            {
                // Update extended item details by ID.
                Success result = apiInstance.UpdateItemById(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.UpdateItemById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Item **(Required)** | 
 **data** | [**Item**](Item.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

