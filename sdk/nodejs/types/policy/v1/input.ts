// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../../types/input";
import * as outputs from "../../../types/output";
import * as enums from "../../../types/enums";
import * as utilities from "../../../utilities";

/**
 * PodDisruptionBudget is an object to define the max disruption that can be caused to a collection of pods
 */
export interface PodDisruptionBudget {
    /**
     * APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
     */
    apiVersion?: pulumi.Input<"policy/v1">;
    /**
     * Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
     */
    kind?: pulumi.Input<"PodDisruptionBudget">;
    /**
     * Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
     */
    metadata?: pulumi.Input<inputs.meta.v1.ObjectMeta>;
    /**
     * Specification of the desired behavior of the PodDisruptionBudget.
     */
    spec?: pulumi.Input<inputs.policy.v1.PodDisruptionBudgetSpec>;
    /**
     * Most recently observed status of the PodDisruptionBudget.
     */
    status?: pulumi.Input<inputs.policy.v1.PodDisruptionBudgetStatus>;
}

/**
 * PodDisruptionBudgetSpec is a description of a PodDisruptionBudget.
 */
export interface PodDisruptionBudgetSpec {
    /**
     * An eviction is allowed if at most "maxUnavailable" pods selected by "selector" are unavailable after the eviction, i.e. even in absence of the evicted pod. For example, one can prevent all voluntary evictions by specifying 0. This is a mutually exclusive setting with "minAvailable".
     */
    maxUnavailable?: pulumi.Input<number | string>;
    /**
     * An eviction is allowed if at least "minAvailable" pods selected by "selector" will still be available after the eviction, i.e. even in the absence of the evicted pod.  So for example you can prevent all voluntary evictions by specifying "100%".
     */
    minAvailable?: pulumi.Input<number | string>;
    /**
     * Label query over pods whose evictions are managed by the disruption budget. A null selector will match no pods, while an empty ({}) selector will select all pods within the namespace.
     */
    selector?: pulumi.Input<inputs.meta.v1.LabelSelector>;
    /**
     * UnhealthyPodEvictionPolicy defines the criteria for when unhealthy pods should be considered for eviction. Current implementation considers healthy pods, as pods that have status.conditions item with type="Ready",status="True".
     *
     * Valid policies are IfHealthyBudget and AlwaysAllow. If no policy is specified, the default behavior will be used, which corresponds to the IfHealthyBudget policy.
     *
     * IfHealthyBudget policy means that running pods (status.phase="Running"), but not yet healthy can be evicted only if the guarded application is not disrupted (status.currentHealthy is at least equal to status.desiredHealthy). Healthy pods will be subject to the PDB for eviction.
     *
     * AlwaysAllow policy means that all running pods (status.phase="Running"), but not yet healthy are considered disrupted and can be evicted regardless of whether the criteria in a PDB is met. This means perspective running pods of a disrupted application might not get a chance to become healthy. Healthy pods will be subject to the PDB for eviction.
     *
     * Additional policies may be added in the future. Clients making eviction decisions should disallow eviction of unhealthy pods if they encounter an unrecognized policy in this field.
     *
     * This field is alpha-level. The eviction API uses this field when the feature gate PDBUnhealthyPodEvictionPolicy is enabled (disabled by default).
     */
    unhealthyPodEvictionPolicy?: pulumi.Input<string>;
}

/**
 * PodDisruptionBudgetSpec is a description of a PodDisruptionBudget.
 */
