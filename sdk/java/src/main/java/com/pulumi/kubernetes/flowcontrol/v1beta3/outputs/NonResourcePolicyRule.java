// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.flowcontrol.v1beta3.outputs;

import com.pulumi.core.annotations.CustomType;
import java.lang.String;
import java.util.List;
import java.util.Objects;

@CustomType
public final class NonResourcePolicyRule {
    /**
     * @return `nonResourceURLs` is a set of url prefixes that a user should have access to and may not be empty. For example:
     *   - &#34;/healthz&#34; is legal
     *   - &#34;/hea*&#34; is illegal
     *   - &#34;/hea&#34; is legal but matches nothing
     *   - &#34;/hea/*&#34; also matches nothing
     *   - &#34;/healthz/*&#34; matches all per-component health checks.
     *     &#34;*&#34; matches all non-resource urls. if it is present, it must be the only entry. Required.
     * 
     */
    private List<String> nonResourceURLs;
    /**
     * @return `verbs` is a list of matching verbs and may not be empty. &#34;*&#34; matches all verbs. If it is present, it must be the only entry. Required.
     * 
     */
    private List<String> verbs;

    private NonResourcePolicyRule() {}
    /**
     * @return `nonResourceURLs` is a set of url prefixes that a user should have access to and may not be empty. For example:
     *   - &#34;/healthz&#34; is legal
     *   - &#34;/hea*&#34; is illegal
     *   - &#34;/hea&#34; is legal but matches nothing
     *   - &#34;/hea/*&#34; also matches nothing
     *   - &#34;/healthz/*&#34; matches all per-component health checks.
     *     &#34;*&#34; matches all non-resource urls. if it is present, it must be the only entry. Required.
     * 
     */
    public List<String> nonResourceURLs() {
        return this.nonResourceURLs;
    }
    /**
     * @return `verbs` is a list of matching verbs and may not be empty. &#34;*&#34; matches all verbs. If it is present, it must be the only entry. Required.
     * 
     */
    public List<String> verbs() {
        return this.verbs;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(NonResourcePolicyRule defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private List<String> nonResourceURLs;
        private List<String> verbs;
        public Builder() {}
        public Builder(NonResourcePolicyRule defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.nonResourceURLs = defaults.nonResourceURLs;
    	      this.verbs = defaults.verbs;
        }

        @CustomType.Setter
        public Builder nonResourceURLs(List<String> nonResourceURLs) {
            this.nonResourceURLs = Objects.requireNonNull(nonResourceURLs);
            return this;
        }
        public Builder nonResourceURLs(String... nonResourceURLs) {
            return nonResourceURLs(List.of(nonResourceURLs));
        }
        @CustomType.Setter
        public Builder verbs(List<String> verbs) {
            this.verbs = Objects.requireNonNull(verbs);
            return this;
        }
        public Builder verbs(String... verbs) {
            return verbs(List.of(verbs));
        }
        public NonResourcePolicyRule build() {
            final var o = new NonResourcePolicyRule();
            o.nonResourceURLs = nonResourceURLs;
            o.verbs = verbs;
            return o;
        }
    }
}