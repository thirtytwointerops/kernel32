using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies the console reading behavior.
    /// </summary>
    [Flags]
    public enum CONSOLE_READING_BEHAVIOR : ushort
    {
        /// <summary>
        /// Leave the events in the input buffer (as in "PeekConsoleInput").
        /// </summary>
        CONSOLE_READ_NOREMOVE = 0x0001,

        /// <summary>
        /// Return immediately, even if there are no events in the input buffer.
        /// </summary>
        CONSOLE_READ_NOWAIT = 0x0002,
    }
}
