namespace ThirtyTwo.Kernel32.Enumerations
{
  [System.Flags]
  public enum ShareMode : long
  {
    Read = 0x00000001,
    Write = 0x00000002,
  }
}
