using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
    /// <summary>
    /// Contains information about the console history.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_HISTORY_INFO : IEquatable<CONSOLE_HISTORY_INFO>
    {
        #region Public Members

        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        public static uint cbSize = (uint)Marshal.SizeOf(typeof(CONSOLE_HISTORY_INFO));

        /// <summary>
        /// The number of commands kept in each history buffer.
        /// </summary>
        public uint HistoryBufferSize;

        /// <summary>
        /// The number of history buffers kept for this console process.
        /// </summary>
        public uint NumberOfHistoryBuffers;

        /// <summary>
        /// Duplicates entries will not be stored in the history buffer.
        /// </summary>
        public static uint dwFlags = 0x1;

        #endregion

        // @

        #region Logical Operator: Comparison (Equals) => bool

        /// <inheritdoc />
        public static bool operator ==(
            CONSOLE_HISTORY_INFO firstStructure,
            CONSOLE_HISTORY_INFO secondStructure
        ) {
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

        /// <inheritdoc />
        public static bool operator !=(
            CONSOLE_HISTORY_INFO firstStructure,
            CONSOLE_HISTORY_INFO secondStructure
        ) {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return (
                firstStructure.HistoryBufferSize != secondStructure.HistoryBufferSize ||
                firstStructure.NumberOfHistoryBuffers != secondStructure.NumberOfHistoryBuffers
            );
        }

        #endregion

        // @

        #region Equals => bool

        /// <inheritdoc />
        public bool Equals(CONSOLE_HISTORY_INFO other)
        {
            return this == other;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is CONSOLE_HISTORY_INFO iNFO)
            {
                return this == iNFO;
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
                $"cbSize: {cbSize}, " +
                $"HistoryBufferSize: {HistoryBufferSize} " +
                $"NumberOfHistoryBuffers: {NumberOfHistoryBuffers} " +
                $"dwFlags: {dwFlags} " +
                @"}";
        }

        #endregion

        // @

        #region GetHashCode => int

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return cbSize.GetHashCode() ^
                HistoryBufferSize.GetHashCode() ^
                NumberOfHistoryBuffers.GetHashCode() ^
                dwFlags.GetHashCode();
        }

        #endregion
    }
}
