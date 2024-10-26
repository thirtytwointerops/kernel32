using System.Runtime.InteropServices;
using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleScreenBufferInformationExtended :
      IEquatable<ConsoleScreenBufferInformationExtended>
  {
    #region Public Members

    public static uint cbSize = (uint)Marshal.SizeOf(
      typeof(ConsoleScreenBufferInformationExtended)
    );

    public Coordinate dwSize;
    public Coordinate dwCursorPosition;
    public CharacterAttributes wAttributes;
    public SmallRectangle srWindow;
    public Coordinate dwMaximumWindowSize;
    public ushort wPopupAttributes;
    public bool bFullscreenSupported;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public uint[] ColorTable;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      ConsoleScreenBufferInformationExtended firstStructure,
      ConsoleScreenBufferInformationExtended secondStructure
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
        firstStructure.dwMaximumWindowSize == secondStructure.dwMaximumWindowSize &&
        firstStructure.wPopupAttributes == secondStructure.wPopupAttributes &&
        firstStructure.bFullscreenSupported == secondStructure.bFullscreenSupported &&
        firstStructure.ColorTable == secondStructure.ColorTable
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      ConsoleScreenBufferInformationExtended firstStructure,
      ConsoleScreenBufferInformationExtended secondStructure
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
        firstStructure.dwMaximumWindowSize != secondStructure.dwMaximumWindowSize ||
        firstStructure.wPopupAttributes != secondStructure.wPopupAttributes ||
        firstStructure.bFullscreenSupported != secondStructure.bFullscreenSupported ||
        firstStructure.ColorTable != secondStructure.ColorTable
      );
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(ConsoleScreenBufferInformationExtended other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is ConsoleScreenBufferInformationExtended consoleScreenBufferInfoEx)
      {
        return this == consoleScreenBufferInfoEx;
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
        $"cbSize: {cbSize}, " +
        $"dwSize: {dwSize}, " +
        $"dwCursorPosition: {dwCursorPosition}, " +
        $"wAttributes: {wAttributes}, " +
        $"srWindow: {srWindow}, " +
        $"dwMaximumWindowSize: {dwMaximumWindowSize}, " +
        $"wPopupAttributes: {wPopupAttributes}, " +
        $"bFullscreenSupported: {bFullscreenSupported}, " +
        $"ColorTable: {ColorTable} " +
        @"}";
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return
        cbSize.GetHashCode() ^
        dwSize.GetHashCode() ^
        dwCursorPosition.GetHashCode() ^
        wAttributes.GetHashCode() ^
        srWindow.GetHashCode() ^
        dwMaximumWindowSize.GetHashCode() ^
        wPopupAttributes.GetHashCode() ^
        bFullscreenSupported.GetHashCode() ^
        ColorTable.GetHashCode()
      ;
    }

    #endregion
  }
}
