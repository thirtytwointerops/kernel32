namespace ThirtyTwo.Kernel32.Enumerations
{
  [System.Flags]
  public enum ConsoleMode : uint
  {
    EnableEchoInput = 0x0004,
    EnableInsertMode = 0x0020,
    EnableLineInput = 0x0002,
    EnableMouseInput = 0x0010,
    EnableProcessedInput = 0x0001,
    EnableQuickEditMode = 0x0040,
    EnableExtendedFlags = 0x0080,
    EnableWindowInput = 0x0008,
    EnableVirtualTerminalInput = 0x0200,

    // @

    EnableProcessedOutput = 0x0001,
    EnableWrapAtEOLOutput = 0x0002,
    EnableVirtualTerminalProcessing = 0x0004,
    DisableNewLineAutoReturn = 0x0008,
    EnableLVBGridWorldWide = 0x0010,
  }
}
