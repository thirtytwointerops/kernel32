using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
    /// <summary>
    /// Describes a menu event in a console "INPUT_RECORD" structure. These events are used
    /// internally and should be ignored.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MENU_EVENT_RECORD : IEquatable<MENU_EVENT_RECORD>
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
            MENU_EVENT_RECORD firstStructure,
            MENU_EVENT_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return
                firstStructure.dwCommandId == secondStructure.dwCommandId
            ;
        }

        #endregion

        // @

        #region Logical Operator: Comparison (Different) => bool

        /// <inheritdoc />
        public static bool operator !=(
            MENU_EVENT_RECORD firstStructure,
            MENU_EVENT_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return
                firstStructure.dwCommandId != secondStructure.dwCommandId
            ;
        }

        #endregion

        // @

        #region Equals => bool

        /// <inheritdoc />
        public bool Equals(MENU_EVENT_RECORD other)
        {
            return this == other;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is MENU_EVENT_RECORD rECORD)
            {
                return this == rECORD;
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
                @"}";
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
