// Copyright (c) 2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: see LICENSE for more details.

namespace System.Reflection
{
    using System;

    /// <summary>
    /// A exception that is raised when the symbols to an
    /// assembly cannot be loaded from a zip file.
    /// </summary>
    public class ZipSymbolsLoadException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipSymbolsLoadException"/> class.
        /// A exception that is raised when the symbols to an
        /// assembly cannot be loaded from a zip file.
        /// </summary>
        public ZipSymbolsLoadException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipSymbolsLoadException"/> class.
        /// A exception that is raised when the symbols to an
        /// assembly cannot be loaded from a zip file.
        /// </summary>
        /// <param name="str">String</param>
        public ZipSymbolsLoadException(string str)
            : base(str)
        {
        }
    }
}
