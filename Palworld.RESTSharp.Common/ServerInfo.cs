﻿using Newtonsoft.Json;

namespace Palworld.RESTSharp.Common
{
    /// <summary>
    /// Information about the Palworld server including name, version, and description of the server.
    /// </summary>
    public class ServerInfo
    {
        /// <summary>
        /// Version of the server build.
        /// </summary>
        [JsonProperty("version")]
        public string version { get; set; }
        /// <summary>
        /// Name of the server
        /// </summary>
        [JsonProperty("servername")]
        public string serverName { get; set; }
        /// <summary>
        /// Description of the server.
        /// </summary>
        [JsonProperty("description")]
        public string description { get; set; }

        /// <summary>
        /// Returns the string representation of the server info.
        /// </summary>
        /// <returns>Server name, version, and description in a single line.</returns>
        public override string ToString() => $"[{serverName}][{version}][{description}]";
    }
}