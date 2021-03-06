// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Azure.Management.Sql.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RecommendedIndexStates.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecommendedIndexStates
    {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Executing")]
        Executing,
        [EnumMember(Value = "Verifying")]
        Verifying,
        [EnumMember(Value = "Pending Revert")]
        PendingRevert,
        [EnumMember(Value = "Reverting")]
        Reverting,
        [EnumMember(Value = "Reverted")]
        Reverted,
        [EnumMember(Value = "Ignored")]
        Ignored,
        [EnumMember(Value = "Expired")]
        Expired,
        [EnumMember(Value = "Blocked")]
        Blocked,
        [EnumMember(Value = "Success")]
        Success
    }
}
