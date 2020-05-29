// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Batch.V1Beta1
{

    [OutputType]
    public sealed class CronJobStatus
    {
        /// <summary>
        /// A list of pointers to currently running jobs.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.ObjectReference> Active;
        /// <summary>
        /// Information when was the last time the job was successfully scheduled.
        /// </summary>
        public readonly string LastScheduleTime;

        [OutputConstructor]
        private CronJobStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.ObjectReference> active,

            string lastScheduleTime)
        {
            Active = active;
            LastScheduleTime = lastScheduleTime;
        }
    }
}
