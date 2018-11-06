// Copyright (c) 2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: see LICENSE for more details.

namespace System.Reflection
{
    using System.Diagnostics;
    using System.IO;
    using System.IO.Compression;

    /// <summary>
    /// Load assemblies from a zip file.
    /// </summary>
    public sealed class ZipAssembly : Assembly
    {
        // always set to Zip file full path + \\ + file path in zip.
        private string locationValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipAssembly"/> class.
        /// Load assemblies from a zip file.
        /// </summary>
        public ZipAssembly()
        {
        }

        /// <summary>
        /// Gets the Assembly associated with this ZipAssembly instance.
        /// </summary>
        public Assembly Assembly { get; private set; }

        // hopefully this has the path to the assembly on System.Reflection.Assembly.Location output with the value from this override.

        /// <summary>
        /// Gets the location of the assembly in the zip file.
        /// </summary>
        public override string Location => locationValue;

        /// <summary>
        /// Loads the assembly from the specified zip file.
        /// </summary>
        /// <param name="zipFileName">zipFileName</param>
        /// <param name="assemblyName">assemplyName</param>
        /// <returns>ZipAssembly</returns>
        public static ZipAssembly LoadFromZip(string zipFileName, string assemblyName) => LoadFromZip(zipFileName, assemblyName, false);

        /// <summary>
        /// Loads the assembly with it’s debugging symbols
        /// from the specified zip file.
        /// </summary>
        /// <param name="zipFileName">zipFileName</param>
        /// <param name="assemblyName">assemplyName</param>
        /// <param name="loadPDBFile">loadPDBFile</param>
        /// <returns>ZipAssembly</returns>
        public static ZipAssembly LoadFromZip(string zipFileName, string assemblyName, bool loadPDBFile)
        {
            // check if the assembly is in the zip file.
            // If it is, get it’s bytes then load it.
            // If not throw an exception. Also throw
            // an exception if the pdb file is not found.
            bool found = false;
            bool pdbfound = false;
            byte[] asmbytes = null;
            byte[] pdbbytes = null;
            string pdbFileName = assemblyName.Replace("dll", "pdb");
            ZipArchive zipFile = ZipFile.OpenRead(zipFileName);
            foreach (ZipArchiveEntry entry in zipFile.Entries)
            {
                if (entry.FullName.Equals(assemblyName))
                {
                    found = true;
                    Stream strm = entry.Open();
                    MemoryStream ms = new MemoryStream();
                    strm.CopyTo(ms);
                    asmbytes = ms.ToArray();
                    ms.Dispose();
                    strm.Dispose();
                }
                else if (entry.FullName.Equals(pdbFileName))
                {
                    pdbfound = true;
                    Stream strm = entry.Open();
                    MemoryStream ms = new MemoryStream();
                    strm.CopyTo(ms);
                    pdbbytes = ms.ToArray();
                    ms.Dispose();
                    strm.Dispose();
                }
            }

            zipFile.Dispose();
            if (!found)
            {
                throw new ZipAssemblyLoadException(
                    "Assembly specified to load in ZipFile not found.");
            }

            if (!pdbfound)
            {
                throw new ZipSymbolsLoadException(
                    "pdb to Assembly specified to load in ZipFile not found.");
            }

            // always load pdb when debugging.
            // PDB should be automatically downloaded to zip file always
            // and really *should* always be present.
            bool loadPDB = loadPDBFile ? loadPDBFile : Debugger.IsAttached;
            ZipAssembly zipassembly = new ZipAssembly
            {
                locationValue = zipFileName + Path.DirectorySeparatorChar + assemblyName,
                Assembly = loadPDB ? Assembly.Load(asmbytes, pdbbytes) : Assembly.Load(asmbytes),
            };
            return zipassembly;
        }
    }
}
