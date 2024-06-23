namespace ThirtyTwo.Kernel32.Enumerations
{
  [System.Flags]
  public enum MouseEvent : uint
  {
    DoubleClick = 0x0002,
    HorizontalWheeled = 0x0008,
    Moved = 0x0001,
    VerticalWheeled = 0x0004,
  }
}
