namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies options for creating a pseudo console.
  /// </summary>
  [System.Flags]
  public enum PseudoConsoleCreationOption : uint
  {
    /// <summary>
    /// Perform a standard pseudo console creation.
    /// </summary>
    Standard = 0,

    /// <summary>
    /// The created pseudo console session will attempt to inherit the cursor position
    /// of the parent console.
    /// </summary>
    InheritCursor = 1,
  }
}
