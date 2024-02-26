namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies mouse events.
  /// </summary>
  [System.Flags]
  public enum MouseEvent : uint
  {
    /// <summary>
    /// The second click (button press) of a double-click occurred. The first click is
    /// returned as a regular button-press event.
    /// </summary>
    DoubleClick = 0x0002,

    /// <summary>
    /// The horizontal mouse wheel was moved. If the high word of the dwButtonState member
    /// contains a positive value, the wheel was rotated to the right. Otherwise, the
    /// wheel was rotated to the left.
    /// </summary>
    HorizontalWheeled = 0x0008,

    /// <summary>
    /// A change in mouse position occurred.
    /// </summary>
    Moved = 0x0001,

    /// <summary>
    /// The vertical mouse wheel was moved. If the high word of the "dwButtonState" member
    /// contains a positive value, the wheel was rotated forward, away from the user.
    /// Otherwise, the wheel was rotated backward, toward the user.
    /// </summary>
    VerticalWheeled = 0x0004,
  }
}
