// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../../types/input";
import * as outputs from "../../../types/output";
import * as enums from "../../../types/enums";
import * as utilities from "../../../utilities";

/**
 * FlowDistinguisherMethod specifies the method of a flow distinguisher.
 */
export interface FlowDistinguisherMethod {
    /**
     * `type` is the type of flow distinguisher method The supported types are "ByUser" and "ByNamespace". Required.
     */
    type: pulumi.Input<string>;
}

/**
 * FlowDistinguisherMethod specifies the method of a flow distinguisher.
 */
export interface FlowDistinguisherMethodPatch {
    /**
     * `type` is the type of flow distinguisher method The supported types are "ByUser" and "ByNamespace". Required.
     */
    type?: pulumi.Input<string>;
}

/**
 * FlowSchema defines the schema of a group of flows. Note that a flow is made up of a set of inbound API requests with similar attributes and is identified by a pair of strings: the name of the FlowSchema and a "flow distinguisher".
 */
export interface FlowSchema {
    /**
     * APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
     */
    apiVersion?: pulumi.Input<"flowcontrol.apiserver.k8s.io/v1beta1">;
    /**
     * Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
     */
    kind?: pulumi.Input<"FlowSchema">;
    /**
     * `metadata` is the standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
     */
    metadata?: pulumi.Input<inputs.meta.v1.ObjectMeta>;
    /**
     * `spec` is the specification of the desired behavior of a FlowSchema. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
     */
    spec?: pulumi.Input<inputs.flowcontrol.v1beta1.FlowSchemaSpec>;
    /**
     * `status` is the current status of a FlowSchema. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
     */
    status?: pulumi.Input<inputs.flowcontrol.v1beta1.FlowSchemaStatus>;
}

/**
 * FlowSchemaCondition describes conditions for a FlowSchema.
 */
export interface FlowSchemaCondition {
    /**
     * `lastTransitionTime` is the last time the condition transitioned from one status to another.
     */
    lastTransitionTime?: pulumi.Input<string>;
    /**
     * `message` is a human-readable message indicating details about last transition.
     */
    message?: pulumi.Input<string>;
    /**
     * `reason` is a unique, one-word, CamelCase reason for the condition's last transition.
     */
    reason?: pulumi.Input<string>;
    /**
     * `status` is the status of the condition. Can be True, False, Unknown. Required.
     */
    status?: pulumi.Input<string>;
    /**
     * `type` is the type of the condition. Required.
     */
    type?: pulumi.Input<string>;
}

/**
 * FlowSchemaSpec describes how the FlowSchema's specification looks like.
 */
export interface FlowSchemaSpec {
    /**
     * `distinguisherMethod` defines how to compute the flow distinguisher for requests that match this schema. `nil` specifies that the distinguisher is disabled and thus will always be the empty string.
     */
    distinguisherMethod?: pulumi.Input<inputs.flowcontrol.v1beta1.FlowDistinguisherMethod>;
    /**
     * `matchingPrecedence` is used to choose among the FlowSchemas that match a given request. The chosen FlowSchema is among those with the numerically lowest (which we take to be logically highest) MatchingPrecedence.  Each MatchingPrecedence value must be ranged in [1,10000]. Note that if the precedence is not specified, it will be set to 1000 as default.
     */
    matchingPrecedence?: pulumi.Input<number>;
    /**
     * `priorityLevelConfiguration` should reference a PriorityLevelConfiguration in the cluster. If the reference cannot be resolved, the FlowSchema will be ignored and marked as invalid in its status. Required.
     */
    priorityLevelConfiguration: pulumi.Input<inputs.flowcontrol.v1beta1.PriorityLevelConfigurationReference>;
    /**
     * `rules` describes which requests will match this flow schema. This FlowSchema matches a request if and only if at least one member of rules matches the request. if it is an empty slice, there will be no requests matching the FlowSchema.
     */
    rules?: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.PolicyRulesWithSubjects>[]>;
}

/**
 * FlowSchemaSpec describes how the FlowSchema's specification looks like.
 */
