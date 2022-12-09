// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.resource.v1alpha1.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.kubernetes.meta.v1.outputs.ObjectMetaPatch;
import com.pulumi.kubernetes.resource.v1alpha1.outputs.ResourceClaimSpecPatch;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class ResourceClaimTemplateSpecPatch {
    /**
     * @return ObjectMeta may contain labels and annotations that will be copied into the PVC when creating it. No other fields are allowed and will be rejected during validation.
     * 
     */
    private @Nullable ObjectMetaPatch metadata;
    /**
     * @return Spec for the ResourceClaim. The entire content is copied unchanged into the ResourceClaim that gets created from this template. The same fields as in a ResourceClaim are also valid here.
     * 
     */
    private @Nullable ResourceClaimSpecPatch spec;

    private ResourceClaimTemplateSpecPatch() {}
    /**
     * @return ObjectMeta may contain labels and annotations that will be copied into the PVC when creating it. No other fields are allowed and will be rejected during validation.
     * 
     */
    public Optional<ObjectMetaPatch> metadata() {
        return Optional.ofNullable(this.metadata);
    }
    /**
     * @return Spec for the ResourceClaim. The entire content is copied unchanged into the ResourceClaim that gets created from this template. The same fields as in a ResourceClaim are also valid here.
     * 
     */
    public Optional<ResourceClaimSpecPatch> spec() {
        return Optional.ofNullable(this.spec);
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(ResourceClaimTemplateSpecPatch defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private @Nullable ObjectMetaPatch metadata;
        private @Nullable ResourceClaimSpecPatch spec;
        public Builder() {}
        public Builder(ResourceClaimTemplateSpecPatch defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.metadata = defaults.metadata;
    	      this.spec = defaults.spec;
        }

        @CustomType.Setter
        public Builder metadata(@Nullable ObjectMetaPatch metadata) {
            this.metadata = metadata;
            return this;
        }
        @CustomType.Setter
        public Builder spec(@Nullable ResourceClaimSpecPatch spec) {
            this.spec = spec;
            return this;
        }
        public ResourceClaimTemplateSpecPatch build() {
            final var o = new ResourceClaimTemplateSpecPatch();
            o.metadata = metadata;
            o.spec = spec;
            return o;
        }
    }
}
