# RadioManager.Api.ItemApi

All URIs are relative to *https://radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateItem**](ItemApi.md#createitem) | **POST** /items | Create an new item.
[**CurrentItemPostStructure**](ItemApi.md#currentitempoststructure) | **POST** /items/current/structure | Post a current playing item, keep structure
[**CurrentItemPostTiming**](ItemApi.md#currentitemposttiming) | **POST** /items/current/timing | Post current playing Item
[**DeleteItemById**](ItemApi.md#deleteitembyid) | **DELETE** /items/{id} | Delete item by ID.
[**GetCurrentItem**](ItemApi.md#getcurrentitem) | **GET** /items/current | Get current Item
[**GetItemById**](ItemApi.md#getitembyid) | **GET** /items/{id} | Get extended item details by ID.
[**ListItems**](ItemApi.md#listitems) | **GET** /items | Get a list of all the items currently in your station.
[**PlaylistPostMerge**](ItemApi.md#playlistpostmerge) | **POST** /items/playlist/merge | Post a playlist, do not remove previously imported items
[**PlaylistPostStructure**](ItemApi.md#playlistpoststructure) | **POST** /items/playlist/structure | Post a playlist, keep current structure
[**PlaylistPostTiming**](ItemApi.md#playlistposttiming) | **POST** /items/playlist/timing | Post a playlist
[**StopCurrentItem**](ItemApi.md#stopcurrentitem) | **POST** /items/stopcurrent | Stop an Item
[**UpdateItemById**](ItemApi.md#updateitembyid) | **PATCH** /items/{id} | Update extended item details by ID.

<a name="createitem"></a>
# **CreateItem**
> InlineResponse2002 CreateItem (ItemDataInput body)

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new ItemDataInput(); // ItemDataInput | Data **(Required)**

            try
            {
                // Create an new item.
                InlineResponse2002 result = apiInstance.CreateItem(body);
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
 **body** | [**ItemDataInput**](ItemDataInput.md)| Data **(Required)** | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currentitempoststructure"></a>
# **CurrentItemPostStructure**
> ItemResult CurrentItemPostStructure (ImportItem body)

Post a current playing item, keep structure

Post current playing Item. Can be existing Item referenced by external_id. When Items are moved, this function **will attempt to** keep Items' ModelType structure in rundown.

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new ImportItem(); // ImportItem | Data **(Required)**

            try
            {
                // Post a current playing item, keep structure
                ItemResult result = apiInstance.CurrentItemPostStructure(body);
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
 **body** | [**ImportItem**](ImportItem.md)| Data **(Required)** | 

### Return type

[**ItemResult**](ItemResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currentitemposttiming"></a>
# **CurrentItemPostTiming**
> ItemResult CurrentItemPostTiming (ImportItem body)

Post current playing Item

Post current playing Item. Can be existing Item referenced by external_id. When Items are moved, this function **will not keep** Items' ModelType structure in rundown.

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new ImportItem(); // ImportItem | Data **(Required)**

            try
            {
                // Post current playing Item
                ItemResult result = apiInstance.CurrentItemPostTiming(body);
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
 **body** | [**ImportItem**](ImportItem.md)| Data **(Required)** | 

### Return type

[**ItemResult**](ItemResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteitembyid"></a>
# **DeleteItemById**
> void DeleteItemById (long? id)

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var id = new long?(); // long? | ID of Item **(Required)**

            try
            {
                // Delete item by ID.
                apiInstance.DeleteItemById(id);
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
 **id** | [**long?**](long?.md)| ID of Item **(Required)** | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentitem"></a>
# **GetCurrentItem**
> ItemResult GetCurrentItem (bool? lastplayed = null)

Get current Item

Get current Item

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetCurrentItemExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var lastplayed = new bool?(); // bool? | Show last played item if there is no current item*(Optional)* (optional) 

            try
            {
                // Get current Item
                ItemResult result = apiInstance.GetCurrentItem(lastplayed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetCurrentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastplayed** | [**bool?**](bool?.md)| Show last played item if there is no current item*(Optional)* | [optional] 

### Return type

[**ItemResult**](ItemResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var id = new long?(); // long? | ID of Item **(Required)**
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
 **id** | [**long?**](long?.md)| ID of Item **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ItemResult**](ItemResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listitems"></a>
# **ListItems**
> InlineResponse2008 ListItems (long? blockId = null, long? broadcastId = null, long? modelTypeId = null, long? tagId = null, long? campaignId = null, long? contactId = null, long? programDraftId = null, long? userDraftId = null, long? stationDraftId = null, long? programId = null, string externalId = null, int? durationMin = null, int? durationMax = null, string status = null, DateTime? startMin = null, DateTime? startMax = null, long? page = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var blockId = new long?(); // long? | Search on Block ID *(Optional)* `(Relation)` (optional) 
            var broadcastId = new long?(); // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var modelTypeId = new long?(); // long? | Search on ModelType ID *(Optional)* `(Relation)` (optional) 
            var tagId = new long?(); // long? | Search on Tag ID *(Optional)* `(Relation)` (optional) 
            var campaignId = new long?(); // long? | Search on Campaign ID *(Optional)* `(Relation)` (optional) 
            var contactId = new long?(); // long? | Search on Contact ID *(Optional)* `(Relation)` (optional) 
            var programDraftId = new long?(); // long? | Search on Program Draft ID *(Optional)* (optional) 
            var userDraftId = new long?(); // long? | Search on User Draft ID *(Optional)* (optional) 
            var stationDraftId = new long?(); // long? | Search on Station Draft ID *(Optional)* (optional) 
            var programId = new long?(); // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var externalId = externalId_example;  // string | Search on External ID *(Optional)* (optional) 
            var durationMin = 56;  // int? | Minimum duration (seconds) *(Optional)* (optional) 
            var durationMax = 56;  // int? | Maximum duration (seconds) *(Optional)* (optional) 
            var status = status_example;  // string | Play Status of item *(Optional)* (optional) 
            var startMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Minimum start date *(Optional)* (optional) 
            var startMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Maximum start date *(Optional)* (optional) 
            var page = 789;  // long? | Current page *(Optional)* (optional)  (default to 1)
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get a list of all the items currently in your station.
                InlineResponse2008 result = apiInstance.ListItems(blockId, broadcastId, modelTypeId, tagId, campaignId, contactId, programDraftId, userDraftId, stationDraftId, programId, externalId, durationMin, durationMax, status, startMin, startMax, page, limit, orderBy, orderDirection, externalStationId);
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
 **blockId** | [**long?**](long?.md)| Search on Block ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | [**long?**](long?.md)| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **modelTypeId** | [**long?**](long?.md)| Search on ModelType ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **tagId** | [**long?**](long?.md)| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **campaignId** | [**long?**](long?.md)| Search on Campaign ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **contactId** | [**long?**](long?.md)| Search on Contact ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **programDraftId** | [**long?**](long?.md)| Search on Program Draft ID *(Optional)* | [optional] 
 **userDraftId** | [**long?**](long?.md)| Search on User Draft ID *(Optional)* | [optional] 
 **stationDraftId** | [**long?**](long?.md)| Search on Station Draft ID *(Optional)* | [optional] 
 **programId** | [**long?**](long?.md)| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **externalId** | **string**| Search on External ID *(Optional)* | [optional] 
 **durationMin** | **int?**| Minimum duration (seconds) *(Optional)* | [optional] 
 **durationMax** | **int?**| Maximum duration (seconds) *(Optional)* | [optional] 
 **status** | **string**| Play Status of item *(Optional)* | [optional] 
 **startMin** | **DateTime?**| Minimum start date *(Optional)* | [optional] 
 **startMax** | **DateTime?**| Maximum start date *(Optional)* | [optional] 
 **page** | **long?**| Current page *(Optional)* | [optional] [default to 1]
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playlistpostmerge"></a>
# **PlaylistPostMerge**
> InlineResponse2021 PlaylistPostMerge (PlaylistMergeBody body)

Post a playlist, do not remove previously imported items

Post a playlist with 'keep structure' method, but do not remove previously imported items

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class PlaylistPostMergeExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new PlaylistMergeBody(); // PlaylistMergeBody | Data *(Required)*

            try
            {
                // Post a playlist, do not remove previously imported items
                InlineResponse2021 result = apiInstance.PlaylistPostMerge(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.PlaylistPostMerge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PlaylistMergeBody**](PlaylistMergeBody.md)| Data *(Required)* | 

### Return type

[**InlineResponse2021**](InlineResponse2021.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playlistpoststructure"></a>
# **PlaylistPostStructure**
> InlineResponse2021 PlaylistPostStructure (PlaylistStructureBody body)

Post a playlist, keep current structure

Post a playlist for a block. Existing Items can referenced by external_id. When Items are moved, this function **will attempt to** keep Items' ModelType structure in rundown.

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new PlaylistStructureBody(); // PlaylistStructureBody | Data *(Required)*

            try
            {
                // Post a playlist, keep current structure
                InlineResponse2021 result = apiInstance.PlaylistPostStructure(body);
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
 **body** | [**PlaylistStructureBody**](PlaylistStructureBody.md)| Data *(Required)* | 

### Return type

[**InlineResponse2021**](InlineResponse2021.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="playlistposttiming"></a>
# **PlaylistPostTiming**
> InlineResponse2021 PlaylistPostTiming (PlaylistTimingBody body)

Post a playlist

Post a playlist for a block. Existing Items can referenced by external_id. When Items are moved, this function **will not** keep Items' ModelType structure in rundown.

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new PlaylistTimingBody(); // PlaylistTimingBody | Data *(Required)*

            try
            {
                // Post a playlist
                InlineResponse2021 result = apiInstance.PlaylistPostTiming(body);
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
 **body** | [**PlaylistTimingBody**](PlaylistTimingBody.md)| Data *(Required)* | 

### Return type

[**InlineResponse2021**](InlineResponse2021.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="stopcurrentitem"></a>
# **StopCurrentItem**
> InlineResponse202 StopCurrentItem (ItemsStopcurrentBody body = null)

Stop an Item

Set a current playing or specific item on played

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class StopCurrentItemExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new ItemsStopcurrentBody(); // ItemsStopcurrentBody | Data *(Optional)* (optional) 

            try
            {
                // Stop an Item
                InlineResponse202 result = apiInstance.StopCurrentItem(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.StopCurrentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemsStopcurrentBody**](ItemsStopcurrentBody.md)| Data *(Optional)* | [optional] 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateitembyid"></a>
# **UpdateItemById**
> InlineResponse202 UpdateItemById (ItemDataInput body, long? id)

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new ItemDataInput(); // ItemDataInput | Data *(Optional)*
            var id = new long?(); // long? | ID of Item **(Required)**

            try
            {
                // Update extended item details by ID.
                InlineResponse202 result = apiInstance.UpdateItemById(body, id);
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
 **body** | [**ItemDataInput**](ItemDataInput.md)| Data *(Optional)* | 
 **id** | [**long?**](long?.md)| ID of Item **(Required)** | 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
