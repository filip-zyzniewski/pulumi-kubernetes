// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as enums from "../../types/enums";
import * as utilities from "../../utilities";

/**
 * ResourceClass is used by administrators to influence how resources are allocated.
 *
 * This is an alpha type and requires enabling the DynamicResourceAllocation feature gate.
 */
export class ResourceClass extends pulumi.CustomResource {
    /**
     * Get an existing ResourceClass resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ResourceClass {
        return new ResourceClass(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:resource.k8s.io/v1alpha1:ResourceClass';

    /**
     * Returns true if the given object is an instance of ResourceClass.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ResourceClass {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ResourceClass.__pulumiType;
    }

    /**
     * APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
     */
    public readonly apiVersion!: pulumi.Output<"resource.k8s.io/v1alpha1">;
    /**
     * DriverName defines the name of the dynamic resource driver that is used for allocation of a ResourceClaim that uses this class.
     *
     * Resource drivers have a unique name in forward domain order (acme.example.com).
     */
    public readonly driverName!: pulumi.Output<string>;
    /**
     * Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
     */
    public readonly kind!: pulumi.Output<"ResourceClass">;
    /**
     * Standard object metadata
     */
    public readonly metadata!: pulumi.Output<outputs.meta.v1.ObjectMeta>;
    /**
     * ParametersRef references an arbitrary separate object that may hold parameters that will be used by the driver when allocating a resource that uses this class. A dynamic resource driver can distinguish between parameters stored here and and those stored in ResourceClaimSpec.
     */
    public readonly parametersRef!: pulumi.Output<outputs.resource.v1alpha1.ResourceClassParametersReference>;
    /**
     * Only nodes matching the selector will be considered by the scheduler when trying to find a Node that fits a Pod when that Pod uses a ResourceClaim that has not been allocated yet.
     *
     * Setting this field is optional. If null, all nodes are candidates.
     */
    public readonly suitableNodes!: pulumi.Output<outputs.core.v1.NodeSelector>;

    /**
     * Create a ResourceClass resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ResourceClassArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.driverName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'driverName'");
            }
            resourceInputs["apiVersion"] = "resource.k8s.io/v1alpha1";
            resourceInputs["driverName"] = args ? args.driverName : undefined;
            resourceInputs["kind"] = "ResourceClass";
            resourceInputs["metadata"] = args ? args.metadata : undefined;
            resourceInputs["parametersRef"] = args ? args.parametersRef : undefined;
            resourceInputs["suitableNodes"] = args ? args.suitableNodes : undefined;
        } else {
            resourceInputs["apiVersion"] = undefined /*out*/;
            resourceInputs["driverName"] = undefined /*out*/;
            resourceInputs["kind"] = undefined /*out*/;
            resourceInputs["metadata"] = undefined /*out*/;
            resourceInputs["parametersRef"] = undefined /*out*/;
            resourceInputs["suitableNodes"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ResourceClass.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a ResourceClass resource.
 */
export interface ResourceClassArgs {
    /**
     * APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
     */
    apiVersion?: pulumi.Input<"resource.k8s.io/v1alpha1">;
    /**
     * DriverName defines the name of the dynamic resource driver that is used for allocation of a ResourceClaim that uses this class.
     *
     * Resource drivers have a unique name in forward domain order (acme.example.com).
     */
    driverName: pulumi.Input<string>;
    /**
     * Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
     */
    kind?: pulumi.Input<"ResourceClass">;
    /**
     * Standard object metadata
     */
    metadata?: pulumi.Input<inputs.meta.v1.ObjectMeta>;
    /**
     * ParametersRef references an arbitrary separate object that may hold parameters that will be used by the driver when allocating a resource that uses this class. A dynamic resource driver can distinguish between parameters stored here and and those stored in ResourceClaimSpec.
     */
    parametersRef?: pulumi.Input<inputs.resource.v1alpha1.ResourceClassParametersReference>;
    /**
     * Only nodes matching the selector will be considered by the scheduler when trying to find a Node that fits a Pod when that Pod uses a ResourceClaim that has not been allocated yet.
     *
     * Setting this field is optional. If null, all nodes are candidates.
     */
    suitableNodes?: pulumi.Input<inputs.core.v1.NodeSelector>;
}
