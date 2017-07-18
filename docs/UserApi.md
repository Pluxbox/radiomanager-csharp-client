# \UserApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUserById**](UserApi.md#DeleteUserById) | **Delete** /users/{id} | Remove user from station by Id
[**GetUserById**](UserApi.md#GetUserById) | **Get** /users/{id} | Get user by id
[**InviteUserByMail**](UserApi.md#InviteUserByMail) | **Post** /users/invite | Invite user by mail
[**ListUsers**](UserApi.md#ListUsers) | **Get** /users | Get all users.


# **DeleteUserById**
> Success DeleteUserById($id)

Remove user from station by Id

Remove user from station by Id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| id of User | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetUserById**
> UserResult GetUserById($id)

Get user by id

Get user by id


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int64**| id of User | 

### Return type

[**UserResult**](UserResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **InviteUserByMail**
> InviteUserSuccess InviteUserByMail($data)

Invite user by mail

Invite user by mail


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**InviteUserData**](InviteUserData.md)| Data **(Required)** | 

### Return type

[**InviteUserSuccess**](InviteUserSuccess.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListUsers**
> UserResults ListUsers($page, $roleId)

Get all users.

List all users.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int64**| Current page *(Optional)* | [optional] [default to 1]
 **roleId** | **int64**| Search on Role ID *(Optional)* | [optional] 

### Return type

[**UserResults**](UserResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

