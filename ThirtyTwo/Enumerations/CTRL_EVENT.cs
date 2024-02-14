using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies the control signals that can be output from the console.
    /// </summary>
    [Flags]
    public enum CTRL_EVENT : uint
    {
        /// <summary>
        /// Generates a "CTRL + C" signal. This signal cannot be limited to a specific process
        /// group. If "dwProcessGroupId" is nonzero, this function will succeed, but the
        /// "CTRL + C" signal will not be received by processes within the specified process group.
        /// </summary>
        CTRL_C_EVENT = 0,

        /// <summary>
        /// Generates a "CTRL + BREAK" signal.
        /// </summary>
        CTRL_BREAK_EVENT = 1,

        /// <summary>
        /// A signal that the system sends to all processes attached to a console when the user
        /// closes the console (either by clicking Close on the console window's window menu,
        /// or by clicking the End Task button command from Task Manager).
        /// </summary>
        CTRL_CLOSE_EVENT = 2,

        /// <summary>
        /// A signal that the system sends to all console processes when a user is logging off.
        /// This signal does not indicate which user is logging off, so no assumptions can
        /// be made. Note that this signal is received only by services. Interactive
        /// applications are terminated at logoff, so they are not present when the system
        /// sends this signal.
        /// </summary>
        CTRL_LOGOFF_EVENT = 5,

        /// <summary>
        /// A signal that the system sends when the system is shutting down. Interactive
        /// applications are not present by the time the system sends this signal, therefore
        /// it can be received only be services in this situation. Services also have their
        /// own notification mechanism for shutdown events. This signal can also be generated
        /// by an application using "GenerateConsoleCtrlEvent".
        /// </summary>
        CTRL_SHUTDOWN_EVENT = 6,
    }
}
