// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta3
{

    /// <summary>
    /// ServiceAccountSubject holds detailed information for service-account-kind subject.
    /// </summary>
    public class ServiceAccountSubjectPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// `name` is the name of matching ServiceAccount objects, or "*" to match regardless of name. Required.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// `namespace` is the namespace of matching ServiceAccount objects. Required.
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        public ServiceAccountSubjectPatchArgs()
        {
        }
        public static new ServiceAccountSubjectPatchArgs Empty => new ServiceAccountSubjectPatchArgs();
    }
}
