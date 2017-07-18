# \PresenterApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePresenter**](PresenterApi.md#CreatePresenter) | **Post** /presenters | Create presenter.
[**DeletePresenterById**](PresenterApi.md#DeletePresenterById) | **Delete** /presenters/{id} | Delete presenter by id
[**GetPresenterById**](PresenterApi.md#GetPresenterById) | **Get** /presenters/{id} | Get presenter by id
[**ListPresenters**](PresenterApi.md#ListPresenters) | **Get** /presenters | Get all presenters.
[**UpdatePresenterByID**](PresenterApi.md#UpdatePresenterByID) | **Patch** /presenters/{id} | Update presenter by id


# **CreatePresenter**
> PostSuccess CreatePresenter($data)

Create presenter.

Create presenter.


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

# **DeletePresenterById**
> Success DeletePresenterById($id)

Delete presenter by id

Delete presenter by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| id of presenter | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetPresenterById**
> PresenterResult GetPresenterById($id, $externalStationId)

Get presenter by id

Get presenter by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| id of Presenter | 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**PresenterResult**](PresenterResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListPresenters**
> PresenterResults ListPresenters($page, $modelTypeId, $programId, $broadcastId, $externalStationId)

Get all presenters.

List all presenters.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int64**| Current page *(Optional)* | [optional] 
 **modelTypeId** | **int64**| Search on ModelType ID (Optional) | [optional] 
 **programId** | **int64**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | **int64**| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**PresenterResults**](PresenterResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdatePresenterByID**
> Success UpdatePresenterByID($id, $data)

Update presenter by id

Update presenter by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| id of Presenter | 
 **data** | [**PresenterDataInput**](PresenterDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

