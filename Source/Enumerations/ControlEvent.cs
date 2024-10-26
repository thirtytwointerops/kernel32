namespace ThirtyTwo.Kernel32.Enumerations
{
  [Flags]
  public enum ControlEvent : uint
  {
    CtrlC = 0,
    CtrlBreak = 1,
    CtrlClose = 2,
    CtrlLogoff = 5,
    CtrlShutdown = 6,
  }
}
