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
    /// IDRange provides a min/max of an allowed range of IDs. Deprecated: use IDRange from policy API Group instead.
    /// </summary>
    public class IDRangeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// max is the end of the range, inclusive.
        /// </summary>
        [Input("max", required: true)]
        public Input<int> Max { get; set; } = null!;

        /// <summary>
        /// min is the start of the range, inclusive.
        /// </summary>
        [Input("min", required: true)]
        public Input<int> Min { get; set; } = null!;

        public IDRangeArgs()
        {
        }
    }
}