export interface FlowSchemaSpecPatch {
    /**
     * `distinguisherMethod` defines how to compute the flow distinguisher for requests that match this schema. `nil` specifies that the distinguisher is disabled and thus will always be the empty string.
     */
    distinguisherMethod?: pulumi.Input<inputs.flowcontrol.v1beta1.FlowDistinguisherMethodPatch>;
    /**
     * `matchingPrecedence` is used to choose among the FlowSchemas that match a given request. The chosen FlowSchema is among those with the numerically lowest (which we take to be logically highest) MatchingPrecedence.  Each MatchingPrecedence value must be ranged in [1,10000]. Note that if the precedence is not specified, it will be set to 1000 as default.
     */
    matchingPrecedence?: pulumi.Input<number>;
    /**
     * `priorityLevelConfiguration` should reference a PriorityLevelConfiguration in the cluster. If the reference cannot be resolved, the FlowSchema will be ignored and marked as invalid in its status. Required.
     */
    priorityLevelConfiguration?: pulumi.Input<inputs.flowcontrol.v1beta1.PriorityLevelConfigurationReferencePatch>;
    /**
     * `rules` describes which requests will match this flow schema. This FlowSchema matches a request if and only if at least one member of rules matches the request. if it is an empty slice, there will be no requests matching the FlowSchema.
     */
    rules?: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.PolicyRulesWithSubjectsPatch>[]>;
}

/**
 * FlowSchemaStatus represents the current state of a FlowSchema.
 */
