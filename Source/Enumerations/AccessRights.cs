namespace ThirtyTwo.Kernel32.Enumerations
{
  [System.Flags]
  public enum AccessRights : long
  {
    GenericRead = 0x80000000L,
    GenericWrite = 0x40000000L,
  }
}
