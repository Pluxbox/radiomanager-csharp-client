# RadioManager.Api.GroupApi

All URIs are relative to *https://radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGroupById**](GroupApi.md#getgroupbyid) | **GET** /groups/{id} | Get group by id
[**ListGroups**](GroupApi.md#listgroups) | **GET** /groups | Get all groups.

<a name="getgroupbyid"></a>
# **GetGroupById**
> GroupResult GetGroupById (long? id, long? externalStationId = null)

Get group by id

Get group by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetGroupByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new GroupApi();
            var id = new long?(); // long? | id of Group
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get group by id
                GroupResult result = apiInstance.GetGroupById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**long?**](long?.md)| id of Group | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**GroupResult**](GroupResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listgroups"></a>
# **ListGroups**
> InlineResponse2007 ListGroups (long? broadcastId = null, long? programId = null, long? userId = null, long? page = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

Get all groups.

List all groups.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListGroupsExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new GroupApi();
            var broadcastId = new long?(); // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var programId = new long?(); // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var userId = new long?(); // long? | Search on User ID *(Optional)* `(Relation)` (optional) 
            var page = 789;  // long? | Current page *(Optional)* (optional)  (default to 1)
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get all groups.
                InlineResponse2007 result = apiInstance.ListGroups(broadcastId, programId, userId, page, limit, orderBy, orderDirection, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.ListGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **broadcastId** | [**long?**](long?.md)| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **programId** | [**long?**](long?.md)| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **userId** | [**long?**](long?.md)| Search on User ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **page** | **long?**| Current page *(Optional)* | [optional] [default to 1]
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
