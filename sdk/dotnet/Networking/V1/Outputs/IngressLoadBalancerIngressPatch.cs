// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Networking.V1
{

    /// <summary>
    /// IngressLoadBalancerIngress represents the status of a load-balancer ingress point.
    /// </summary>
    [OutputType]
    public sealed class IngressLoadBalancerIngressPatch
    {
        /// <summary>
        /// Hostname is set for load-balancer ingress points that are DNS based.
        /// </summary>
        public readonly string Hostname;
        /// <summary>
        /// IP is set for load-balancer ingress points that are IP based.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// Ports provides information about the ports exposed by this LoadBalancer.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Networking.V1.IngressPortStatusPatch> Ports;

        [OutputConstructor]
        private IngressLoadBalancerIngressPatch(
            string hostname,

            string ip,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Networking.V1.IngressPortStatusPatch> ports)
        {
            Hostname = hostname;
            Ip = ip;
            Ports = ports;
        }
    }
}
