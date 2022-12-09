// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.admissionregistration.v1alpha1.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.kubernetes.admissionregistration.v1alpha1.outputs.MatchResourcesPatch;
import com.pulumi.kubernetes.admissionregistration.v1alpha1.outputs.ParamKindPatch;
import com.pulumi.kubernetes.admissionregistration.v1alpha1.outputs.ValidationPatch;
import java.lang.String;
import java.util.List;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class ValidatingAdmissionPolicySpecPatch {
    /**
     * @return FailurePolicy defines how to handle failures for the admission policy. Failures can occur from invalid or mis-configured policy definitions or bindings. A policy is invalid if spec.paramKind refers to a non-existent Kind. A binding is invalid if spec.paramRef.name refers to a non-existent resource. Allowed values are Ignore or Fail. Defaults to Fail.
     * 
     */
    private @Nullable String failurePolicy;
    /**
     * @return MatchConstraints specifies what resources this policy is designed to validate. The AdmissionPolicy cares about a request if it matches _all_ Constraints. However, in order to prevent clusters from being put into an unstable state that cannot be recovered from via the API ValidatingAdmissionPolicy cannot match ValidatingAdmissionPolicy and ValidatingAdmissionPolicyBinding. Required.
     * 
     */
    private @Nullable MatchResourcesPatch matchConstraints;
    /**
     * @return ParamKind specifies the kind of resources used to parameterize this policy. If absent, there are no parameters for this policy and the param CEL variable will not be provided to validation expressions. If ParamKind refers to a non-existent kind, this policy definition is mis-configured and the FailurePolicy is applied. If paramKind is specified but paramRef is unset in ValidatingAdmissionPolicyBinding, the params variable will be null.
     * 
     */
    private @Nullable ParamKindPatch paramKind;
    /**
     * @return Validations contain CEL expressions which is used to apply the validation. A minimum of one validation is required for a policy definition. Required.
     * 
     */
    private @Nullable List<ValidationPatch> validations;

    private ValidatingAdmissionPolicySpecPatch() {}
    /**
     * @return FailurePolicy defines how to handle failures for the admission policy. Failures can occur from invalid or mis-configured policy definitions or bindings. A policy is invalid if spec.paramKind refers to a non-existent Kind. A binding is invalid if spec.paramRef.name refers to a non-existent resource. Allowed values are Ignore or Fail. Defaults to Fail.
     * 
     */
    public Optional<String> failurePolicy() {
        return Optional.ofNullable(this.failurePolicy);
    }
    /**
     * @return MatchConstraints specifies what resources this policy is designed to validate. The AdmissionPolicy cares about a request if it matches _all_ Constraints. However, in order to prevent clusters from being put into an unstable state that cannot be recovered from via the API ValidatingAdmissionPolicy cannot match ValidatingAdmissionPolicy and ValidatingAdmissionPolicyBinding. Required.
     * 
     */
    public Optional<MatchResourcesPatch> matchConstraints() {
        return Optional.ofNullable(this.matchConstraints);
    }
    /**
     * @return ParamKind specifies the kind of resources used to parameterize this policy. If absent, there are no parameters for this policy and the param CEL variable will not be provided to validation expressions. If ParamKind refers to a non-existent kind, this policy definition is mis-configured and the FailurePolicy is applied. If paramKind is specified but paramRef is unset in ValidatingAdmissionPolicyBinding, the params variable will be null.
     * 
     */
    public Optional<ParamKindPatch> paramKind() {
        return Optional.ofNullable(this.paramKind);
    }
    /**
     * @return Validations contain CEL expressions which is used to apply the validation. A minimum of one validation is required for a policy definition. Required.
     * 
     */
    public List<ValidationPatch> validations() {
        return this.validations == null ? List.of() : this.validations;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(ValidatingAdmissionPolicySpecPatch defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private @Nullable String failurePolicy;
        private @Nullable MatchResourcesPatch matchConstraints;
        private @Nullable ParamKindPatch paramKind;
        private @Nullable List<ValidationPatch> validations;
        public Builder() {}
        public Builder(ValidatingAdmissionPolicySpecPatch defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.failurePolicy = defaults.failurePolicy;
    	      this.matchConstraints = defaults.matchConstraints;
    	      this.paramKind = defaults.paramKind;
    	      this.validations = defaults.validations;
        }

        @CustomType.Setter
        public Builder failurePolicy(@Nullable String failurePolicy) {
            this.failurePolicy = failurePolicy;
            return this;
        }
        @CustomType.Setter
        public Builder matchConstraints(@Nullable MatchResourcesPatch matchConstraints) {
            this.matchConstraints = matchConstraints;
            return this;
        }
        @CustomType.Setter
        public Builder paramKind(@Nullable ParamKindPatch paramKind) {
            this.paramKind = paramKind;
            return this;
        }
        @CustomType.Setter
        public Builder validations(@Nullable List<ValidationPatch> validations) {
            this.validations = validations;
            return this;
        }
        public Builder validations(ValidationPatch... validations) {
            return validations(List.of(validations));
        }
        public ValidatingAdmissionPolicySpecPatch build() {
            final var o = new ValidatingAdmissionPolicySpecPatch();
            o.failurePolicy = failurePolicy;
            o.matchConstraints = matchConstraints;
            o.paramKind = paramKind;
            o.validations = validations;
            return o;
        }
    }
}
