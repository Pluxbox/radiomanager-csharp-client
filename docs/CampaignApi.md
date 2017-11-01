# RadioManager.Api.CampaignApi

All URIs are relative to *https://staging.radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCampaign**](CampaignApi.md#createcampaign) | **POST** /campaigns | Create campaign.
[**DeleteCampaignById**](CampaignApi.md#deletecampaignbyid) | **DELETE** /campaigns/{id} | Delete campaign by id
[**GetCampaignById**](CampaignApi.md#getcampaignbyid) | **GET** /campaigns/{id} | Get campaign by id
[**ListCampaigns**](CampaignApi.md#listcampaigns) | **GET** /campaigns | Get all campaigns.
[**UpdateCampaignByID**](CampaignApi.md#updatecampaignbyid) | **PATCH** /campaigns/{id} | Update campaign by id


<a name="createcampaign"></a>
# **CreateCampaign**
> PostSuccess CreateCampaign (CampaignDataInput data)

Create campaign.

Create campaign.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class CreateCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new CampaignApi();
            var data = new CampaignDataInput(); // CampaignDataInput | Data **(Required)**

            try
            {
                // Create campaign.
                PostSuccess result = apiInstance.CreateCampaign(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CreateCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**CampaignDataInput**](CampaignDataInput.md)| Data **(Required)** | 

### Return type

[**PostSuccess**](PostSuccess.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecampaignbyid"></a>
# **DeleteCampaignById**
> Success DeleteCampaignById (long? id)

Delete campaign by id

Delete campaign by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class DeleteCampaignByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new CampaignApi();
            var id = 789;  // long? | ID of Campaign **(Required)**

            try
            {
                // Delete campaign by id
                Success result = apiInstance.DeleteCampaignById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.DeleteCampaignById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Campaign **(Required)** | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignbyid"></a>
# **GetCampaignById**
> CampaignResult GetCampaignById (long? id, long? externalStationId = null)

Get campaign by id

Get campaign by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetCampaignByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new CampaignApi();
            var id = 789;  // long? | ID of Campaign **(Required)**
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get campaign by id
                CampaignResult result = apiInstance.GetCampaignById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.GetCampaignById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Campaign **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**CampaignResult**](CampaignResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcampaigns"></a>
# **ListCampaigns**
> CampaignResults ListCampaigns (long? page = null, long? itemId = null, long? modelTypeId = null, DateTime? startMin = null, DateTime? startMax = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)

Get all campaigns.

List all campaigns.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListCampaignsExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new CampaignApi();
            var page = 789;  // long? | Current page *(Optional)* (optional) 
            var itemId = 789;  // long? | Search on Item ID *(Optional)* `(Relation)` (optional) 
            var modelTypeId = 789;  // long? | Search on ModelType ID *(Optional)* `(Relation)` (optional) 
            var startMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Minimum start date *(Optional)* (optional) 
            var startMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Maximum start date *(Optional)* (optional) 
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get all campaigns.
                CampaignResults result = apiInstance.ListCampaigns(page, itemId, modelTypeId, startMin, startMax, limit, orderBy, orderDirection, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.ListCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **long?**| Current page *(Optional)* | [optional] 
 **itemId** | **long?**| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **modelTypeId** | **long?**| Search on ModelType ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **startMin** | **DateTime?**| Minimum start date *(Optional)* | [optional] 
 **startMax** | **DateTime?**| Maximum start date *(Optional)* | [optional] 
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**CampaignResults**](CampaignResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecampaignbyid"></a>
# **UpdateCampaignByID**
> Success UpdateCampaignByID (long? id, CampaignDataInput data = null)

Update campaign by id

Update campaign by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class UpdateCampaignByIDExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new CampaignApi();
            var id = 789;  // long? | ID of Campaign **(Required)**
            var data = new CampaignDataInput(); // CampaignDataInput | Data *(Optional)* (optional) 

            try
            {
                // Update campaign by id
                Success result = apiInstance.UpdateCampaignByID(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.UpdateCampaignByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Campaign **(Required)** | 
 **data** | [**CampaignDataInput**](CampaignDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

