// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.batch.v1.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.kubernetes.batch.v1.inputs.JobConditionArgs;
import com.pulumi.kubernetes.batch.v1.inputs.UncountedTerminatedPodsArgs;
import java.lang.Integer;
import java.lang.String;
import java.util.List;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


/**
 * JobStatus represents the current state of a Job.
 * 
 */
public final class JobStatusArgs extends com.pulumi.resources.ResourceArgs {

    public static final JobStatusArgs Empty = new JobStatusArgs();

    /**
     * The number of pending and running pods.
     * 
     */
    @Import(name="active")
    private @Nullable Output<Integer> active;

    /**
     * @return The number of pending and running pods.
     * 
     */
    public Optional<Output<Integer>> active() {
        return Optional.ofNullable(this.active);
    }

    /**
     * CompletedIndexes holds the completed indexes when .spec.completionMode = &#34;Indexed&#34; in a text format. The indexes are represented as decimal integers separated by commas. The numbers are listed in increasing order. Three or more consecutive numbers are compressed and represented by the first and last element of the series, separated by a hyphen. For example, if the completed indexes are 1, 3, 4, 5 and 7, they are represented as &#34;1,3-5,7&#34;.
     * 
     */
    @Import(name="completedIndexes")
    private @Nullable Output<String> completedIndexes;

    /**
     * @return CompletedIndexes holds the completed indexes when .spec.completionMode = &#34;Indexed&#34; in a text format. The indexes are represented as decimal integers separated by commas. The numbers are listed in increasing order. Three or more consecutive numbers are compressed and represented by the first and last element of the series, separated by a hyphen. For example, if the completed indexes are 1, 3, 4, 5 and 7, they are represented as &#34;1,3-5,7&#34;.
     * 
     */
    public Optional<Output<String>> completedIndexes() {
        return Optional.ofNullable(this.completedIndexes);
    }

    /**
     * Represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC. The completion time is only set when the job finishes successfully.
     * 
     */
    @Import(name="completionTime")
    private @Nullable Output<String> completionTime;

    /**
     * @return Represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC. The completion time is only set when the job finishes successfully.
     * 
     */
    public Optional<Output<String>> completionTime() {
        return Optional.ofNullable(this.completionTime);
    }

    /**
     * The latest available observations of an object&#39;s current state. When a Job fails, one of the conditions will have type &#34;Failed&#34; and status true. When a Job is suspended, one of the conditions will have type &#34;Suspended&#34; and status true; when the Job is resumed, the status of this condition will become false. When a Job is completed, one of the conditions will have type &#34;Complete&#34; and status true. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
     * 
     */
    @Import(name="conditions")
    private @Nullable Output<List<JobConditionArgs>> conditions;

    /**
     * @return The latest available observations of an object&#39;s current state. When a Job fails, one of the conditions will have type &#34;Failed&#34; and status true. When a Job is suspended, one of the conditions will have type &#34;Suspended&#34; and status true; when the Job is resumed, the status of this condition will become false. When a Job is completed, one of the conditions will have type &#34;Complete&#34; and status true. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
     * 
     */
    public Optional<Output<List<JobConditionArgs>>> conditions() {
        return Optional.ofNullable(this.conditions);
    }

    /**
     * The number of pods which reached phase Failed.
     * 
     */
    @Import(name="failed")
    private @Nullable Output<Integer> failed;

    /**
     * @return The number of pods which reached phase Failed.
     * 
     */
    public Optional<Output<Integer>> failed() {
        return Optional.ofNullable(this.failed);
    }

    /**
     * The number of pods which have a Ready condition.
     * 
     * This field is beta-level. The job controller populates the field when the feature gate JobReadyPods is enabled (enabled by default).
     * 
     */
    @Import(name="ready")
    private @Nullable Output<Integer> ready;

    /**
     * @return The number of pods which have a Ready condition.
     * 
     * This field is beta-level. The job controller populates the field when the feature gate JobReadyPods is enabled (enabled by default).
     * 
     */
    public Optional<Output<Integer>> ready() {
        return Optional.ofNullable(this.ready);
    }

    /**
     * Represents time when the job controller started processing a job. When a Job is created in the suspended state, this field is not set until the first time it is resumed. This field is reset every time a Job is resumed from suspension. It is represented in RFC3339 form and is in UTC.
     * 
     */
    @Import(name="startTime")
    private @Nullable Output<String> startTime;

    /**
     * @return Represents time when the job controller started processing a job. When a Job is created in the suspended state, this field is not set until the first time it is resumed. This field is reset every time a Job is resumed from suspension. It is represented in RFC3339 form and is in UTC.
     * 
     */
    public Optional<Output<String>> startTime() {
        return Optional.ofNullable(this.startTime);
    }

    /**
     * The number of pods which reached phase Succeeded.
     * 
     */
    @Import(name="succeeded")
    private @Nullable Output<Integer> succeeded;

