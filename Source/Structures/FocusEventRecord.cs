using System.Runtime.InteropServices;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct FocusEventRecord :
      IEquatable<FocusEventRecord>
  {
    #region Public Members

    public bool bSetFocus;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

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

    public static bool operator !=(
      FocusEventRecord firstStructure,
      FocusEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return firstStructure.bSetFocus != secondStructure.bSetFocus;
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(FocusEventRecord other)
    {
      return this == other;
    }

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

    public override int GetHashCode()
    {
      return bSetFocus.GetHashCode();
    }

    #endregion
  }
}
