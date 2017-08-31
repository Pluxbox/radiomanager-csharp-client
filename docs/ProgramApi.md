# RadioManager.Api.ProgramApi

All URIs are relative to *http://radiomanager.pb/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProgram**](ProgramApi.md#createprogram) | **POST** /programs | Create program.
[**DeleteProgramById**](ProgramApi.md#deleteprogrambyid) | **DELETE** /programs/{id} | Delete program by id
[**GetProgramById**](ProgramApi.md#getprogrambyid) | **GET** /programs/{id} | Get program by id
[**ListPrograms**](ProgramApi.md#listprograms) | **GET** /programs | Get all programs.
[**UpdateProgramByID**](ProgramApi.md#updateprogrambyid) | **PATCH** /programs/{id} | Update program by id


<a name="createprogram"></a>
# **CreateProgram**
> PostSuccess CreateProgram (ProgramDataInput data)

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
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var data = new ProgramDataInput(); // ProgramDataInput | Data **(Required)**

            try
            {
                // Create program.
                PostSuccess result = apiInstance.CreateProgram(data);
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
 **data** | [**ProgramDataInput**](ProgramDataInput.md)| Data **(Required)** | 

### Return type

[**PostSuccess**](PostSuccess.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprogrambyid"></a>
# **DeleteProgramById**
> Success DeleteProgramById (long? id)

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
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var id = 789;  // long? | ID of program **(Required)**

            try
            {
                // Delete program by id
                Success result = apiInstance.DeleteProgramById(id);
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
 **id** | **long?**| ID of program **(Required)** | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
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
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var id = 789;  // long? | ID of Program **(Required)**
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
 **id** | **long?**| ID of Program **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ProgramResult**](ProgramResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listprograms"></a>
# **ListPrograms**
> ProgramResults ListPrograms (long? page = null, long? genreId = null, long? modelTypeId = null, long? presenterId = null, long? tagId = null, long? broadcastId = null, long? itemId = null, long? blockId = null, long? externalStationId = null)

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
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var page = 789;  // long? | Current page *(Optional)* (optional) 
            var genreId = 789;  // long? | Search on Genre ID *(Optional)* (optional) 
            var modelTypeId = 789;  // long? | Search on ModelType ID *(Optional)* (optional) 
            var presenterId = 789;  // long? | Search on Presenter ID *(Optional)* `(Relation)` (optional) 
            var tagId = 789;  // long? | Search on Tag ID *(Optional)* `(Relation)` (optional) 
            var broadcastId = 789;  // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var itemId = 789;  // long? | Search on Item ID *(Optional)* `(Relation)` (optional) 
            var blockId = 789;  // long? | Search on Block ID *(Optional)* `(Relation)` (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get all programs.
                ProgramResults result = apiInstance.ListPrograms(page, genreId, modelTypeId, presenterId, tagId, broadcastId, itemId, blockId, externalStationId);
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
 **page** | **long?**| Current page *(Optional)* | [optional] 
 **genreId** | **long?**| Search on Genre ID *(Optional)* | [optional] 
 **modelTypeId** | **long?**| Search on ModelType ID *(Optional)* | [optional] 
 **presenterId** | **long?**| Search on Presenter ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **tagId** | **long?**| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | **long?**| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **itemId** | **long?**| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **blockId** | **long?**| Search on Block ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ProgramResults**](ProgramResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprogrambyid"></a>
# **UpdateProgramByID**
> Success UpdateProgramByID (long? id, ProgramDataInput data = null)

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
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ProgramApi();
            var id = 789;  // long? | ID of Program **(Required)**
            var data = new ProgramDataInput(); // ProgramDataInput | Data *(Optional)* (optional) 

            try
            {
                // Update program by id
                Success result = apiInstance.UpdateProgramByID(id, data);
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
 **id** | **long?**| ID of Program **(Required)** | 
 **data** | [**ProgramDataInput**](ProgramDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

