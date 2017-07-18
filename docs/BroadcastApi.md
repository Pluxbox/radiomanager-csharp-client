# \BroadcastApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBroadcast**](BroadcastApi.md#CreateBroadcast) | **Post** /broadcasts | Create broadcast.
[**DeleteBroadcastById**](BroadcastApi.md#DeleteBroadcastById) | **Delete** /broadcasts/{id} | Delete broadcast by id
[**GetBroadcastById**](BroadcastApi.md#GetBroadcastById) | **Get** /broadcasts/{id} | Get broadcast by id
[**GetCurrentBroadcast**](BroadcastApi.md#GetCurrentBroadcast) | **Get** /broadcasts/current | Get current Broadcast
[**GetDailyEPG**](BroadcastApi.md#GetDailyEPG) | **Get** /broadcasts/epg/daily | Get daily EPG
[**GetEPGByDate**](BroadcastApi.md#GetEPGByDate) | **Get** /broadcasts/epg | Get EPG by date
[**GetNextBroadcast**](BroadcastApi.md#GetNextBroadcast) | **Get** /broadcasts/next | Get next Broadcast
[**GetWeeklyEPG**](BroadcastApi.md#GetWeeklyEPG) | **Get** /broadcasts/epg/weekly | Get weekly EPG
[**ListBroadcasts**](BroadcastApi.md#ListBroadcasts) | **Get** /broadcasts | Get all broadcasts.
[**PrintBroadcastById**](BroadcastApi.md#PrintBroadcastById) | **Get** /broadcasts/print/{id} | Print Broadcast by id
[**UpdateBroadcastByID**](BroadcastApi.md#UpdateBroadcastByID) | **Patch** /broadcasts/{id} | Update broadcast by id


# **CreateBroadcast**
> PostSuccess CreateBroadcast($data)

Create broadcast.

Create broadcast.


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

# **DeleteBroadcastById**
> Success DeleteBroadcastById($id)

Delete broadcast by id

Delete broadcast by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Broadcast **(Required)** | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetBroadcastById**
> BroadcastResult GetBroadcastById($id, $externalStationId)

Get broadcast by id

Get broadcast by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Broadcast **(Required)** | 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**BroadcastResult**](BroadcastResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetCurrentBroadcast**
> Broadcast GetCurrentBroadcast()

Get current Broadcast

Get current Broadcast


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

# **GetDailyEPG**
> EpgBroadcast GetDailyEPG($date)

Get daily EPG

Get current Broadcast


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **time.Time**| Date *(Optional)* | [optional] 

### Return type

[**EpgBroadcast**](EPG_Broadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetEPGByDate**
> EpgBroadcast GetEPGByDate($date)

Get EPG by date

Get EPG by date


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **time.Time**| Date *(Optional)* | [optional] 

### Return type

[**EpgBroadcast**](EPG_Broadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetNextBroadcast**
> Broadcast GetNextBroadcast()

Get next Broadcast

Get next Broadcast


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

# **GetWeeklyEPG**
> EpgBroadcast GetWeeklyEPG($date)

Get weekly EPG

Get weekly EPG


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **string**| Date *(Optional)* | [optional] 

### Return type

[**EpgBroadcast**](EPG_Broadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListBroadcasts**
> BroadcastResults ListBroadcasts($page, $startMin, $startMax, $modelTypeId, $tagId, $presenterId, $itemId, $blockId, $genreId, $programId, $externalStationId)

Get all broadcasts.

List all broadcasts.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int64**| Current page *(Optional)* | [optional] [default to 1]
 **startMin** | **time.Time**| Minimum start date *(Optional)* | [optional] 
 **startMax** | **time.Time**| Maximum start date *(Optional)* | [optional] 
 **modelTypeId** | **int64**| Search on ModelType ID *(Optional)* | [optional] 
 **tagId** | **int64**| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **presenterId** | **int64**| Search on Presenter ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **itemId** | **int64**| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **blockId** | **int64**| Search on Block ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **genreId** | **int64**| Search on Genre ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **programId** | **int64**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**BroadcastResults**](BroadcastResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **PrintBroadcastById**
> EpgBroadcast PrintBroadcastById($id, $programId, $presenterId, $tagId)

Print Broadcast by id

Print Broadcast by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Broadcast **(Required)** | 
 **programId** | **int64**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **presenterId** | **int64**| Search on Presenter ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **tagId** | **int64**| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 

### Return type

[**EpgBroadcast**](EPG_Broadcast.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateBroadcastByID**
> Success UpdateBroadcastByID($id, $data)

Update broadcast by id

Update broadcast by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Broadcast **(Required)** | 
 **data** | [**BroadcastDataInput**](BroadcastDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

