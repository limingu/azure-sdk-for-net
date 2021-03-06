// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the job status.
    /// </summary>
    public partial class JobStatus
    {
        /// <summary>
        /// Initializes a new instance of the JobStatus class.
        /// </summary>
        public JobStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobStatus class.
        /// </summary>
        /// <param name="jobName">Possible values include:
        /// 'InitialSync'</param>
        /// <param name="jobProgress">Gets or sets the monitoring job
        /// percentage.</param>
        public JobStatus(string jobName = default(string), string jobProgress = default(string))
        {
            JobName = jobName;
            JobProgress = jobProgress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'InitialSync'
        /// </summary>
        [JsonProperty(PropertyName = "jobName")]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or sets the monitoring job percentage.
        /// </summary>
        [JsonProperty(PropertyName = "jobProgress")]
        public string JobProgress { get; private set; }

    }
}
