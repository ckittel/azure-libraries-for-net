// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TopLevelDomainsOperations.
    /// </summary>
    public static partial class TopLevelDomainsOperationsExtensions
    {
            /// <summary>
            /// Get all top-level domains supported for registration.
            /// </summary>
            /// <remarks>
            /// Get all top-level domains supported for registration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TopLevelDomainInner>> ListAsync(this ITopLevelDomainsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get details of a top-level domain.
            /// </summary>
            /// <remarks>
            /// Get details of a top-level domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the top-level domain.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TopLevelDomainInner> GetAsync(this ITopLevelDomainsOperations operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all legal agreements that user needs to accept before purchasing a
            /// domain.
            /// </summary>
            /// <remarks>
            /// Gets all legal agreements that user needs to accept before purchasing a
            /// domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the top-level domain.
            /// </param>
            /// <param name='agreementOption'>
            /// Domain agreement options.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TldLegalAgreement>> ListAgreementsAsync(this ITopLevelDomainsOperations operations, string name, TopLevelDomainAgreementOptionInner agreementOption, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAgreementsWithHttpMessagesAsync(name, agreementOption, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all top-level domains supported for registration.
            /// </summary>
            /// <remarks>
            /// Get all top-level domains supported for registration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TopLevelDomainInner>> ListNextAsync(this ITopLevelDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all legal agreements that user needs to accept before purchasing a
            /// domain.
            /// </summary>
            /// <remarks>
            /// Gets all legal agreements that user needs to accept before purchasing a
            /// domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TldLegalAgreement>> ListAgreementsNextAsync(this ITopLevelDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAgreementsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
