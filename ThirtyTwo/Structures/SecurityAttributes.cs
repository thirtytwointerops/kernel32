using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// The "SecurityAttributes" structure contains the security descriptor for an object
  /// and specifies whether the handle retrieved by specifying this structure is inheritable.
  /// This structure provides security settings for objects created by various functions,
  /// such as "CreateFile", "CreatePipe", "CreateProcess", "RegCreateKeyEx", or "RegSaveKeyEx".
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct SecurityAttributes :
      IEquatable<SecurityAttributes>
  {
    #region Public Members

    /// <summary>
    /// The size, in bytes, of this structure.
    /// </summary>
    public static uint nLength = (uint)Marshal.SizeOf(
      typeof(SecurityAttributes)
    );

    /// <summary>
    /// A pointer to a "SecurityDescriptor" structure that controls access to the object.
    /// If the value of this member is "NULL", the object is assigned the default security
    /// descriptor associated with the access token of the calling process. This is not
    /// the same as granting access to everyone by assigning a "NULL" discretionary access
    /// control list (DACL). By default, the default DACL in the access token of a process
    /// allows access only to the user represented by the access token.
    /// </summary>
    public SecurityDescriptor lpSecurityDescriptor;

    /// <summary>
    /// A Boolean value that specifies whether the returned handle is inherited when a new
    /// process is created. If this member is "TRUE", the new process inherits the handle.
    /// </summary>
    public bool bInheritHandle;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
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

    /// <inheritdoc />
    public static bool operator !=(
      SecurityAttributes firstStructure,
      SecurityAttributes secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return
        firstStructure.lpSecurityDescriptor != secondStructure.lpSecurityDescriptor ||
        firstStructure.bInheritHandle != secondStructure.bInheritHandle
      ;
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(SecurityAttributes other)
    {
      return this == other;
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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
