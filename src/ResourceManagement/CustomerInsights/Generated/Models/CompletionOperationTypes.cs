// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CompletionOperationTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompletionOperationTypes
    {
        [EnumMember(Value = "DoNothing")]
        DoNothing,
        [EnumMember(Value = "DeleteFile")]
        DeleteFile,
        [EnumMember(Value = "MoveFile")]
        MoveFile
    }
    internal static class CompletionOperationTypesEnumExtension
    {
        internal static string ToSerializedValue(this CompletionOperationTypes? value)
        {
            return value == null ? null : ((CompletionOperationTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CompletionOperationTypes value)
        {
            switch( value )
            {
                case CompletionOperationTypes.DoNothing:
                    return "DoNothing";
                case CompletionOperationTypes.DeleteFile:
                    return "DeleteFile";
                case CompletionOperationTypes.MoveFile:
                    return "MoveFile";
            }
            return null;
        }

        internal static CompletionOperationTypes? ParseCompletionOperationTypes(this string value)
        {
            switch( value )
            {
                case "DoNothing":
                    return CompletionOperationTypes.DoNothing;
                case "DeleteFile":
                    return CompletionOperationTypes.DeleteFile;
                case "MoveFile":
                    return CompletionOperationTypes.MoveFile;
            }
            return null;
        }
    }
}
