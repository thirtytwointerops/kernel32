using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Contains information for a console font.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleFontInformation :
      IEquatable<ConsoleFontInformation>
  {
    #region Public Members

    /// <summary>
    /// The index of the font int the system's console font table.
    /// </summary>
    public uint wFont;

    /// <summary>
    /// A "Coordinate" structure that contains the width and height of each character
    /// in the font, in logical units. The X member contains the width, while
    /// the Y member contains the height.
    /// </summary>
    public Coordinate dwFontSize;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
    public bool Equals(ConsoleFontInformation other)
    {
      return this == other;
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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
