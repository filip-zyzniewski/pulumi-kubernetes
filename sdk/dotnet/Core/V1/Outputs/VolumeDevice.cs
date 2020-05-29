// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    [OutputType]
    public sealed class VolumeDevice
    {
        /// <summary>
        /// devicePath is the path inside of the container that the device will be mapped to.
        /// </summary>
        public readonly string DevicePath;
        /// <summary>
        /// name must match the name of a persistentVolumeClaim in the pod
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private VolumeDevice(
            string devicePath,

            string name)
        {
            DevicePath = devicePath;
            Name = name;
        }
    }
}
