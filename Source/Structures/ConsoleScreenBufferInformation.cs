using System.Runtime.InteropServices;
using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleScreenBufferInformation :
      IEquatable<ConsoleScreenBufferInformation>
  {
    #region Public Members

    public Coordinate dwSize;
    public Coordinate dwCursorPosition;
    public CharacterAttributes wAttributes;
    public SmallRectangle srWindow;
    public Coordinate dwMaximumWindowSize;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      ConsoleScreenBufferInformation firstStructure,
      ConsoleScreenBufferInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.dwSize == secondStructure.dwSize &&
        firstStructure.dwCursorPosition == secondStructure.dwCursorPosition &&
        firstStructure.wAttributes == secondStructure.wAttributes &&
        firstStructure.srWindow == secondStructure.srWindow &&
        firstStructure.dwMaximumWindowSize == secondStructure.dwMaximumWindowSize
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      ConsoleScreenBufferInformation firstStructure,
      ConsoleScreenBufferInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return (
        firstStructure.dwSize != secondStructure.dwSize ||
        firstStructure.dwCursorPosition != secondStructure.dwCursorPosition ||
        firstStructure.wAttributes != secondStructure.wAttributes ||
        firstStructure.srWindow != secondStructure.srWindow ||
        firstStructure.dwMaximumWindowSize != secondStructure.dwMaximumWindowSize
      );
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(ConsoleScreenBufferInformation other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is ConsoleScreenBufferInformation consoleScreenBufferInfo)
      {
        return this == consoleScreenBufferInfo;
      }

      return base.Equals(obj);
    }

    #endregion

    // @

    #region To String => string

    public override string ToString()
    {
      return
        @"{ " +
        $"dwSize: {dwSize}, " +
        $"dwCursorPosition: {dwCursorPosition}, " +
        $"wAttributes: {wAttributes}, " +
        $"srWindow: {srWindow}, " +
        $"dwMaximumWindowSize: {dwMaximumWindowSize} " +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return
        dwSize.GetHashCode() ^
        dwCursorPosition.GetHashCode() ^
        wAttributes.GetHashCode() ^
        srWindow.GetHashCode() ^
        dwMaximumWindowSize.GetHashCode()
      ;
    }

    #endregion
  }
}
