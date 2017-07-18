# RadioManager.Api.UserApi

All URIs are relative to *https://staging.radiomanager.pluxbox.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUserById**](UserApi.md#deleteuserbyid) | **DELETE** /users/{id} | Remove user from station by Id
[**GetUserById**](UserApi.md#getuserbyid) | **GET** /users/{id} | Get user by id
[**InviteUserByMail**](UserApi.md#inviteuserbymail) | **POST** /users/invite | Invite user by mail
[**ListUsers**](UserApi.md#listusers) | **GET** /users | Get all users.


<a name="deleteuserbyid"></a>
# **DeleteUserById**
> Success DeleteUserById (long? id)

Remove user from station by Id

Remove user from station by Id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class DeleteUserByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new UserApi();
            var id = 789;  // long? | id of User

            try
            {
                // Remove user from station by Id
                Success result = apiInstance.DeleteUserById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUserById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id of User | 

### Return type

[**Success**](Success.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbyid"></a>
# **GetUserById**
> UserResult GetUserById (long? id)

Get user by id

Get user by id

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class GetUserByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new UserApi();
            var id = 789;  // long? | id of User

            try
            {
                // Get user by id
                UserResult result = apiInstance.GetUserById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id of User | 

### Return type

[**UserResult**](UserResult.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteuserbymail"></a>
# **InviteUserByMail**
> InviteUserSuccess InviteUserByMail (InviteUserData data)

Invite user by mail

Invite user by mail

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class InviteUserByMailExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new UserApi();
            var data = new InviteUserData(); // InviteUserData | Data **(Required)**

            try
            {
                // Invite user by mail
                InviteUserSuccess result = apiInstance.InviteUserByMail(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.InviteUserByMail: " + e.Message );
            }
        }
    }
}
```

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

<a name="listusers"></a>
# **ListUsers**
> UserResults ListUsers (long? page = null, long? roleId = null)

Get all users.

List all users.

### Example
```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class ListUsersExample
    {
        public void main()
        {
            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new UserApi();
            var page = 789;  // long? | Current page *(Optional)* (optional)  (default to 1)
            var roleId = 789;  // long? | Search on Role ID *(Optional)* (optional) 

            try
            {
                // Get all users.
                UserResults result = apiInstance.ListUsers(page, roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ListUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **long?**| Current page *(Optional)* | [optional] [default to 1]
 **roleId** | **long?**| Search on Role ID *(Optional)* | [optional] 

### Return type

[**UserResults**](UserResults.md)

### Authorization

[API Key](../README.md#API Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

