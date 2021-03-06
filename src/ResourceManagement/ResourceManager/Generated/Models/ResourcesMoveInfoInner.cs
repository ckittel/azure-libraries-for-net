// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters of move resources.
    /// </summary>
    public partial class ResourcesMoveInfoInner
    {
        /// <summary>
        /// Initializes a new instance of the ResourcesMoveInfoInner class.
        /// </summary>
        public ResourcesMoveInfoInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourcesMoveInfoInner class.
        /// </summary>
        /// <param name="resources">The ids of the resources.</param>
        /// <param name="targetResourceGroup">The target resource
        /// group.</param>
        public ResourcesMoveInfoInner(IList<string> resources = default(IList<string>), string targetResourceGroup = default(string))
        {
            Resources = resources;
            TargetResourceGroup = targetResourceGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ids of the resources.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }

        /// <summary>
        /// Gets or sets the target resource group.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroup")]
        public string TargetResourceGroup { get; set; }

    }
}
