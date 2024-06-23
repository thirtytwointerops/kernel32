using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Auto)]
  public struct KeyEventRecord :
      IEquatable<KeyEventRecord>
  {
    #region Public Members

    [FieldOffset(0)]
    public bool bKeyDown;

    [FieldOffset(1)]
    public ushort wRepeatCount;

    [FieldOffset(3)]
    public VirtualKey wVirtualKeyCode;

    [FieldOffset(5)]
    public ushort wVirtualScanCode;

    [FieldOffset(7)]
    public char UnicodeChar;

    [FieldOffset(7)]
    public char AsciiChar;

    [FieldOffset(9)]
    public ModifierKeyState dwControlKeyState;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      KeyEventRecord firstStructure,
      KeyEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return
        firstStructure.bKeyDown == secondStructure.bKeyDown &&
        firstStructure.wRepeatCount == secondStructure.wRepeatCount &&
        firstStructure.wVirtualKeyCode == secondStructure.wVirtualKeyCode &&
        firstStructure.wVirtualScanCode == secondStructure.wVirtualScanCode &&
        firstStructure.UnicodeChar == secondStructure.UnicodeChar &&
        firstStructure.AsciiChar == secondStructure.AsciiChar &&
        firstStructure.dwControlKeyState == secondStructure.dwControlKeyState
      ;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      KeyEventRecord firstStructure,
      KeyEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return
        firstStructure.bKeyDown != secondStructure.bKeyDown ||
        firstStructure.wRepeatCount != secondStructure.wRepeatCount ||
        firstStructure.wVirtualKeyCode != secondStructure.wVirtualKeyCode ||
        firstStructure.wVirtualScanCode != secondStructure.wVirtualScanCode ||
        firstStructure.UnicodeChar != secondStructure.UnicodeChar ||
        firstStructure.AsciiChar != secondStructure.AsciiChar ||
        firstStructure.dwControlKeyState != secondStructure.dwControlKeyState
      ;
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(KeyEventRecord other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is KeyEventRecord keyEventRecord)
      {
        return this == keyEventRecord;
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
        $"bKeyDown: {bKeyDown}, " +
        $"wRepeatCount: {wRepeatCount}, " +
        $"wVirtualKeyCode: {wVirtualKeyCode}, " +
        $"wVirtualScanCode: {wVirtualScanCode}, " +
        $"UnicodeChar: {UnicodeChar}, " +
        $"AsciiChar: {AsciiChar}, " +
        $"dwControlKeyState: {dwControlKeyState} " +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return
        bKeyDown.GetHashCode() ^
        wRepeatCount.GetHashCode() ^
        wVirtualKeyCode.GetHashCode() ^
        wVirtualScanCode.GetHashCode() ^
        UnicodeChar.GetHashCode() ^
        AsciiChar.GetHashCode() ^
        dwControlKeyState.GetHashCode()
      ;
    }

    #endregion
  }
}
