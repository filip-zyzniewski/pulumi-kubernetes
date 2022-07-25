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
    /// ObjectMetricSource indicates how to scale on a metric describing a kubernetes object (for example, hits-per-second on an Ingress object).
    /// </summary>
    public class ObjectMetricSourcePatchArgs : Pulumi.ResourceArgs
    {
        [Input("describedObject")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2Beta2.CrossVersionObjectReferencePatchArgs>? DescribedObject { get; set; }

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

        public ObjectMetricSourcePatchArgs()
        {
        }
    }
}