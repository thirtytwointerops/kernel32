using System.Runtime.InteropServices;
using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InputRecord :
      IEquatable<InputRecord>
  {
    #region Public Members

    [FieldOffset(0)]
    public InputRecordEventType EventType;

    [FieldOffset(2)]
    public KeyEventRecord KeyEvent;

    [FieldOffset(2)]
    public MouseEventRecord MouseEvent;

    [FieldOffset(2)]
    public WindowBufferSizeRecord WindowBufferSizeEvent;

    [FieldOffset(2)]
    public MenuEventRecord MenuEvent;

    [FieldOffset(2)]
    public FocusEventRecord FocusEvent;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

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

    public bool Equals(InputRecord other)
    {
      return this == other;
    }

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
