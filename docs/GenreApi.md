# \GenreApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGenreById**](GenreApi.md#GetGenreById) | **Get** /genres/{id} | Get genre by id
[**ListGenres**](GenreApi.md#ListGenres) | **Get** /genres | List all genres.


# **GetGenreById**
> GenreResult GetGenreById($id, $externalStationId)

Get genre by id

Get genre by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Genre **(Required)** | 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**GenreResult**](GenreResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListGenres**
> GenreResults ListGenres($page, $parentId, $programId, $broadcastId, $externalStationId)

List all genres.

List all genres.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int64**| Current page *(Optional)* | [optional] 
 **parentId** | **int64**| Search on Parent ID of Genre *(Optional)* | [optional] 
 **programId** | **int64**| Search on Program ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | **int64**| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**GenreResults**](GenreResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

