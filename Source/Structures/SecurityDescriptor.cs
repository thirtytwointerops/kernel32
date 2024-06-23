using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct SecurityDescriptor :
      IEquatable<SecurityDescriptor>
  {
    #region Public Members

    public byte Revision;
    public byte Sbz1;
    public SecurityDescriptorControl Control;
    public IntPtr Owner;
    public IntPtr Group;
    public IntPtr Sacl;
    public IntPtr Dacl;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

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

    public bool Equals(SecurityDescriptor other)
    {
      return this == other;
    }

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
