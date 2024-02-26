namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies mouse button states.
  /// </summary>
  [System.Flags]
  public enum MouseButtonState : uint
  {
    /// <summary>
    /// The leftmost mouse button.
    /// </summary>
    FromLeft1stButtonPressed = 0x0001,

    /// <summary>
    /// The second button from the left.
    /// </summary>
    FromLeft2ndButtonPressed = 0x0004,

    /// <summary>
    /// The third button from the left.
    /// </summary>
    FromLeft3rdButtonPressed = 0x0008,

    /// <summary>
    /// The fourth button from the left.
    /// </summary>
    FromLeft4thButtonPressed = 0x0010,

    /// <summary>
    /// The rightmost mouse button.
    /// </summary>
    RightmostButtonPressed = 0x0002,
  }
}