    /**
     * @return The number of pods which reached phase Succeeded.
     * 
     */
    public Optional<Output<Integer>> succeeded() {
        return Optional.ofNullable(this.succeeded);
    }

    /**
     * UncountedTerminatedPods holds the UIDs of Pods that have terminated but the job controller hasn&#39;t yet accounted for in the status counters.
     * 
     * The job controller creates pods with a finalizer. When a pod terminates (succeeded or failed), the controller does three steps to account for it in the job status: (1) Add the pod UID to the arrays in this field. (2) Remove the pod finalizer. (3) Remove the pod UID from the arrays while increasing the corresponding
     *     counter.
     * 
     * Old jobs might not be tracked using this field, in which case the field remains null.
     * 
     */
    @Import(name="uncountedTerminatedPods")
    private @Nullable Output<UncountedTerminatedPodsArgs> uncountedTerminatedPods;

    /**
     * @return UncountedTerminatedPods holds the UIDs of Pods that have terminated but the job controller hasn&#39;t yet accounted for in the status counters.
     * 
     * The job controller creates pods with a finalizer. When a pod terminates (succeeded or failed), the controller does three steps to account for it in the job status: (1) Add the pod UID to the arrays in this field. (2) Remove the pod finalizer. (3) Remove the pod UID from the arrays while increasing the corresponding
     *     counter.
     * 
     * Old jobs might not be tracked using this field, in which case the field remains null.
     * 
     */
    public Optional<Output<UncountedTerminatedPodsArgs>> uncountedTerminatedPods() {
        return Optional.ofNullable(this.uncountedTerminatedPods);
    }

    private JobStatusArgs() {}

