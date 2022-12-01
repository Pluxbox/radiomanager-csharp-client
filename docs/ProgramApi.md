# RadioManager.Api.ProgramApi

All URIs are relative to *https://staging.radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProgram**](ProgramApi.md#createprogram) | **POST** /programs | Create program.
[**DeleteProgramById**](ProgramApi.md#deleteprogrambyid) | **DELETE** /programs/{id} | Delete program by id
[**GetProgramById**](ProgramApi.md#getprogrambyid) | **GET** /programs/{id} | Get program by id
[**ListPrograms**](ProgramApi.md#listprograms) | **GET** /programs | Get all programs.
[**UpdateProgramByID**](ProgramApi.md#updateprogrambyid) | **PATCH** /programs/{id} | Update program by id

<a name="createprogram"></a>
# **CreateProgram**
> InlineResponse2002 CreateProgram (ProgramDataInput body)

Create program.

Create program.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class CreateProgramExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var body = new ProgramDataInput(); // ProgramDataInput | Data **(Required)**

            try
            {
                // Create program.
                InlineResponse2002 result = apiInstance.CreateProgram(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.CreateProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProgramDataInput**](ProgramDataInput.md)| Data **(Required)** | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteprogrambyid"></a>
# **DeleteProgramById**
> InlineResponse202 DeleteProgramById (long? id)

Delete program by id

Delete program by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class DeleteProgramByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var id = new long?(); // long? | ID of program **(Required)**

            try
            {
                // Delete program by id
                InlineResponse202 result = apiInstance.DeleteProgramById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.DeleteProgramById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**long?**](long?.md)| ID of program **(Required)** | 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprogrambyid"></a>
# **GetProgramById**
> ProgramResult GetProgramById (long? id, long? externalStationId = null)

Get program by id

Get program by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetProgramByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var id = new long?(); // long? | ID of Program **(Required)**
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get program by id
                ProgramResult result = apiInstance.GetProgramById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.GetProgramById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**long?**](long?.md)| ID of Program **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ProgramResult**](ProgramResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listprograms"></a>
# **ListPrograms**
> InlineResponse20011 ListPrograms (long? broadcastId = null, long? modelTypeId = null, long? tagId = null, long? presenterId = null, long? genreId = null, long? groupId = null, long? blockId = null, long? itemId = null, int? disabled = null, long? page = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

Get all programs.

List all programs.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListProgramsExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var broadcastId = new long?(); // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var modelTypeId = new long?(); // long? | Search on ModelType ID *(Optional)* `(Relation)` (optional) 
            var tagId = new long?(); // long? | Search on Tag ID *(Optional)* `(Relation)` (optional) 
            var presenterId = new long?(); // long? | Search on Presenter ID *(Optional)* `(Relation)` (optional) 
            var genreId = new long?(); // long? | Search on Genre ID *(Optional)* (optional) 
            var groupId = new long?(); // long? | Search on Group ID *(Optional)* (optional) 
            var blockId = new long?(); // long? | Search on Block ID *(Optional)* `(Relation)` (optional) 
            var itemId = new long?(); // long? | Search on Item ID *(Optional)* `(Relation)` (optional) 
            var disabled = new int?(); // int? | Search on Disabled status *(Optional)* (optional) 
            var page = 789;  // long? | Current page *(Optional)* (optional)  (default to 1)
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get all programs.
                InlineResponse20011 result = apiInstance.ListPrograms(broadcastId, modelTypeId, tagId, presenterId, genreId, groupId, blockId, itemId, disabled, page, limit, orderBy, orderDirection, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.ListPrograms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **broadcastId** | [**long?**](long?.md)| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **modelTypeId** | [**long?**](long?.md)| Search on ModelType ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **tagId** | [**long?**](long?.md)| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **presenterId** | [**long?**](long?.md)| Search on Presenter ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **genreId** | [**long?**](long?.md)| Search on Genre ID *(Optional)* | [optional] 
 **groupId** | [**long?**](long?.md)| Search on Group ID *(Optional)* | [optional] 
 **blockId** | [**long?**](long?.md)| Search on Block ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **itemId** | [**long?**](long?.md)| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **disabled** | [**int?**](int?.md)| Search on Disabled status *(Optional)* | [optional] 
 **page** | **long?**| Current page *(Optional)* | [optional] [default to 1]
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateprogrambyid"></a>
# **UpdateProgramByID**
> InlineResponse202 UpdateProgramByID (ProgramDataInput body, long? id)

Update program by id

Update program by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class UpdateProgramByIDExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var body = new ProgramDataInput(); // ProgramDataInput | Data *(Optional)*
            var id = new long?(); // long? | ID of Program **(Required)**

            try
            {
                // Update program by id
                InlineResponse202 result = apiInstance.UpdateProgramByID(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.UpdateProgramByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProgramDataInput**](ProgramDataInput.md)| Data *(Optional)* | 
 **id** | [**long?**](long?.md)| ID of Program **(Required)** | 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
