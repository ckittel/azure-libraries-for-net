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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// MetricsOperations operations.
    /// </summary>
    public partial interface IMetricsOperations
    {
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
        /// The aggregation to use for sorting results and the direction of the
        /// sort.
        /// Only one order can be specified.
        /// Examples: sum asc.
        /// </param>
        /// <param name='filter'>
        /// The **$filter** is used to reduce the set of metric data
        /// returned.&lt;br&gt;Example:&lt;br&gt;Metric contains metadata A, B
        /// and C.&lt;br&gt;- Return all time series of C where A = a1 and B =
        /// b1 or b2&lt;br&gt;**$filter=A eq ‘a1’ and B eq ‘b1’ or B eq ‘b2’
        /// and C eq ‘*’**&lt;br&gt;- Invalid variant:&lt;br&gt;**$filter=A eq
        /// ‘a1’ and B eq ‘b1’ and C eq ‘*’ or B = ‘b2’**&lt;br&gt;This is
        /// invalid because the logical or operator cannot separate two
        /// different metadata names.&lt;br&gt;- Return all time series where A
        /// = a1, B = b1 and C = c1:&lt;br&gt;**$filter=A eq ‘a1’ and B eq ‘b1’
        /// and C eq ‘c1’**&lt;br&gt;- Return all time series where A =
        /// a1&lt;br&gt;**$filter=A eq ‘a1’ and B eq ‘*’ and C eq ‘*’**.
        /// </param>
        /// <param name='resultType'>
        /// Reduces the set of data collected. The syntax allowed depends on
        /// the operation. See the operation's description for details.
        /// Possible values include: 'Data', 'Metadata'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ResponseInner>> ListWithHttpMessagesAsync(string resourceUri, string timespan = default(string), System.TimeSpan? interval = default(System.TimeSpan?), string metric = default(string), string aggregation = default(string), int? top = default(int?), string orderby = default(string), string filter = default(string), ResultType? resultType = default(ResultType?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
