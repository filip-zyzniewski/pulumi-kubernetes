// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    /// <summary>
    /// Represents a Fibre Channel volume. Fibre Channel volumes can only be mounted as read/write once. Fibre Channel volumes support ownership management and SELinux relabeling.
    /// </summary>
    public class FCVolumeSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// Optional: FC target lun number
        /// </summary>
        [Input("lun")]
        public Input<int>? Lun { get; set; }

        /// <summary>
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("targetWWNs")]
        private InputList<string>? _targetWWNs;

        /// <summary>
        /// Optional: FC target worldwide names (WWNs)
        /// </summary>
        public InputList<string> TargetWWNs
        {
            get => _targetWWNs ?? (_targetWWNs = new InputList<string>());
            set => _targetWWNs = value;
        }

        [Input("wwids")]
        private InputList<string>? _wwids;

        /// <summary>
        /// Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.
        /// </summary>
        public InputList<string> Wwids
        {
            get => _wwids ?? (_wwids = new InputList<string>());
            set => _wwids = value;
        }

        public FCVolumeSourceArgs()
        {
        }
    }
}
