// Copyright (c) 2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: see LICENSE for more details.

namespace System.Reflection
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
        /// <param name="str">The exception message to pass along</param>
        public ZipAssemblyLoadException(string str)
            : base(str)
        {
        }
    }
}
