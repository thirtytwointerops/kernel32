using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Describes a focus event in a console "INPUT_RECORD" structure. These events are
  /// used internally and should be ignored.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct FocusEventRecord :
      IEquatable<FocusEventRecord>
  {
    #region Public Members

    /// <summary>
    /// Reserved.
    /// </summary>
    public bool bSetFocus;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
    public static bool operator ==(
      FocusEventRecord firstStructure,
      FocusEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return firstStructure.bSetFocus == secondStructure.bSetFocus;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    /// <inheritdoc />
    public static bool operator !=(
      FocusEventRecord firstStructure,
      FocusEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return firstStructure.bSetFocus != secondStructure.bSetFocus;
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(FocusEventRecord other)
    {
      return this == other;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      if (obj is FocusEventRecord focusEventRecord)
      {
        return this == focusEventRecord;
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
        $"bSetFocus: {bSetFocus} " +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    /// <inheritdoc />
    public override int GetHashCode()
    {
      return bSetFocus.GetHashCode();
    }

    #endregion
  }
}
