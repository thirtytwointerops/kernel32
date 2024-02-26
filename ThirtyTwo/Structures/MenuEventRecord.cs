using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Describes a menu event in a console "InputRecord" structure. These events are used
  /// internally and should be ignored.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct MenuEventRecord :
      IEquatable<MenuEventRecord>
  {
    #region Public Members

    /// <summary>
    /// Reserved.
    /// </summary>
    public uint dwCommandId;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
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

    /// <inheritdoc />
    public static bool operator !=(
      MenuEventRecord firstStructure,
      MenuEventRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return firstStructure.dwCommandId != secondStructure.dwCommandId;
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(MenuEventRecord other)
    {
      return this == other;
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
    public override int GetHashCode()
    {
      return dwCommandId.GetHashCode();
    }

    #endregion
  }
}
