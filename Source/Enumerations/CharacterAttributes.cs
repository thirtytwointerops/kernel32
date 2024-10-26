namespace ThirtyTwo.Kernel32.Enumerations
{
  [Flags]
  public enum CharacterAttributes : ushort
  {
    ForegroundBlue = 0x0001,
    ForegroundGreen = 0x0002,
    ForegroundRed = 0x0004,
    ForegroundIntensity = 0x0008,

    // @

    BackgroundBlue = 0x0010,
    BackgroundGreen = 0x0020,
    BackgroundRed = 0x0040,
    BackgroundIntensity = 0x0080,

    // @

    CommonLVBLeadingByte = 0x0100,
    CommonLVBTrailingByte = 0x0200,

    // @

    CommonGridHorizontal = 0x0400,
    CommonGridLeftVertical = 0x0800,
    CommonGridRightVertical = 0x1000,

    // @

    CommonLVBReverseVideo = 0x4000,
    CommonLVBUnderscore = 0x8000,
  }
}
