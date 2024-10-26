namespace ThirtyTwo.Kernel32.Enumerations
{
  [Flags]
  public enum ResultHandle : uint
  {
    Ok = 0x00000000,
    Abort = 0x80004004,
    AccessDenied = 0x80070005,
    Fail = 0x80004005,
    Handle = 0x80070006,
    InvalidArgument = 0x80070057,
    NoInterface = 0x80004002,
    NotImplemented = 0x80004001,
    OutOfMemory = 0x8007000E,
    Pointer = 0x80004003,
    Unexpected = 0x8000FFFF,
  }
}
