using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies the sharing modes for a security descriptor.
    /// </summary>
    [Flags]
    public enum SHARE_MODE : long
    {
        /// <summary>
        /// Other open operations can be performed on the console screen buffer for read access.
        /// </summary>
        FILE_SHARE_READ = 0x00000001,

        /// <summary>
        /// Other open operations can be performed on the console screen buffer for write access.
        /// </summary>
        FILE_SHARE_WRITE = 0x00000002,
    }
}
