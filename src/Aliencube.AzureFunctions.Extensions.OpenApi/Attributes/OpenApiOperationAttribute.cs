﻿using System;

namespace Aliencube.AzureFunctions.Extensions.OpenApi.Attributes
{
    /// <summary>
    /// This represents the attribute entity for HTTP triggers to define Open API operation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class OpenApiOperationAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenApiOperationAttribute"/> class.
        /// </summary>
        /// <param name="operationId">Operation ID.</param>
        /// <param name="tags">List of tags.</param>
        public OpenApiOperationAttribute(string operationId = null, params string[] tags)
        {
            this.OperationId = operationId;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets the operation ID.
        /// </summary>
        public virtual string OperationId { get; }

        /// <summary>
        /// Gets the list of tags.
        /// </summary>
        public virtual string[] Tags { get; }
    }
}