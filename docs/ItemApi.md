# \ItemApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateItem**](ItemApi.md#CreateItem) | **Post** /items | Create an new item.
[**CurrentItemPostStructure**](ItemApi.md#CurrentItemPostStructure) | **Post** /items/current/structure | Post a current playing item, keep structure
[**CurrentItemPostTiming**](ItemApi.md#CurrentItemPostTiming) | **Post** /items/current/timing | Post a current playing item
[**DeleteItemById**](ItemApi.md#DeleteItemById) | **Delete** /items/{id} | Delete item by ID.
[**GetItemById**](ItemApi.md#GetItemById) | **Get** /items/{id} | Get extended item details by ID.
[**ListItems**](ItemApi.md#ListItems) | **Get** /items | Get a list of all the items currently in your station.
[**PlaylistPostStructure**](ItemApi.md#PlaylistPostStructure) | **Post** /items/playlist/structure | Post a playlist, keep current structure
[**PlaylistPostTiming**](ItemApi.md#PlaylistPostTiming) | **Post** /items/playlist/timing | Post a playlist
[**UpdateItemById**](ItemApi.md#UpdateItemById) | **Patch** /items/{id} | Update extended item details by ID.


# **CreateItem**
> PostSuccess CreateItem($data)

Create an new item.

Create item.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ItemDataInput**](ItemDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**PostSuccess**](PostSuccess.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CurrentItemPostStructure**
> Success CurrentItemPostStructure($data)

Post a current playing item, keep structure

Post a current playing item, keep structure


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ImportItem**](ImportItem.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CurrentItemPostTiming**
> Success CurrentItemPostTiming($data)

Post a current playing item

Post a current playing item


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ImportItem**](ImportItem.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteItemById**
> Success DeleteItemById($id)

Delete item by ID.

Delete item by id.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Item **(Required)** | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetItemById**
> ItemResult GetItemById($id, $externalStationId)

Get extended item details by ID.

Read item by id.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Item **(Required)** | 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ItemResult**](ItemResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListItems**
> ItemResults ListItems($page, $orderBy, $orderDirection, $startMin, $startMax, $durationMin, $durationMax, $status, $modelTypeId, $programDraftId, $userDraftId, $stationDraftId, $blockId, $broadcastId, $campaignId, $contactId, $programId, $tagId, $externalStationId)

Get a list of all the items currently in your station.

Get a list of all the items currently in your station. This feature supports pagination and will give a maximum results of 50 items back.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int64**| Current page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 
 **startMin** | **time.Time**| Minimum start date *(Optional)* | [optional] 
 **startMax** | **time.Time**| Maximum start date *(Optional)* | [optional] 
 **durationMin** | **int32**| Minimum duration (seconds) *(Optional)* | [optional] 
 **durationMax** | **int32**| Maximum duration (seconds) *(Optional)* | [optional] 
 **status** | **string**| Play Status of item *(Optional)* | [optional] 
 **modelTypeId** | **int64**| Search on ModelType ID *(Optional)* | [optional] 
 **programDraftId** | **int64**| Search on Program Draft ID *(Optional)* | [optional] 
 **userDraftId** | **int64**| Search on User Draft ID *(Optional)* | [optional] 
 **stationDraftId** | **int64**| Search on Station Draft ID *(Optional)* | [optional] 
 **blockId** | **int64**| Search on Block ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | **int64**| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **campaignId** | **int64**| Search on Campaign ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **contactId** | **int64**| Search on Contact ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **programId** | **int64**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **tagId** | **int64**| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ItemResults**](ItemResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **PlaylistPostStructure**
> InlineResponse202 PlaylistPostStructure($data)

Post a playlist, keep current structure

Post a playlist, keep current structure


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Data1**](Data1.md)| Data *(Optional)* | [optional] 

### Return type

[**InlineResponse202**](inline_response_202.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **PlaylistPostTiming**
> InlineResponse202 PlaylistPostTiming($data)

Post a playlist

Post a playlist


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Data**](Data.md)| Data *(Optional)* | [optional] 

### Return type

[**InlineResponse202**](inline_response_202.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateItemById**
> Success UpdateItemById($id, $data)

Update extended item details by ID.

Update item by id.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Item **(Required)** | 
 **data** | [**Item**](Item.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

