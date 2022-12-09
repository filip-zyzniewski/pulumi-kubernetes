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
    /// ResourceClaimStatus tracks whether the resource has been allocated and what the resulting attributes are.
    /// </summary>
    [OutputType]
    public sealed class ResourceClaimStatusPatch
    {
        /// <summary>
        /// Allocation is set by the resource driver once a resource has been allocated successfully. If this is not specified, the resource is not yet allocated.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Resource.V1Alpha1.AllocationResultPatch Allocation;
        /// <summary>
        /// DeallocationRequested indicates that a ResourceClaim is to be deallocated.
        /// 
        /// The driver then must deallocate this claim and reset the field together with clearing the Allocation field.
        /// 
        /// While DeallocationRequested is set, no new consumers may be added to ReservedFor.
        /// </summary>
        public readonly bool DeallocationRequested;
        /// <summary>
        /// DriverName is a copy of the driver name from the ResourceClass at the time when allocation started.
        /// </summary>
        public readonly string DriverName;
        /// <summary>
        /// ReservedFor indicates which entities are currently allowed to use the claim. A Pod which references a ResourceClaim which is not reserved for that Pod will not be started.
        /// 
        /// There can be at most 32 such reservations. This may get increased in the future, but not reduced.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Resource.V1Alpha1.ResourceClaimConsumerReferencePatch> ReservedFor;

        [OutputConstructor]
        private ResourceClaimStatusPatch(
            Pulumi.Kubernetes.Types.Outputs.Resource.V1Alpha1.AllocationResultPatch allocation,

            bool deallocationRequested,

            string driverName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Resource.V1Alpha1.ResourceClaimConsumerReferencePatch> reservedFor)
        {
            Allocation = allocation;
            DeallocationRequested = deallocationRequested;
            DriverName = driverName;
            ReservedFor = reservedFor;
        }
    }
}
