// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.core.v1.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


/**
 * SeccompProfile defines a pod/container&#39;s seccomp profile settings. Only one profile source may be set.
 * 
 */
public final class SeccompProfilePatchArgs extends com.pulumi.resources.ResourceArgs {

    public static final SeccompProfilePatchArgs Empty = new SeccompProfilePatchArgs();

    /**
     * localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet&#39;s configured seccomp profile location. Must only be set if type is &#34;Localhost&#34;.
     * 
     */
    @Import(name="localhostProfile")
    private @Nullable Output<String> localhostProfile;

    /**
     * @return localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet&#39;s configured seccomp profile location. Must only be set if type is &#34;Localhost&#34;.
     * 
     */
    public Optional<Output<String>> localhostProfile() {
        return Optional.ofNullable(this.localhostProfile);
    }

    /**
     * type indicates which kind of seccomp profile will be applied. Valid options are:
     * 
     * Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.
     * 
     */
    @Import(name="type")
    private @Nullable Output<String> type;

    /**
     * @return type indicates which kind of seccomp profile will be applied. Valid options are:
     * 
     * Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.
     * 
     */
    public Optional<Output<String>> type() {
        return Optional.ofNullable(this.type);
    }

    private SeccompProfilePatchArgs() {}

    private SeccompProfilePatchArgs(SeccompProfilePatchArgs $) {
        this.localhostProfile = $.localhostProfile;
        this.type = $.type;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(SeccompProfilePatchArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private SeccompProfilePatchArgs $;

        public Builder() {
            $ = new SeccompProfilePatchArgs();
        }

        public Builder(SeccompProfilePatchArgs defaults) {
            $ = new SeccompProfilePatchArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param localhostProfile localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet&#39;s configured seccomp profile location. Must only be set if type is &#34;Localhost&#34;.
         * 
         * @return builder
         * 
         */
        public Builder localhostProfile(@Nullable Output<String> localhostProfile) {
            $.localhostProfile = localhostProfile;
            return this;
        }

        /**
         * @param localhostProfile localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet&#39;s configured seccomp profile location. Must only be set if type is &#34;Localhost&#34;.
         * 
         * @return builder
         * 
         */
        public Builder localhostProfile(String localhostProfile) {
            return localhostProfile(Output.of(localhostProfile));
        }

        /**
         * @param type type indicates which kind of seccomp profile will be applied. Valid options are:
         * 
         * Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.
         * 
         * @return builder
         * 
         */
        public Builder type(@Nullable Output<String> type) {
            $.type = type;
            return this;
        }

        /**
         * @param type type indicates which kind of seccomp profile will be applied. Valid options are:
         * 
         * Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.
         * 
         * @return builder
         * 
         */
        public Builder type(String type) {
            return type(Output.of(type));
        }

        public SeccompProfilePatchArgs build() {
            return $;
        }
    }

}