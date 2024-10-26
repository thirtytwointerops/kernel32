using System.Runtime.InteropServices;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct MenuEventRecord :
      IEquatable<MenuEventRecord>
  {
    #region Public Members

    public uint dwCommandId;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      MenuEventRecord firstStructure,
      MenuEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return firstStructure.dwCommandId == secondStructure.dwCommandId;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      MenuEventRecord firstStructure,
      MenuEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return firstStructure.dwCommandId != secondStructure.dwCommandId;
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(MenuEventRecord other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is MenuEventRecord menuEventRecord)
      {
        return this == menuEventRecord;
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
        $"dwCommandId: {dwCommandId} " +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return dwCommandId.GetHashCode();
    }

    #endregion
  }
}
