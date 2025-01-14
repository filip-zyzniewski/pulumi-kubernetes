// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.core.v1.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.kubernetes.core.v1.outputs.DaemonEndpointPatch;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class NodeDaemonEndpointsPatch {
    /**
     * @return Endpoint on which Kubelet is listening.
     * 
     */
    private @Nullable DaemonEndpointPatch kubeletEndpoint;

    private NodeDaemonEndpointsPatch() {}
    /**
     * @return Endpoint on which Kubelet is listening.
     * 
     */
    public Optional<DaemonEndpointPatch> kubeletEndpoint() {
        return Optional.ofNullable(this.kubeletEndpoint);
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(NodeDaemonEndpointsPatch defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private @Nullable DaemonEndpointPatch kubeletEndpoint;
        public Builder() {}
        public Builder(NodeDaemonEndpointsPatch defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.kubeletEndpoint = defaults.kubeletEndpoint;
        }

        @CustomType.Setter
        public Builder kubeletEndpoint(@Nullable DaemonEndpointPatch kubeletEndpoint) {
            this.kubeletEndpoint = kubeletEndpoint;
            return this;
        }
        public NodeDaemonEndpointsPatch build() {
            final var o = new NodeDaemonEndpointsPatch();
            o.kubeletEndpoint = kubeletEndpoint;
            return o;
        }
    }
}
