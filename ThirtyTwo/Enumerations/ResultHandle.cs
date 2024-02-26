namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// A 32-bit value that is used to describe an error or warning.
  /// </summary>
  [System.Flags]
  public enum ResultHandle : uint
  {
    /// <summary>
    /// Operation successful.
    /// </summary>
    Ok = 0x00000000,

    /// <summary>
    /// Operation aborted.
    /// </summary>
    Abort = 0x80004004,

    /// <summary>
    /// General access denied error.
    /// </summary>
    AccessDenied = 0x80070005,

    /// <summary>
    /// Unspecified failure.
    /// </summary>
    Fail = 0x80004005,

    /// <summary>
    /// Handle that is not valid.
    /// </summary>
    Handle = 0x80070006,

    /// <summary>
    /// One or more arguments are not valid.
    /// </summary>
    InvalidArgument = 0x80070057,

    /// <summary>
    /// No such interface supported.
    /// </summary>
    NoInterface = 0x80004002,

    /// <summary>
    /// Not implemented.
    /// </summary>
    NotImplemented = 0x80004001,

    /// <summary>
    /// Failed to allocate necessary memory.
    /// </summary>
    OutOfMemory = 0x8007000E,

    /// <summary>
    /// Pointer that is not valid.
    /// </summary>
    Pointer = 0x80004003,

    /// <summary>
    /// Unexpected failure.
    /// </summary>
    Unexpected = 0x8000FFFF,
  }
}
