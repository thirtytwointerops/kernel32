using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct MouseEventRecord :
      IEquatable<MouseEventRecord>
  {
    #region Public Members

    public Coordinate dwMousePosition;
    public MouseButtonState dwButtonState;
    public ModifierKeyState dwControlKeyState;
    public MouseEvent dwEventFlags;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      MouseEventRecord firstStructure,
      MouseEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return
        firstStructure.dwMousePosition == secondStructure.dwMousePosition &&
        firstStructure.dwButtonState == secondStructure.dwButtonState &&
        firstStructure.dwControlKeyState == secondStructure.dwControlKeyState &&
        firstStructure.dwEventFlags == secondStructure.dwEventFlags
      ;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      MouseEventRecord firstStructure,
      MouseEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return
        firstStructure.dwMousePosition != secondStructure.dwMousePosition ||
        firstStructure.dwButtonState != secondStructure.dwButtonState ||
        firstStructure.dwControlKeyState != secondStructure.dwControlKeyState ||
        firstStructure.dwEventFlags != secondStructure.dwEventFlags
      ;
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(MouseEventRecord other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is MouseEventRecord mouseEventRecord)
      {
        return this == mouseEventRecord;
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
        $"dwMousePosition: {dwMousePosition}, " +
        $"dwButtonState: {dwButtonState}, " +
        $"dwControlKeyState: {dwControlKeyState}, " +
        $"dwEventFlags: {dwEventFlags} " +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return
        dwMousePosition.GetHashCode() ^
        dwButtonState.GetHashCode() ^
        dwControlKeyState.GetHashCode() ^
        dwEventFlags.GetHashCode()
      ;
    }

    #endregion
  }
}
