using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies the default console device.
    /// </summary>
    [Flags]
    public enum CONSOLE_STANDARD_DEVICE : int
    {
        /// <summary>
        /// The standard input device. Initially, this is the console input buffer.
        /// </summary>
        STD_INPUT_HANDLE = -10,

        /// <summary>
        /// The standard output device. Initially, this is the active console screen buffer.
        /// </summary>
        STD_OUTPUT_HANDLE = -11,

        /// <summary>
        /// The standard error device. Initially, this is the active console screen buffer.
        /// </summary>
        STD_ERROR_HANDLE = -12,
    }
}
