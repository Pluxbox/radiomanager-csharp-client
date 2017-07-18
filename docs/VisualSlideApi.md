# RadioManager.Api.VisualSlideApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadVisualSlide**](VisualSlideApi.md#downloadvisualslide) | **GET** /visual/image | Get Visual Slide Image as JPEG
[**GetVisualSlide**](VisualSlideApi.md#getvisualslide) | **GET** /visual | Get Visual Slide Image as Base64


<a name="downloadvisualslide"></a>
# **DownloadVisualSlide**
> VisualImageResult DownloadVisualSlide ()

Get Visual Slide Image as JPEG

Get Visual Slide Image as JPEG

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class DownloadVisualSlideExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new VisualSlideApi();

            try
            {
                // Get Visual Slide Image as JPEG
                VisualImageResult result = apiInstance.DownloadVisualSlide();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VisualSlideApi.DownloadVisualSlide: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**VisualImageResult**](VisualImageResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvisualslide"></a>
# **GetVisualSlide**
> VisualResult GetVisualSlide ()

Get Visual Slide Image as Base64

Get Visual Slide Image as Base64

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetVisualSlideExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new VisualSlideApi();

            try
            {
                // Get Visual Slide Image as Base64
                VisualResult result = apiInstance.GetVisualSlide();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VisualSlideApi.GetVisualSlide: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**VisualResult**](VisualResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

