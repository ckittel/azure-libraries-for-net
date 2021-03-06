// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ControllerId.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ControllerId
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Controller0")]
        Controller0,
        [EnumMember(Value = "Controller1")]
        Controller1
    }
    internal static class ControllerIdEnumExtension
    {
        internal static string ToSerializedValue(this ControllerId? value)
        {
            return value == null ? null : ((ControllerId)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ControllerId value)
        {
            switch( value )
            {
                case ControllerId.Unknown:
                    return "Unknown";
                case ControllerId.None:
                    return "None";
                case ControllerId.Controller0:
                    return "Controller0";
                case ControllerId.Controller1:
                    return "Controller1";
            }
            return null;
        }

        internal static ControllerId? ParseControllerId(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return ControllerId.Unknown;
                case "None":
                    return ControllerId.None;
                case "Controller0":
                    return ControllerId.Controller0;
                case "Controller1":
                    return ControllerId.Controller1;
            }
            return null;
        }
    }
}
