// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Resource.V1Alpha1
{
    /// <summary>
    /// PodScheduling objects hold information that is needed to schedule a Pod with ResourceClaims that use "WaitForFirstConsumer" allocation mode.
    /// 
    /// This is an alpha type and requires enabling the DynamicResourceAllocation feature gate.
    /// </summary>
    [KubernetesResourceType("kubernetes:resource.k8s.io/v1alpha1:PodScheduling")]
    public partial class PodScheduling : KubernetesResource
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Standard object metadata
        /// </summary>
        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// Spec describes where resources for the Pod are needed.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Resource.V1Alpha1.PodSchedulingSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// Status describes where resources for the Pod can be allocated.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Resource.V1Alpha1.PodSchedulingStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a PodScheduling resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PodScheduling(string name, Pulumi.Kubernetes.Types.Inputs.Resource.V1Alpha1.PodSchedulingArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:resource.k8s.io/v1alpha1:PodScheduling", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal PodScheduling(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:resource.k8s.io/v1alpha1:PodScheduling", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private PodScheduling(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:resource.k8s.io/v1alpha1:PodScheduling", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Resource.V1Alpha1.PodSchedulingArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Resource.V1Alpha1.PodSchedulingArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Resource.V1Alpha1.PodSchedulingArgs();
            args.ApiVersion = "resource.k8s.io/v1alpha1";
            args.Kind = "PodScheduling";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PodScheduling resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PodScheduling Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PodScheduling(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Resource.V1Alpha1
{

    public class PodSchedulingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Standard object metadata
        /// </summary>
        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// Spec describes where resources for the Pod are needed.
        /// </summary>
        [Input("spec", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Resource.V1Alpha1.PodSchedulingSpecArgs> Spec { get; set; } = null!;

        public PodSchedulingArgs()
        {
        }
        public static new PodSchedulingArgs Empty => new PodSchedulingArgs();
    }
}
