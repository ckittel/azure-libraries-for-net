// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Dns.Fluent
{
    using System.Collections.Generic;

    /// <summary>
    /// An immutable client-side representation of a PTR (pointer) record set in Azure DNS Zone.
    /// </summary>
    public interface IPtrRecordSet :
        Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet
    {
        /// <summary>
        /// Gets the target domain names of PTR records in this record set.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<string> TargetDomainNames { get; }
    }
}