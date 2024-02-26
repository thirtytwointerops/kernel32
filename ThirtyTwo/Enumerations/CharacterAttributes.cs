namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies the attributes of a given character. 
  /// </summary>
  [System.Flags]
  public enum CharacterAttributes : ushort
  {
    /// <summary>
    /// Text color contains blue.
    /// </summary>
    ForegroundBlue = 0x0001,

    /// <summary>
    /// Text color contains green.
    /// </summary>
    ForegroundGreen = 0x0002,

    /// <summary>
    /// Text color contains red.
    /// </summary>
    ForegroundRed = 0x0004,

    /// <summary>
    /// Text color is intensified.
    /// </summary>
    ForegroundIntensity = 0x0008,

    // *

    /// <summary>
    /// Background color contains blue.
    /// </summary>
    BackgroundBlue = 0x0010,

    /// <summary>
    /// Background color contains green.
    /// </summary>
    BackgroundGreen = 0x0020,

    /// <summary>
    /// Background color contains red.
    /// </summary>
    BackgroundRed = 0x0040,

    /// <summary>
    /// Background color is intensified.
    /// </summary>
    BackgroundIntensity = 0x0080,

    // *

    /// <summary>
    /// Leading byte.
    /// </summary>
    CommonLVBLeadingByte = 0x0100,

    /// <summary>
    /// Trailing byte.
    /// </summary>
    CommonLVBTrailingByte = 0x0200,

    // *

    /// <summary>
    /// Top horizontal.
    /// </summary>
    CommonGridHorizontal = 0x0400,

    /// <summary>
    /// Left vertical.
    /// </summary>
    CommonGridLeftVertical = 0x0800,

    /// <summary>
    /// Right vertical.
    /// </summary>
    CommonGridRightVertical = 0x1000,

    // *

    /// <summary>
    /// Reverse foreground an background attribute.
    /// </summary>
    CommonLVBReverseVideo = 0x4000,

    /// <summary>
    /// Underscore.
    /// </summary>
    CommonLVBUnderscore = 0x8000,
  }
}