export interface FlowSchemaStatus {
    /**
     * `conditions` is a list of the current states of FlowSchema.
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.FlowSchemaCondition>[]>;
}

/**
 * GroupSubject holds detailed information for group-kind subject.
 */
export interface GroupSubject {
    /**
     * name is the user group that matches, or "*" to match all user groups. See https://github.com/kubernetes/apiserver/blob/master/pkg/authentication/user/user.go for some well-known group names. Required.
     */
    name: pulumi.Input<string>;
}

/**
 * GroupSubject holds detailed information for group-kind subject.
 */
export interface GroupSubjectPatch {
    /**
     * name is the user group that matches, or "*" to match all user groups. See https://github.com/kubernetes/apiserver/blob/master/pkg/authentication/user/user.go for some well-known group names. Required.
     */
    name?: pulumi.Input<string>;
}

/**
 * LimitResponse defines how to handle requests that can not be executed right now.
 */
export interface LimitResponse {
    /**
     * `queuing` holds the configuration parameters for queuing. This field may be non-empty only if `type` is `"Queue"`.
     */
    queuing?: pulumi.Input<inputs.flowcontrol.v1beta1.QueuingConfiguration>;
    /**
     * `type` is "Queue" or "Reject". "Queue" means that requests that can not be executed upon arrival are held in a queue until they can be executed or a queuing limit is reached. "Reject" means that requests that can not be executed upon arrival are rejected. Required.
     */
    type: pulumi.Input<string>;
}

/**
 * LimitResponse defines how to handle requests that can not be executed right now.
 */
export interface LimitResponsePatch {
    /**
     * `queuing` holds the configuration parameters for queuing. This field may be non-empty only if `type` is `"Queue"`.
     */
    queuing?: pulumi.Input<inputs.flowcontrol.v1beta1.QueuingConfigurationPatch>;
    /**
     * `type` is "Queue" or "Reject". "Queue" means that requests that can not be executed upon arrival are held in a queue until they can be executed or a queuing limit is reached. "Reject" means that requests that can not be executed upon arrival are rejected. Required.
     */
    type?: pulumi.Input<string>;
}

/**
 * LimitedPriorityLevelConfiguration specifies how to handle requests that are subject to limits. It addresses two issues:
 *  * How are requests for this priority level limited?
 *  * What should be done with requests that exceed the limit?
 */
export interface LimitedPriorityLevelConfiguration {
    /**
     * `assuredConcurrencyShares` (ACS) configures the execution limit, which is a limit on the number of requests of this priority level that may be exeucting at a given time.  ACS must be a positive number. The server's concurrency limit (SCL) is divided among the concurrency-controlled priority levels in proportion to their assured concurrency shares. This produces the assured concurrency value (ACV) --- the number of requests that may be executing at a time --- for each such priority level:
     *
     *             ACV(l) = ceil( SCL * ACS(l) / ( sum[priority levels k] ACS(k) ) )
     *
     * bigger numbers of ACS mean more reserved concurrent requests (at the expense of every other PL). This field has a default value of 30.
     */
    assuredConcurrencyShares?: pulumi.Input<number>;
    /**
     * `limitResponse` indicates what to do with requests that can not be executed right now
     */
    limitResponse?: pulumi.Input<inputs.flowcontrol.v1beta1.LimitResponse>;
}

/**
 * LimitedPriorityLevelConfiguration specifies how to handle requests that are subject to limits. It addresses two issues:
 *  * How are requests for this priority level limited?
 *  * What should be done with requests that exceed the limit?
 */
export interface LimitedPriorityLevelConfigurationPatch {
    /**
     * `assuredConcurrencyShares` (ACS) configures the execution limit, which is a limit on the number of requests of this priority level that may be exeucting at a given time.  ACS must be a positive number. The server's concurrency limit (SCL) is divided among the concurrency-controlled priority levels in proportion to their assured concurrency shares. This produces the assured concurrency value (ACV) --- the number of requests that may be executing at a time --- for each such priority level:
     *
     *             ACV(l) = ceil( SCL * ACS(l) / ( sum[priority levels k] ACS(k) ) )
     *
     * bigger numbers of ACS mean more reserved concurrent requests (at the expense of every other PL). This field has a default value of 30.
     */
    assuredConcurrencyShares?: pulumi.Input<number>;
    /**
     * `limitResponse` indicates what to do with requests that can not be executed right now
     */
    limitResponse?: pulumi.Input<inputs.flowcontrol.v1beta1.LimitResponsePatch>;
}

/**
 * NonResourcePolicyRule is a predicate that matches non-resource requests according to their verb and the target non-resource URL. A NonResourcePolicyRule matches a request if and only if both (a) at least one member of verbs matches the request and (b) at least one member of nonResourceURLs matches the request.
 */
export interface NonResourcePolicyRule {
    /**
     * `nonResourceURLs` is a set of url prefixes that a user should have access to and may not be empty. For example:
     *   - "/healthz" is legal
     *   - "/hea*" is illegal
     *   - "/hea" is legal but matches nothing
     *   - "/hea/*" also matches nothing
     *   - "/healthz/*" matches all per-component health checks.
     * "*" matches all non-resource urls. if it is present, it must be the only entry. Required.
     */
    nonResourceURLs: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * `verbs` is a list of matching verbs and may not be empty. "*" matches all verbs. If it is present, it must be the only entry. Required.
     */
    verbs: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * NonResourcePolicyRule is a predicate that matches non-resource requests according to their verb and the target non-resource URL. A NonResourcePolicyRule matches a request if and only if both (a) at least one member of verbs matches the request and (b) at least one member of nonResourceURLs matches the request.
 */
export interface NonResourcePolicyRulePatch {
    /**
     * `nonResourceURLs` is a set of url prefixes that a user should have access to and may not be empty. For example:
     *   - "/healthz" is legal
     *   - "/hea*" is illegal
     *   - "/hea" is legal but matches nothing
     *   - "/hea/*" also matches nothing
     *   - "/healthz/*" matches all per-component health checks.
     * "*" matches all non-resource urls. if it is present, it must be the only entry. Required.
     */
    nonResourceURLs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * `verbs` is a list of matching verbs and may not be empty. "*" matches all verbs. If it is present, it must be the only entry. Required.
     */
    verbs?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * PolicyRulesWithSubjects prescribes a test that applies to a request to an apiserver. The test considers the subject making the request, the verb being requested, and the resource to be acted upon. This PolicyRulesWithSubjects matches a request if and only if both (a) at least one member of subjects matches the request and (b) at least one member of resourceRules or nonResourceRules matches the request.
 */
export interface PolicyRulesWithSubjects {
    /**
     * `nonResourceRules` is a list of NonResourcePolicyRules that identify matching requests according to their verb and the target non-resource URL.
     */
    nonResourceRules?: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.NonResourcePolicyRule>[]>;
    /**
     * `resourceRules` is a slice of ResourcePolicyRules that identify matching requests according to their verb and the target resource. At least one of `resourceRules` and `nonResourceRules` has to be non-empty.
     */
    resourceRules?: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.ResourcePolicyRule>[]>;
    /**
     * subjects is the list of normal user, serviceaccount, or group that this rule cares about. There must be at least one member in this slice. A slice that includes both the system:authenticated and system:unauthenticated user groups matches every request. Required.
     */
    subjects: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.Subject>[]>;
}

/**
 * PolicyRulesWithSubjects prescribes a test that applies to a request to an apiserver. The test considers the subject making the request, the verb being requested, and the resource to be acted upon. This PolicyRulesWithSubjects matches a request if and only if both (a) at least one member of subjects matches the request and (b) at least one member of resourceRules or nonResourceRules matches the request.
 */
export interface PolicyRulesWithSubjectsPatch {
    /**
     * `nonResourceRules` is a list of NonResourcePolicyRules that identify matching requests according to their verb and the target non-resource URL.
     */
    nonResourceRules?: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.NonResourcePolicyRulePatch>[]>;
    /**
     * `resourceRules` is a slice of ResourcePolicyRules that identify matching requests according to their verb and the target resource. At least one of `resourceRules` and `nonResourceRules` has to be non-empty.
     */
    resourceRules?: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.ResourcePolicyRulePatch>[]>;
    /**
     * subjects is the list of normal user, serviceaccount, or group that this rule cares about. There must be at least one member in this slice. A slice that includes both the system:authenticated and system:unauthenticated user groups matches every request. Required.
     */
    subjects?: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.SubjectPatch>[]>;
}

/**
 * PriorityLevelConfiguration represents the configuration of a priority level.
 */
export interface PriorityLevelConfiguration {
    /**
     * APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
     */
    apiVersion?: pulumi.Input<"flowcontrol.apiserver.k8s.io/v1beta1">;
    /**
     * Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
     */
    kind?: pulumi.Input<"PriorityLevelConfiguration">;
    /**
     * `metadata` is the standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
     */
    metadata?: pulumi.Input<inputs.meta.v1.ObjectMeta>;
    /**
     * `spec` is the specification of the desired behavior of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
     */
    spec?: pulumi.Input<inputs.flowcontrol.v1beta1.PriorityLevelConfigurationSpec>;
    /**
     * `status` is the current status of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
     */
    status?: pulumi.Input<inputs.flowcontrol.v1beta1.PriorityLevelConfigurationStatus>;
}

/**
 * PriorityLevelConfigurationCondition defines the condition of priority level.
 */
export interface PriorityLevelConfigurationCondition {
    /**
     * `lastTransitionTime` is the last time the condition transitioned from one status to another.
     */
    lastTransitionTime?: pulumi.Input<string>;
    /**
     * `message` is a human-readable message indicating details about last transition.
     */
    message?: pulumi.Input<string>;
    /**
     * `reason` is a unique, one-word, CamelCase reason for the condition's last transition.
     */
    reason?: pulumi.Input<string>;
    /**
     * `status` is the status of the condition. Can be True, False, Unknown. Required.
     */
    status?: pulumi.Input<string>;
    /**
     * `type` is the type of the condition. Required.
     */
    type?: pulumi.Input<string>;
}

/**
 * PriorityLevelConfigurationReference contains information that points to the "request-priority" being used.
 */
export interface PriorityLevelConfigurationReference {
    /**
     * `name` is the name of the priority level configuration being referenced Required.
     */
    name: pulumi.Input<string>;
}

/**
 * PriorityLevelConfigurationReference contains information that points to the "request-priority" being used.
 */
export interface PriorityLevelConfigurationReferencePatch {
    /**
     * `name` is the name of the priority level configuration being referenced Required.
     */
    name?: pulumi.Input<string>;
}

/**
 * PriorityLevelConfigurationSpec specifies the configuration of a priority level.
 */
export interface PriorityLevelConfigurationSpec {
    /**
     * `limited` specifies how requests are handled for a Limited priority level. This field must be non-empty if and only if `type` is `"Limited"`.
     */
    limited?: pulumi.Input<inputs.flowcontrol.v1beta1.LimitedPriorityLevelConfiguration>;
    /**
     * `type` indicates whether this priority level is subject to limitation on request execution.  A value of `"Exempt"` means that requests of this priority level are not subject to a limit (and thus are never queued) and do not detract from the capacity made available to other priority levels.  A value of `"Limited"` means that (a) requests of this priority level _are_ subject to limits and (b) some of the server's limited capacity is made available exclusively to this priority level. Required.
     */
    type: pulumi.Input<string>;
}

/**
 * PriorityLevelConfigurationSpec specifies the configuration of a priority level.
 */
export interface PriorityLevelConfigurationSpecPatch {
    /**
     * `limited` specifies how requests are handled for a Limited priority level. This field must be non-empty if and only if `type` is `"Limited"`.
     */
    limited?: pulumi.Input<inputs.flowcontrol.v1beta1.LimitedPriorityLevelConfigurationPatch>;
    /**
     * `type` indicates whether this priority level is subject to limitation on request execution.  A value of `"Exempt"` means that requests of this priority level are not subject to a limit (and thus are never queued) and do not detract from the capacity made available to other priority levels.  A value of `"Limited"` means that (a) requests of this priority level _are_ subject to limits and (b) some of the server's limited capacity is made available exclusively to this priority level. Required.
     */
    type?: pulumi.Input<string>;
}

/**
 * PriorityLevelConfigurationStatus represents the current state of a "request-priority".
 */
export interface PriorityLevelConfigurationStatus {
    /**
     * `conditions` is the current state of "request-priority".
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.flowcontrol.v1beta1.PriorityLevelConfigurationCondition>[]>;
}

/**
 * QueuingConfiguration holds the configuration parameters for queuing
 */
export interface QueuingConfiguration {
    /**
     * `handSize` is a small positive number that configures the shuffle sharding of requests into queues.  When enqueuing a request at this priority level the request's flow identifier (a string pair) is hashed and the hash value is used to shuffle the list of queues and deal a hand of the size specified here.  The request is put into one of the shortest queues in that hand. `handSize` must be no larger than `queues`, and should be significantly smaller (so that a few heavy flows do not saturate most of the queues).  See the user-facing documentation for more extensive guidance on setting this field.  This field has a default value of 8.
     */
    handSize?: pulumi.Input<number>;
    /**
     * `queueLengthLimit` is the maximum number of requests allowed to be waiting in a given queue of this priority level at a time; excess requests are rejected.  This value must be positive.  If not specified, it will be defaulted to 50.
     */
    queueLengthLimit?: pulumi.Input<number>;
    /**
     * `queues` is the number of queues for this priority level. The queues exist independently at each apiserver. The value must be positive.  Setting it to 1 effectively precludes shufflesharding and thus makes the distinguisher method of associated flow schemas irrelevant.  This field has a default value of 64.
     */
    queues?: pulumi.Input<number>;
}

/**
 * QueuingConfiguration holds the configuration parameters for queuing
 */
export interface QueuingConfigurationPatch {
    /**
     * `handSize` is a small positive number that configures the shuffle sharding of requests into queues.  When enqueuing a request at this priority level the request's flow identifier (a string pair) is hashed and the hash value is used to shuffle the list of queues and deal a hand of the size specified here.  The request is put into one of the shortest queues in that hand. `handSize` must be no larger than `queues`, and should be significantly smaller (so that a few heavy flows do not saturate most of the queues).  See the user-facing documentation for more extensive guidance on setting this field.  This field has a default value of 8.
     */
    handSize?: pulumi.Input<number>;
    /**
     * `queueLengthLimit` is the maximum number of requests allowed to be waiting in a given queue of this priority level at a time; excess requests are rejected.  This value must be positive.  If not specified, it will be defaulted to 50.
     */
    queueLengthLimit?: pulumi.Input<number>;
    /**
     * `queues` is the number of queues for this priority level. The queues exist independently at each apiserver. The value must be positive.  Setting it to 1 effectively precludes shufflesharding and thus makes the distinguisher method of associated flow schemas irrelevant.  This field has a default value of 64.
     */
    queues?: pulumi.Input<number>;
}

/**
 * ResourcePolicyRule is a predicate that matches some resource requests, testing the request's verb and the target resource. A ResourcePolicyRule matches a resource request if and only if: (a) at least one member of verbs matches the request, (b) at least one member of apiGroups matches the request, (c) at least one member of resources matches the request, and (d) least one member of namespaces matches the request.
 */
export interface ResourcePolicyRule {
    /**
     * `apiGroups` is a list of matching API groups and may not be empty. "*" matches all API groups and, if present, must be the only entry. Required.
     */
    apiGroups: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * `clusterScope` indicates whether to match requests that do not specify a namespace (which happens either because the resource is not namespaced or the request targets all namespaces). If this field is omitted or false then the `namespaces` field must contain a non-empty list.
     */
    clusterScope?: pulumi.Input<boolean>;
    /**
     * `namespaces` is a list of target namespaces that restricts matches.  A request that specifies a target namespace matches only if either (a) this list contains that target namespace or (b) this list contains "*".  Note that "*" matches any specified namespace but does not match a request that _does not specify_ a namespace (see the `clusterScope` field for that). This list may be empty, but only if `clusterScope` is true.
     */
    namespaces?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * `resources` is a list of matching resources (i.e., lowercase and plural) with, if desired, subresource.  For example, [ "services", "nodes/status" ].  This list may not be empty. "*" matches all resources and, if present, must be the only entry. Required.
     */
    resources: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * `verbs` is a list of matching verbs and may not be empty. "*" matches all verbs and, if present, must be the only entry. Required.
     */
    verbs: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * ResourcePolicyRule is a predicate that matches some resource requests, testing the request's verb and the target resource. A ResourcePolicyRule matches a resource request if and only if: (a) at least one member of verbs matches the request, (b) at least one member of apiGroups matches the request, (c) at least one member of resources matches the request, and (d) least one member of namespaces matches the request.
 */
export interface ResourcePolicyRulePatch {
    /**
     * `apiGroups` is a list of matching API groups and may not be empty. "*" matches all API groups and, if present, must be the only entry. Required.
     */
    apiGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * `clusterScope` indicates whether to match requests that do not specify a namespace (which happens either because the resource is not namespaced or the request targets all namespaces). If this field is omitted or false then the `namespaces` field must contain a non-empty list.
     */
    clusterScope?: pulumi.Input<boolean>;
    /**
     * `namespaces` is a list of target namespaces that restricts matches.  A request that specifies a target namespace matches only if either (a) this list contains that target namespace or (b) this list contains "*".  Note that "*" matches any specified namespace but does not match a request that _does not specify_ a namespace (see the `clusterScope` field for that). This list may be empty, but only if `clusterScope` is true.
     */
    namespaces?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * `resources` is a list of matching resources (i.e., lowercase and plural) with, if desired, subresource.  For example, [ "services", "nodes/status" ].  This list may not be empty. "*" matches all resources and, if present, must be the only entry. Required.
     */
    resources?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * `verbs` is a list of matching verbs and may not be empty. "*" matches all verbs and, if present, must be the only entry. Required.
     */
    verbs?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * ServiceAccountSubject holds detailed information for service-account-kind subject.
 */
export interface ServiceAccountSubject {
    /**
     * `name` is the name of matching ServiceAccount objects, or "*" to match regardless of name. Required.
     */
    name: pulumi.Input<string>;
    /**
     * `namespace` is the namespace of matching ServiceAccount objects. Required.
     */
    namespace: pulumi.Input<string>;
}

/**
 * ServiceAccountSubject holds detailed information for service-account-kind subject.
 */
export interface ServiceAccountSubjectPatch {
    /**
     * `name` is the name of matching ServiceAccount objects, or "*" to match regardless of name. Required.
     */
    name?: pulumi.Input<string>;
    /**
     * `namespace` is the namespace of matching ServiceAccount objects. Required.
     */
    namespace?: pulumi.Input<string>;
}

/**
 * Subject matches the originator of a request, as identified by the request authentication system. There are three ways of matching an originator; by user, group, or service account.
 */
export interface Subject {
    group?: pulumi.Input<inputs.flowcontrol.v1beta1.GroupSubject>;
    /**
     * Required
     */
    kind: pulumi.Input<string>;
    serviceAccount?: pulumi.Input<inputs.flowcontrol.v1beta1.ServiceAccountSubject>;
    user?: pulumi.Input<inputs.flowcontrol.v1beta1.UserSubject>;
}

/**
 * Subject matches the originator of a request, as identified by the request authentication system. There are three ways of matching an originator; by user, group, or service account.
 */
export interface SubjectPatch {
    group?: pulumi.Input<inputs.flowcontrol.v1beta1.GroupSubjectPatch>;
    /**
     * Required
     */
    kind?: pulumi.Input<string>;
    serviceAccount?: pulumi.Input<inputs.flowcontrol.v1beta1.ServiceAccountSubjectPatch>;
    user?: pulumi.Input<inputs.flowcontrol.v1beta1.UserSubjectPatch>;
}

/**
 * UserSubject holds detailed information for user-kind subject.
 */
export interface UserSubject {
    /**
     * `name` is the username that matches, or "*" to match all usernames. Required.
     */
    name: pulumi.Input<string>;
}

/**
 * UserSubject holds detailed information for user-kind subject.
 */
export interface UserSubjectPatch {
    /**
     * `name` is the username that matches, or "*" to match all usernames. Required.
     */
    name?: pulumi.Input<string>;
}