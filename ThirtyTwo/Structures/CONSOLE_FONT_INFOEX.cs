using System.Runtime.InteropServices;
using System;
using System.Xml.Linq;

namespace ThirtyTwo.Kernel32.Structures
{
    /// <summary>
    /// Contains extended information for a console font.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_FONT_INFOEX : IEquatable<CONSOLE_FONT_INFOEX>
    {
        #region Public Members

        /// <summary>
        /// The size of this structure, in bytes.
        /// </summary>
        public static uint cbSize = (uint)Marshal.SizeOf(typeof(CONSOLE_FONT_INFOEX));

        /// <summary>
        /// The index of the font in the system's console font table.
        /// </summary>
        public uint nFont;

        /// <summary>
        /// A "COORD" structure that contains the width and height of each character
        /// in the font, in logical units. The X member contains the width, while
        /// the Y member contains the height.
        /// </summary>
        public COORD dwFontSize;

        /// <summary>
        /// The font pitch and family. 
        /// </summary>
        public uint FontFamily;

        /// <summary>
        /// The font weight. The weight can range from 100 to 1000, in multiples of
        /// 100. For example, the normal weight is 400, while 700 is bold.
        /// </summary>
        public uint FontWeight;

        /// <summary>
        /// The name of the typeface (such as Courier or Arial).
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string FaceName;

        #endregion

        // @

        #region Logical Operator: Comparison (Equals) => bool

        /// <inheritdoc />
        public static bool operator ==(
            CONSOLE_FONT_INFOEX firstStructure,
            CONSOLE_FONT_INFOEX secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return (
                firstStructure.nFont == secondStructure.nFont &&
                firstStructure.dwFontSize == secondStructure.dwFontSize &&
                firstStructure.FontFamily == secondStructure.FontFamily &&
                firstStructure.FontWeight == secondStructure.FontWeight &&
                firstStructure.FaceName == secondStructure.FaceName
            );
        }

        #endregion

        // @

        #region Logical Operator: Comparison (Different) => bool

        /// <inheritdoc />
        public static bool operator !=(
            CONSOLE_FONT_INFOEX firstStructure,
            CONSOLE_FONT_INFOEX secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return (
                firstStructure.nFont != secondStructure.nFont ||
                firstStructure.dwFontSize != secondStructure.dwFontSize ||
                firstStructure.FontFamily != secondStructure.FontFamily ||
                firstStructure.FontWeight != secondStructure.FontWeight ||
                firstStructure.FaceName != secondStructure.FaceName
            );
        }

        #endregion

        // @

        #region Equals => bool

        /// <inheritdoc />
        public bool Equals(CONSOLE_FONT_INFOEX other)
        {
            return this == other;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is CONSOLE_FONT_INFOEX iNFOEX)
            {
                return this == iNFOEX;
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
                $"nFont: {nFont}, " +
                $"dwFontSize: {dwFontSize}, " +
                $"FontFamily: {FontFamily}, " +
                $"FontWeight: {FontWeight}, " +
                $"FaceName: {FaceName}" +
                @"}";
        }

        #endregion

        // @

        #region GetHashCode => int

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return cbSize.GetHashCode() ^
                nFont.GetHashCode() ^
                dwFontSize.GetHashCode() ^
                FontFamily.GetHashCode() ^
                FontWeight.GetHashCode() ^
                FaceName.GetHashCode();
        }

        #endregion
    }
}
