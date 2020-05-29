// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    /// <summary>
    /// ResourceQuotaSpec defines the desired hard limits to enforce for Quota.
    /// </summary>
    public class ResourceQuotaSpecArgs : Pulumi.ResourceArgs
    {
        [Input("hard")]
        private InputMap<string>? _hard;

        /// <summary>
        /// hard is the set of desired hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/
        /// </summary>
        public InputMap<string> Hard
        {
            get => _hard ?? (_hard = new InputMap<string>());
            set => _hard = value;
        }

        /// <summary>
        /// scopeSelector is also a collection of filters like scopes that must match each object tracked by a quota but expressed using ScopeSelectorOperator in combination with possible values. For a resource to match, both scopes AND scopeSelector (if specified in spec), must be matched.
        /// </summary>
        [Input("scopeSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ScopeSelectorArgs>? ScopeSelector { get; set; }

        [Input("scopes")]
        private InputList<string>? _scopes;

        /// <summary>
        /// A collection of filters that must match each object tracked by a quota. If not specified, the quota matches all objects.
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        public ResourceQuotaSpecArgs()
        {
        }
    }
}
