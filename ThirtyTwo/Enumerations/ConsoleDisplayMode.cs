namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies the console display mode.
  /// </summary>
  [System.Flags]
  public enum ConsoleDisplayMode : uint
  {
    /// <summary>
    /// Full-screen console. The console is in this mode as soon as the window is maximized.
    /// At this point, the transition to full-screen mode can still fail.
    /// </summary>
    FullScreen = 1,

    /// <summary>
    /// Full-screen console communicating directly with the video hardware. This mode is set
    /// after the console is in "FullScreen" mode to indicate that the transition to
    /// full-screen mode has completed
    /// </summary>
    FullScreenHardware = 2,

    /// <summary>
    /// Text is displayed in a console window.
    /// </summary>
    Windowed = 2,
  }
}
