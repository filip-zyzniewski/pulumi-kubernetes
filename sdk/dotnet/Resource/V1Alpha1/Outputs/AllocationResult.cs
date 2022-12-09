// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Resource.V1Alpha1
{

    /// <summary>
    /// AllocationResult contains attributed of an allocated resource.
    /// </summary>
    [OutputType]
    public sealed class AllocationResult
    {
        /// <summary>
        /// This field will get set by the resource driver after it has allocated the resource driver to inform the scheduler where it can schedule Pods using the ResourceClaim.
        /// 
        /// Setting this field is optional. If null, the resource is available everywhere.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.NodeSelector AvailableOnNodes;
        /// <summary>
        /// ResourceHandle contains arbitrary data returned by the driver after a successful allocation. This is opaque for Kubernetes. Driver documentation may explain to users how to interpret this data if needed.
        /// 
        /// The maximum size of this field is 16KiB. This may get increased in the future, but not reduced.
        /// </summary>
        public readonly string ResourceHandle;
        /// <summary>
        /// Shareable determines whether the resource supports more than one consumer at a time.
        /// </summary>
        public readonly bool Shareable;

        [OutputConstructor]
        private AllocationResult(
            Pulumi.Kubernetes.Types.Outputs.Core.V1.NodeSelector availableOnNodes,

            string resourceHandle,

            bool shareable)
        {
            AvailableOnNodes = availableOnNodes;
            ResourceHandle = resourceHandle;
            Shareable = shareable;
        }
    }
}
