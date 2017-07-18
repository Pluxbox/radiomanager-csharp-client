# \CampaignApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCampaign**](CampaignApi.md#CreateCampaign) | **Post** /campaigns | Create campaign.
[**DeleteCampaignById**](CampaignApi.md#DeleteCampaignById) | **Delete** /campaigns/{id} | Delete campaign by id
[**GetCampaignById**](CampaignApi.md#GetCampaignById) | **Get** /campaigns/{id} | Get campaign by id
[**ListCampaigns**](CampaignApi.md#ListCampaigns) | **Get** /campaigns | Get all campaigns.
[**UpdateCampaignByID**](CampaignApi.md#UpdateCampaignByID) | **Patch** /campaigns/{id} | Update campaign by id


# **CreateCampaign**
> PostSuccess CreateCampaign($data)

Create campaign.

Create campaign.


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

# **DeleteCampaignById**
> Success DeleteCampaignById($id)

Delete campaign by id

Delete campaign by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Campaign **(Required)** | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetCampaignById**
> CampaignResult GetCampaignById($id, $externalStationId)

Get campaign by id

Get campaign by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Campaign **(Required)** | 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**CampaignResult**](CampaignResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListCampaigns**
> CampaignResults ListCampaigns($page, $modelTypeId, $itemId, $startMin, $startMax, $externalStationId)

Get all campaigns.

List all campaigns.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int64**| Current page *(Optional)* | [optional] 
 **modelTypeId** | **int64**| Search on ModelType ID *(Optional)* | [optional] 
 **itemId** | **int64**| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **startMin** | **time.Time**| Minimum start date *(Optional)* | [optional] 
 **startMax** | **time.Time**| Maximum start date *(Optional)* | [optional] 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**CampaignResults**](CampaignResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateCampaignByID**
> Success UpdateCampaignByID($id, $data)

Update campaign by id

Update campaign by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Campaign **(Required)** | 
 **data** | [**CampaignDataInput**](CampaignDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

