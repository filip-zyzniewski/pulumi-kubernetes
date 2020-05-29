// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.AuditRegistraion.V1Alpha1
{

    [OutputType]
    public sealed class ServiceReference
    {
        /// <summary>
        /// `name` is the name of the service. Required
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// `namespace` is the namespace of the service. Required
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// `path` is an optional URL path which will be sent in any request to this service.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// If specified, the port on the service that hosting webhook. Default to 443 for backward compatibility. `port` should be a valid port number (1-65535, inclusive).
        /// </summary>
        public readonly int Port;

        [OutputConstructor]
        private ServiceReference(
            string name,

            string @namespace,

            string path,

            int port)
        {
            Name = name;
            Namespace = @namespace;
            Path = path;
            Port = port;
        }
    }
}
