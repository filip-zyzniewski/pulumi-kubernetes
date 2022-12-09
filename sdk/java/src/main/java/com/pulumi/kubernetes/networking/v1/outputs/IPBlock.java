// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.networking.v1.outputs;

import com.pulumi.core.annotations.CustomType;
import java.lang.String;
import java.util.List;
import java.util.Objects;
import javax.annotation.Nullable;

@CustomType
public final class IPBlock {
    /**
     * @return CIDR is a string representing the IP Block Valid examples are &#34;192.168.1.0/24&#34; or &#34;2001:db8::/64&#34;
     * 
     */
    private String cidr;
    /**
     * @return Except is a slice of CIDRs that should not be included within an IP Block Valid examples are &#34;192.168.1.0/24&#34; or &#34;2001:db8::/64&#34; Except values will be rejected if they are outside the CIDR range
     * 
     */
    private @Nullable List<String> except;

    private IPBlock() {}
    /**
     * @return CIDR is a string representing the IP Block Valid examples are &#34;192.168.1.0/24&#34; or &#34;2001:db8::/64&#34;
     * 
     */
    public String cidr() {
        return this.cidr;
    }
    /**
     * @return Except is a slice of CIDRs that should not be included within an IP Block Valid examples are &#34;192.168.1.0/24&#34; or &#34;2001:db8::/64&#34; Except values will be rejected if they are outside the CIDR range
     * 
     */
    public List<String> except() {
        return this.except == null ? List.of() : this.except;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(IPBlock defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private String cidr;
        private @Nullable List<String> except;
        public Builder() {}
        public Builder(IPBlock defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.cidr = defaults.cidr;
    	      this.except = defaults.except;
        }

        @CustomType.Setter
        public Builder cidr(String cidr) {
            this.cidr = Objects.requireNonNull(cidr);
            return this;
        }
        @CustomType.Setter
        public Builder except(@Nullable List<String> except) {
            this.except = except;
            return this;
        }
        public Builder except(String... except) {
            return except(List.of(except));
        }
        public IPBlock build() {
            final var o = new IPBlock();
            o.cidr = cidr;
            o.except = except;
            return o;
        }
    }
}
