using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Describes an input event in the console input buffer. These records can be read from
  /// the input buffer by using the "ReadConsoleInput" or "PeekConsoleInput" function, or
  /// written to the input buffer by using the "WriteConsoleInput" function.
  /// </summary>
  [StructLayout(LayoutKind.Explicit)]
  public struct InputRecord :
      IEquatable<InputRecord>
  {
    #region Public Members

    /// <summary>
    /// A handle to the type of input event and the event record stored in the "Event"
    /// member. This member can be defined by one of the values ​​of the
    /// "InputRecordEventType" enumeration.
    /// </summary>
    [FieldOffset(0)]
    public InputRecordEventType EventType;

    /// <summary>
    /// Describes a keyboard input event.
    /// </summary>
    [FieldOffset(2)]
    public KeyEventRecord KeyEvent;

    /// <summary>
    /// Describes a mouse input event.
    /// </summary>
    [FieldOffset(2)]
    public MouseEventRecord MouseEvent;

    /// <summary>
    /// Describes a change in the size of the console screen buffer.
    /// </summary>
    [FieldOffset(2)]
    public WindowBufferSizeRecord WindowBufferSizeEvent;

    /// <summary>
    /// Describes a menu event;
    /// </summary>
    [FieldOffset(2)]
    public MenuEventRecord MenuEvent;

    /// <summary>
    /// Describes a focus event.
    /// </summary>
    [FieldOffset(2)]
    public FocusEventRecord FocusEvent;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
    public static bool operator ==(
      InputRecord firstStructure,
      InputRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return
        firstStructure.EventType == secondStructure.EventType &&
        firstStructure.KeyEvent == secondStructure.KeyEvent &&
        firstStructure.MouseEvent == secondStructure.MouseEvent &&
        firstStructure.WindowBufferSizeEvent == secondStructure.WindowBufferSizeEvent &&
        firstStructure.MenuEvent == secondStructure.MenuEvent &&
        firstStructure.FocusEvent == secondStructure.FocusEvent
      ;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    /// <inheritdoc />
    public static bool operator !=(
      InputRecord firstStructure,
      InputRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return
        firstStructure.EventType != secondStructure.EventType ||
        firstStructure.KeyEvent != secondStructure.KeyEvent ||
        firstStructure.MouseEvent != secondStructure.MouseEvent ||
        firstStructure.WindowBufferSizeEvent != secondStructure.WindowBufferSizeEvent ||
        firstStructure.MenuEvent != secondStructure.MenuEvent ||
        firstStructure.FocusEvent != secondStructure.FocusEvent
      ;
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(InputRecord other)
    {
      return this == other;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      if (obj is InputRecord inputRecord)
      {
        return this == inputRecord;
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
        $"EventType: {EventType}, " +
        $"KeyEvent: {KeyEvent}, " +
        $"MouseEvent: {MouseEvent}, " +
        $"WindowBufferSizeEvent: {WindowBufferSizeEvent}, " +
        $"MenuEvent: {MenuEvent}, " +
        $"FocusEvent: {FocusEvent} " +
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
        EventType.GetHashCode() ^
        KeyEvent.GetHashCode() ^
        MouseEvent.GetHashCode() ^
        WindowBufferSizeEvent.GetHashCode() ^
        MenuEvent.GetHashCode() ^
        FocusEvent.GetHashCode()
      ;
    }

    #endregion
  }
}
