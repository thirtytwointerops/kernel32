using System.Runtime.InteropServices;
using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
  public struct CharacterInformation :
      IEquatable<CharacterInformation>
  {
    #region Public Members

    [FieldOffset(0)]
    public char UnicodeChar;

    [FieldOffset(0)]
    public char AsciiChar;

    [FieldOffset(2)]
    public CharacterAttributes Attributes;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

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

    public bool Equals(CharacterInformation other)
    {
      return this == other;
    }

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
