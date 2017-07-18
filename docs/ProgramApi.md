# \ProgramApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProgram**](ProgramApi.md#CreateProgram) | **Post** /programs | Create program.
[**DeleteProgramById**](ProgramApi.md#DeleteProgramById) | **Delete** /programs/{id} | Delete program by id
[**GetProgramById**](ProgramApi.md#GetProgramById) | **Get** /programs/{id} | Get program by id
[**ListPrograms**](ProgramApi.md#ListPrograms) | **Get** /programs | Get all programs.
[**UpdateProgramByID**](ProgramApi.md#UpdateProgramByID) | **Patch** /programs/{id} | Update program by id


# **CreateProgram**
> PostSuccess CreateProgram($data)

Create program.

Create program.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ProgramDataInput**](ProgramDataInput.md)| Data **(Required)** | 

### Return type

[**PostSuccess**](PostSuccess.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteProgramById**
> Success DeleteProgramById($id)

Delete program by id

Delete program by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of program **(Required)** | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetProgramById**
> ProgramResult GetProgramById($id, $externalStationId)

Get program by id

Get program by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Program **(Required)** | 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ProgramResult**](ProgramResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListPrograms**
> ProgramResults ListPrograms($page, $genreId, $modelTypeId, $presenterId, $tagId, $broadcastId, $itemId, $blockId, $externalStationId)

Get all programs.

List all programs.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int64**| Current page *(Optional)* | [optional] 
 **genreId** | **int64**| Search on Genre ID *(Optional)* | [optional] 
 **modelTypeId** | **int64**| Search on ModelType ID *(Optional)* | [optional] 
 **presenterId** | **int64**| Search on Presenter ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **tagId** | **int64**| Search on Tag ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **broadcastId** | **int64**| Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **itemId** | **int64**| Search on Item ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **blockId** | **int64**| Search on Block ID *(Optional)* &#x60;(Relation)&#x60; | [optional] 
 **externalStationId** | **int64**| Query on a different (content providing) station *(Optional)* | [optional] 

### Return type

[**ProgramResults**](ProgramResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateProgramByID**
> Success UpdateProgramByID($id, $data)

Update program by id

Update program by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| ID of Program **(Required)** | 
 **data** | [**ProgramDataInput**](ProgramDataInput.md)| Data *(Optional)* | [optional] 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

