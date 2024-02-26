namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies the sharing modes for a security descriptor.
  /// </summary>
  [System.Flags]
  public enum ShareMode : long
  {
    /// <summary>
    /// Other open operations can be performed on the console screen buffer for read access.
    /// </summary>
    Read = 0x00000001,

    /// <summary>
    /// Other open operations can be performed on the console screen buffer for write access.
    /// </summary>
    Write = 0x00000002,
  }
}
