using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Contains information for a console selection.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleSelectionInformation :
      IEquatable<ConsoleSelectionInformation>
  {
    #region Public Members

    /// <summary>
    /// The selection indicator. This member can contain one or a combination of values
    /// from the "SelectionIndicator" enumeration.
    /// </summary>
    public SelectionIndicator dwFlags;

    /// <summary>
    /// A "Coordinate" structure that specifies the selection anchor, in characters.
    /// </summary>
    public Coordinate dwSelectionAnchor;

    /// <summary>
    /// A "SmallRectangle" structure that specifies the selection rectangle.
    /// </summary>
    public SmallRectangle srSelection;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
    public static bool operator ==(
      ConsoleSelectionInformation firstStructure,
      ConsoleSelectionInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.dwFlags == secondStructure.dwFlags &&
        firstStructure.dwSelectionAnchor == secondStructure.dwSelectionAnchor &&
        firstStructure.srSelection == secondStructure.srSelection
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    /// <inheritdoc />
    public static bool operator !=(
      ConsoleSelectionInformation firstStructure,
      ConsoleSelectionInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.dwFlags != secondStructure.dwFlags ||
        firstStructure.dwSelectionAnchor != secondStructure.dwSelectionAnchor ||
        firstStructure.srSelection != secondStructure.srSelection
      );
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(ConsoleSelectionInformation other)
    {
      return this == other;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      if (obj is ConsoleSelectionInformation consoleSelectionInfo)
      {
        return this == consoleSelectionInfo;
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
        $"dwFlags: {dwFlags}, " +
        $"dwSelectionAnchor: {dwSelectionAnchor}, " +
        $"srSelection: {srSelection} " +
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
        dwFlags.GetHashCode() ^
        dwSelectionAnchor.GetHashCode() ^
        srSelection.GetHashCode()
      ;
    }

    #endregion
  }
}
