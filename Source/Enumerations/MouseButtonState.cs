namespace ThirtyTwo.Kernel32.Enumerations
{
  [System.Flags]
  public enum MouseButtonState : uint
  {
    FromLeft1stButtonPressed = 0x0001,
    FromLeft2ndButtonPressed = 0x0004,
    FromLeft3rdButtonPressed = 0x0008,
    FromLeft4thButtonPressed = 0x0010,
    RightmostButtonPressed = 0x0002,
  }
}
