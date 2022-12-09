// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.admissionregistration.v1alpha1.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.kubernetes.admissionregistration.v1alpha1.outputs.MatchResourcesPatch;
import com.pulumi.kubernetes.admissionregistration.v1alpha1.outputs.ParamRefPatch;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class ValidatingAdmissionPolicyBindingSpecPatch {
    /**
     * @return MatchResources declares what resources match this binding and will be validated by it. Note that this is intersected with the policy&#39;s matchConstraints, so only requests that are matched by the policy can be selected by this. If this is unset, all resources matched by the policy are validated by this binding When resourceRules is unset, it does not constrain resource matching. If a resource is matched by the other fields of this object, it will be validated. Note that this is differs from ValidatingAdmissionPolicy matchConstraints, where resourceRules are required.
     * 
     */
    private @Nullable MatchResourcesPatch matchResources;
    /**
     * @return ParamRef specifies the parameter resource used to configure the admission control policy. It should point to a resource of the type specified in ParamKind of the bound ValidatingAdmissionPolicy. If the policy specifies a ParamKind and the resource referred to by ParamRef does not exist, this binding is considered mis-configured and the FailurePolicy of the ValidatingAdmissionPolicy applied.
     * 
     */
    private @Nullable ParamRefPatch paramRef;
    /**
     * @return PolicyName references a ValidatingAdmissionPolicy name which the ValidatingAdmissionPolicyBinding binds to. If the referenced resource does not exist, this binding is considered invalid and will be ignored Required.
     * 
     */
    private @Nullable String policyName;

    private ValidatingAdmissionPolicyBindingSpecPatch() {}
    /**
     * @return MatchResources declares what resources match this binding and will be validated by it. Note that this is intersected with the policy&#39;s matchConstraints, so only requests that are matched by the policy can be selected by this. If this is unset, all resources matched by the policy are validated by this binding When resourceRules is unset, it does not constrain resource matching. If a resource is matched by the other fields of this object, it will be validated. Note that this is differs from ValidatingAdmissionPolicy matchConstraints, where resourceRules are required.
     * 
     */
    public Optional<MatchResourcesPatch> matchResources() {
        return Optional.ofNullable(this.matchResources);
    }
    /**
     * @return ParamRef specifies the parameter resource used to configure the admission control policy. It should point to a resource of the type specified in ParamKind of the bound ValidatingAdmissionPolicy. If the policy specifies a ParamKind and the resource referred to by ParamRef does not exist, this binding is considered mis-configured and the FailurePolicy of the ValidatingAdmissionPolicy applied.
     * 
     */
    public Optional<ParamRefPatch> paramRef() {
        return Optional.ofNullable(this.paramRef);
    }
    /**
     * @return PolicyName references a ValidatingAdmissionPolicy name which the ValidatingAdmissionPolicyBinding binds to. If the referenced resource does not exist, this binding is considered invalid and will be ignored Required.
     * 
     */
    public Optional<String> policyName() {
        return Optional.ofNullable(this.policyName);
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(ValidatingAdmissionPolicyBindingSpecPatch defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private @Nullable MatchResourcesPatch matchResources;
        private @Nullable ParamRefPatch paramRef;
        private @Nullable String policyName;
        public Builder() {}
        public Builder(ValidatingAdmissionPolicyBindingSpecPatch defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.matchResources = defaults.matchResources;
    	      this.paramRef = defaults.paramRef;
    	      this.policyName = defaults.policyName;
        }

        @CustomType.Setter
        public Builder matchResources(@Nullable MatchResourcesPatch matchResources) {
            this.matchResources = matchResources;
            return this;
        }
        @CustomType.Setter
        public Builder paramRef(@Nullable ParamRefPatch paramRef) {
            this.paramRef = paramRef;
            return this;
        }
        @CustomType.Setter
        public Builder policyName(@Nullable String policyName) {
            this.policyName = policyName;
            return this;
        }
        public ValidatingAdmissionPolicyBindingSpecPatch build() {
            final var o = new ValidatingAdmissionPolicyBindingSpecPatch();
            o.matchResources = matchResources;
            o.paramRef = paramRef;
            o.policyName = policyName;
            return o;
        }
    }
}
