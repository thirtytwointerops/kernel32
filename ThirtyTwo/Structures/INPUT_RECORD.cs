using System.Runtime.InteropServices;
using System;
using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
    /// <summary>
    /// Describes an input event in the console input buffer. These records can be read from
    /// the input buffer by using the "ReadConsoleInput" or "PeekConsoleInput" function, or
    /// written to the input buffer by using the "WriteConsoleInput" function.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct INPUT_RECORD : IEquatable<INPUT_RECORD>
    {
        #region Public Members

        /// <summary>
        /// A handle to the type of input event and the event record stored in the "Event"
        /// member. This member can be defined by one of the values ​​of the
        /// "INPUT_RECORD_EVENT_TYPE" enumeration.
        /// </summary>
        [FieldOffset(0)]
        public INPUT_RECORD_EVENT_TYPE EventType;

        /// <summary>
        /// Describes a keyboard input event.
        /// </summary>
        [FieldOffset(1)]
        public KEY_EVENT_RECORD KeyEvent;

        /// <summary>
        /// Describes a mouse input event.
        /// </summary>
        [FieldOffset(1)]
        public MOUSE_EVENT_RECORD MouseEvent;

        /// <summary>
        /// Describes a change in the size of the console screen buffer.
        /// </summary>
        [FieldOffset(1)]
        public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

        /// <summary>
        /// Describes a menu event;
        /// </summary>
        [FieldOffset(1)]
        public MENU_EVENT_RECORD MenuEvent;

        /// <summary>
        /// Describes a focus event.
        /// </summary>
        [FieldOffset(1)]
        public FOCUS_EVENT_RECORD FocusEvent;

        #endregion

        // @

        #region Logical Operator: Comparison (Equals) => bool

        /// <inheritdoc />
        public static bool operator ==(
            INPUT_RECORD firstStructure,
            INPUT_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return
                firstStructure.EventType == secondStructure.EventType &&
                firstStructure.KeyEvent == secondStructure.KeyEvent &&
                firstStructure.MouseEvent == secondStructure.MouseEvent &&
                firstStructure.WindowBufferSizeEvent == secondStructure.WindowBufferSizeEvent &&
                firstStructure.MenuEvent == secondStructure.MenuEvent &&
                firstStructure.FocusEvent == secondStructure.FocusEvent
            ;
        }

        #endregion

        // @

        #region Logical Operator: Comparison (Different) => bool

        /// <inheritdoc />
        public static bool operator !=(
            INPUT_RECORD firstStructure,
            INPUT_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return
                firstStructure.EventType != secondStructure.EventType ||
                firstStructure.KeyEvent != secondStructure.KeyEvent ||
                firstStructure.MouseEvent != secondStructure.MouseEvent ||
                firstStructure.WindowBufferSizeEvent != secondStructure.WindowBufferSizeEvent ||
                firstStructure.MenuEvent != secondStructure.MenuEvent ||
                firstStructure.FocusEvent != secondStructure.FocusEvent
            ;
        }

        #endregion

        // @

        #region Equals => bool

        /// <inheritdoc />
        public bool Equals(INPUT_RECORD other)
        {
            return this == other;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is INPUT_RECORD rECORD)
            {
                return this == rECORD;
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
                $"EventType: {EventType}, " +
                $"KeyEvent: {KeyEvent}, " +
                $"MouseEvent: {MouseEvent}, " +
                $"WindowBufferSizeEvent: {WindowBufferSizeEvent}, " +
                $"MenuEvent: {MenuEvent}, " +
                $"FocusEvent: {FocusEvent} " +
                @"}";
        }

        #endregion

        // @

        #region GetHashCode => int

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return EventType.GetHashCode() ^
                KeyEvent.GetHashCode() ^
                MouseEvent.GetHashCode() ^
                WindowBufferSizeEvent.GetHashCode() ^
                MenuEvent.GetHashCode() ^
                FocusEvent.GetHashCode();
        }

        #endregion
    }
}
