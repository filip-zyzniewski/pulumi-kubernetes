// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Authorization.V1Beta1
{

    [OutputType]
    public sealed class SelfSubjectAccessReviewSpec
    {
        /// <summary>
        /// NonResourceAttributes describes information for a non-resource access request
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Authorization.V1Beta1.NonResourceAttributes NonResourceAttributes;
        /// <summary>
        /// ResourceAuthorizationAttributes describes information for a resource access request
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Authorization.V1Beta1.ResourceAttributes ResourceAttributes;

        [OutputConstructor]
        private SelfSubjectAccessReviewSpec(
            Pulumi.Kubernetes.Types.Outputs.Authorization.V1Beta1.NonResourceAttributes nonResourceAttributes,

            Pulumi.Kubernetes.Types.Outputs.Authorization.V1Beta1.ResourceAttributes resourceAttributes)
        {
            NonResourceAttributes = nonResourceAttributes;
            ResourceAttributes = resourceAttributes;
        }
    }
}
