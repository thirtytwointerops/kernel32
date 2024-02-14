using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
    /// <summary>
    /// Contains information about a console screen buffer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_SCREEN_BUFFER_INFO : IEquatable<CONSOLE_SCREEN_BUFFER_INFO>
    {
        #region Public Members

        /// <summary>
        /// A "COORD" structure that contains the size of the console screen buffer, in
        /// character columns and rows.
        /// </summary>
        public COORD dwSize;

        /// <summary>
        /// A "COORD" structure that contains the column and row coordinates of the cursor
        /// in the console screen buffer.
        /// </summary>
        public COORD dwCursorPosition;

        /// <summary>
        /// The attributes of the characters written to a screen buffer by the "WriteFile"
        /// and "WriteConsole" functions, or echoed to a screen buffer by the "ReadFile" and
        /// "ReadConsole" functions. This member can be zero or a combination of values ​​from
        /// the "CHAR_ATTRIBUTES" enumeration.
        /// </summary>
        public CHAR_ATTRIBUTES wAttributes;

        /// <summary>
        /// A "SMALL_RECT" structure that contains the console screen buffer coordinates of
        /// the upper-left and lower-right corners of the display window.
        /// </summary>
        public SMALL_RECT srWindow;

        /// <summary>
        /// A "COORD" structure that contains the maximum size of the console window, in
        /// character columns and rows, given the current screen buffer size and font and
        /// the screen size.
        /// </summary>
        public COORD dwMaximumWindowSize;

        #endregion

        // @

        #region Logical Operator: Comparison (Equals) => bool

        /// <inheritdoc />
        public static bool operator ==(
            CONSOLE_SCREEN_BUFFER_INFO firstStructure,
            CONSOLE_SCREEN_BUFFER_INFO secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return (
                firstStructure.dwSize == secondStructure.dwSize &&
                firstStructure.dwCursorPosition == secondStructure.dwCursorPosition &&
                firstStructure.wAttributes == secondStructure.wAttributes &&
                firstStructure.srWindow == secondStructure.srWindow &&
                firstStructure.dwMaximumWindowSize == secondStructure.dwMaximumWindowSize
            );
        }

        #endregion

        // @

        #region Logical Operator: Comparison (Different) => bool

        /// <inheritdoc />
        public static bool operator !=(
            CONSOLE_SCREEN_BUFFER_INFO firstStructure,
            CONSOLE_SCREEN_BUFFER_INFO secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return (
                firstStructure.dwSize != secondStructure.dwSize ||
                firstStructure.dwCursorPosition != secondStructure.dwCursorPosition ||
                firstStructure.wAttributes != secondStructure.wAttributes ||
                firstStructure.srWindow != secondStructure.srWindow ||
                firstStructure.dwMaximumWindowSize != secondStructure.dwMaximumWindowSize
            );
        }

        #endregion

        // @

        #region Equals => bool

        /// <inheritdoc />
        public bool Equals(CONSOLE_SCREEN_BUFFER_INFO other)
        {
            return this == other;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is CONSOLE_SCREEN_BUFFER_INFO iNFO)
            {
                return this == iNFO;
            }

            return base.Equals(obj);
        }

        #endregion

        // @

        #region To String => string

        /// <inheritdoc />
        public override string ToString()
        {
            return
                @"{ " +
                $"dwSize: {dwSize}, " +
                $"dwCursorPosition: {dwCursorPosition}, " +
                $"wAttributes: {wAttributes}, " +
                $"srWindow: {srWindow}, " +
                $"dwMaximumWindowSize: {dwMaximumWindowSize} " +
                @"}";
        }

        #endregion

        // @

        #region GetHashCode => int

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return dwSize.GetHashCode() ^
                dwCursorPosition.GetHashCode() ^
                wAttributes.GetHashCode() ^
                srWindow.GetHashCode() ^
                dwMaximumWindowSize.GetHashCode();
        }

        #endregion
    }
}
