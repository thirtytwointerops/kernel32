using System.Runtime.InteropServices;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleHistoryInformation :
      IEquatable<ConsoleHistoryInformation>
  {
    #region Public Members

    public static uint cbSize = (uint)Marshal.SizeOf(
      typeof(ConsoleHistoryInformation)
    );

    public uint HistoryBufferSize;
    public uint NumberOfHistoryBuffers;
    public static uint dwFlags = 0x1;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      ConsoleHistoryInformation firstStructure,
      ConsoleHistoryInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.HistoryBufferSize == secondStructure.HistoryBufferSize &&
        firstStructure.NumberOfHistoryBuffers == secondStructure.NumberOfHistoryBuffers
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      ConsoleHistoryInformation firstStructure,
      ConsoleHistoryInformation secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return (
        firstStructure.HistoryBufferSize != secondStructure.HistoryBufferSize ||
        firstStructure.NumberOfHistoryBuffers != secondStructure.NumberOfHistoryBuffers
      );
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(ConsoleHistoryInformation other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is ConsoleHistoryInformation consoleHistoryInfo)
      {
        return this == consoleHistoryInfo;
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
        $"cbSize: {cbSize}, " +
        $"HistoryBufferSize: {HistoryBufferSize} " +
        $"NumberOfHistoryBuffers: {NumberOfHistoryBuffers} " +
        $"dwFlags: {dwFlags} " +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return
        cbSize.GetHashCode() ^
        HistoryBufferSize.GetHashCode() ^
        NumberOfHistoryBuffers.GetHashCode() ^
        dwFlags.GetHashCode()
      ;
    }

    #endregion
  }
}
