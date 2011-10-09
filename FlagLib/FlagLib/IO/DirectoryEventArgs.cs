﻿using System;
using System.IO;

namespace FlagLib.IO
{
    public class DirectoryEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the directorys that has been found.
        /// </summary>
        /// <value>
        /// The directory that has been found.
        /// </value>
        public DirectoryInfo Directory { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryEventArgs"/> class.
        /// </summary>
        /// <param name="directory">The found directory.</param>
        public DirectoryEventArgs(DirectoryInfo directory)
        {
            this.Directory = directory;
        }
    }
}