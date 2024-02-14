using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies the window event messages emitted by the console.
    /// </summary>
    [Flags]
    public enum CONSOLE_WINDOW_EVENT : int
    {
        /// <summary>
        /// The console caret has moved. The "idObject" parameter is one or more of the
        /// following values: "CONSOLE_CARET_SELECTION" or "CONSOLE_CARET_VISIBLE". The
        /// "idChild" parameter is a "COORD" structure that specifies the cursor's current
        /// position.
        /// </summary>
        EVENT_CONSOLE_CARET = 0x4001,

        /// <summary>
        /// A console process has exited. The "idObject" parameter contains the process
        /// identifier of the terminated process.
        /// </summary>
        EVENT_CONSOLE_END_APPLICATION = 0x4007,

        /// <summary>
        /// The console layout has changed.
        /// </summary>
        EVENT_CONSOLE_LAYOUT = 0x4005,

        /// <summary>
        /// A new console process has started.The "idObject" parameter contains the process
        /// identifier of the newly created process.If the application is a 16-bit application,
        /// the "idChild" parameter is "CONSOLE_APPLICATION_16BIT" and "idObject" is the
        /// process identifier of the NTVDM session associated with the console.
        /// </summary>
        EVENT_CONSOLE_START_APPLICATION = 0x4006,

        /// <summary>
        /// More than one character has changed. The "idObject" parameter is a "COORD" structure
        /// that specifies the start of the changed region.The "idChild" parameter is a "COORD"
        /// structure that specifies the end of the changed region.
        /// </summary>
        EVENT_CONSOLE_UPDATE_REGION = 0x4002,

        /// <summary>
        /// The console has scrolled. The "idObject" parameter is the horizontal distance the
        /// console has scrolled. The "idChild" parameter is the vertical distance the console
        /// has scrolled.
        /// </summary>
        EVENT_CONSOLE_UPDATE_SCROLL = 0x4004,

        /// <summary>
        /// A single character has changed. The "idObject" parameter is a "COORD" structure that
        /// specifies the character that has changed. The "idChild" parameter specifies the
        /// character in the low word and the character attributes in the high word.
        /// </summary>
        EVENT_CONSOLE_UPDATE_SIMPLE = 0x4003,
    }
}
