// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// MetricsOperations operations.
    /// </summary>
    internal partial class MetricsOperations : IServiceOperations<MonitorManagementClient>, IMetricsOperations
    {
        /// <summary>
        /// Initializes a new instance of the MetricsOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        internal MetricsOperations(MonitorManagementClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the MonitorManagementClient
        /// </summary>
        public MonitorManagementClient Client { get; private set; }

        /// <summary>
        /// **Lists the metric values for a resource**.
        /// </summary>
        /// <param name='resourceUri'>
        /// The identifier of the resource.
        /// </param>
        /// <param name='timespan'>
        /// The timespan of the query. It is a string with the following format
        /// 'startDateTime_ISO/endDateTime_ISO'.
        /// </param>
        /// <param name='interval'>
        /// The interval (i.e. timegrain) of the query.
        /// </param>
        /// <param name='metric'>
        /// The name of the metric to retrieve.
        /// </param>
        /// <param name='aggregation'>
        /// The list of aggregation types (comma separated) to retrieve.
        /// </param>
        /// <param name='top'>
        /// The maximum number of records to retrieve.
        /// Valid only if $filter is specified.
        /// Defaults to 10.
        /// </param>
        /// <param name='orderby'>
        /// The aggregation to use for sorting results and the direction of the sort.
        /// Only one order can be specified.
        /// Examples: sum asc.
        /// </param>
        /// <param name='filter'>
        /// The **$filter** is used to reduce the set of metric data
        /// returned.&lt;br&gt;Example:&lt;br&gt;Metric contains metadata A, B and
        /// C.&lt;br&gt;- Return all time series of C where A = a1 and B = b1 or
        /// b2&lt;br&gt;**$filter=A eq ‘a1’ and B eq ‘b1’ or B eq ‘b2’ and C eq
        /// ‘*’**&lt;br&gt;- Invalid variant:&lt;br&gt;**$filter=A eq ‘a1’ and B eq
        /// ‘b1’ and C eq ‘*’ or B = ‘b2’**&lt;br&gt;This is invalid because the
        /// logical or operator cannot separate two different metadata
        /// names.&lt;br&gt;- Return all time series where A = a1, B = b1 and C =
        /// c1:&lt;br&gt;**$filter=A eq ‘a1’ and B eq ‘b1’ and C eq ‘c1’**&lt;br&gt;-
        /// Return all time series where A = a1&lt;br&gt;**$filter=A eq ‘a1’ and B eq
        /// ‘*’ and C eq ‘*’**.
        /// </param>
        /// <param name='resultType'>
        /// Reduces the set of data collected. The syntax allowed depends on the
        /// operation. See the operation's description for details. Possible values
        /// include: 'Data', 'Metadata'
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<ResponseInner>> ListWithHttpMessagesAsync(string resourceUri, string timespan = default(string), System.TimeSpan? interval = default(System.TimeSpan?), string metric = default(string), string aggregation = default(string), int? top = default(int?), string orderby = default(string), string filter = default(string), ResultType? resultType = default(ResultType?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (resourceUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceUri");
            }
            string apiVersion = "2017-05-01-preview";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceUri", resourceUri);
                tracingParameters.Add("timespan", timespan);
                tracingParameters.Add("interval", interval);
                tracingParameters.Add("metric", metric);
                tracingParameters.Add("aggregation", aggregation);
                tracingParameters.Add("top", top);
                tracingParameters.Add("orderby", orderby);
                tracingParameters.Add("filter", filter);
                tracingParameters.Add("resultType", resultType);
                tracingParameters.Add("apiVersion", apiVersion);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "List", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "{resourceUri}/providers/microsoft.insights/metrics").ToString();
            _url = _url.Replace("{resourceUri}", resourceUri);
            List<string> _queryParameters = new List<string>();
            if (timespan != null)
            {
                _queryParameters.Add(string.Format("timespan={0}", System.Uri.EscapeDataString(timespan)));
            }
            if (interval != null)
            {
                _queryParameters.Add(string.Format("interval={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(interval, Client.SerializationSettings).Trim('"'))));
            }
            if (metric != null)
            {
                _queryParameters.Add(string.Format("metric={0}", System.Uri.EscapeDataString(metric)));
            }
            if (aggregation != null)
            {
                _queryParameters.Add(string.Format("aggregation={0}", System.Uri.EscapeDataString(aggregation)));
            }
            if (top != null)
            {
                _queryParameters.Add(string.Format("$top={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(top, Client.SerializationSettings).Trim('"'))));
            }
            if (orderby != null)
            {
                _queryParameters.Add(string.Format("$orderby={0}", System.Uri.EscapeDataString(orderby)));
            }
            if (filter != null)
            {
                _queryParameters.Add(string.Format("$filter={0}", System.Uri.EscapeDataString(filter)));
            }
            if (resultType != null)
            {
                _queryParameters.Add(string.Format("resultType={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(resultType, Client.SerializationSettings).Trim('"'))));
            }
            if (apiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(apiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach (var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorResponseException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    ErrorResponse _errorBody = Rest.Serialization.SafeJsonConvert.DeserializeObject<ErrorResponse>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<ResponseInner>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Rest.Serialization.SafeJsonConvert.DeserializeObject<ResponseInner>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
