using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Contains information for a console read operation.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct ReadConsoleControl :
      IEquatable<ReadConsoleControl>
  {
    #region Public Members

    /// <summary>
    /// The size of the structure.
    /// </summary>
    public static uint nLength = (uint)Marshal.SizeOf(
      typeof(ReadConsoleControl)
    );

    /// <summary>
    /// The number of characters to skip (and thus preserve) before writing newly read
    /// input in the buffer passed to the "ReadConsole" function. This value must be less
    /// than the "nNumberOfCharsToRead" parameter of the ReadConsole function.
    /// </summary>
    public uint nInitialChars;

    /// <summary>
    /// A mask specifying which control characters between "0x00" and "0x1F" should be used
    /// to signal that the read is complete. Each bit corresponds to a character with the
    /// least significant bit corresponding to "0x00" or "NULL" and the most significant bit
    /// corresponding to "0x1F" or "US". Multiple bits (control characters) can be specified.
    /// </summary>
    public uint dwCtrlWakeupMask;

    /// <summary>
    /// The state of the control keys. This member can contain one or a combination of
    /// values ​​from the "CTRL_KEY_STATE" enumeration.
    /// </summary>
    public ModifierKeyState dwCtrlKeyState;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
    public static bool operator ==(
      ReadConsoleControl firstStructure,
      ReadConsoleControl secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.nInitialChars == secondStructure.nInitialChars &&
        firstStructure.dwCtrlWakeupMask == secondStructure.dwCtrlWakeupMask &&
        firstStructure.dwCtrlKeyState == secondStructure.dwCtrlKeyState
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    /// <inheritdoc />
    public static bool operator !=(
      ReadConsoleControl firstStructure,
      ReadConsoleControl secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.nInitialChars != secondStructure.nInitialChars ||
        firstStructure.dwCtrlWakeupMask != secondStructure.dwCtrlWakeupMask ||
        firstStructure.dwCtrlKeyState != secondStructure.dwCtrlKeyState
      );
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(ReadConsoleControl other)
    {
      return this == other;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      if (obj is ReadConsoleControl consoleReadConsoleControl)
      {
        return this == consoleReadConsoleControl;
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
        $"nLength: {nLength}, " +
        $"nInitialChars: {nInitialChars} " +
        $"dwCtrlWakeupMask: {dwCtrlWakeupMask} " +
        $"dwCtrlKeyState: {dwCtrlKeyState} " +
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
        nLength.GetHashCode() ^
        nInitialChars.GetHashCode() ^
        dwCtrlWakeupMask.GetHashCode() ^
        dwCtrlKeyState.GetHashCode()
      ;
    }

    #endregion
  }
}