export interface PodDisruptionBudgetSpecPatch {
    /**
     * An eviction is allowed if at most "maxUnavailable" pods selected by "selector" are unavailable after the eviction, i.e. even in absence of the evicted pod. For example, one can prevent all voluntary evictions by specifying 0. This is a mutually exclusive setting with "minAvailable".
     */
    maxUnavailable?: pulumi.Input<number | string>;
    /**
     * An eviction is allowed if at least "minAvailable" pods selected by "selector" will still be available after the eviction, i.e. even in the absence of the evicted pod.  So for example you can prevent all voluntary evictions by specifying "100%".
     */
    minAvailable?: pulumi.Input<number | string>;
    /**
     * Label query over pods whose evictions are managed by the disruption budget. A null selector will match no pods, while an empty ({}) selector will select all pods within the namespace.
     */
    selector?: pulumi.Input<inputs.meta.v1.LabelSelectorPatch>;
    /**
     * UnhealthyPodEvictionPolicy defines the criteria for when unhealthy pods should be considered for eviction. Current implementation considers healthy pods, as pods that have status.conditions item with type="Ready",status="True".
     *
     * Valid policies are IfHealthyBudget and AlwaysAllow. If no policy is specified, the default behavior will be used, which corresponds to the IfHealthyBudget policy.
     *
     * IfHealthyBudget policy means that running pods (status.phase="Running"), but not yet healthy can be evicted only if the guarded application is not disrupted (status.currentHealthy is at least equal to status.desiredHealthy). Healthy pods will be subject to the PDB for eviction.
     *
     * AlwaysAllow policy means that all running pods (status.phase="Running"), but not yet healthy are considered disrupted and can be evicted regardless of whether the criteria in a PDB is met. This means perspective running pods of a disrupted application might not get a chance to become healthy. Healthy pods will be subject to the PDB for eviction.
     *
     * Additional policies may be added in the future. Clients making eviction decisions should disallow eviction of unhealthy pods if they encounter an unrecognized policy in this field.
     *
     * This field is alpha-level. The eviction API uses this field when the feature gate PDBUnhealthyPodEvictionPolicy is enabled (disabled by default).
     */
    unhealthyPodEvictionPolicy?: pulumi.Input<string>;
}

/**
 * PodDisruptionBudgetStatus represents information about the status of a PodDisruptionBudget. Status may trail the actual state of a system.
 */
export interface PodDisruptionBudgetStatus {
    /**
     * Conditions contain conditions for PDB. The disruption controller sets the DisruptionAllowed condition. The following are known values for the reason field (additional reasons could be added in the future): - SyncFailed: The controller encountered an error and wasn't able to compute
     *               the number of allowed disruptions. Therefore no disruptions are
     *               allowed and the status of the condition will be False.
     * - InsufficientPods: The number of pods are either at or below the number
     *                     required by the PodDisruptionBudget. No disruptions are
     *                     allowed and the status of the condition will be False.
     * - SufficientPods: There are more pods than required by the PodDisruptionBudget.
     *                   The condition will be True, and the number of allowed
     *                   disruptions are provided by the disruptionsAllowed property.
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.meta.v1.Condition>[]>;
    /**
     * current number of healthy pods
     */
    currentHealthy: pulumi.Input<number>;
    /**
     * minimum desired number of healthy pods
     */
    desiredHealthy: pulumi.Input<number>;
    /**
     * DisruptedPods contains information about pods whose eviction was processed by the API server eviction subresource handler but has not yet been observed by the PodDisruptionBudget controller. A pod will be in this map from the time when the API server processed the eviction request to the time when the pod is seen by PDB controller as having been marked for deletion (or after a timeout). The key in the map is the name of the pod and the value is the time when the API server processed the eviction request. If the deletion didn't occur and a pod is still there it will be removed from the list automatically by PodDisruptionBudget controller after some time. If everything goes smooth this map should be empty for the most of the time. Large number of entries in the map may indicate problems with pod deletions.
     */
    disruptedPods?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Number of pod disruptions that are currently allowed.
     */
    disruptionsAllowed: pulumi.Input<number>;
    /**
     * total number of pods counted by this disruption budget
     */
    expectedPods: pulumi.Input<number>;
    /**
     * Most recent generation observed when updating this PDB status. DisruptionsAllowed and other status information is valid only if observedGeneration equals to PDB's object generation.
     */
    observedGeneration?: pulumi.Input<number>;
}

