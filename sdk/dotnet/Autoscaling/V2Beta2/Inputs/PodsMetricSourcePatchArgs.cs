// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2Beta2
{

    /// <summary>
    /// PodsMetricSource indicates how to scale on a metric describing each pod in the current scale target (for example, transactions-processed-per-second). The values will be averaged together before being compared to the target value.
    /// </summary>
    public class PodsMetricSourcePatchArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// metric identifies the target metric by name and selector
        /// </summary>
        [Input("metric")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2Beta2.MetricIdentifierPatchArgs>? Metric { get; set; }

        /// <summary>
        /// target specifies the target value for the given metric
        /// </summary>
        [Input("target")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2Beta2.MetricTargetPatchArgs>? Target { get; set; }

        public PodsMetricSourcePatchArgs()
        {
        }
    }
}