﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuroSpeech
{
    public class PackageInstallerOptions
    {

        /// <summary>
        /// If set, starts the Node.js instance with the specified environment variables.
        /// </summary>
        public IDictionary<string,string> EnvironmentVariables { get; set; }

        /// <summary>
        /// Folder where node packages will be downloaded
        /// </summary>
        public string TempFolder { get; set; } = "d:\\temp\\ns-npm";


        /// <summary>
        /// NPM Registry used to download packages
        /// </summary>
        public string NPMRegistry { get; set; }


        /// <summary>
        /// White list of packages to execute
        /// </summary>
        public string[] PrivatePackages { get; set; }

        /// <summary>
        /// Time to live, after which NodeServer will dispose
        /// </summary>
        public TimeSpan TTL { get; set; } = TimeSpan.FromHours(1);

        /// <summary>
        /// Useful for single npm cache folder, default is true
        /// </summary>
        public bool UseFileLock { get; set; } = true;
    }
}
