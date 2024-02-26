using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Describes a mouse input event in a console "InputRecord" structure.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct MouseEventRecord :
      IEquatable<MouseEventRecord>
  {
    #region Public Members

    /// <summary>
    /// A "Coordinate" structure that contains the location of the cursor, in terms of the
    /// console screen buffer's character-cell coordinates.
    /// </summary>
    public Coordinate dwMousePosition;

    /// <summary>
    /// The status of the mouse buttons. The least significant bit corresponds to the
    /// leftmost mouse button. The next least significant bit corresponds to the
    /// rightmost mouse button. The next bit indicates the next-to-leftmost mouse button.
    /// The bits then correspond left to right to the mouse buttons. A bit is 1 if the
    /// button was pressed. This member can be defined by one of the values ​​in the
    /// "MouseButtonState" enumeration.
    /// </summary>
    public MouseButtonState dwButtonState;

    /// <summary>
    /// The state of the control keys. This member can contain one or a combination of
    /// values ​​from the "CTRL_KEY_STATE" enumeration.
    /// </summary>
    public ModifierKeyState dwControlKeyState;

    /// <summary>
    /// The type of mouse event. If this value is zero, it indicates a mouse button being
    /// pressed or released. Otherwise, this member can be defined by one of the values ​​in
    /// the "MouseEvent" enumeration.
    /// </summary>
    public MouseEvent dwEventFlags;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
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

    /// <inheritdoc />
    public static bool operator !=(
      MouseEventRecord firstStructure,
      MouseEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
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

    /// <inheritdoc />
    public bool Equals(MouseEventRecord other)
    {
      return this == other;
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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
