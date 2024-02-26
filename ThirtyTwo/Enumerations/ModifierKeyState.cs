namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies the states of modifier keys.
  /// </summary>
  [System.Flags]
  public enum ModifierKeyState : uint
  {
    /// <summary>
    /// The CAPS LOCK light is on.
    /// </summary>
    CapsLockOn = 0x0080,

    /// <summary>
    /// The key is enhanced.
    /// </summary>
    EnhancedKey = 0x0100,

    /// <summary>
    /// The left "ALT" key is pressed.
    /// </summary>
    LeftAltPressed = 0x0002,

    /// <summary>
    /// The left "CTRL" key is pressed.
    /// </summary>
    LeftCtrlPressed = 0x0008,

    /// <summary>
    /// The "NUM LOCK" light is on.
    /// </summary>
    NumLockOn = 0x0020,

    /// <summary>
    /// The right "ALT" key is pressed.
    /// </summary>
    RightAltPressed = 0x0001,

    /// <summary>
    /// The right "CTRL" key is pressed.
    /// </summary>
    RightCtrlPressed = 0x0004,

    /// <summary>
    /// The "SCROLL LOCK" light is on.
    /// </summary>
    ScrollLockOn = 0x0040,

    /// <summary>
    /// The "SHIFT" key is pressed.
    /// </summary>
    ShiftPressed = 0x0010,
  }
}
