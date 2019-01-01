// Copyright (c) 2018-2019, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: see LICENSE for more details.

namespace Elskom.Generic.Libs
{
    using System;

    /// <summary>
    /// A exception that is raised when the
    /// assembly cannot be loaded from a zip file.
    /// </summary>
    public class ZipAssemblyLoadException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipAssemblyLoadException"/> class.
        /// A exception that is raised when the
        /// assembly cannot be loaded from a zip file.
        /// </summary>
        public ZipAssemblyLoadException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipAssemblyLoadException"/> class.
        /// A exception that is raised when the
        /// assembly cannot be loaded from a zip file.
        /// </summary>
        /// <param name="str">String</param>
        public ZipAssemblyLoadException(string str)
            : base(str)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipAssemblyLoadException"/> class.
        /// A exception that is raised when the
        /// assembly cannot be loaded from a zip file.
        /// </summary>
        /// <param name="message">String.</param>
        /// <param name="innerException">Inner exception.</param>
        public ZipAssemblyLoadException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
