namespace ThirtyTwo.Kernel32.Enumerations
{
  [Flags]
  public enum ConsoleWindowEvent : int
  {
    Caret = 0x4001,
    EndApplication = 0x4007,
    Layout = 0x4005,
    StartApplication = 0x4006,
    UpdateRegion = 0x4002,
    UpdateScroll = 0x4004,
    UpdateSimple = 0x4003,
  }
}
