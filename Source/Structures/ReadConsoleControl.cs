using System.Runtime.InteropServices;
using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct ReadConsoleControl :
      IEquatable<ReadConsoleControl>
  {
    #region Public Members

    public static uint nLength = (uint)Marshal.SizeOf(
      typeof(ReadConsoleControl)
    );

    public uint nInitialChars;
    public uint dwCtrlWakeupMask;
    public ModifierKeyState dwCtrlKeyState;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

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

    public static bool operator !=(
      ReadConsoleControl firstStructure,
      ReadConsoleControl secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
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

    public bool Equals(ReadConsoleControl other)
    {
      return this == other;
    }

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
