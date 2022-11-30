# RadioManager.Api.UserApi

All URIs are relative to *https://radiomanager.io/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUserById**](UserApi.md#deleteuserbyid) | **DELETE** /users/{id} | Remove User from station by Id
[**GetUserById**](UserApi.md#getuserbyid) | **GET** /users/{id} | Get user by id
[**InviteUserByMail**](UserApi.md#inviteuserbymail) | **POST** /users/invite | Invite user by mail
[**ListUsers**](UserApi.md#listusers) | **GET** /users | Get all users.

<a name="deleteuserbyid"></a>
# **DeleteUserById**
> InlineResponse202 DeleteUserById (long? id)

Remove User from station by Id

Remove User from station by Id, will not actually delete a User record

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new UserApi();
            var id = new long?(); // long? | ID of User **(Required)**

            try
            {
                // Remove User from station by Id
                InlineResponse202 result = apiInstance.DeleteUserById(id);
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
 **id** | [**long?**](long?.md)| ID of User **(Required)** | 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new UserApi();
            var id = new long?(); // long? | id of User

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
 **id** | [**long?**](long?.md)| id of User | 

### Return type

[**UserResult**](UserResult.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inviteuserbymail"></a>
# **InviteUserByMail**
> InlineResponse202 InviteUserByMail (InviteUserData body)

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new UserApi();
            var body = new InviteUserData(); // InviteUserData | Data *(Required)*

            try
            {
                // Invite user by mail
                InlineResponse202 result = apiInstance.InviteUserByMail(body);
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
 **body** | [**InviteUserData**](InviteUserData.md)| Data *(Required)* | 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listusers"></a>
# **ListUsers**
> InlineResponse20013 ListUsers (long? roleId = null, long? groupId = null, long? page = null, long? limit = null, string orderBy = null, string orderDirection = null)

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
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new UserApi();
            var roleId = new long?(); // long? | Search on Role ID *(Optional)* (optional) 
            var groupId = new long?(); // long? | Search on Group ID *(Optional)* (optional) 
            var page = 789;  // long? | Current page *(Optional)* (optional)  (default to 1)
            var limit = 789;  // long? | Results per page *(Optional)* (optional) 
            var orderBy = orderBy_example;  // string | Field to order the results *(Optional)* (optional) 
            var orderDirection = orderDirection_example;  // string | Direction of ordering *(Optional)* (optional) 

            try
            {
                // Get all users.
                InlineResponse20013 result = apiInstance.ListUsers(roleId, groupId, page, limit, orderBy, orderDirection);
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
 **roleId** | [**long?**](long?.md)| Search on Role ID *(Optional)* | [optional] 
 **groupId** | [**long?**](long?.md)| Search on Group ID *(Optional)* | [optional] 
 **page** | **long?**| Current page *(Optional)* | [optional] [default to 1]
 **limit** | **long?**| Results per page *(Optional)* | [optional] 
 **orderBy** | **string**| Field to order the results *(Optional)* | [optional] 
 **orderDirection** | **string**| Direction of ordering *(Optional)* | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[API-Key](../README.md#API-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
