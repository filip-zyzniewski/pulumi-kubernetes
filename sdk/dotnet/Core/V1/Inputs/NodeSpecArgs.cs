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
    /// NodeSpec describes the attributes that a node is created with.
    /// </summary>
    public class NodeSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If specified, the source to get node configuration from The DynamicKubeletConfig feature gate must be enabled for the Kubelet to use this field
        /// </summary>
        [Input("configSource")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.NodeConfigSourceArgs>? ConfigSource { get; set; }

        /// <summary>
        /// Deprecated. Not all kubelets will set this field. Remove field after 1.13. see: https://issues.k8s.io/61966
        /// </summary>
        [Input("externalID")]
        public Input<string>? ExternalID { get; set; }

        /// <summary>
        /// PodCIDR represents the pod IP range assigned to the node.
        /// </summary>
        [Input("podCIDR")]
        public Input<string>? PodCIDR { get; set; }

        [Input("podCIDRs")]
        private InputList<string>? _podCIDRs;

        /// <summary>
        /// podCIDRs represents the IP ranges assigned to the node for usage by Pods on that node. If this field is specified, the 0th entry must match the podCIDR field. It may contain at most 1 value for each of IPv4 and IPv6.
        /// </summary>
        public InputList<string> PodCIDRs
        {
            get => _podCIDRs ?? (_podCIDRs = new InputList<string>());
            set => _podCIDRs = value;
        }

        /// <summary>
        /// ID of the node assigned by the cloud provider in the format: &lt;ProviderName&gt;://&lt;ProviderSpecificNodeID&gt;
        /// </summary>
        [Input("providerID")]
        public Input<string>? ProviderID { get; set; }

        [Input("taints")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TaintArgs>? _taints;

        /// <summary>
        /// If specified, the node's taints.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TaintArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TaintArgs>());
            set => _taints = value;
        }

        /// <summary>
        /// Unschedulable controls node schedulability of new pods. By default, node is schedulable. More info: https://kubernetes.io/docs/concepts/nodes/node/#manual-node-administration
        /// </summary>
        [Input("unschedulable")]
        public Input<bool>? Unschedulable { get; set; }

        public NodeSpecArgs()
        {
        }
    }
}
