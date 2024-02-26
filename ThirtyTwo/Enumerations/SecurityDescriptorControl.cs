namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// The "SecurityDescriptorControl" enumeration is a set of bit flags that qualify the
  /// meaning of a security descriptor or its components.
  /// </summary>
  [System.Flags]
  public enum SecurityDescriptorControl : uint
  {
    /// <summary>
    /// The owner security identifier (SID) is not present in the security descriptor,
    /// and a default owner SID is substituted.
    /// </summary>
    OwnerDefaulted = 0x0001,

    /// <summary>
    /// The group SID is not present in the security descriptor, and a default group SID
    /// is substituted.
    /// </summary>
    GroupDefaulted = 0x0002,

    /// <summary>
    /// The discretionary access control list (DACL) is present in the security descriptor.
    /// </summary>
    DACLPresent = 0x0004,

    /// <summary>
    /// The DACL is not present in the security descriptor, and a default DACL is substituted.
    /// </summary>
    DACLDefaulted = 0x0008,

    /// <summary>
    /// The system access control list (SACL) is present in the security descriptor.
    /// </summary>
    SACLPresent = 0x0010,

    /// <summary>
    /// The SACL is not present in the security descriptor, and a default SACL is substituted.
    /// </summary>
    SACLDefaulted = 0x0020,

    /// <summary>
    /// The DACL is set up to support automatic propagation of inheritable access control
    /// entries (ACEs) to existing child objects.
    /// </summary>
    DACLAutoInheritRequired = 0x0100,

    /// <summary>
    /// The SACL is set up to support automatic propagation of inheritable ACEs to existing
    /// child objects.
    /// </summary>
    SACLAutoInheritRequired = 0x0200,

    /// <summary>
    /// The DACL is set up to support automatic propagation of inheritable ACEs to existing
    /// child objects.
    /// </summary>
    DACLAutoInherit = 0x0400,

    /// <summary>
    /// The SACL is set up to support automatic propagation of inheritable ACEs to existing
    /// child objects.
    /// </summary>
    SACLAutoInherit = 0x0800,

    /// <summary>
    /// The DACL cannot be modified by inheritable ACEs.
    /// </summary>
    DACLProtected = 0x1000,

    /// <summary>
    /// The SACL cannot be modified by inheritable ACEs.
    /// </summary>
    SACLProtected = 0x2000,

    /// <summary>
    /// Indicates that the resource manager control is valid.
    /// </summary>
    ResourceManagerControlValid = 0x4000,

    /// <summary>
    /// The security descriptor is in self-relative format.
    /// </summary>
    SelfRelative = 0x8000,
  }
}
