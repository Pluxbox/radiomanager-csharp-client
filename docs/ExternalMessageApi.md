# RadioManager.Api.ExternalMessageApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QueueExternalMessage**](ExternalMessageApi.md#queueexternalmessage) | **POST** /externalmessagequeue | Queue External Message.


<a name="queueexternalmessage"></a>
# **QueueExternalMessage**
> Object QueueExternalMessage (ExternalMessageQueueData message)

Queue External Message.

Queue External Message.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class QueueExternalMessageExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ExternalMessageApi();
            var message = new ExternalMessageQueueData(); // ExternalMessageQueueData | Data **(Required)**

            try
            {
                // Queue External Message.
                Object result = apiInstance.QueueExternalMessage(message);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalMessageApi.QueueExternalMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **message** | [**ExternalMessageQueueData**](ExternalMessageQueueData.md)| Data **(Required)** | 

### Return type

**Object**

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

