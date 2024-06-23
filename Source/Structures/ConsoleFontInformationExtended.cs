using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleFontInformationExtended :
      IEquatable<ConsoleFontInformationExtended>
  {
    #region Public Members

    public static uint cbSize = (uint)Marshal.SizeOf(
      typeof(ConsoleFontInformationExtended)
    );

    public uint nFont;
    public Coordinate dwFontSize;
    public uint FontFamily;
    public uint FontWeight;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string FaceName;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      ConsoleFontInformationExtended firstStructure,
      ConsoleFontInformationExtended secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.nFont == secondStructure.nFont &&
        firstStructure.dwFontSize == secondStructure.dwFontSize &&
        firstStructure.FontFamily == secondStructure.FontFamily &&
        firstStructure.FontWeight == secondStructure.FontWeight &&
        firstStructure.FaceName == secondStructure.FaceName
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      ConsoleFontInformationExtended firstStructure,
      ConsoleFontInformationExtended secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return (
        firstStructure.nFont != secondStructure.nFont ||
        firstStructure.dwFontSize != secondStructure.dwFontSize ||
        firstStructure.FontFamily != secondStructure.FontFamily ||
        firstStructure.FontWeight != secondStructure.FontWeight ||
        firstStructure.FaceName != secondStructure.FaceName
      );
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(ConsoleFontInformationExtended other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is ConsoleFontInformationExtended consoleFontInfoEx)
      {
        return this == consoleFontInfoEx;
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
        $"nFont: {nFont}, " +
        $"dwFontSize: {dwFontSize}, " +
        $"FontFamily: {FontFamily}, " +
        $"FontWeight: {FontWeight}, " +
        $"FaceName: {FaceName}" +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return
        cbSize.GetHashCode() ^
        nFont.GetHashCode() ^
        dwFontSize.GetHashCode() ^
        FontFamily.GetHashCode() ^
        FontWeight.GetHashCode() ^
        FaceName.GetHashCode()
      ;
    }

    #endregion
  }
}
