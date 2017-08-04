# RadioManager.Api.PresenterApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePresenter**](PresenterApi.md#createpresenter) | **POST** /presenters | Create presenter.
[**DeletePresenterById**](PresenterApi.md#deletepresenterbyid) | **DELETE** /presenters/{id} | Delete presenter by id
[**GetPresenterById**](PresenterApi.md#getpresenterbyid) | **GET** /presenters/{id} | Get presenter by id
[**ListPresenters**](PresenterApi.md#listpresenters) | **GET** /presenters | Get all presenters.
[**UpdatePresenterByID**](PresenterApi.md#updatepresenterbyid) | **PATCH** /presenters/{id} | Update presenter by id


<a name="createpresenter"></a>
# **CreatePresenter**
> PostSuccess CreatePresenter (PresenterDataInput data)

Create presenter.

Create presenter.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class CreatePresenterExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new PresenterApi();
            var data = new PresenterDataInput(); // PresenterDataInput | Data **(Required)**

            try
            {
                // Create presenter.
                PostSuccess result = apiInstance.CreatePresenter(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenterApi.CreatePresenter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**PresenterDataInput**](PresenterDataInput.md)| Data **(Required)** | 

### Return type

[**PostSuccess**](PostSuccess.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepresenterbyid"></a>
# **DeletePresenterById**
> Success DeletePresenterById (long? id)

Delete presenter by id

Delete presenter by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class DeletePresenterByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new PresenterApi();
            var id = 789;  // long? | id of presenter

            try
            {
                // Delete presenter by id
                Success result = apiInstance.DeletePresenterById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenterApi.DeletePresenterById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id of presenter | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpresenterbyid"></a>
# **GetPresenterById**
> PresenterResult GetPresenterById (long? id, long? externalStationId = null)

Get presenter by id

Get presenter by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetPresenterByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new PresenterApi();
            var id = 789;  // long? | id of Presenter
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get presenter by id
                PresenterResult result = apiInstance.GetPresenterById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenterApi.GetPresenterById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id of Presenter | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**PresenterResult**](PresenterResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpresenters"></a>
# **ListPresenters**
> PresenterResults ListPresenters (long? page = null, long? modelTypeId = null, long? programId = null, long? broadcastId = null, long? externalStationId = null)

Get all presenters.

List all presenters.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListPresentersExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new PresenterApi();
            var page = 789;  // long? | Current page *(Optional)* (optional) 
            var modelTypeId = 789;  // long? | Search on ModelType ID (Optional) (optional) 
            var programId = 789;  // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var broadcastId = 789;  // long? | Search on Broadcast ID *(Optional)* `(Relation)` (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get all presenters.
                PresenterResults result = apiInstance.ListPresenters(page, modelTypeId, programId, broadcastId, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenterApi.ListPresenters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **long?**| Current page *(Optional)* | [optional] 
 **modelTypeId** | **long?**| Search on ModelType ID (Optional) | [optional] 
 **programId** | **long?**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | **long?**| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**PresenterResults**](PresenterResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepresenterbyid"></a>
# **UpdatePresenterByID**
> Success UpdatePresenterByID (long? id, PresenterDataInput data = null)

Update presenter by id

Update presenter by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class UpdatePresenterByIDExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new PresenterApi();
            var id = 789;  // long? | id of Presenter
            var data = new PresenterDataInput(); // PresenterDataInput | Data *(Optional)* (optional) 

            try
            {
                // Update presenter by id
                Success result = apiInstance.UpdatePresenterByID(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenterApi.UpdatePresenterByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id of Presenter | 
 **data** | [**PresenterDataInput**](PresenterDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

