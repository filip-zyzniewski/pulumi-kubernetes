// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Meta.V1
{

    /// <summary>
    /// Condition contains details for one aspect of the current state of this API Resource.
    /// </summary>
    [OutputType]
    public sealed class Condition
    {
        /// <summary>
        /// lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// message is a human readable message indicating details about the transition. This may be an empty string.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.
        /// </summary>
        public readonly int ObservedGeneration;
        /// <summary>
        /// reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// status of the condition, one of True, False, Unknown.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// type of condition in CamelCase or in foo.example.com/CamelCase.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private Condition(
            string lastTransitionTime,

            string message,

            int observedGeneration,

            string reason,

            string status,

            string type)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            ObservedGeneration = observedGeneration;
            Reason = reason;
            Status = status;
            Type = type;
        }
    }
}
