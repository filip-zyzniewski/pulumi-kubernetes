// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1
{

    /// <summary>
    /// CustomResourceDefinitionCondition contains details for the current condition of this pod.
    /// </summary>
    public class CustomResourceDefinitionConditionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// lastTransitionTime last time the condition transitioned from one status to another.
        /// </summary>
        [Input("lastTransitionTime")]
        public Input<string>? LastTransitionTime { get; set; }

        /// <summary>
        /// message is a human-readable message indicating details about last transition.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// reason is a unique, one-word, CamelCase reason for the condition's last transition.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// status is the status of the condition. Can be True, False, Unknown.
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// type is the type of the condition. Types include Established, NamesAccepted and Terminating.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public CustomResourceDefinitionConditionArgs()
        {
        }
    }
}
