# RadioManager.Api.BroadcastApi

All URIs are relative to *http://radiomanager.pb/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBroadcast**](BroadcastApi.md#createbroadcast) | **POST** /broadcasts | Create broadcast.
[**DeleteBroadcastById**](BroadcastApi.md#deletebroadcastbyid) | **DELETE** /broadcasts/{id} | Delete broadcast by id
[**GetBroadcastById**](BroadcastApi.md#getbroadcastbyid) | **GET** /broadcasts/{id} | Get broadcast by id
[**GetCurrentBroadcast**](BroadcastApi.md#getcurrentbroadcast) | **GET** /broadcasts/current | Get current Broadcast
[**GetDailyEPG**](BroadcastApi.md#getdailyepg) | **GET** /broadcasts/epg/daily | Get daily EPG
[**GetEPGByDate**](BroadcastApi.md#getepgbydate) | **GET** /broadcasts/epg | Get EPG by date
[**GetNextBroadcast**](BroadcastApi.md#getnextbroadcast) | **GET** /broadcasts/next | Get next Broadcast
[**GetWeeklyEPG**](BroadcastApi.md#getweeklyepg) | **GET** /broadcasts/epg/weekly | Get weekly EPG
[**ListBroadcasts**](BroadcastApi.md#listbroadcasts) | **GET** /broadcasts | Get all broadcasts.
[**PrintBroadcastById**](BroadcastApi.md#printbroadcastbyid) | **GET** /broadcasts/print/{id} | Print Broadcast by id
[**UpdateBroadcastByID**](BroadcastApi.md#updatebroadcastbyid) | **PATCH** /broadcasts/{id} | Update broadcast by id


<a name="createbroadcast"></a>
# **CreateBroadcast**
> PostSuccess CreateBroadcast (BroadcastDataInput data)

Create broadcast.

Create broadcast.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class CreateBroadcastExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();
            var data = new BroadcastDataInput(); // BroadcastDataInput | Data **(Required)**

            try
            {
                // Create broadcast.
                PostSuccess result = apiInstance.CreateBroadcast(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.CreateBroadcast: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**BroadcastDataInput**](BroadcastDataInput.md)| Data **(Required)** | 

### Return type

[**PostSuccess**](PostSuccess.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebroadcastbyid"></a>
# **DeleteBroadcastById**
> Success DeleteBroadcastById (long? id)

Delete broadcast by id

Delete broadcast by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class DeleteBroadcastByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();
            var id = 789;  // long? | ID of Broadcast **(Required)**

            try
            {
                // Delete broadcast by id
                Success result = apiInstance.DeleteBroadcastById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.DeleteBroadcastById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Broadcast **(Required)** | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbroadcastbyid"></a>
# **GetBroadcastById**
> BroadcastResult GetBroadcastById (long? id, long? externalStationId = null)

Get broadcast by id

Get broadcast by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetBroadcastByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();
            var id = 789;  // long? | ID of Broadcast **(Required)**
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get broadcast by id
                BroadcastResult result = apiInstance.GetBroadcastById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.GetBroadcastById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Broadcast **(Required)** | 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**BroadcastResult**](BroadcastResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentbroadcast"></a>
# **GetCurrentBroadcast**
> Broadcast GetCurrentBroadcast ()

Get current Broadcast

Get current Broadcast

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetCurrentBroadcastExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();

            try
            {
                // Get current Broadcast
                Broadcast result = apiInstance.GetCurrentBroadcast();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.GetCurrentBroadcast: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Broadcast**](Broadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdailyepg"></a>
# **GetDailyEPG**
> EPGBroadcast GetDailyEPG (DateTime? date = null)

Get daily EPG

Get current Broadcast

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetDailyEPGExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Date *(Optional)* (optional) 

            try
            {
                // Get daily EPG
                EPGBroadcast result = apiInstance.GetDailyEPG(date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.GetDailyEPG: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime?**| Date *(Optional)* | [optional] 

### Return type

[**EPGBroadcast**](EPGBroadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getepgbydate"></a>
# **GetEPGByDate**
> EPGBroadcast GetEPGByDate (DateTime? date = null)

Get EPG by date

Get EPG by date

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetEPGByDateExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Date *(Optional)* (optional) 

            try
            {
                // Get EPG by date
                EPGBroadcast result = apiInstance.GetEPGByDate(date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.GetEPGByDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime?**| Date *(Optional)* | [optional] 

### Return type

[**EPGBroadcast**](EPGBroadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnextbroadcast"></a>
# **GetNextBroadcast**
> Broadcast GetNextBroadcast ()

Get next Broadcast

Get next Broadcast

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetNextBroadcastExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();

            try
            {
                // Get next Broadcast
                Broadcast result = apiInstance.GetNextBroadcast();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.GetNextBroadcast: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Broadcast**](Broadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getweeklyepg"></a>
# **GetWeeklyEPG**
> EPGBroadcast GetWeeklyEPG (string date = null)

Get weekly EPG

Get weekly EPG

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetWeeklyEPGExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();
            var date = date_example;  // string | Date *(Optional)* (optional) 

            try
            {
                // Get weekly EPG
                EPGBroadcast result = apiInstance.GetWeeklyEPG(date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.GetWeeklyEPG: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **string**| Date *(Optional)* | [optional] 

### Return type

[**EPGBroadcast**](EPGBroadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbroadcasts"></a>
# **ListBroadcasts**
> BroadcastResults ListBroadcasts (long? page = null, DateTime? startMin = null, DateTime? startMax = null, long? modelTypeId = null, long? tagId = null, long? presenterId = null, long? itemId = null, long? blockId = null, long? genreId = null, long? programId = null, long? externalStationId = null)

Get all broadcasts.

List all broadcasts.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListBroadcastsExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();
            var page = 789;  // long? | Current page *(Optional)* (optional)  (default to 1)
            var startMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Minimum start date *(Optional)* (optional) 
            var startMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Maximum start date *(Optional)* (optional) 
            var modelTypeId = 789;  // long? | Search on ModelType ID *(Optional)* (optional) 
            var tagId = 789;  // long? | Search on Tag ID *(Optional)* `(Relation)` (optional) 
            var presenterId = 789;  // long? | Search on Presenter ID *(Optional)* `(Relation)` (optional) 
            var itemId = 789;  // long? | Search on Item ID *(Optional)* `(Relation)` (optional) 
            var blockId = 789;  // long? | Search on Block ID *(Optional)* `(Relation)` (optional) 
            var genreId = 789;  // long? | Search on Genre ID *(Optional)* `(Relation)` (optional) 
            var programId = 789;  // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get all broadcasts.
                BroadcastResults result = apiInstance.ListBroadcasts(page, startMin, startMax, modelTypeId, tagId, presenterId, itemId, blockId, genreId, programId, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.ListBroadcasts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **long?**| Current page *(Optional)* | [optional] [default to 1]
 **startMin** | **DateTime?**| Minimum start date *(Optional)* | [optional] 
 **startMax** | **DateTime?**| Maximum start date *(Optional)* | [optional] 
 **modelTypeId** | **long?**| Search on ModelType ID *(Optional)* | [optional] 
 **tagId** | **long?**| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **presenterId** | **long?**| Search on Presenter ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **itemId** | **long?**| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **blockId** | **long?**| Search on Block ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **genreId** | **long?**| Search on Genre ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **programId** | **long?**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **externalStationId** | **long?**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**BroadcastResults**](BroadcastResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printbroadcastbyid"></a>
# **PrintBroadcastById**
> EPGBroadcast PrintBroadcastById (long? id, long? programId = null, long? presenterId = null, long? tagId = null)

Print Broadcast by id

Print Broadcast by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class PrintBroadcastByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();
            var id = 789;  // long? | ID of Broadcast **(Required)**
            var programId = 789;  // long? | Search on Program ID *(Optional)* `(Relation)` (optional) 
            var presenterId = 789;  // long? | Search on Presenter ID *(Optional)* `(Relation)` (optional) 
            var tagId = 789;  // long? | Search on Tag ID *(Optional)* `(Relation)` (optional) 

            try
            {
                // Print Broadcast by id
                EPGBroadcast result = apiInstance.PrintBroadcastById(id, programId, presenterId, tagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.PrintBroadcastById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Broadcast **(Required)** | 
 **programId** | **long?**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **presenterId** | **long?**| Search on Presenter ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **tagId** | **long?**| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 

### Return type

[**EPGBroadcast**](EPGBroadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebroadcastbyid"></a>
# **UpdateBroadcastByID**
> Success UpdateBroadcastByID (long? id, BroadcastDataInput data = null)

Update broadcast by id

Update broadcast by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class UpdateBroadcastByIDExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BroadcastApi();
            var id = 789;  // long? | ID of Broadcast **(Required)**
            var data = new BroadcastDataInput(); // BroadcastDataInput | Data *(Optional)* (optional) 

            try
            {
                // Update broadcast by id
                Success result = apiInstance.UpdateBroadcastByID(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BroadcastApi.UpdateBroadcastByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of Broadcast **(Required)** | 
 **data** | [**BroadcastDataInput**](BroadcastDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

