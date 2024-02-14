using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// A 32-bit value that is used to describe an error or warning.
    /// </summary>
    [Flags]
    public enum HRESULT : uint
    {
        /// <summary>
        /// Operation successful.
        /// </summary>
        S_OK = 0x00000000,

        /// <summary>
        /// Operation aborted.
        /// </summary>
        E_ABORT = 0x80004004,

        /// <summary>
        /// General access denied error.
        /// </summary>
        E_ACCESSDENIED = 0x80070005,

        /// <summary>
        /// Unspecified failure.
        /// </summary>
        E_FAIL = 0x80004005,

        /// <summary>
        /// Handle that is not valid.
        /// </summary>
        E_HANDLE = 0x80070006,

        /// <summary>
        /// One or more arguments are not valid.
        /// </summary>
        E_INVALIDARG = 0x80070057,

        /// <summary>
        /// No such interface supported.
        /// </summary>
        E_NOINTERFACE = 0x80004002,

        /// <summary>
        /// Not implemented.
        /// </summary>
        E_NOTIMPL = 0x80004001,

        /// <summary>
        /// Failed to allocate necessary memory.
        /// </summary>
        E_OUTOFMEMORY = 0x8007000E,

        /// <summary>
        /// Pointer that is not valid.
        /// </summary>
        E_POINTER = 0x80004003,

        /// <summary>
        /// Unexpected failure.
        /// </summary>
        E_UNEXPECTED = 0x8000FFFF,
    }
}
