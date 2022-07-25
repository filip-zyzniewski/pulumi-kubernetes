// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.ApiRegistration.V1Beta1
{

    /// <summary>
    /// APIServiceCondition describes the state of an APIService at a particular point
    /// </summary>
    public class APIServiceConditionPatchArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Last time the condition transitioned from one status to another.
        /// </summary>
        [Input("lastTransitionTime")]
        public Input<string>? LastTransitionTime { get; set; }

        /// <summary>
        /// Human-readable message indicating details about last transition.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// Unique, one-word, CamelCase reason for the condition's last transition.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// Status is the status of the condition. Can be True, False, Unknown.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Type is the type of the condition.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public APIServiceConditionPatchArgs()
        {
        }
    }
}