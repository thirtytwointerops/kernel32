namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies the default console device.
  /// </summary>
  [System.Flags]
  public enum ConsoleStandardDevice : int
  {
    /// <summary>
    /// The standard input device. Initially, this is the console input buffer.
    /// </summary>
    InputHandle = -10,

    /// <summary>
    /// The standard output device. Initially, this is the active console screen buffer.
    /// </summary>
    OutputHandle = -11,

    /// <summary>
    /// The standard error device. Initially, this is the active console screen buffer.
    /// </summary>
    ErrorHandle = -12,
  }
}
