/* 
 * RadioManager
 *
 * RadioManager
 *
 * OpenAPI spec version: 2.0
 * Contact: support@pluxbox.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using RadioManager.Client;
using RadioManager.Model;

namespace RadioManager.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGenreApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get genre by id
        /// </summary>
        /// <remarks>
        /// Get genre by id
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of Genre **(Required)**</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>GenreResult</returns>
        GenreResult GetGenreById (long? id, long? externalStationId = null);

        /// <summary>
        /// Get genre by id
        /// </summary>
        /// <remarks>
        /// Get genre by id
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of Genre **(Required)**</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>ApiResponse of GenreResult</returns>
        ApiResponse<GenreResult> GetGenreByIdWithHttpInfo (long? id, long? externalStationId = null);
        /// <summary>
        /// List all genres.
        /// </summary>
        /// <remarks>
        /// List all genres.
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Current page *(Optional)* (optional)</param>
        /// <param name="parentId">Search on Parent ID of Genre *(Optional)* (optional)</param>
        /// <param name="programId">Search on Program ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="broadcastId">Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="limit">Results per page *(Optional)* (optional)</param>
        /// <param name="orderBy">Field to order the results *(Optional)* (optional)</param>
        /// <param name="orderDirection">Direction of ordering *(Optional)* (optional)</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>GenreResults</returns>
        GenreResults ListGenres (long? page = null, long? parentId = null, long? programId = null, long? broadcastId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null);

        /// <summary>
        /// List all genres.
        /// </summary>
        /// <remarks>
        /// List all genres.
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Current page *(Optional)* (optional)</param>
        /// <param name="parentId">Search on Parent ID of Genre *(Optional)* (optional)</param>
        /// <param name="programId">Search on Program ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="broadcastId">Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="limit">Results per page *(Optional)* (optional)</param>
        /// <param name="orderBy">Field to order the results *(Optional)* (optional)</param>
        /// <param name="orderDirection">Direction of ordering *(Optional)* (optional)</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>ApiResponse of GenreResults</returns>
        ApiResponse<GenreResults> ListGenresWithHttpInfo (long? page = null, long? parentId = null, long? programId = null, long? broadcastId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get genre by id
        /// </summary>
        /// <remarks>
        /// Get genre by id
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of Genre **(Required)**</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>Task of GenreResult</returns>
        System.Threading.Tasks.Task<GenreResult> GetGenreByIdAsync (long? id, long? externalStationId = null);

        /// <summary>
        /// Get genre by id
        /// </summary>
        /// <remarks>
        /// Get genre by id
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of Genre **(Required)**</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>Task of ApiResponse (GenreResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<GenreResult>> GetGenreByIdAsyncWithHttpInfo (long? id, long? externalStationId = null);
        /// <summary>
        /// List all genres.
        /// </summary>
        /// <remarks>
        /// List all genres.
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Current page *(Optional)* (optional)</param>
        /// <param name="parentId">Search on Parent ID of Genre *(Optional)* (optional)</param>
        /// <param name="programId">Search on Program ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="broadcastId">Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="limit">Results per page *(Optional)* (optional)</param>
        /// <param name="orderBy">Field to order the results *(Optional)* (optional)</param>
        /// <param name="orderDirection">Direction of ordering *(Optional)* (optional)</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>Task of GenreResults</returns>
        System.Threading.Tasks.Task<GenreResults> ListGenresAsync (long? page = null, long? parentId = null, long? programId = null, long? broadcastId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null);

        /// <summary>
        /// List all genres.
        /// </summary>
        /// <remarks>
        /// List all genres.
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Current page *(Optional)* (optional)</param>
        /// <param name="parentId">Search on Parent ID of Genre *(Optional)* (optional)</param>
        /// <param name="programId">Search on Program ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="broadcastId">Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="limit">Results per page *(Optional)* (optional)</param>
        /// <param name="orderBy">Field to order the results *(Optional)* (optional)</param>
        /// <param name="orderDirection">Direction of ordering *(Optional)* (optional)</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>Task of ApiResponse (GenreResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<GenreResults>> ListGenresAsyncWithHttpInfo (long? page = null, long? parentId = null, long? programId = null, long? broadcastId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GenreApi : IGenreApi
    {
        private RadioManager.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GenreApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = RadioManager.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenreApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GenreApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = RadioManager.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public RadioManager.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get genre by id Get genre by id
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of Genre **(Required)**</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>GenreResult</returns>
        public GenreResult GetGenreById (long? id, long? externalStationId = null)
        {
             ApiResponse<GenreResult> localVarResponse = GetGenreByIdWithHttpInfo(id, externalStationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get genre by id Get genre by id
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of Genre **(Required)**</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>ApiResponse of GenreResult</returns>
        public ApiResponse< GenreResult > GetGenreByIdWithHttpInfo (long? id, long? externalStationId = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GenreApi->GetGenreById");

            var localVarPath = "/genres/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (externalStationId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "_external_station_id", externalStationId)); // query parameter

            // authentication (API Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetGenreById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GenreResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GenreResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenreResult)));
        }

        /// <summary>
        /// Get genre by id Get genre by id
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of Genre **(Required)**</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>Task of GenreResult</returns>
        public async System.Threading.Tasks.Task<GenreResult> GetGenreByIdAsync (long? id, long? externalStationId = null)
        {
             ApiResponse<GenreResult> localVarResponse = await GetGenreByIdAsyncWithHttpInfo(id, externalStationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get genre by id Get genre by id
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of Genre **(Required)**</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>Task of ApiResponse (GenreResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GenreResult>> GetGenreByIdAsyncWithHttpInfo (long? id, long? externalStationId = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GenreApi->GetGenreById");

            var localVarPath = "/genres/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (externalStationId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "_external_station_id", externalStationId)); // query parameter

            // authentication (API Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetGenreById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GenreResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GenreResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenreResult)));
        }

        /// <summary>
        /// List all genres. List all genres.
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Current page *(Optional)* (optional)</param>
        /// <param name="parentId">Search on Parent ID of Genre *(Optional)* (optional)</param>
        /// <param name="programId">Search on Program ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="broadcastId">Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="limit">Results per page *(Optional)* (optional)</param>
        /// <param name="orderBy">Field to order the results *(Optional)* (optional)</param>
        /// <param name="orderDirection">Direction of ordering *(Optional)* (optional)</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>GenreResults</returns>
        public GenreResults ListGenres (long? page = null, long? parentId = null, long? programId = null, long? broadcastId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)
        {
             ApiResponse<GenreResults> localVarResponse = ListGenresWithHttpInfo(page, parentId, programId, broadcastId, limit, orderBy, orderDirection, externalStationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all genres. List all genres.
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Current page *(Optional)* (optional)</param>
        /// <param name="parentId">Search on Parent ID of Genre *(Optional)* (optional)</param>
        /// <param name="programId">Search on Program ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="broadcastId">Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="limit">Results per page *(Optional)* (optional)</param>
        /// <param name="orderBy">Field to order the results *(Optional)* (optional)</param>
        /// <param name="orderDirection">Direction of ordering *(Optional)* (optional)</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>ApiResponse of GenreResults</returns>
        public ApiResponse< GenreResults > ListGenresWithHttpInfo (long? page = null, long? parentId = null, long? programId = null, long? broadcastId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)
        {

            var localVarPath = "/genres";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (parentId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "parent_id", parentId)); // query parameter
            if (programId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "program_id", programId)); // query parameter
            if (broadcastId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "broadcast_id", broadcastId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order-by", orderBy)); // query parameter
            if (orderDirection != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order-direction", orderDirection)); // query parameter
            if (externalStationId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "_external_station_id", externalStationId)); // query parameter

            // authentication (API Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListGenres", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GenreResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GenreResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenreResults)));
        }

        /// <summary>
        /// List all genres. List all genres.
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Current page *(Optional)* (optional)</param>
        /// <param name="parentId">Search on Parent ID of Genre *(Optional)* (optional)</param>
        /// <param name="programId">Search on Program ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="broadcastId">Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="limit">Results per page *(Optional)* (optional)</param>
        /// <param name="orderBy">Field to order the results *(Optional)* (optional)</param>
        /// <param name="orderDirection">Direction of ordering *(Optional)* (optional)</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>Task of GenreResults</returns>
        public async System.Threading.Tasks.Task<GenreResults> ListGenresAsync (long? page = null, long? parentId = null, long? programId = null, long? broadcastId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)
        {
             ApiResponse<GenreResults> localVarResponse = await ListGenresAsyncWithHttpInfo(page, parentId, programId, broadcastId, limit, orderBy, orderDirection, externalStationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all genres. List all genres.
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Current page *(Optional)* (optional)</param>
        /// <param name="parentId">Search on Parent ID of Genre *(Optional)* (optional)</param>
        /// <param name="programId">Search on Program ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="broadcastId">Search on Broadcast ID *(Optional)* &#x60;(Relation)&#x60; (optional)</param>
        /// <param name="limit">Results per page *(Optional)* (optional)</param>
        /// <param name="orderBy">Field to order the results *(Optional)* (optional)</param>
        /// <param name="orderDirection">Direction of ordering *(Optional)* (optional)</param>
        /// <param name="externalStationId">Query on a different (content providing) station *(Optional)* (optional)</param>
        /// <returns>Task of ApiResponse (GenreResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GenreResults>> ListGenresAsyncWithHttpInfo (long? page = null, long? parentId = null, long? programId = null, long? broadcastId = null, long? limit = null, string orderBy = null, string orderDirection = null, long? externalStationId = null)
        {

            var localVarPath = "/genres";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (parentId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "parent_id", parentId)); // query parameter
            if (programId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "program_id", programId)); // query parameter
            if (broadcastId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "broadcast_id", broadcastId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order-by", orderBy)); // query parameter
            if (orderDirection != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order-direction", orderDirection)); // query parameter
            if (externalStationId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "_external_station_id", externalStationId)); // query parameter

            // authentication (API Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListGenres", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GenreResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GenreResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenreResults)));
        }

    }
}
