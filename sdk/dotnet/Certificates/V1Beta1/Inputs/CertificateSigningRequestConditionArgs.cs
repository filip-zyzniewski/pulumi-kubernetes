// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Certificates.V1Beta1
{

    public class CertificateSigningRequestConditionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// timestamp for the last update to this condition
        /// </summary>
        [Input("lastUpdateTime")]
        public Input<string>? LastUpdateTime { get; set; }

        /// <summary>
        /// human readable message with details about the request state
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// brief reason for the request state
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// request approval state, currently Approved or Denied.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public CertificateSigningRequestConditionArgs()
        {
        }
    }
}
