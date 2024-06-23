using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleCursorInformation :
      IEquatable<ConsoleCursorInformation>
  {
    #region Public Members

    public uint dwSize;
    public bool bVisible;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      ConsoleCursorInformation firstStructure,
      ConsoleCursorInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.dwSize == secondStructure.dwSize &&
        firstStructure.bVisible == secondStructure.bVisible
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      ConsoleCursorInformation firstStructure,
      ConsoleCursorInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return (
        firstStructure.dwSize != secondStructure.dwSize ||
        firstStructure.bVisible != secondStructure.bVisible
      );
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(ConsoleCursorInformation other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is ConsoleCursorInformation consoleCursorInfo)
      {
        return this == consoleCursorInfo;
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
        $"bVisible: {bVisible} " +
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
        bVisible.GetHashCode()
      ;
    }

    #endregion
  }
}
