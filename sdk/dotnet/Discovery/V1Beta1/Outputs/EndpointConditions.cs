// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Discovery.V1Beta1
{

    [OutputType]
    public sealed class EndpointConditions
    {
        /// <summary>
        /// ready indicates that this endpoint is prepared to receive traffic, according to whatever system is managing the endpoint. A nil value indicates an unknown state. In most cases consumers should interpret this unknown state as ready.
        /// </summary>
        public readonly bool Ready;

        [OutputConstructor]
        private EndpointConditions(bool ready)
        {
            Ready = ready;
        }
    }
}
