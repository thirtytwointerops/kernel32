namespace ThirtyTwo.Kernel32.Enumerations
{
  [System.Flags]
  public enum SecurityDescriptorControl : uint
  {
    OwnerDefaulted = 0x0001,
    GroupDefaulted = 0x0002,
    DACLPresent = 0x0004,
    DACLDefaulted = 0x0008,
    SACLPresent = 0x0010,
    SACLDefaulted = 0x0020,
    DACLAutoInheritRequired = 0x0100,
    SACLAutoInheritRequired = 0x0200,
    DACLAutoInherit = 0x0400,
    SACLAutoInherit = 0x0800,
    DACLProtected = 0x1000,
    SACLProtected = 0x2000,
    ResourceManagerControlValid = 0x4000,
    SelfRelative = 0x8000,
  }
}
