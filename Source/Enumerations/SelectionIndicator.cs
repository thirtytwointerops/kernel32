namespace ThirtyTwo.Kernel32.Enumerations
{
  [Flags]
  public enum SelectionIndicator : uint
  {
    MouseDown = 0x0008,
    MouseSelection = 0x0004,
    NoSelection = 0x0000,
    SelectionInProgress = 0x0001,
    SelectionNotEmpty = 0x0002,
  }
}
