// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1
{

    /// <summary>
    /// SELinuxStrategyOptions defines the strategy type and any options used to create the strategy. Deprecated: use SELinuxStrategyOptions from policy API Group instead.
    /// </summary>
    public class SELinuxStrategyOptionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// rule is the strategy that will dictate the allowable labels that may be set.
        /// </summary>
        [Input("rule", required: true)]
        public Input<string> Rule { get; set; } = null!;

        /// <summary>
        /// seLinuxOptions required to run as; required for MustRunAs More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/
        /// </summary>
        [Input("seLinuxOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.SELinuxOptionsArgs>? SeLinuxOptions { get; set; }

        public SELinuxStrategyOptionsArgs()
        {
        }
    }
}
