// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SSIS package location.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SSISPackageLocation
    {
        /// <summary>
        /// Initializes a new instance of the SSISPackageLocation class.
        /// </summary>
        public SSISPackageLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SSISPackageLocation class.
        /// </summary>
        /// <param name="packagePath">The SSIS package path. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="type">The type of SSIS package location. Possible
        /// values include: 'SSISDB', 'File', 'InlinePackage'</param>
        /// <param name="packagePassword">Password of the package.</param>
        /// <param name="accessCredential">The package access
        /// credential.</param>
        /// <param name="configurationPath">The configuration file of the
        /// package execution. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="packageName">The package name.</param>
        /// <param name="packageContent">The embedded package content. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="packageLastModifiedDate">The embedded package last
        /// modified date.</param>
        /// <param name="childPackages">The embedded child package
        /// list.</param>
        public SSISPackageLocation(object packagePath = default(object), string type = default(string), SecretBase packagePassword = default(SecretBase), SSISAccessCredential accessCredential = default(SSISAccessCredential), object configurationPath = default(object), string packageName = default(string), object packageContent = default(object), string packageLastModifiedDate = default(string), IList<SSISChildPackage> childPackages = default(IList<SSISChildPackage>))
        {
            PackagePath = packagePath;
            Type = type;
            PackagePassword = packagePassword;
            AccessCredential = accessCredential;
            ConfigurationPath = configurationPath;
            PackageName = packageName;
            PackageContent = packageContent;
            PackageLastModifiedDate = packageLastModifiedDate;
            ChildPackages = childPackages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SSIS package path. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "packagePath")]
        public object PackagePath { get; set; }

        /// <summary>
        /// Gets or sets the type of SSIS package location. Possible values
        /// include: 'SSISDB', 'File', 'InlinePackage'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets password of the package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packagePassword")]
        public SecretBase PackagePassword { get; set; }

        /// <summary>
        /// Gets or sets the package access credential.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessCredential")]
        public SSISAccessCredential AccessCredential { get; set; }

        /// <summary>
        /// Gets or sets the configuration file of the package execution. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.configurationPath")]
        public object ConfigurationPath { get; set; }

        /// <summary>
        /// Gets or sets the package name.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageName")]
        public string PackageName { get; set; }

        /// <summary>
        /// Gets or sets the embedded package content. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageContent")]
        public object PackageContent { get; set; }

        /// <summary>
        /// Gets or sets the embedded package last modified date.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageLastModifiedDate")]
        public string PackageLastModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the embedded child package list.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.childPackages")]
        public IList<SSISChildPackage> ChildPackages { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccessCredential != null)
            {
                AccessCredential.Validate();
            }
            if (ChildPackages != null)
            {
                foreach (var element in ChildPackages)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
