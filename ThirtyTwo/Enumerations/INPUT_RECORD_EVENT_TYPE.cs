namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies the event type of the console input record.
    /// </summary>
    public enum INPUT_RECORD_EVENT_TYPE: ushort
    {
        /// <summary>
        /// The Event member contains a "FOCUS_EVENT_RECORD" structure. These events are used
        /// internally and should be ignored.
        /// </summary>
        FOCUS_EVENT = 0x0010,

        /// <summary>
        /// The Event member contains a "KEY_EVENT_RECORD" structure with information about a
        /// keyboard event.
        /// </summary>
        KEY_EVENT = 0x0001,

        /// <summary>
        /// The Event member contains a "MENU_EVENT_RECORD" structure. These events are used
        /// internally and should be ignored.
        /// </summary>
        MENU_EVENT = 0x0008,

        /// <summary>
        /// The Event member contains a "MOUSE_EVENT_RECORD" structure with information about a
        /// mouse movement or button press event.
        /// </summary>
        MOUSE_EVENT = 0x0002,

        /// <summary>
        /// The Event member contains a "WINDOW_BUFFER_SIZE_RECORD" structure with information
        /// about the new size of the console screen buffer.
        /// </summary>
        WINDOW_BUFFER_SIZE_EVENT = 0x0004,
    }
}
