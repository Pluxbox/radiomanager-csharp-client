# RadioManager.Api.BlockApi

All URIs are relative to *https://radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBlockById**](BlockApi.md#getblockbyid) | **GET** /blocks/{id} | Get block by id
[**GetCurrentBlock**](BlockApi.md#getcurrentblock) | **GET** /blocks/current | Get current Block
[**GetNextBlock**](BlockApi.md#getnextblock) | **GET** /blocks/next | Get upcoming Block
[**ListBlocks**](BlockApi.md#listblocks) | **GET** /blocks | Get a list of all blocks currently in your station.

<a name="getblockbyid"></a>
# **GetBlockById**
> BlockResult GetBlockById (long? id, long? externalStationId = null)

Get block by id

Get block by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetBlockByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BlockApi();
            var id = new long?(); // long? | ID of Block **(Required)**
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get block by id
                BlockResult result = apiInstance.GetBlockById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.GetBlockById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**long?**](long?.md)| ID of Block **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**BlockResult**](BlockResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentblock"></a>
# **GetCurrentBlock**
> BlockResult GetCurrentBlock ()

Get current Block

Get currently playing Block

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetCurrentBlockExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BlockApi();

            try
            {
                // Get current Block
                BlockResult result = apiInstance.GetCurrentBlock();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.GetCurrentBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BlockResult**](BlockResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnextblock"></a>
# **GetNextBlock**
> BlockResult GetNextBlock ()

Get upcoming Block

Get currently upcoming Block

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetNextBlockExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BlockApi();

            try
            {
                // Get upcoming Block
                BlockResult result = apiInstance.GetNextBlock();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.GetNextBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BlockResult**](BlockResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listblocks"></a>
# **ListBlocks**
> InlineResponse200 ListBlocks (long? broadcastId = null, long? itemId = null, long? programId = null, DateTime? startMin = null, DateTime? startMax = null, long? page = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

Get a list of all blocks currently in your station.

Get a list of all blocks currently in your station. This feature supports pagination and will give a maximum of 50 blocks back.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListBlocksExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BlockApi();
            var broadcastId = new long?(); // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var itemId = new long?(); // long? | Search on Item ID *(Optional)* `(Relation)` (optional) 
            var programId = new long?(); // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var startMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Minimum start date *(Optional)* (optional) 
            var startMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Maximum start date *(Optional)* (optional) 
            var page = 789;  // long? | Current page *(Optional)* (optional)  (default to 1)
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get a list of all blocks currently in your station.
                InlineResponse200 result = apiInstance.ListBlocks(broadcastId, itemId, programId, startMin, startMax, page, limit, orderBy, orderDirection, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.ListBlocks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **broadcastId** | [**long?**](long?.md)| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **itemId** | [**long?**](long?.md)| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **programId** | [**long?**](long?.md)| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **startMin** | **DateTime?**| Minimum start date *(Optional)* | [optional] 
 **startMax** | **DateTime?**| Maximum start date *(Optional)* | [optional] 
 **page** | **long?**| Current page *(Optional)* | [optional] [default to 1]
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
