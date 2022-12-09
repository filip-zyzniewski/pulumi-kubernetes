// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.core.v1.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.kubernetes.core.v1.outputs.ClaimSourcePatch;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class PodResourceClaimPatch {
    /**
     * @return Name uniquely identifies this resource claim inside the pod. This must be a DNS_LABEL.
     * 
     */
    private @Nullable String name;
    /**
     * @return Source describes where to find the ResourceClaim.
     * 
     */
    private @Nullable ClaimSourcePatch source;

    private PodResourceClaimPatch() {}
    /**
     * @return Name uniquely identifies this resource claim inside the pod. This must be a DNS_LABEL.
     * 
     */
    public Optional<String> name() {
        return Optional.ofNullable(this.name);
    }
    /**
     * @return Source describes where to find the ResourceClaim.
     * 
     */
    public Optional<ClaimSourcePatch> source() {
        return Optional.ofNullable(this.source);
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(PodResourceClaimPatch defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private @Nullable String name;
        private @Nullable ClaimSourcePatch source;
        public Builder() {}
        public Builder(PodResourceClaimPatch defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.name = defaults.name;
    	      this.source = defaults.source;
        }

        @CustomType.Setter
        public Builder name(@Nullable String name) {
            this.name = name;
            return this;
        }
        @CustomType.Setter
        public Builder source(@Nullable ClaimSourcePatch source) {
            this.source = source;
            return this;
        }
        public PodResourceClaimPatch build() {
            final var o = new PodResourceClaimPatch();
            o.name = name;
            o.source = source;
            return o;
        }
    }
}
