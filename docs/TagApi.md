# RadioManager.Api.TagApi

All URIs are relative to *https://radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTag**](TagApi.md#createtag) | **POST** /tags | Create tag.
[**DeleteTagById**](TagApi.md#deletetagbyid) | **DELETE** /tags/{id} | Delete tag by id
[**GetTagById**](TagApi.md#gettagbyid) | **GET** /tags/{id} | Get tags by id
[**ListTags**](TagApi.md#listtags) | **GET** /tags | Get a list of all the tags currently in your station.
[**UpdateTagByID**](TagApi.md#updatetagbyid) | **PATCH** /tags/{id} | Update tag by id

<a name="createtag"></a>
# **CreateTag**
> PostSuccess CreateTag (TagDataInput body)

Create tag.

Create tag.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class CreateTagExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new TagApi();
            var body = new TagDataInput(); // TagDataInput | Data **(Required)**

            try
            {
                // Create tag.
                PostSuccess result = apiInstance.CreateTag(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.CreateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TagDataInput**](TagDataInput.md)| Data **(Required)** | 

### Return type

[**PostSuccess**](PostSuccess.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetagbyid"></a>
# **DeleteTagById**
> Success DeleteTagById (long? id)

Delete tag by id

Delete tag by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class DeleteTagByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new TagApi();
            var id = 789;  // long? | ID of Tag **(Required)**

            try
            {
                // Delete tag by id
                Success result = apiInstance.DeleteTagById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.DeleteTagById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Tag **(Required)** | 

### Return type

[**Success**](Success.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettagbyid"></a>
# **GetTagById**
> TagResult GetTagById (long? id, long? externalStationId = null)

Get tags by id

Get tags by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetTagByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new TagApi();
            var id = 789;  // long? | ID of Tag **(Required)**
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get tags by id
                TagResult result = apiInstance.GetTagById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.GetTagById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Tag **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**TagResult**](TagResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listtags"></a>
# **ListTags**
> Object ListTags (long? page = null, long? programId = null, long? itemId = null, long? broadcastId = null, long? contactId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

Get a list of all the tags currently in your station.

Get a list of all the tags currently in your station. This feature supports pagination and will give a maximum results of 50 tags back.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListTagsExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new TagApi();
            var page = 789;  // long? | Current page *(Optional)* (optional) 
            var programId = 789;  // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var itemId = 789;  // long? | Search on Item ID *(Optional)* `(Relation)` (optional) 
            var broadcastId = 789;  // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var contactId = 789;  // long? | Search on Contact ID *(Optional)* `(Relation)` (optional) 
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get a list of all the tags currently in your station.
                Object result = apiInstance.ListTags(page, programId, itemId, broadcastId, contactId, limit, orderBy, orderDirection, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.ListTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **long?**| Current page *(Optional)* | [optional] 
 **programId** | **long?**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **itemId** | **long?**| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | **long?**| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **contactId** | **long?**| Search on Contact ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
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
<a name="updatetagbyid"></a>
# **UpdateTagByID**
> Success UpdateTagByID (long? id, TagDataInput body = null)

Update tag by id

Update tag by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class UpdateTagByIDExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new TagApi();
            var id = 789;  // long? | ID of Tag **(Required)**
            var body = new TagDataInput(); // TagDataInput | Data *(Optional)* (optional) 

            try
            {
                // Update tag by id
                Success result = apiInstance.UpdateTagByID(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.UpdateTagByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Tag **(Required)** | 
 **body** | [**TagDataInput**](TagDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
