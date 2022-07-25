// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    /// <summary>
    /// Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.
    /// </summary>
    [OutputType]
    public sealed class CephFSVolumeSourcePatch
    {
        /// <summary>
        /// monitors is Required: Monitors is a collection of Ceph monitors More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        public readonly ImmutableArray<string> Monitors;
        /// <summary>
        /// path is Optional: Used as the mounted root, rather than the full Ceph tree, default is /
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// readOnly is Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// secretFile is Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        public readonly string SecretFile;
        /// <summary>
        /// secretRef is Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.LocalObjectReferencePatch SecretRef;
        /// <summary>
        /// user is optional: User is the rados user name, default is admin More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        public readonly string User;

        [OutputConstructor]
        private CephFSVolumeSourcePatch(
            ImmutableArray<string> monitors,

            string path,

            bool readOnly,

            string secretFile,

            Pulumi.Kubernetes.Types.Outputs.Core.V1.LocalObjectReferencePatch secretRef,

            string user)
        {
            Monitors = monitors;
            Path = path;
            ReadOnly = readOnly;
            SecretFile = secretFile;
            SecretRef = secretRef;
            User = user;
        }
    }
}