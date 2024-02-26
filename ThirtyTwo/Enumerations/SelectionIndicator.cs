namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies console selection indicators.
  /// </summary>
  [System.Flags]
  public enum SelectionIndicator : uint
  {
    /// <summary>
    /// Mouse is down. The user is actively adjusting the selection rectangle with a mouse.
    /// </summary>
    MouseDown = 0x0008,

    /// <summary>
    /// Selecting with the mouse. If off, the user is operating conhost.exe mark mode
    /// selection with the keyboard.
    /// </summary>
    MouseSelection = 0x0004,

    /// <summary>
    /// No selection.
    /// </summary>
    NoSelection = 0x0000,

    /// <summary>
    /// Selection has begun. If a mouse selection, this will typically not occur without
    /// the "CONSOLE_SELECTION_NOT_EMPTY" flag. If a keyboard selection, this may occur
    /// when mark mode has been entered but the user is still navigating to the initial
    /// position.
    /// </summary>
    SelectionInProgress = 0x0001,

    /// <summary>
    /// Selection rectangle not empty. The payload of "dwSelectionAnchor" and
    /// "srSelection" are valid.
    /// </summary>
    SelectionNotEmpty = 0x0002,
  }
}