    private JobStatusArgs(JobStatusArgs $) {
        this.active = $.active;
        this.completedIndexes = $.completedIndexes;
        this.completionTime = $.completionTime;
        this.conditions = $.conditions;
        this.failed = $.failed;
        this.ready = $.ready;
        this.startTime = $.startTime;
        this.succeeded = $.succeeded;
        this.uncountedTerminatedPods = $.uncountedTerminatedPods;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(JobStatusArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private JobStatusArgs $;

        public Builder() {
            $ = new JobStatusArgs();
        }

        public Builder(JobStatusArgs defaults) {
            $ = new JobStatusArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param active The number of pending and running pods.
         * 
         * @return builder
         * 
         */
        public Builder active(@Nullable Output<Integer> active) {
            $.active = active;
            return this;
        }

        /**
         * @param active The number of pending and running pods.
         * 
         * @return builder
         * 
         */
        public Builder active(Integer active) {
            return active(Output.of(active));
        }

        /**
         * @param completedIndexes CompletedIndexes holds the completed indexes when .spec.completionMode = &#34;Indexed&#34; in a text format. The indexes are represented as decimal integers separated by commas. The numbers are listed in increasing order. Three or more consecutive numbers are compressed and represented by the first and last element of the series, separated by a hyphen. For example, if the completed indexes are 1, 3, 4, 5 and 7, they are represented as &#34;1,3-5,7&#34;.
         * 
         * @return builder
         * 
         */
        public Builder completedIndexes(@Nullable Output<String> completedIndexes) {
            $.completedIndexes = completedIndexes;
            return this;
        }

        /**
         * @param completedIndexes CompletedIndexes holds the completed indexes when .spec.completionMode = &#34;Indexed&#34; in a text format. The indexes are represented as decimal integers separated by commas. The numbers are listed in increasing order. Three or more consecutive numbers are compressed and represented by the first and last element of the series, separated by a hyphen. For example, if the completed indexes are 1, 3, 4, 5 and 7, they are represented as &#34;1,3-5,7&#34;.
         * 
         * @return builder
         * 
         */
        public Builder completedIndexes(String completedIndexes) {
            return completedIndexes(Output.of(completedIndexes));
        }

        /**
         * @param completionTime Represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC. The completion time is only set when the job finishes successfully.
         * 
         * @return builder
         * 
         */
        public Builder completionTime(@Nullable Output<String> completionTime) {
            $.completionTime = completionTime;
            return this;
        }

        /**
         * @param completionTime Represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC. The completion time is only set when the job finishes successfully.
         * 
         * @return builder
         * 
         */
        public Builder completionTime(String completionTime) {
            return completionTime(Output.of(completionTime));
        }

        /**
         * @param conditions The latest available observations of an object&#39;s current state. When a Job fails, one of the conditions will have type &#34;Failed&#34; and status true. When a Job is suspended, one of the conditions will have type &#34;Suspended&#34; and status true; when the Job is resumed, the status of this condition will become false. When a Job is completed, one of the conditions will have type &#34;Complete&#34; and status true. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
         * 
         * @return builder
         * 
         */
        public Builder conditions(@Nullable Output<List<JobConditionArgs>> conditions) {
            $.conditions = conditions;
            return this;
        }

        /**
         * @param conditions The latest available observations of an object&#39;s current state. When a Job fails, one of the conditions will have type &#34;Failed&#34; and status true. When a Job is suspended, one of the conditions will have type &#34;Suspended&#34; and status true; when the Job is resumed, the status of this condition will become false. When a Job is completed, one of the conditions will have type &#34;Complete&#34; and status true. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
         * 
         * @return builder
         * 
         */
        public Builder conditions(List<JobConditionArgs> conditions) {
            return conditions(Output.of(conditions));
        }

        /**
         * @param conditions The latest available observations of an object&#39;s current state. When a Job fails, one of the conditions will have type &#34;Failed&#34; and status true. When a Job is suspended, one of the conditions will have type &#34;Suspended&#34; and status true; when the Job is resumed, the status of this condition will become false. When a Job is completed, one of the conditions will have type &#34;Complete&#34; and status true. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
         * 
         * @return builder
         * 
         */
        public Builder conditions(JobConditionArgs... conditions) {
            return conditions(List.of(conditions));
        }

        /**
         * @param failed The number of pods which reached phase Failed.
         * 
         * @return builder
         * 
         */
        public Builder failed(@Nullable Output<Integer> failed) {
            $.failed = failed;
            return this;
        }

        /**
         * @param failed The number of pods which reached phase Failed.
         * 
         * @return builder
         * 
         */
        public Builder failed(Integer failed) {
            return failed(Output.of(failed));
        }

        /**
         * @param ready The number of pods which have a Ready condition.
         * 
         * This field is beta-level. The job controller populates the field when the feature gate JobReadyPods is enabled (enabled by default).
         * 
         * @return builder
         * 
         */
        public Builder ready(@Nullable Output<Integer> ready) {
            $.ready = ready;
            return this;
        }

        /**
         * @param ready The number of pods which have a Ready condition.
         * 
         * This field is beta-level. The job controller populates the field when the feature gate JobReadyPods is enabled (enabled by default).
         * 
         * @return builder
         * 
         */
        public Builder ready(Integer ready) {
            return ready(Output.of(ready));
        }

        /**
         * @param startTime Represents time when the job controller started processing a job. When a Job is created in the suspended state, this field is not set until the first time it is resumed. This field is reset every time a Job is resumed from suspension. It is represented in RFC3339 form and is in UTC.
         * 
         * @return builder
         * 
         */
        public Builder startTime(@Nullable Output<String> startTime) {
            $.startTime = startTime;
            return this;
        }

        /**
         * @param startTime Represents time when the job controller started processing a job. When a Job is created in the suspended state, this field is not set until the first time it is resumed. This field is reset every time a Job is resumed from suspension. It is represented in RFC3339 form and is in UTC.
         * 
         * @return builder
         * 
         */
        public Builder startTime(String startTime) {
            return startTime(Output.of(startTime));
        }

        /**
         * @param succeeded The number of pods which reached phase Succeeded.
         * 
         * @return builder
         * 
         */
        public Builder succeeded(@Nullable Output<Integer> succeeded) {
            $.succeeded = succeeded;
            return this;
        }

        /**
         * @param succeeded The number of pods which reached phase Succeeded.
         * 
         * @return builder
         * 
         */
        public Builder succeeded(Integer succeeded) {
            return succeeded(Output.of(succeeded));
        }

        /**
         * @param uncountedTerminatedPods UncountedTerminatedPods holds the UIDs of Pods that have terminated but the job controller hasn&#39;t yet accounted for in the status counters.
         * 
         * The job controller creates pods with a finalizer. When a pod terminates (succeeded or failed), the controller does three steps to account for it in the job status: (1) Add the pod UID to the arrays in this field. (2) Remove the pod finalizer. (3) Remove the pod UID from the arrays while increasing the corresponding
         *     counter.
         * 
         * Old jobs might not be tracked using this field, in which case the field remains null.
         * 
         * @return builder
         * 
         */
        public Builder uncountedTerminatedPods(@Nullable Output<UncountedTerminatedPodsArgs> uncountedTerminatedPods) {
            $.uncountedTerminatedPods = uncountedTerminatedPods;
            return this;
        }

        /**
         * @param uncountedTerminatedPods UncountedTerminatedPods holds the UIDs of Pods that have terminated but the job controller hasn&#39;t yet accounted for in the status counters.
         * 
         * The job controller creates pods with a finalizer. When a pod terminates (succeeded or failed), the controller does three steps to account for it in the job status: (1) Add the pod UID to the arrays in this field. (2) Remove the pod finalizer. (3) Remove the pod UID from the arrays while increasing the corresponding
         *     counter.
         * 
         * Old jobs might not be tracked using this field, in which case the field remains null.
         * 
         * @return builder
         * 
         */
        public Builder uncountedTerminatedPods(UncountedTerminatedPodsArgs uncountedTerminatedPods) {
            return uncountedTerminatedPods(Output.of(uncountedTerminatedPods));
        }

        public JobStatusArgs build() {
            return $;
        }
    }

}
