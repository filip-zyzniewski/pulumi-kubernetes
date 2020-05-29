// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.AdmissionRegistration.V1Beta1
{

    [OutputType]
    public sealed class RuleWithOperations
    {
        /// <summary>
        /// APIGroups is the API groups the resources belong to. '*' is all groups. If '*' is present, the length of the slice must be one. Required.
        /// </summary>
        public readonly ImmutableArray<string> ApiGroups;
        /// <summary>
        /// APIVersions is the API versions the resources belong to. '*' is all versions. If '*' is present, the length of the slice must be one. Required.
        /// </summary>
        public readonly ImmutableArray<string> ApiVersions;
        /// <summary>
        /// Operations is the operations the admission hook cares about - CREATE, UPDATE, or * for all operations. If '*' is present, the length of the slice must be one. Required.
        /// </summary>
        public readonly ImmutableArray<string> Operations;
        /// <summary>
        /// Resources is a list of resources this rule applies to.
        /// 
        /// For example: 'pods' means pods. 'pods/log' means the log subresource of pods. '*' means all resources, but not subresources. 'pods/*' means all subresources of pods. '*/scale' means all scale subresources. '*/*' means all resources and their subresources.
        /// 
        /// If wildcard is present, the validation rule will ensure resources do not overlap with each other.
        /// 
        /// Depending on the enclosing object, subresources might not be allowed. Required.
        /// </summary>
        public readonly ImmutableArray<string> Resources;
        /// <summary>
        /// scope specifies the scope of this rule. Valid values are "Cluster", "Namespaced", and "*" "Cluster" means that only cluster-scoped resources will match this rule. Namespace API objects are cluster-scoped. "Namespaced" means that only namespaced resources will match this rule. "*" means that there are no scope restrictions. Subresources match the scope of their parent resource. Default is "*".
        /// </summary>
        public readonly string Scope;

        [OutputConstructor]
        private RuleWithOperations(
            ImmutableArray<string> apiGroups,

            ImmutableArray<string> apiVersions,

            ImmutableArray<string> operations,

            ImmutableArray<string> resources,

            string scope)
        {
            ApiGroups = apiGroups;
            ApiVersions = apiVersions;
            Operations = operations;
            Resources = resources;
            Scope = scope;
        }
    }
}
