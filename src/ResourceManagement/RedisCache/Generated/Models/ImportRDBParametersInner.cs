// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Redis;
    using Microsoft.Azure.Management.Redis.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for Redis import operation.
    /// </summary>
    public partial class ImportRDBParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the ImportRDBParametersInner class.
        /// </summary>
        public ImportRDBParametersInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportRDBParametersInner class.
        /// </summary>
        /// <param name="files">files to import.</param>
        /// <param name="format">File format.</param>
        public ImportRDBParametersInner(IList<string> files, string format = default(string))
        {
            Format = format;
            Files = files;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets file format.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets files to import.
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<string> Files { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Files == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Files");
            }
        }
    }
}
