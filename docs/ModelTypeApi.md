# \ModelTypeApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetModelTypeById**](ModelTypeApi.md#GetModelTypeById) | **Get** /model_types/{id} | Get modelType by id
[**ListModelTypes**](ModelTypeApi.md#ListModelTypes) | **Get** /model_types | Get all modelTypes.


# **GetModelTypeById**
> ModelTypeResult GetModelTypeById($id, $externalStationId)

Get modelType by id

Get modelType by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of ModelType **(Required)** | 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ModelTypeResult**](ModelTypeResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListModelTypes**
> ModelTypeResults ListModelTypes($page, $model, $programId, $broadcastId, $itemId, $campaignId, $presenterId, $contactId, $externalStationId)

Get all modelTypes.

List all modelTypes.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int64**| Current page *(Optional)* | [optional] 
 **model** | **string**|  | [optional] 
 **programId** | **int64**| Search on Program ID *(Optional)* | [optional] 
 **broadcastId** | **int64**| Search on Broadcast ID *(Optional)* | [optional] 
 **itemId** | **int64**| Search on Item ID *(Optional)* | [optional] 
 **campaignId** | **int64**| Search on Campaign ID *(Optional)* | [optional] 
 **presenterId** | **int64**| Search on Presenter ID *(Optional)* | [optional] 
 **contactId** | **int64**| Search on Contact ID *(Optional)* | [optional] 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ModelTypeResults**](ModelTypeResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

