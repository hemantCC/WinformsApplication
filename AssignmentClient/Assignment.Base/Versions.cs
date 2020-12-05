using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Base
{
    public static class Versions
    {
        /// <summary>
        /// The AssemblyFileVersion of the application source tree
        /// MINOR version when you add functionality in a backwards compatible manner.
        /// </summary>
        public const string MinorVersion = "2";

        /// <summary>
        /// The AssemblyFileVersion of the application source tree.
        /// MAJOR version when you make incompatible API changes.
        /// </summary>
        public const string MajorVersion = "1";

        /// <summary>
        /// The AssemblyFileVersion of the application source tree.
        /// PATCH version when you make backwards compatible bug fixes.
        /// </summary>
        public const string PatchVersion = "003";
    }
}
