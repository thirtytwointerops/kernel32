using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies the access rights for a security descriptor.
    /// </summary>
    [Flags]
    public enum ACCESS_RIGHTS : long
    {
        /// <summary>
        /// Requests read access to the console screen buffer, enabling the process to read
        /// data from the buffer.
        /// </summary>
        GENERIC_READ = 0x80000000L,

        /// <summary>
        /// Requests write access to the console screen buffer, enabling the process to write
        /// data to the buffer.
        /// </summary>
        GENERIC_WRITE = 0x40000000L,
    }
}
