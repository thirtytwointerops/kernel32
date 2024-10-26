namespace ThirtyTwo.Kernel32.Enumerations
{
  [Flags]
  public enum AccessRights : long
  {
    GenericWrite = 0x40000000L,
    GenericRead = 0x80000000L,
  }
}
