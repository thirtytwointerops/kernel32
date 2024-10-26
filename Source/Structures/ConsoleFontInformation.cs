using System.Runtime.InteropServices;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleFontInformation :
      IEquatable<ConsoleFontInformation>
  {
    #region Public Members

    public uint wFont;
    public Coordinate dwFontSize;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      ConsoleFontInformation firstStructure,
      ConsoleFontInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.wFont == secondStructure.wFont &&
        firstStructure.dwFontSize == secondStructure.dwFontSize
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      ConsoleFontInformation firstStructure,
      ConsoleFontInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return (
        firstStructure.wFont != secondStructure.wFont ||
        firstStructure.dwFontSize != secondStructure.dwFontSize
      );
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(ConsoleFontInformation other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is ConsoleFontInformation consoleFontInfo)
      {
        return this == consoleFontInfo;
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
        $"wFont: {wFont}, " +
        $"dwFontSize: {dwFontSize} " +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return
        wFont.GetHashCode() ^
        dwFontSize.GetHashCode()
      ;
    }

    #endregion
  }
}
