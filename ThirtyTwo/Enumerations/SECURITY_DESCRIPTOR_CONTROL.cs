using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// The "SECURITY_DESCRIPTOR_CONTROL" enumeration is a set of bit flags that qualify the
    /// meaning of a security descriptor or its components.
    /// </summary>
    [Flags]
    public enum SECURITY_DESCRIPTOR_CONTROL : uint
    {
        /// <summary>
        /// The owner security identifier (SID) is not present in the security descriptor,
        /// and a default owner SID is substituted.
        /// </summary>
        SE_OWNER_DEFAULTED = 0x0001,

        /// <summary>
        /// The group SID is not present in the security descriptor, and a default group SID
        /// is substituted.
        /// </summary>
        SE_GROUP_DEFAULTED = 0x0002,

        /// <summary>
        /// The discretionary access control list (DACL) is present in the security descriptor.
        /// </summary>
        SE_DACL_PRESENT = 0x0004,

        /// <summary>
        /// The DACL is not present in the security descriptor, and a default DACL is substituted.
        /// </summary>
        SE_DACL_DEFAULTED = 0x0008,

        /// <summary>
        /// The system access control list (SACL) is present in the security descriptor.
        /// </summary>
        SE_SACL_PRESENT = 0x0010,

        /// <summary>
        /// The SACL is not present in the security descriptor, and a default SACL is substituted.
        /// </summary>
        SE_SACL_DEFAULTED = 0x0020,

        /// <summary>
        /// The DACL is set up to support automatic propagation of inheritable access control
        /// entries (ACEs) to existing child objects.
        /// </summary>
        SE_DACL_AUTO_INHERIT_REQ = 0x0100,

        /// <summary>
        /// The SACL is set up to support automatic propagation of inheritable ACEs to existing
        /// child objects.
        /// </summary>
        SE_SACL_AUTO_INHERIT_REQ = 0x0200,

        /// <summary>
        /// The DACL is set up to support automatic propagation of inheritable ACEs to existing
        /// child objects.
        /// </summary>
        SE_DACL_AUTO_INHERITED = 0x0400,

        /// <summary>
        /// The SACL is set up to support automatic propagation of inheritable ACEs to existing
        /// child objects.
        /// </summary>
        SE_SACL_AUTO_INHERITED = 0x0800,

        /// <summary>
        /// The DACL cannot be modified by inheritable ACEs.
        /// </summary>
        SE_DACL_PROTECTED = 0x1000,

        /// <summary>
        /// The SACL cannot be modified by inheritable ACEs.
        /// </summary>
        SE_SACL_PROTECTED = 0x2000,

        /// <summary>
        /// Indicates that the resource manager control is valid.
        /// </summary>
        SE_RM_CONTROL_VALID = 0x4000,

        /// <summary>
        /// The security descriptor is in self-relative format.
        /// </summary>
        SE_SELF_RELATIVE = 0x8000,
    }
}
