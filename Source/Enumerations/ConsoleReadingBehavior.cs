﻿namespace ThirtyTwo.Kernel32.Enumerations
{
  [Flags]
  public enum ConsoleReadingBehavior : ushort
  {
    NoRemove = 0x0001,
    NoWait = 0x0002,
  }
}
