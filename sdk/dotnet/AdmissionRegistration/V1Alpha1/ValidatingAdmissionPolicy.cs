// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.AdmissionRegistration.V1Alpha1
{
    /// <summary>
    /// ValidatingAdmissionPolicy describes the definition of an admission validation policy that accepts or rejects an object without changing it.
    /// </summary>
    [KubernetesResourceType("kubernetes:admissionregistration.k8s.io/v1alpha1:ValidatingAdmissionPolicy")]
    public partial class ValidatingAdmissionPolicy : KubernetesResource
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
        /// Standard object metadata; More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        /// </summary>
        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// Specification of the desired behavior of the ValidatingAdmissionPolicy.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.AdmissionRegistration.V1Alpha1.ValidatingAdmissionPolicySpec> Spec { get; private set; } = null!;


        /// <summary>
        /// Create a ValidatingAdmissionPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ValidatingAdmissionPolicy(string name, Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1Alpha1.ValidatingAdmissionPolicyArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:admissionregistration.k8s.io/v1alpha1:ValidatingAdmissionPolicy", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal ValidatingAdmissionPolicy(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:admissionregistration.k8s.io/v1alpha1:ValidatingAdmissionPolicy", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private ValidatingAdmissionPolicy(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:admissionregistration.k8s.io/v1alpha1:ValidatingAdmissionPolicy", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1Alpha1.ValidatingAdmissionPolicyArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1Alpha1.ValidatingAdmissionPolicyArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1Alpha1.ValidatingAdmissionPolicyArgs();
            args.ApiVersion = "admissionregistration.k8s.io/v1alpha1";
            args.Kind = "ValidatingAdmissionPolicy";
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
        /// Get an existing ValidatingAdmissionPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ValidatingAdmissionPolicy Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ValidatingAdmissionPolicy(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1Alpha1
{

    public class ValidatingAdmissionPolicyArgs : global::Pulumi.ResourceArgs
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
        /// Standard object metadata; More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        /// </summary>
        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// Specification of the desired behavior of the ValidatingAdmissionPolicy.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1Alpha1.ValidatingAdmissionPolicySpecArgs>? Spec { get; set; }

        public ValidatingAdmissionPolicyArgs()
        {
        }
        public static new ValidatingAdmissionPolicyArgs Empty => new ValidatingAdmissionPolicyArgs();
    }
}
