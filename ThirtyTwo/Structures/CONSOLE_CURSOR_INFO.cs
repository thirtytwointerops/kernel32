using System.Runtime.InteropServices;
using System;
using System.Xml.Linq;

namespace ThirtyTwo.Kernel32.Structures
{
    /// <summary>
    /// Contains information about the console cursor.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_CURSOR_INFO : IEquatable<CONSOLE_CURSOR_INFO>
    {
        #region Public Members

        /// <summary>
        /// The percentage of the character cell that is filled by the cursor. This
        /// value is between 1 and 100. The cursor appearance variates, ranging from
        /// completely filling the cell to showing up as a horizontal line at the
        /// bottom of the cell.
        /// </summary>
        public uint dwSize;

        /// <summary>
        /// The visibility of the cursor. If true cursor is visible, this member
        /// is TRUE.
        /// </summary>
        public bool bVisible;

        #endregion

        // @

        #region Logical Operator: Comparison (Equals) => bool

        /// <inheritdoc />
        public static bool operator ==(
            CONSOLE_CURSOR_INFO firstStructure,
            CONSOLE_CURSOR_INFO secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return (
                firstStructure.dwSize == secondStructure.dwSize &&
                firstStructure.bVisible == secondStructure.bVisible
            );
        }

        #endregion

        // @

        #region Logical Operator: Comparison (Different) => bool

        /// <inheritdoc />
        public static bool operator !=(
            CONSOLE_CURSOR_INFO firstStructure,
            CONSOLE_CURSOR_INFO secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return (
                firstStructure.dwSize != secondStructure.dwSize ||
                firstStructure.bVisible != secondStructure.bVisible
            );
        }

        #endregion

        // @

        #region Equals => bool

        /// <inheritdoc />
        public bool Equals(CONSOLE_CURSOR_INFO other)
        {
            return this == other;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is CONSOLE_CURSOR_INFO iNFO)
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
                $"dwSize: {dwSize}, " +
                $"bVisible: {bVisible} " +
                @"}";
        }

        #endregion

        // @

        #region GetHashCode => int

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return dwSize.GetHashCode() ^
                bVisible.GetHashCode();
        }

        #endregion
    }
}
