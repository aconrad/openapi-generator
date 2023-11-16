/*
 * Dummy
 *
 * To test name, parameter mapping options
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using ConfigurationClient = Org.OpenAPITools.Client.Configuration;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFakeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// parameter name mapping test
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="UnderscoreType">_type</param>
        /// <param name="type">type</param>
        /// <param name="TypeWithUnderscore">type_</param>
        /// <param name="httpDebugOption">http debug option (to test parameter naming option)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Env</returns>
        Env GetParameterNameMapping(long UnderscoreType, string type, string TypeWithUnderscore, string httpDebugOption, int operationIndex = 0);

        /// <summary>
        /// parameter name mapping test
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="UnderscoreType">_type</param>
        /// <param name="type">type</param>
        /// <param name="TypeWithUnderscore">type_</param>
        /// <param name="httpDebugOption">http debug option (to test parameter naming option)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Env</returns>
        ApiResponse<Env> GetParameterNameMappingWithHttpInfo(long UnderscoreType, string type, string TypeWithUnderscore, string httpDebugOption, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFakeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// parameter name mapping test
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="UnderscoreType">_type</param>
        /// <param name="type">type</param>
        /// <param name="TypeWithUnderscore">type_</param>
        /// <param name="httpDebugOption">http debug option (to test parameter naming option)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Env</returns>
        Task<Env> GetParameterNameMappingAsync(long UnderscoreType, string type, string TypeWithUnderscore, string httpDebugOption, int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// parameter name mapping test
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="UnderscoreType">_type</param>
        /// <param name="type">type</param>
        /// <param name="TypeWithUnderscore">type_</param>
        /// <param name="httpDebugOption">http debug option (to test parameter naming option)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Env)</returns>
        Task<ApiResponse<Env>> GetParameterNameMappingWithHttpInfoAsync(long UnderscoreType, string type, string TypeWithUnderscore, string httpDebugOption, int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFakeApi : IFakeApiSync, IFakeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FakeApi : IFakeApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FakeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FakeApi(string basePath) : this(new ConfigurationClient { BasePath = basePath })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FakeApi(ConfigurationClient configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            Configuration = ConfigurationClient.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            Client = new ApiClient(Configuration.BasePath);
            AsynchronousClient = new ApiClient(Configuration.BasePath);
            ExceptionFactory = ConfigurationClient.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public FakeApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (asyncClient == null) throw new ArgumentNullException(nameof(asyncClient));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = ConfigurationClient.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
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
        /// Provides a common RequestOptions object for all operations.
        /// </summary>
		private RequestOptions GetRequestOptions(string[] _contentTypes, string[] _accepts, string operationId, int operationIndex)
		{
            RequestOptions localVarRequestOptions = new RequestOptions();
            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Operation = operationId;
            localVarRequestOptions.OperationIndex = operationIndex;

            return localVarRequestOptions;
		}

        /// <summary>
        /// Sets RequestOptions Authorization headers with bearer or oauth.
        /// </summary>
        private RequestOptions SetAuthorization(RequestOptions localVarRequestOptions)
        {
			// oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
            }
            return localVarRequestOptions;
		}

        /// <summary>
        /// Validates if operation has an exception and rethrows it.
        /// </summary>
        private void ValidateException(string operationName, IApiResponse localVarResponse)
        {
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory(operationName, localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }
		}

        /// <summary>
        /// Provides a specific RequestOptions object for GetParameterNameMapping.
        /// </summary>
		private RequestOptions GetRequestOptionsGetParameterNameMapping(long UnderscoreType, string type, string TypeWithUnderscore, string httpDebugOption, int operationIndex = 0)
		{
            // verify the required parameter 'type' is set
            if (type == null)
            {
                throw new ApiException(400, "Missing required parameter 'type' when calling FakeApi->GetParameterNameMapping");
            }

            // verify the required parameter 'TypeWithUnderscore' is set
            if (TypeWithUnderscore == null)
            {
                throw new ApiException(400, "Missing required parameter 'TypeWithUnderscore' when calling FakeApi->GetParameterNameMapping");
            }

            // verify the required parameter 'httpDebugOption' is set
            if (httpDebugOption == null)
            {
                throw new ApiException(400, "Missing required parameter 'httpDebugOption' when calling FakeApi->GetParameterNameMapping");
            }

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            RequestOptions localVarRequestOptions = GetRequestOptions(_contentTypes, _accepts,"FakeApi.GetParameterNameMapping" ,operationIndex);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "type", type));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "http_debug_option", httpDebugOption));
            localVarRequestOptions.HeaderParameters.Add("_type", ClientUtils.ParameterToString(UnderscoreType)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("type_", ClientUtils.ParameterToString(TypeWithUnderscore)); // header parameter

			return localVarRequestOptions;
		}

        /// <summary>
        /// parameter name mapping test 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="UnderscoreType">_type</param>
        /// <param name="type">type</param>
        /// <param name="TypeWithUnderscore">type_</param>
        /// <param name="httpDebugOption">http debug option (to test parameter naming option)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Env</returns>
        public Env GetParameterNameMapping(long UnderscoreType, string type, string TypeWithUnderscore, string httpDebugOption, int operationIndex = 0)
        {
            ApiResponse<Env> localVarResponse = GetParameterNameMappingWithHttpInfo(UnderscoreType, type, TypeWithUnderscore, httpDebugOption);
            return localVarResponse.Data;
        }

        /// <summary>
        /// parameter name mapping test 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="UnderscoreType">_type</param>
        /// <param name="type">type</param>
        /// <param name="TypeWithUnderscore">type_</param>
        /// <param name="httpDebugOption">http debug option (to test parameter naming option)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Env</returns>
        public ApiResponse<Env> GetParameterNameMappingWithHttpInfo(long UnderscoreType, string type, string TypeWithUnderscore, string httpDebugOption, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetParameterNameMapping(UnderscoreType, type, TypeWithUnderscore, httpDebugOption, operationIndex);

            // make the HTTP request
            var localVarResponse = Client.Get<Env>("/fake/parameter-name-mapping", localVarRequestOptions, Configuration);
            ValidateException("GetParameterNameMapping", localVarResponse);
            return localVarResponse;
        }

        /// <summary>
        /// parameter name mapping test 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="UnderscoreType">_type</param>
        /// <param name="type">type</param>
        /// <param name="TypeWithUnderscore">type_</param>
        /// <param name="httpDebugOption">http debug option (to test parameter naming option)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Env</returns>
        public async Task<Env> GetParameterNameMappingAsync(long UnderscoreType, string type, string TypeWithUnderscore, string httpDebugOption, int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiResponse<Env> localVarResponse = await GetParameterNameMappingWithHttpInfoAsync(UnderscoreType, type, TypeWithUnderscore, httpDebugOption, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// parameter name mapping test 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="UnderscoreType">_type</param>
        /// <param name="type">type</param>
        /// <param name="TypeWithUnderscore">type_</param>
        /// <param name="httpDebugOption">http debug option (to test parameter naming option)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Env)</returns>
        public async Task<ApiResponse<Env>> GetParameterNameMappingWithHttpInfoAsync(long UnderscoreType, string type, string TypeWithUnderscore, string httpDebugOption, int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetParameterNameMapping(UnderscoreType, type, TypeWithUnderscore, httpDebugOption, operationIndex);

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<Env>("/fake/parameter-name-mapping", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);
            ValidateException("GetParameterNameMapping", localVarResponse);
            return localVarResponse;
        }
    }
}
