# RadioManager.Api.TagApi

All URIs are relative to *https://staging.radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTag**](TagApi.md#createtag) | **POST** /tags | Create tag.
[**DeleteTagById**](TagApi.md#deletetagbyid) | **DELETE** /tags/{id} | Delete tag by id
[**GetTagById**](TagApi.md#gettagbyid) | **GET** /tags/{id} | Get tags by id
[**ListTags**](TagApi.md#listtags) | **GET** /tags | Get a list of all the tags currently in your station.
[**UpdateTagByID**](TagApi.md#updatetagbyid) | **PATCH** /tags/{id} | Update tag by id

<a name="createtag"></a>
# **CreateTag**
> InlineResponse2002 CreateTag (TagDataInput body)

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
                InlineResponse2002 result = apiInstance.CreateTag(body);
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetagbyid"></a>
# **DeleteTagById**
> InlineResponse202 DeleteTagById (long? id)

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
            var id = new long?(); // long? | ID of Tag **(Required)**

            try
            {
                // Delete tag by id
                InlineResponse202 result = apiInstance.DeleteTagById(id);
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
 **id** | [**long?**](long?.md)| ID of Tag **(Required)** | 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettagbyid"></a>
# **GetTagById**
> TagResult GetTagById (long? id)

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
            var id = new long?(); // long? | ID of Tag **(Required)**

            try
            {
                // Get tags by id
                TagResult result = apiInstance.GetTagById(id);
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
 **id** | [**long?**](long?.md)| ID of Tag **(Required)** | 

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
> InlineResponse20012 ListTags (long? programId = null, long? itemId = null, long? broadcastId = null, long? contactId = null, long? page = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

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
            var programId = new long?(); // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var itemId = new long?(); // long? | Search on Item ID *(Optional)* `(Relation)` (optional) 
            var broadcastId = new long?(); // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var contactId = new long?(); // long? | Search on Contact ID *(Optional)* `(Relation)` (optional) 
            var page = 789;  // long? | Current page *(Optional)* (optional)  (default to 1)
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get a list of all the tags currently in your station.
                InlineResponse20012 result = apiInstance.ListTags(programId, itemId, broadcastId, contactId, page, limit, orderBy, orderDirection, externalStationId);
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
 **programId** | [**long?**](long?.md)| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **itemId** | [**long?**](long?.md)| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | [**long?**](long?.md)| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **contactId** | [**long?**](long?.md)| Search on Contact ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **page** | **long?**| Current page *(Optional)* | [optional] [default to 1]
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetagbyid"></a>
# **UpdateTagByID**
> InlineResponse202 UpdateTagByID (TagDataInput body, long? id)

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
            var body = new TagDataInput(); // TagDataInput | Data *(Optional)*
            var id = new long?(); // long? | ID of Tag **(Required)**

            try
            {
                // Update tag by id
                InlineResponse202 result = apiInstance.UpdateTagByID(body, id);
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
 **body** | [**TagDataInput**](TagDataInput.md)| Data *(Optional)* | 
 **id** | [**long?**](long?.md)| ID of Tag **(Required)** | 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
