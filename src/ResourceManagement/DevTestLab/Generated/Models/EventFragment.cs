// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An event to be notified for.
    /// </summary>
    public partial class EventFragment
    {
        /// <summary>
        /// Initializes a new instance of the EventFragment class.
        /// </summary>
        public EventFragment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventFragment class.
        /// </summary>
        /// <param name="eventName">The event type for which this notification
        /// is enabled (i.e. AutoShutdown, Cost). Possible values include:
        /// 'AutoShutdown', 'Cost'</param>
        public EventFragment(string eventName = default(string))
        {
            EventName = eventName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the event type for which this notification is enabled
        /// (i.e. AutoShutdown, Cost). Possible values include: 'AutoShutdown',
        /// 'Cost'
        /// </summary>
        [JsonProperty(PropertyName = "eventName")]
        public string EventName { get; set; }

    }
}
