namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies the console reading behavior.
  /// </summary>
  [System.Flags]
  public enum ConsoleReadingBehavior : ushort
  {
    /// <summary>
    /// Leave the events in the input buffer (as in "PeekConsoleInput").
    /// </summary>
    NoRemove = 0x0001,

    /// <summary>
    /// Return immediately, even if there are no events in the input buffer.
    /// </summary>
    NoWait = 0x0002,
  }
}
