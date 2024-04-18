using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// The "SecurityDescriptor" structure contains the security information associated
  /// with an object. Applications use this structure to set and query an object's
  /// security status.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct SecurityDescriptor :
      IEquatable<SecurityDescriptor>
  {
    #region Public Members

    /// <summary>
    /// The revision level of the security descriptor structure.
    /// </summary>
    public byte Revision;

    /// <summary>
    /// Reserved. Must be zero.
    /// </summary>
    public byte Sbz1;

    /// <summary>
    /// A set of bit flags that qualify the meaning of the security descriptor or its
    /// individual members.
    /// </summary>
    public SecurityDescriptorControl Control;

    /// <summary>
    /// A pointer to a security identifier (SID) structure representing an object’s owner.
    /// </summary>
    public IntPtr Owner;

    /// <summary>
    /// A pointer to a SID structure representing an object’s primary group.
    /// </summary>
    public IntPtr Group;

    /// <summary>
    /// A pointer to a system access control list (SACL) structure.
    /// </summary>
    public IntPtr Sacl;

    /// <summary>
    /// A pointer to a discretionary access control list (DACL) structure.
    /// </summary>
    public IntPtr Dacl;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
    public static bool operator ==(
      SecurityDescriptor firstStructure,
      SecurityDescriptor secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return
        firstStructure.Revision == secondStructure.Revision &&
        firstStructure.Sbz1 == secondStructure.Sbz1 &&
        firstStructure.Control == secondStructure.Control &&
        firstStructure.Owner == secondStructure.Owner &&
        firstStructure.Group == secondStructure.Group &&
        firstStructure.Sacl == secondStructure.Sacl &&
        firstStructure.Dacl == secondStructure.Dacl
      ;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    /// <inheritdoc />
    public static bool operator !=(
      SecurityDescriptor firstStructure,
      SecurityDescriptor secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return
        firstStructure.Revision != secondStructure.Revision ||
        firstStructure.Sbz1 != secondStructure.Sbz1 ||
        firstStructure.Control != secondStructure.Control ||
        firstStructure.Owner != secondStructure.Owner ||
        firstStructure.Group != secondStructure.Group ||
        firstStructure.Sacl != secondStructure.Sacl ||
        firstStructure.Dacl != secondStructure.Dacl
      ;
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(SecurityDescriptor other)
    {
      return this == other;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      if (obj is SecurityDescriptor securityDescriptor)
      {
        return this == securityDescriptor;
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
        $"Revision: {Revision}, " +
        $"Sbz1: {Sbz1}, " +
        $"Control: {Control}, " +
        $"Owner: {Owner}, " +
        $"Group: {Group}, " +
        $"Sacl: {Sacl}, " +
        $"Dacl: {Dacl} " +
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
        Revision.GetHashCode() ^
        Sbz1.GetHashCode() ^
        Control.GetHashCode() ^
        Owner.GetHashCode() ^
        Group.GetHashCode() ^
        Sacl.GetHashCode() ^
        Dacl.GetHashCode()
      ;
    }

    #endregion
  }
}
