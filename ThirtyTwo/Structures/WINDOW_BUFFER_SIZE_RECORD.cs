using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
    /// <summary>
    /// Describes a change in the size of the console screen buffer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOW_BUFFER_SIZE_RECORD : IEquatable<WINDOW_BUFFER_SIZE_RECORD>
    {
        #region Public Members

        /// <summary>
        /// A "COORD" structure that contains the size of the console screen buffer, in
        /// character cell columns and rows.
        /// </summary>
        public COORD dwSize;

        #endregion

        // @

        #region Logical Operator: Comparison (Equals) => bool

        /// <inheritdoc />
        public static bool operator ==(
            WINDOW_BUFFER_SIZE_RECORD firstStructure,
            WINDOW_BUFFER_SIZE_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return
                firstStructure.dwSize == secondStructure.dwSize
            ;
        }

        #endregion

        // @

        #region Logical Operator: Comparison (Different) => bool

        /// <inheritdoc />
        public static bool operator !=(
            WINDOW_BUFFER_SIZE_RECORD firstStructure,
            WINDOW_BUFFER_SIZE_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return false;
            }

            return
                firstStructure.dwSize != secondStructure.dwSize
            ;
        }

        #endregion

        // @

        #region Logical Operator: Arithmetic (Sum) => WINDOW_BUFFER_SIZE_RECORD

        /// <inheritdoc />
        public static WINDOW_BUFFER_SIZE_RECORD operator +(
            WINDOW_BUFFER_SIZE_RECORD firstStructure,
            WINDOW_BUFFER_SIZE_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return new WINDOW_BUFFER_SIZE_RECORD
                {
                    dwSize = new COORD
                    {
                        X = 0, // standard value
                        Y = 0, // standard value
                    }
                };
            }

            return new WINDOW_BUFFER_SIZE_RECORD
            {
                dwSize = firstStructure.dwSize + secondStructure.dwSize,
            };
        }

        #endregion

        // @

        #region Logical Operator: Arithmetic (Subtract) => WINDOW_BUFFER_SIZE_RECORD

        /// <inheritdoc />
        public static WINDOW_BUFFER_SIZE_RECORD operator -(
            WINDOW_BUFFER_SIZE_RECORD firstStructure,
            WINDOW_BUFFER_SIZE_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return new WINDOW_BUFFER_SIZE_RECORD
                {
                    dwSize = new COORD
                    {
                        X = 0, // standard value
                        Y = 0, // standard value
                    }
                };
            }

            return new WINDOW_BUFFER_SIZE_RECORD
            {
                dwSize = firstStructure.dwSize - secondStructure.dwSize,
            };
        }

        #endregion

        // @

        #region Logical Operator: Arithmetic (Multiply) => WINDOW_BUFFER_SIZE_RECORD

        /// <inheritdoc />
        public static WINDOW_BUFFER_SIZE_RECORD operator *(
            WINDOW_BUFFER_SIZE_RECORD firstStructure,
            WINDOW_BUFFER_SIZE_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return new WINDOW_BUFFER_SIZE_RECORD
                {
                    dwSize = new COORD
                    {
                        X = 0, // standard value
                        Y = 0, // standard value
                    }
                };
            }

            return new WINDOW_BUFFER_SIZE_RECORD
            {
                dwSize = firstStructure.dwSize * secondStructure.dwSize,
            };
        }

        #endregion

        // @

        #region Logical Operator: Arithmetic (Divide) => WINDOW_BUFFER_SIZE_RECORD

        /// <inheritdoc />
        public static WINDOW_BUFFER_SIZE_RECORD operator /(
            WINDOW_BUFFER_SIZE_RECORD firstStructure,
            WINDOW_BUFFER_SIZE_RECORD secondStructure
        )
        {
            if (firstStructure == null || secondStructure == null)
            {
                return new WINDOW_BUFFER_SIZE_RECORD
                {
                    dwSize = new COORD
                    {
                        X = 0, // standard value
                        Y = 0, // standard value
                    }
                };
            }

            return new WINDOW_BUFFER_SIZE_RECORD
            {
                dwSize = firstStructure.dwSize / secondStructure.dwSize,
            };
        }

        #endregion

        // @

        #region Equals => bool

        /// <inheritdoc />
        public bool Equals(WINDOW_BUFFER_SIZE_RECORD other)
        {
            return this == other;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is WINDOW_BUFFER_SIZE_RECORD rECORD)
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
                $"dwSize: {dwSize} " +
                @"}";
        }

        #endregion

        // @

        #region GetHashCode => int

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return dwSize.GetHashCode();
        }

        #endregion
    }
}
