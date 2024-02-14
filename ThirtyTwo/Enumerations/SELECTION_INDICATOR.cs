using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies console selection indicators.
    /// </summary>
    [Flags]
    public enum SELECTION_INDICATOR : uint
    {
        /// <summary>
        /// Mouse is down. The user is actively adjusting the selection rectangle with a mouse.
        /// </summary>
        CONSOLE_MOUSE_DOWN = 0x0008,

        /// <summary>
        /// Selecting with the mouse. If off, the user is operating conhost.exe mark mode
        /// selection with the keyboard.
        /// </summary>
        CONSOLE_MOUSE_SELECTION = 0x0004,

        /// <summary>
        /// No selection.
        /// </summary>
        CONSOLE_NO_SELECTION = 0x0000,

        /// <summary>
        /// Selection has begun. If a mouse selection, this will typically not occur without
        /// the "CONSOLE_SELECTION_NOT_EMPTY" flag. If a keyboard selection, this may occur
        /// when mark mode has been entered but the user is still navigating to the initial
        /// position.
        /// </summary>
        CONSOLE_SELECTION_IN_PROGRESS = 0x0001,

        /// <summary>
        /// Selection rectangle not empty. The payload of "dwSelectionAnchor" and
        /// "srSelection" are valid.
        /// </summary>
        CONSOLE_SELECTION_NOT_EMPTY = 0x0002,
    }
}
