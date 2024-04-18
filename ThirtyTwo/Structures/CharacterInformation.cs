using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Specifies a Unicode or ANSI character and its attributes. This structure is
  /// used by console functions to read from and write to a console screen buffer.
  /// </summary>
  [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
  public struct CharacterInformation :
      IEquatable<CharacterInformation>
  {
    #region Public Members

    /// <summary>
    /// Unicode character of a screen buffer character cell.
    /// </summary>
    [FieldOffset(0)]
    public char UnicodeChar;

    /// <summary>
    /// ANSI character of a screen buffer character cell.
    /// </summary>
    [FieldOffset(0)]
    public char AsciiChar;

    /// <summary>
    /// The character's attributes. This member can be zero or a combination of
    /// values ​​from the "CharacterAttributes" enumeration.
    /// </summary>
    [FieldOffset(2)]
    public CharacterAttributes Attributes;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
    public static bool operator ==(
      CharacterInformation firstStructure,
      CharacterInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.UnicodeChar == secondStructure.UnicodeChar &&
        firstStructure.AsciiChar == secondStructure.AsciiChar &&
        firstStructure.Attributes == secondStructure.Attributes
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    /// <inheritdoc />
    public static bool operator !=(
      CharacterInformation firstStructure,
      CharacterInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return (
        firstStructure.UnicodeChar != secondStructure.UnicodeChar ||
        firstStructure.AsciiChar != secondStructure.AsciiChar ||
        firstStructure.Attributes != secondStructure.Attributes
      );
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(CharacterInformation other)
    {
      return this == other;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      if (obj is CharacterInformation charInfo)
      {
        return this == charInfo;
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
        $"UnicodeChar: {UnicodeChar}, " +
        $"AsciiChar: {AsciiChar}, " +
        $"Attributes: {Attributes} " +
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
        UnicodeChar.GetHashCode() ^
        AsciiChar.GetHashCode() ^
        Attributes.GetHashCode()
      ;
    }

    #endregion
  }
}
