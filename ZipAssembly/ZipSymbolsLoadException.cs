// Copyright (c) 2018-2019, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: see LICENSE for more details.

namespace Elskom.Generic.Libs
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipSymbolsLoadException"/> class.
        /// A exception that is raised when the symbols to an
        /// assembly cannot be loaded from a zip file.
        /// </summary>
        /// <param name="message">String.</param>
        /// <param name="innerException">Inner exception.</param>
        public ZipSymbolsLoadException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
