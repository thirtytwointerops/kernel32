using System.Runtime.InteropServices;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct SecurityAttributes :
      IEquatable<SecurityAttributes>
  {
    #region Public Members

    public static uint nLength = (uint)Marshal.SizeOf(
      typeof(SecurityAttributes)
    );

    public SecurityDescriptor lpSecurityDescriptor;
    public bool bInheritHandle;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      SecurityAttributes firstStructure,
      SecurityAttributes secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return
        firstStructure.lpSecurityDescriptor == secondStructure.lpSecurityDescriptor &&
        firstStructure.bInheritHandle == secondStructure.bInheritHandle
      ;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      SecurityAttributes firstStructure,
      SecurityAttributes secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return
        firstStructure.lpSecurityDescriptor != secondStructure.lpSecurityDescriptor ||
        firstStructure.bInheritHandle != secondStructure.bInheritHandle
      ;
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(SecurityAttributes other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is SecurityAttributes securityAttributes)
      {
        return this == securityAttributes;
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
        $"lpSecurityDescriptor: {lpSecurityDescriptor}, " +
        $"bInheritHandle: {bInheritHandle} " +
        @"}";
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return
        nLength.GetHashCode() ^
        lpSecurityDescriptor.GetHashCode() ^
        bInheritHandle.GetHashCode()
      ;
    }

    #endregion
  }
}
