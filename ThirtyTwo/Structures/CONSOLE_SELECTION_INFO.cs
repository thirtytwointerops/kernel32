using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
    /// <summary>
    /// Contains information for a console selection.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_SELECTION_INFO : IEquatable<CONSOLE_SELECTION_INFO>
    {
        #region Public Members

        /// <summary>
        /// The selection indicator. This member can contain one or a combination of values
        /// from the "SELECTION_INDICATOR" enumeration.
        /// </summary>
        public SELECTION_INDICATOR dwFlags;

        /// <summary>
        /// A "COORD" structure that specifies the selection anchor, in characters.
        /// </summary>
        public COORD dwSelectionAnchor;

        /// <summary>
        /// A "SMALL_RECT" structure that specifies the selection rectangle.
        /// </summary>
        public SMALL_RECT srSelection;

        #endregion

        // @

        #region Logical Operator: Comparison (Equals) => bool

        /// <inheritdoc />
        public static bool operator ==(
            CONSOLE_SELECTION_INFO firstStructure,
            CONSOLE_SELECTION_INFO secondStructure
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
            CONSOLE_SELECTION_INFO firstStructure,
            CONSOLE_SELECTION_INFO secondStructure
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
        public bool Equals(CONSOLE_SELECTION_INFO other)
        {
            return this == other;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is CONSOLE_SELECTION_INFO iNFO)
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
                $"dwFlags: {dwFlags}, " +
                $"dwSelectionAnchor: {dwSelectionAnchor}, " +
                $"srSelection: {srSelection} " +
                @"}";
        }

        #endregion

        // @

        #region GetHashCode => int

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return dwFlags.GetHashCode() ^
                dwSelectionAnchor.GetHashCode() ^
                srSelection.GetHashCode();
        }

        #endregion
    }
}
