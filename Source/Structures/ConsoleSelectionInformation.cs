using System.Runtime.InteropServices;
using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleSelectionInformation :
      IEquatable<ConsoleSelectionInformation>
  {
    #region Public Members

    public SelectionIndicator dwFlags;
    public Coordinate dwSelectionAnchor;
    public SmallRectangle srSelection;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

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

    public static bool operator !=(
      ConsoleSelectionInformation firstStructure,
      ConsoleSelectionInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
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

    public bool Equals(ConsoleSelectionInformation other)
    {
      return this == other;
    }

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
