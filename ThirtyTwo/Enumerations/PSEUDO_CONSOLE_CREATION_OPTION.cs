using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies options for creating a pseudo console.
    /// </summary>
    [Flags]
    public enum PSEUDO_CONSOLE_CREATION_OPTION : uint
    {
        /// <summary>
        /// Perform a standard pseudo console creation.
        /// </summary>
        PSEUDOCONSOLE_STANDARD = 0,

        /// <summary>
        /// The created pseudo console session will attempt to inherit the cursor position
        /// of the parent console.
        /// </summary>
        PSEUDOCONSOLE_INHERIT_CURSOR = 1,
    }
}
