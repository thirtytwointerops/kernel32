using System.Runtime.InteropServices;
using System.Text;
using System;

using Microsoft.Win32.SafeHandles;

using ThirtyTwo.Kernel32.Enumerations;
using ThirtyTwo.Kernel32.Structures;

namespace ThirtyTwo.Kernel32
{
    /// <summary>
    /// Provides public, static methods for communicating with the Kernel32 API.
    /// </summary>
    public static class Kernel
    {
        #region Public Constants

        /// <summary>
        /// Specifies the name of the DLL where the methods will be imported.
        /// </summary>
        public const string DLL_NAME = @"kernel32.dll";

        #endregion

        // @

        #region GetLastError => SYSTEM_ERROR_CODES

        /// <summary>
        /// Retrieves the calling thread's last-error code value. The last-error code is
        /// maintained on a per-thread basis. Multiple threads do not overwrite each other's
        /// last-error code.
        /// </summary>
        /// 
        /// <returns>
        /// The return value is the calling thread's last-error code.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetLastError")]
        public static extern SYSTEM_ERROR_CODES GetLastError();

        #endregion

        // @

        #region GetLastErrorCode => uint

        /// <summary>
        /// Retrieves the calling thread's last-error code value. The last-error code is
        /// maintained on a per-thread basis. Multiple threads do not overwrite each other's
        /// last-error code.
        /// </summary>
        /// 
        /// <returns>
        /// The return value is the calling thread's last-error code.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetLastError")]
        public static extern uint GetLastErrorCode();

        #endregion

        // @

        #region AddConsoleAlias (Unicode - LPWStr) => bool

        /// <summary>
        /// Defines a console alias for the specified executable.
        /// </summary>
        /// 
        /// <param name="Source">
        /// The console alias to be mapped to the text specified by "Target".
        /// </param>
        /// <param name="Target">
        /// The text to be substituted for "Source". If this parameter is "NULL", then the
        /// console alias is removed.
        /// </param>
        /// <param name="ExeName">
        /// The name of the executable file for which the console alias is to be defined.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is "TRUE". If the function fails, the
        /// return value is "FALSE". To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "AddConsoleAlias", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool AddConsoleAlias(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder Source,

            [In, MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder Target,

            [In, MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder ExeName
        );

        #endregion

        // @

        #region AllocConsole => bool

        /// <summary>
        /// Allocates a new console for the calling process.
        /// </summary>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "AllocConsole", SetLastError = true)]
        public static extern bool AllocConsole();

        #endregion

        // @

        #region AttachConsole => bool

        /// <summary>
        /// Attaches the calling process to the console of the specified process as a client
        /// application.
        /// </summary>
        /// 
        /// <param name="dwProcessId">
        /// The identifier of the process whose console is to be used.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "AttachConsole", SetLastError = true)]
        public static extern bool AttachConsole([In] uint dwProcessId);

        #endregion

        // @

        #region ClosePseudoConsole => void

        /// <summary>
        /// Closes a pseudo console from the given handle.
        /// </summary>
        /// 
        /// <param name="hPC">
        /// A handle to an active pseudo console as opened by "CreatePseudoConsole".
        /// </param>
        [DllImport(DLL_NAME, EntryPoint = "ClosePseudoConsole", SetLastError = true)]
        public static extern void ClosePseudoConsole([In] IntPtr hPC);

        #endregion

        // @

        #region CreatePseudoConsole => HRESULT

        /// <summary>
        /// Creates a new pseudo console object for the calling process.
        /// </summary>
        /// 
        /// <param name="size">
        /// The dimensions of the window/buffer in count of characters that will be used
        /// on initial creation of the pseudo console. This can be adjusted later with
        /// "ResizePseudoConsole".
        /// </param>
        /// <param name="hInput">
        /// An open handle to a stream of data that represents user input to the device.
        /// This is currently restricted to synchronous I/O.
        /// </param>
        /// <param name="hOutput">
        /// An open handle to a stream of data that represents application output from the
        /// device. This is currently restricted to synchronous I/O.
        /// </param>
        /// <param name="dwFlags">
        /// The creation option. This parameter can be defined by one of the values ​​of the
        /// "PSEUDO_CONSOLE_CREATION_OPTION" enumeration.
        /// </param>
        /// <param name="phPC">
        /// Pointer to a location that will receive a handle to the new pseudo console device.
        /// </param>
        /// 
        /// <returns>
        /// If this method succeeds, it returns "S_OK". Otherwise, it returns an "HRESULT"
        /// error code.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "CreatePseudoConsole", SetLastError = true)]
        public static extern HRESULT CreatePseudoConsole(
            [In] COORD size,
            [In] IntPtr hInput,
            [In] IntPtr hOutput,
            [In] PSEUDO_CONSOLE_CREATION_OPTION dwFlags,
            [Out] out IntPtr phPC
        );

        #endregion

        // @

        #region CreateConsoleScreenBuffer => SafeFileHandle

        /// <summary>
        /// Creates a console screen buffer.
        /// </summary>
        /// 
        /// <param name="dwDesiredAccess">
        /// The access to the console screen buffer. This parameter can be defined by one of the
        /// values ​​of the "ACCESS_RIGHTS" enumeration.
        /// </param>
        /// <param name="dwShareMode">
        /// This parameter can be zero, indicating that the buffer cannot be shared, or it can
        /// be one or more values ​​from the "SHARE_MODE" enumeration.
        /// </param>
        /// <param name="lpSecurityAttributes">
        /// A pointer to a "SECURITY_ATTRIBUTES" structure that determines whether the returned
        /// handle can be inherited by child processes. If "lpSecurityAttributes" is "NULL",
        /// the handle cannot be inherited. The "lpSecurityDescriptor" member of the structure
        /// specifies a security descriptor for the new console screen buffer. If
        /// "lpSecurityAttributes" is "NULL", the console screen buffer gets a default security
        /// descriptor. The ACLs in the default security descriptor for a console screen buffer
        /// come from the primary or impersonation token of the creator.
        /// </param>
        /// <param name="dwFlags">
        /// The type of console screen buffer to create. The only supported screen buffer type
        /// is "CONSOLE_TEXTMODE_BUFFER (1)".
        /// </param>
        /// <param name="lpScreenBufferData">
        /// Reserved. Should be "NULL".
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is a handle to the new console screen
        /// buffer. If the function fails, the return value is "INVALID_HANDLE_VALUE". To get
        /// extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "CreateConsoleScreenBuffer", SetLastError = true)]
        public static extern SafeFileHandle CreateConsoleScreenBuffer(
            [In] ACCESS_RIGHTS dwDesiredAccess,
            [In] SHARE_MODE dwShareMode,
            [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes,
            [In] uint dwFlags,
            [In] IntPtr lpScreenBufferData = default
        );

        #endregion

        // @

        #region FillConsoleOutputAttribute => bool

        /// <summary>
        /// Sets the character attributes for a specified number of character cells, beginning
        /// at the specified coordinates in a screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// <param name="wAttribute">
        /// The attributes to use when writing to the console screen buffer. This parameter can
        /// be zero or a combination of values ​​from the "CHAR_ATTRIBUTES" enumeration.
        /// </param>
        /// <param name="nLength">
        /// The number of character cells to be set to the specified color attributes.
        /// </param>
        /// <param name="dwWriteCoord">
        /// A "COORD" structure that specifies the character coordinates of the first cell
        /// whose attributes are to be set.
        /// </param>
        /// <param name="lpNumberOfAttrsWritten">
        /// A pointer to a variable that receives the number of character cells whose
        /// attributes were actually set.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "FillConsoleOutputAttribute", SetLastError = true)]
        public static extern bool FillConsoleOutputAttribute(
            [In] IntPtr hConsoleOutput,
            [In] CHAR_ATTRIBUTES wAttribute,
            [In] uint nLength,
            [In] COORD dwWriteCoord,
            [Out] out uint lpNumberOfAttrsWritten
        );

        #endregion

        // @

        #region FillConsoleOutputCharacter (Unicode - LPWStr) => bool

        /// <summary>
        /// Writes a character to the console screen buffer a specified number of times,
        /// beginning at the specified coordinates.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// <param name="cCharacter">
        /// The character to be written to the console screen buffer.
        /// </param>
        /// <param name="nLength">
        /// The number of character cells to which the character should be written.
        /// </param>
        /// <param name="dwWriteCoord">
        /// A "COORD" structure that specifies the character coordinates of the first cell
        /// to which the character is to be written.
        /// </param>
        /// <param name="lpNumberOfCharsWritten">
        /// A pointer to a variable that receives the number of characters actually written to
        /// the console screen buffer.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "FillConsoleOutputCharacter", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool FillConsoleOutputCharacter(
            [In] IntPtr hConsoleOutput,
            [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder cCharacter,
            [In] uint nLength,
            [In] COORD dwWriteCoord,
            [Out] out uint lpNumberOfCharsWritten
        );

        #endregion

        // @

        #region FlushConsoleInputBuffer => bool

        /// <summary>
        /// Flushes the console input buffer. All input records currently in the input buffer
        /// are discarded.
        /// </summary>
        /// 
        /// <param name="hConsoleInput">
        /// A handle to the console input buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "FlushConsoleInputBuffer", SetLastError = true)]
        public static extern bool FlushConsoleInputBuffer([In] IntPtr hConsoleInput);

        #endregion

        // @

        #region FreeConsole => void

        /// <summary>
        /// Detaches the calling process from its console.
        /// </summary>
        [DllImport(DLL_NAME, EntryPoint = "FreeConsole", SetLastError = true)]
        public static extern void FreeConsole();

        #endregion

        // @

        #region GenerateConsoleCtrlEvent => bool

        /// <summary>
        /// Sends a specified signal to a console process group that shares the console
        /// associated with the calling process.
        /// </summary>
        /// 
        /// <param name="dwCtrlEvent">
        /// The type of signal to be generated. This parameter can be defined by one of the
        /// values ​​in the "CTRL_EVENT" enumeration.
        /// </param>
        /// <param name="dwProcessGroupId">
        /// The identifier of the process group to receive the signal. A process group is
        /// created when the "CREATE_NEW_PROCESS_GROUP" flag is specified in a call to the
        /// "CreateProcess" function. The process identifier of the new process is also the
        /// process group identifier of a new process group. The process group includes all
        /// processes that are descendants of the root process. Only those processes in the
        /// group that share the same console as the calling process receive the signal. In
        /// other words, if a process in the group creates a new console, that process does
        /// not receive the signal, nor do its descendants. If this parameter is zero, the
        /// signal is generated in all processes that share the console of the calling process.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GenerateConsoleCtrlEvent", SetLastError = true)]
        public static extern bool GenerateConsoleCtrlEvent(
            [In] CTRL_EVENT dwCtrlEvent,
            [In] uint dwProcessGroupId
        );

        #endregion

        // @

        #region GetConsoleAlias (Unicode - LPWStr) => uint

        /// <summary>
        /// Retrieves the text for the specified console alias and executable.
        /// </summary>
        /// 
        /// <param name="lpSource">
        /// The console alias whose text is to be retrieved.
        /// </param>
        /// <param name="lpTargetBuffer">
        /// A pointer to a buffer that receives the text associated with the console alias.
        /// </param>
        /// <param name="TargetBufferLength">
        /// The size of the buffer pointed to by "lpTargetBuffer", in bytes.
        /// </param>
        /// <param name="lpExeName">
        /// The name of the executable file.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleAlias", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern uint GetConsoleAlias(
            [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpSource,
            [Out] out StringBuilder lpTargetBuffer,
            [In, MarshalAs(UnmanagedType.LPWStr)] uint TargetBufferLength,
            [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpExeName
        );

        #endregion

        // @

        #region GetConsoleAliases (Unicode - LPWStr) => uint

        /// <summary>
        /// Retrieves all defined console aliases for the specified executable.
        /// </summary>
        /// 
        /// <param name="lpAliasBuffer">
        /// A pointer to a buffer that receives the aliases. The format of the data is as
        /// follows: "Source1=Target1\0Source2=Target2\0... SourceN=TargetN\0", where "N" is
        /// the number of console aliases defined.
        /// </param>
        /// <param name="AliasBufferLength">
        /// The size of the buffer pointed to by "lpAliasBuffer", in bytes.
        /// </param>
        /// <param name="lpExeName">
        /// The executable file whose aliases are to be retrieved.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleAliases", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern uint GetConsoleAliases(
            [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder lpAliasBuffer,
            [In] uint AliasBufferLength,
            [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpExeName
        );

        #endregion

        // @

        #region GetConsoleAliasesLength (Unicode - LPWStr) => uint

        /// <summary>
        /// Retrieves the required size for the buffer used by the "GetConsoleAliases" function.
        /// </summary>
        /// 
        /// <param name="lpExeName">
        /// The name of the executable file whose console aliases are to be retrieved.
        /// </param>
        /// 
        /// <returns>
        /// The size of the buffer required to store all console aliases defined for this
        /// executable file, in bytes.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleAliasesLength", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern uint GetConsoleAliasesLength(
            [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpExeName
        );

        #endregion

        // @

        #region GetConsoleAliasExes (Unicode - LPWStr) => uint

        /// <summary>
        /// Retrieves the names of all executable files with console aliases defined.
        /// </summary>
        /// 
        /// <param name="lpExeNameBuffer">
        /// A pointer to a buffer that receives the names of the executable files.
        /// </param>
        /// <param name="ExeNameBufferLength">
        /// The size of the buffer pointed to by "lpExeNameBuffer", in bytes.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleAliasExes", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern uint GetConsoleAliasExes(
            [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder lpExeNameBuffer,
            [In] uint ExeNameBufferLength
        );

        #endregion

        // @

        #region GetConsoleAliasExesLength => uint

        /// <summary>
        /// Retrieves the required size for the buffer used by the "GetConsoleAliasExes" function.
        /// </summary>
        /// 
        /// <returns>
        /// The size of the buffer required to store the names of all executable files that
        /// have console aliases defined, in bytes.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleAliasExesLength", SetLastError = true)]
        public static extern uint GetConsoleAliasExesLength();

        #endregion

        // @

        #region GetConsoleCP => uint

        /// <summary>
        /// Retrieves the input code page used by the console associated with the calling
        /// process. A console uses its input code page to translate keyboard input into the
        /// corresponding character value.
        /// </summary>
        /// 
        /// <returns>
        /// The return value is a code that identifies the code page. If the return value is
        /// zero, the function has failed. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleCP", SetLastError = true)]
        public static extern uint GetConsoleCP();

        #endregion

        // @

        #region GetConsoleCursorInfo => bool

        /// <summary>
        /// Retrieves information about the size and visibility of the cursor for the specified
        /// console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpConsoleCursorInfo">
        /// A pointer to a "CONSOLE_CURSOR_INFO" structure that receives information about the
        /// console's cursor.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleCursorInfo", SetLastError = true)]
        public static extern bool GetConsoleCursorInfo(
            [In] IntPtr hConsoleOutput,
            [Out] out CONSOLE_CURSOR_INFO lpConsoleCursorInfo
        );

        #endregion

        // @

        #region GetConsoleDisplayMode => bool

        /// <summary>
        /// Retrieves the display mode of the current console.
        /// </summary>
        /// 
        /// <param name="lpModeFlags">
        /// The display mode of the console. This parameter can be set by one of the values ​​in
        /// the "CONSOLE_DISPLAY_MODE" enumeration.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleDisplayMode", SetLastError = true)]
        public static extern bool GetConsoleDisplayMode(
            [Out] out CONSOLE_DISPLAY_MODE lpModeFlags
        );

        #endregion

        // @

        #region GetConsoleFontSize => COORD

        /// <summary>
        /// Retrieves the size of the font used by the specified console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="nFont">
        /// The index of the font whose size is to be retrieved. This index is obtained by
        /// calling the "GetCurrentConsoleFont" function.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is a "COORD" structure that contains the
        /// width and height of each character in the font, in logical units. The "X" member
        /// contains the width, while the "Y" member contains the height. If the function fails,
        /// the width and the height are zero.To get extended error information, call
        /// "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleFontSize", SetLastError = true)]
        public static extern COORD GetConsoleFontSize(
            [In] IntPtr hConsoleOutput,
            [In] uint nFont
        );

        #endregion

        // @

        #region GetConsoleHistoryInfo => bool

        /// <summary>
        /// Retrieves the history settings for the calling process's console.
        /// </summary>
        /// 
        /// <param name="lpConsoleHistoryInfo">
        /// A pointer to a "CONSOLE_HISTORY_INFO" structure that receives the history settings
        /// for the calling process's console.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleHistoryInfo", SetLastError = true)]
        public static extern bool GetConsoleHistoryInfo(
            [Out] out CONSOLE_HISTORY_INFO lpConsoleHistoryInfo
        );

        #endregion

        // @

        #region GetConsoleMode => bool

        /// <summary>
        /// Retrieves the current input mode of a console's input buffer or the current output
        /// mode of a console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleHandle">
        /// A handle to the console input buffer or the console screen buffer. The handle must
        /// have the "GENERIC_READ" access right.
        /// </param>
        /// <param name="lpMode">
        /// A pointer to a variable that receives the current mode of the specified buffer. If
        /// the "hConsoleHandle" parameter is an input handle, the mode can be one or more
        /// values ​​from the "CONSOLE_MODE" enumeration. When a console is created, all input
        /// modes except "ENABLE_WINDOW_INPUT" and "ENABLE_VIRTUAL_TERMINAL_INPUT" are enabled
        /// by default. If the "hConsoleHandle" parameter is a screen buffer handle, the mode
        /// can be one or more values ​​from the "CONSOLE_MODE" enumeration. When a screen buffer
        /// is created, both output modes are enabled by default.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleMode", SetLastError = true)]
        public static extern bool GetConsoleMode(
            [In] IntPtr hConsoleHandle,
            [Out] out CONSOLE_MODE lpMode
        );

        #endregion

        // @

        #region GetConsoleOriginalTitle (Unicode - LPWStr) => uint

        /// <summary>
        /// Retrieves the original title for the current console window.
        /// </summary>
        /// 
        /// <param name="lpConsoleTitle">
        /// A pointer to a buffer that receives a null-terminated string containing the
        /// original title.
        /// </param>
        /// <param name="nSize">
        /// The size of the "lpConsoleTitle" buffer, in characters.
        /// </param>
        /// 
        /// <returns>
        /// If "nSize" is zero, the return value is zero. If the function succeeds, the return
        /// value is the length of the original console title, in characters. If the function
        /// fails, the return value is zero and "GetLastError" returns the error code.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleOriginalTitle", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern uint GetConsoleOriginalTitle(
            [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder lpConsoleTitle,
            [In] uint nSize
        );

        #endregion

        // @

        #region GetConsoleOutputCP => uint

        /// <summary>
        /// Retrieves the output code page used by the console associated with the calling
        /// process. A console uses its output code page to translate the character values
        /// written by the various output functions into the images displayed in the
        /// console window.
        /// </summary>
        /// 
        /// <returns>
        /// The return value is a code that identifies the code page. If the return value is
        /// zero, the function has failed. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleOutputCP", SetLastError = true)]
        public static extern uint GetConsoleOutputCP();

        #endregion

        // @

        #region GetConsoleProcessList => uint

        /// <summary>
        /// Retrieves a list of the processes attached to the current console.
        /// </summary>
        /// 
        /// <param name="lpdwProcessList">
        /// A pointer to a buffer that receives an array of process identifiers upon success.
        /// This must be a valid buffer and cannot be "NULL". The buffer must have space to
        /// receive at least "1" returned process id.
        /// </param>
        /// <param name="dwProcessCount">
        /// The maximum number of process identifiers that can be stored in the "lpdwProcessList"
        /// buffer. This must be greater than "0".
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is less than or equal to "dwProcessCount"
        /// and represents the number of process identifiers stored in the "lpdwProcessList"
        /// buffer. If the buffer is too small to hold all the valid process identifiers, the
        /// return value is the required number of array elements. The function will have stored
        /// no identifiers in the buffer. In this situation, use the return value to allocate a
        /// buffer that is large enough to store the entire list and call the function again. If
        /// the return value is zero, the function has failed, because every console has at least
        /// one process associated with it.To get extended error information, call
        /// "GetLastError". If a "NULL" process list was provided or the process count was "0",
        /// the call will return "0" and "GetLastError" will return
        /// "ERROR_INVALID_PARAMETER (87)". Please provide a buffer of at least one element to
        /// call this function. Allocate a larger buffer and call again if the return code is
        /// larger than the length of the provided buffer.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleProcessList", SetLastError = true)]
        public static extern uint GetConsoleProcessList(
        [Out] out IntPtr[] lpdwProcessList,
            [In] uint dwProcessCount
        );

        #endregion

        // @

        #region GetConsoleScreenBufferInfo => bool

        /// <summary>
        /// Retrieves information about the specified console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpConsoleScreenBufferInfo">
        /// A pointer to a "CONSOLE_SCREEN_BUFFER_INFO" structure that receives the console
        /// screen buffer information.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleScreenBufferInfo", SetLastError = true)]
        public static extern bool GetConsoleScreenBufferInfo(
            [In] IntPtr hConsoleOutput,
            [Out] out CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo
        );

        #endregion

        // @

        #region GetConsoleScreenBufferInfoEx => bool

        /// <summary>
        /// Retrieves extended information about the specified console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpConsoleScreenBufferInfoEx">
        /// A "CONSOLE_SCREEN_BUFFER_INFOEX" structure that receives the requested console
        /// screen buffer information.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleScreenBufferInfoEx", SetLastError = true)]
        public static extern bool GetConsoleScreenBufferInfoEx(
            [In] IntPtr hConsoleOutput,
            [Out] out CONSOLE_SCREEN_BUFFER_INFOEX lpConsoleScreenBufferInfoEx
        );

        #endregion

        // @

        #region GetConsoleSelectionInfo => bool

        /// <summary>
        /// Retrieves information about the current console selection.
        /// </summary>
        /// 
        /// <param name="lpConsoleSelectionInfo">
        /// A pointer to a "CONSOLE_SELECTION_INFO" structure that receives the
        /// selection information.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleSelectionInfo", SetLastError = true)]
        public static extern bool GetConsoleSelectionInfo(
            [Out] out CONSOLE_SELECTION_INFO lpConsoleSelectionInfo
        );

        #endregion

        // @

        #region GetConsoleTitle (Unicode - LPWStr) => bool

        /// <summary>
        /// Retrieves the title for the current console window.
        /// </summary>
        /// 
        /// <param name="lpConsoleTitle">
        /// A pointer to a buffer that receives a null-terminated string containing the title.
        /// If the buffer is too small to store the title, the function stores as many
        /// characters of the title as will fit in the buffer, ending with a null terminator.
        /// </param>
        /// <param name="nSize">
        /// The size of the buffer pointed to by the "lpConsoleTitle" parameter, in characters.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is the length of the console window's
        /// title, in characters. If the function fails, the return value is zero and
        /// "GetLastError" returns the error code.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleTitle", SetLastError = true)]
        public static extern bool GetConsoleTitle(
            [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder lpConsoleTitle,
            [In] uint nSize
        );

        #endregion

        // @

        #region GetConsoleWindow => IntPtr

        /// <summary>
        /// Retrieves the window handle used by the console associated with the calling process.
        /// </summary>
        /// 
        /// <returns>
        /// The return value is a handle to the window used by the console associated with the
        /// calling process or "NULL" if there is no such associated console.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetConsoleWindow", SetLastError = true)]
        public static extern IntPtr GetConsoleWindow();

        #endregion

        // @

        #region GetCurrentConsoleFont => bool

        /// <summary>
        /// Retrieves information about the current console font.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="bMaximumWindow">
        /// If this parameter is "TRUE", font information is retrieved for the maximum window
        /// size. If this parameter is "FALSE", font information is retrieved for the current
        /// window size.
        /// </param>
        /// <param name="lpConsoleCurrentFont">
        /// A pointer to a "CONSOLE_FONT_INFO" structure that receives the requested font
        /// information.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetCurrentConsoleFont", SetLastError = true)]
        public static extern bool GetCurrentConsoleFont(
            [In] IntPtr hConsoleOutput,
            [In] bool bMaximumWindow,
            [Out] out CONSOLE_FONT_INFO lpConsoleCurrentFont
        );

        #endregion

        // @

        #region GetCurrentConsoleFontEx => bool

        /// <summary>
        /// Retrieves extended information about the current console font.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="bMaximumWindow">
        /// If this parameter is "TRUE", font information is retrieved for the maximum window
        /// size. If this parameter is "FALSE", font information is retrieved for the current
        /// window size.
        /// </param>
        /// <param name="lpConsoleCurrentFontEx">
        /// A pointer to a "CONSOLE_FONT_INFOEX" structure that receives the requested font
        /// information.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetCurrentConsoleFontEx", SetLastError = true)]
        public static extern bool GetCurrentConsoleFontEx(
            [In] IntPtr hConsoleOutput,
            [In] bool bMaximumWindow,
            [Out] out CONSOLE_FONT_INFOEX lpConsoleCurrentFontEx
        );

        #endregion

        // @

        #region GetLargestConsoleWindowSize => COORD

        /// <summary>
        /// Retrieves the size of the largest possible console window, based on the current font
        /// and the size of the display.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is a "COORD" structure that specifies the
        /// number of character cell columns ("X" member) and rows ("Y" member) in the largest
        /// possible console window. Otherwise, the members of the structure are zero. To get
        /// extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetLargestConsoleWindowSize", SetLastError = true)]
        public static extern COORD GetLargestConsoleWindowSize(
            [In] IntPtr hConsoleOutput
        );

        #endregion

        // @

        #region GetNumberOfConsoleInputEvents => bool

        /// <summary>
        /// Retrieves the number of unread input records in the console's input buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleInput">
        /// A handle to the console input buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpcNumberOfEvents">
        /// A pointer to a variable that receives the number of unread input records in the
        /// console's input buffer.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetNumberOfConsoleInputEvents", SetLastError = true)]
        public static extern bool GetNumberOfConsoleInputEvents(
            [In] IntPtr hConsoleInput,
            [Out] out uint lpcNumberOfEvents
        );

        #endregion

        // @

        #region GetNumberOfConsoleMouseButtons => bool

        /// <summary>
        /// Retrieves the number of buttons on the mouse used by the current console.
        /// </summary>
        /// 
        /// <param name="lpNumberOfMouseButtons">
        /// A pointer to a variable that receives the number of mouse buttons.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetNumberOfConsoleMouseButtons", SetLastError = true)]
        public static extern bool GetNumberOfConsoleMouseButtons(
            [Out] out uint lpNumberOfMouseButtons
        );

        #endregion

        // @

        #region GetStdHandle => IntPtr

        /// <summary>
        /// Retrieves a handle to the specified standard device (standard input, standard
        /// output, or standard error).
        /// </summary>
        /// 
        /// <param name="nStdHandle">
        /// The standard device. This parameter can be set by one of the values ​​in the
        /// "CONSOLE_STANDARD_DEVICE" enumeration.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is a handle to the specified device, or
        /// a redirected handle set by a previous call to SetStdHandle. The handle has
        /// "GENERIC_READ" and "GENERIC_WRITE" access rights, unless the application has used
        /// "SetStdHandle" to set a standard handle with lesser access.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "GetStdHandle", SetLastError = true)]
        public static extern IntPtr GetStdHandle(
            [In] CONSOLE_STANDARD_DEVICE nStdHandle
        );

        #endregion

        // @

        #region HandlerRoutine (delegate) => bool

        /// <summary>
        /// An application-defined function used with the "SetConsoleCtrlHandler" function.
        /// A console process uses this function to handle control signals received by the
        /// process. When the signal is received, the system creates a new thread in the
        /// process to execute the function. The "PHANDLER_ROUTINE" type defines a pointer to
        /// this callback function. "HandlerRoutine" is a placeholder for the
        /// application-defined function name.
        /// </summary>
        /// 
        /// <param name="dwCtrlType">
        /// The type of control signal received by the handler. This parameter can be defined
        /// by one of the values ​​in the "CTRL_EVENT" enumeration.
        /// </param>
        /// 
        /// <returns>
        /// If the function handles the control signal, it should return "TRUE". If it returns
        /// "FALSE", the next handler function in the list of handlers for this process is used.
        /// </returns>
        public delegate bool HandlerRoutine(
            [In] CTRL_EVENT dwCtrlType
        );

        #endregion

        // @

        #region PeekConsoleInput => bool

        /// <summary>
        /// Reads data from the specified console input buffer without removing it from
        /// the buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleInput">
        /// A handle to the console input buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpBuffer">
        /// A pointer to an array of "INPUT_RECORD" structures that receives the input
        /// buffer data.
        /// </param>
        /// <param name="nLength">
        /// The size of the array pointed to by the "lpBuffer" parameter, in array elements.
        /// </param>
        /// <param name="lpNumberOfEventsRead">
        /// A pointer to a variable that receives the number of input records read.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "PeekConsoleInput", SetLastError = true)]
        public static extern bool PeekConsoleInput(
            [In] IntPtr hConsoleInput,
            [Out] out INPUT_RECORD lpBuffer,
            [In] uint nLength,
            [Out] out uint lpNumberOfEventsRead
        );

        #endregion

        // @

        #region ReadConsole => bool

        /// <summary>
        /// Reads character input from the console input buffer and removes it from the buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleInput">
        /// A handle to the console input buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpBuffer">
        /// A pointer to a buffer that receives the data read from the console input buffer.
        /// </param>
        /// <param name="nNumberOfCharsToRead">
        /// The number of characters to be read. The size of the buffer pointed to by the
        /// "lpBuffer" parameter should be at least "nNumberOfCharsToRead * sizeof(char)" bytes.
        /// </param>
        /// <param name="lpNumberOfCharsRead">
        /// A pointer to a variable that receives the number of characters actually read.
        /// </param>
        /// <param name="pInputControl">
        /// A pointer to a "CONSOLE_READCONSOLE_CONTROL" structure that specifies a control
        /// character to signal the end of the read operation. This parameter can be "NULL".
        /// This parameter requires Unicode input by default. For ANSI mode, set this parameter
        /// to "NULL".
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "ReadConsole", SetLastError = true)]
        public static extern bool ReadConsole(
            [In] IntPtr hConsoleInput,
            [Out] out byte[] lpBuffer,
            [In] uint nNumberOfCharsToRead,
            [Out] out uint lpNumberOfCharsRead,
            [In] ref CONSOLE_READCONSOLE_CONTROL pInputControl
        );

        #endregion

        // @

        #region ReadConsoleInput => bool

        /// <summary>
        /// Reads data from a console input buffer and removes it from the buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleInput">
        /// A handle to the console input buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpBuffer">
        /// A pointer to an array of "INPUT_RECORD" structures that receives the input
        /// buffer data.
        /// </param>
        /// <param name="nLength">
        /// The size of the array pointed to by the "lpBuffer" parameter, in array elements.
        /// </param>
        /// <param name="lpNumberOfEventsRead">
        /// A pointer to a variable that receives the number of input records read.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "ReadConsoleInput", SetLastError = true)]
        public static extern bool ReadConsoleInput(
            [In] IntPtr hConsoleInput,
            [Out] out INPUT_RECORD lpBuffer,
            [In] uint nLength,
            [Out] out uint lpNumberOfEventsRead
        );

        #endregion

        // @

        #region ReadConsoleInputEx => bool

        /// <summary>
        /// Reads data from a console input buffer and removes it from the buffer, with
        /// configurable behavior.
        /// </summary>
        /// 
        /// <param name="hConsoleInput">
        /// A handle to the console input buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpBuffer">
        /// A pointer to an array of "INPUT_RECORD" structures that receives the input
        /// buffer data.
        /// </param>
        /// <param name="nLength">
        /// The size of the array pointed to by the "lpBuffer" parameter, in array elements.
        /// </param>
        /// <param name="lpNumberOfEventsRead">
        /// A pointer to a variable that receives the number of input records read.
        /// </param>
        /// <param name="wFlags">
        /// A set of flags (ORed together) that specify the console's reading behavior.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "ReadConsoleInputEx", SetLastError = true)]
        public static extern bool ReadConsoleInputEx(
            [In] IntPtr hConsoleInput,
            [Out] out INPUT_RECORD lpBuffer,
            [In] uint nLength,
            [Out] out uint lpNumberOfEventsRead,
            [In] CONSOLE_READING_BEHAVIOR wFlags
        );

        #endregion

        // @

        #region ReadConsoleOutput => bool

        /// <summary>
        /// Reads character and color attribute data from a rectangular block of character
        /// cells in a console screen buffer, and the function writes the data to a rectangular
        /// block at a specified location in the destination buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpBuffer">
        /// A pointer to a destination buffer that receives the data read from the console
        /// screen buffer. This pointer is treated as the origin of a two-dimensional array of
        /// "CHAR_INFO" structures whose size is specified by the "dwBufferSize" parameter.
        /// </param>
        /// <param name="dwBufferSize">
        /// The size of the "lpBuffer" parameter, in character cells. The "X" member of the
        /// "COORD" structure is the number of columns; the "Y" member is the number of rows.
        /// </param>
        /// <param name="dwBufferCoord">
        /// The coordinates of the upper-left cell in the lpBuffer parameter that receives the
        /// data read from the console screen buffer. The "X" member of the "COORD" structure
        /// is the column, and the "Y" member is the row.
        /// </param>
        /// <param name="lpReadRegion">
        /// A pointer to a "SMALL_RECT" structure. On input, the structure members specify the
        /// upper-left and lower-right coordinates of the console screen buffer rectangle from
        /// which the function is to read. On output, the structure members specify the actual
        /// rectangle that was used.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "ReadConsoleOutput", SetLastError = true)]
        public static extern bool ReadConsoleOutput(
            [In] IntPtr hConsoleOutput,
            [Out] out CHAR_INFO lpBuffer,
            [In] COORD dwBufferSize,
            [In] COORD dwBufferCoord,
            [In, Out] ref SMALL_RECT lpReadRegion
        );

        #endregion

        // @

        #region ReadConsoleOutputAttribute => bool

        /// <summary>
        /// Copies a specified number of character attributes from consecutive cells of a
        /// console screen buffer, beginning at a specified location.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpAttribute">
        /// A pointer to a buffer that receives the attributes being used by the console screen buffer.
        /// </param>
        /// <param name="nLength">
        /// The number of screen buffer character cells from which to read. The size of the
        /// buffer pointed to by the "lpAttribute" parameter should be "nLength * sizeof(ushort)".
        /// </param>
        /// <param name="dwReadCoord">
        /// The coordinates of the first cell in the console screen buffer from which to read,
        /// in characters. The "X" member of the "COORD" structure is the column, and the "Y"
        /// member is the row.
        /// </param>
        /// <param name="lpNumberOfAttrsRead">
        /// A pointer to a variable that receives the number of attributes actually read.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "ReadConsoleOutputAttribute", SetLastError = true)]
        public static extern bool ReadConsoleOutputAttribute(
            [In] IntPtr hConsoleOutput,
            [Out] out CHAR_ATTRIBUTES lpAttribute,
            [In] uint nLength,
            [In] COORD dwReadCoord,
            [Out] out uint lpNumberOfAttrsRead
        );

        #endregion

        // @

        #region ReadConsoleOutputCharacter (Unicode or ANSI - LPTStr) => bool

        /// <summary>
        /// Copies a number of characters from consecutive cells of a console screen buffer,
        /// beginning at a specified location.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpCharacter">
        /// A pointer to a buffer that receives the characters read from the console
        /// screen buffer.
        /// </param>
        /// <param name="nLength">
        /// The number of screen buffer character cells from which to read. The size of the
        /// buffer pointed to by the "lpCharacter" parameter should be "nLength * sizeof(char)".
        /// </param>
        /// <param name="dwReadCoord">
        /// The coordinates of the first cell in the console screen buffer from which to read,
        /// in characters. The "X" member of the "COORD" structure is the column, and the "Y"
        /// member is the row.
        /// </param>
        /// <param name="lpNumberOfCharsRead">
        /// A pointer to a variable that receives the number of characters actually read.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "ReadConsoleOutputCharacter", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ReadConsoleOutputCharacter(
            [In] IntPtr hConsoleOutput,
            [Out, MarshalAs(UnmanagedType.LPTStr)] out StringBuilder lpCharacter,
            [In] uint nLength,
            [In] COORD dwReadCoord,
            [Out] out uint lpNumberOfCharsRead
        );

        #endregion

        // @

        #region ResizePseudoConsole => HRESULT

        /// <summary>
        /// Resizes the internal buffers for a pseudo console to the given size.
        /// </summary>
        /// 
        /// <param name="hPC">
        /// A handle to an active pseudo console as opened by "CreatePseudoConsole".
        /// </param>
        /// <param name="size">
        /// The dimensions of the window/buffer in count of characters that will be used for
        /// the internal buffer of this pseudo console.
        /// </param>
        /// 
        /// <returns>
        /// If this method succeeds, it returns "S_OK". Otherwise, it returns an "HRESULT"
        /// error code.
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "ResizePseudoConsole", SetLastError = true)]
        public static extern HRESULT ResizePseudoConsole(
            [In] IntPtr hPC,
            [In] COORD size
        );

        #endregion

        // @

        #region ScrollConsoleScreenBuffer => bool

        /// <summary>
        /// Moves a block of data in a screen buffer. The effects of the move can be limited by
        /// specifying a clipping rectangle, so the contents of the console screen buffer
        /// outside the clipping rectangle are unchanged.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpScrollRectangle">
        /// A pointer to a "SMALL_RECT" structure whose members specify the upper-left and
        /// lower-right coordinates of the console screen buffer rectangle to be moved.
        /// </param>
        /// <param name="lpClipRectangle">
        /// A pointer to a "SMALL_RECT" structure whose members specify the upper-left and
        /// lower-right coordinates of the console screen buffer rectangle that is affected by
        /// the scrolling. This pointer can be "NULL".
        /// </param>
        /// <param name="dwDestinationOrigin">
        /// A "COORD" structure that specifies the upper-left corner of the new location of the
        /// "lpScrollRectangle" contents, in characters.
        /// </param>
        /// <param name="lpFill">
        /// A pointer to a "CHAR_INFO" structure that specifies the character and color
        /// attributes to be used in filling the cells within the intersection of
        /// "lpScrollRectangle" and "lpClipRectangle" that were left empty as a result of the move.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "ScrollConsoleScreenBuffer", SetLastError = true)]
        public static extern bool ScrollConsoleScreenBuffer(
            [In] IntPtr hConsoleOutput,
            [In] ref SMALL_RECT lpScrollRectangle,
            [In] ref SMALL_RECT lpClipRectangle,
            [In] COORD dwDestinationOrigin,
            [In] ref CHAR_INFO lpFill
        );

        #endregion

        // @

        #region SetConsoleActiveScreenBuffer => bool

        /// <summary>
        /// Sets the specified screen buffer to be the currently displayed console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleActiveScreenBuffer", SetLastError = true)]
        public static extern bool SetConsoleActiveScreenBuffer(
            [In] IntPtr hConsoleOutput
        );

        #endregion

        // @

        #region SetConsoleCP => bool

        /// <summary>
        /// Sets the input code page used by the console associated with the calling process. A
        /// console uses its input code page to translate keyboard input into the corresponding
        /// character value.
        /// </summary>
        /// 
        /// <param name="wCodePageID">
        /// The identifier of the code page to be set.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleCP", SetLastError = true)]
        public static extern bool SetConsoleCP(
            [In] uint wCodePageID
        );

        #endregion

        // @

        #region SetConsoleCtrlHandler => bool

        /// <summary>
        /// Adds or removes an application-defined "HandlerRoutine" function from the list of
        /// handler functions for the calling process. If no handler function is specified, the
        /// function sets an inheritable attribute that determines whether the calling process
        /// ignores "CTRL + C" signals.
        /// </summary>
        /// 
        /// <param name="HandlerRoutine">
        /// A pointer to the application-defined "HandlerRoutine" function to be added or
        /// removed. This parameter can be "NULL".
        /// </param>
        /// <param name="Add">
        /// If this parameter is "TRUE", the handler is added; if it is "FALSE", the handler is
        /// removed. If the "HandlerRoutine" parameter is "NULL", a "TRUE" value causes the
        /// calling process to ignore "CTRL + C" input, and a "FALSE" value restores normal
        /// processing of "CTRL + C" input. This attribute of ignoring or processing "CTRL + C"
        /// is inherited by child processes.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleCtrlHandler", SetLastError = true)]
        public static extern bool SetConsoleCtrlHandler(
            [In] HandlerRoutine HandlerRoutine,
            [In] bool Add
        );

        #endregion

        // @

        #region SetConsoleCursorInfo => bool

        /// <summary>
        /// Sets the size and visibility of the cursor for the specified console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="lpConsoleCursorInfo">
        /// A pointer to a "CONSOLE_CURSOR_INFO" structure that provides the new specifications
        /// for the console screen buffer's cursor.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleCursorInfo", SetLastError = true)]
        public static extern bool SetConsoleCursorInfo(
            [In] IntPtr hConsoleOutput,
            [In] ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo
        );

        #endregion

        // @

        #region SetConsoleCursorPosition => bool

        /// <summary>
        /// Sets the cursor position in the specified console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="dwCursorPosition">
        /// A "COORD" structure that specifies the new cursor position, in characters. The
        /// coordinates are the column and row of a screen buffer character cell. The
        /// coordinates must be within the boundaries of the console screen buffer.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleCursorPosition", SetLastError = true)]
        public static extern bool SetConsoleCursorPosition(
            [In] IntPtr hConsoleOutput,
            [In] COORD dwCursorPosition
        );

        #endregion

        // @

        #region SetConsoleDisplayMode => bool

        /// <summary>
        /// Sets the display mode of the specified console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer.
        /// </param>
        /// <param name="dwFlags">
        /// The display mode of the console. This parameter can be defined by one or more
        /// values ​​from the "CONSOLE_DISPLAY_MODE" enumeration.
        /// </param>
        /// <param name="lpNewScreenBufferDimensions">
        /// A pointer to a "COORD" structure that receives the new dimensions of the screen
        /// buffer, in characters.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleDisplayMode", SetLastError = true)]
        public static extern bool SetConsoleDisplayMode(
            [In] IntPtr hConsoleOutput,
            [In] CONSOLE_DISPLAY_MODE dwFlags,
            [Out] out COORD lpNewScreenBufferDimensions
        );

        #endregion

        // @

        #region SetConsoleHistoryInfo => bool

        /// <summary>
        /// Sets the history settings for the calling process's console.
        /// </summary>
        /// 
        /// <param name="lpConsoleHistoryInfo">
        /// A pointer to a "CONSOLE_HISTORY_INFO" structure that contains the history settings
        /// for the process's console.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleHistoryInfo", SetLastError = true)]
        public static extern bool SetConsoleHistoryInfo(
            [In] CONSOLE_HISTORY_INFO lpConsoleHistoryInfo
        );

        #endregion

        // @

        #region SetConsoleMode => bool

        /// <summary>
        /// Sets the input mode of a console's input buffer or the output mode of a console
        /// screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleHandle">
        /// A handle to the console input buffer or a console screen buffer. The handle must
        /// have the "GENERIC_READ" access right.
        /// </param>
        /// <param name="dwMode">
        /// The input or output mode to be set. If the "hConsoleHandle" parameter is an input
        /// handle, the mode can be one or more of the values ​​in the "CONSOLE_MODE" enumeration.
        /// When a console is created, all input modes except "ENABLE_WINDOW_INPUT" and
        /// "ENABLE_VIRTUAL_TERMINAL_INPUT" are enabled by default. If the "hConsoleHandle"
        /// parameter is a screen buffer handle, the mode can be one or more of the values ​​in
        /// the "CONSOLE_MODE" enumeration. When a screen buffer is created, both output modes
        /// are enabled by default.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleMode", SetLastError = true)]
        public static extern bool SetConsoleMode(
            [In] IntPtr hConsoleHandle,
            [In] CONSOLE_MODE dwMode
        );

        #endregion

        // @

        #region SetConsoleOutputCP => bool

        /// <summary>
        /// Sets the output code page used by the console associated with the calling process.
        /// A console uses its output code page to translate the character values written by
        /// the various output functions into the images displayed in the console window.
        /// </summary>
        /// 
        /// <param name="wCodePageID">
        /// The identifier of the code page to set.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleOutputCP", SetLastError = true)]
        public static extern bool SetConsoleOutputCP(
            [In] uint wCodePageID
        );

        #endregion

        // @

        #region SetConsoleScreenBufferInfoEx => bool

        /// <summary>
        /// Sets extended information about the specified console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// <param name="lpConsoleScreenBufferInfoEx">
        /// A "CONSOLE_SCREEN_BUFFER_INFOEX" structure that contains the console screen
        /// buffer information.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleScreenBufferInfoEx", SetLastError = true)]
        public static extern bool SetConsoleScreenBufferInfoEx(
            [In] IntPtr hConsoleOutput,
            [In] CONSOLE_SCREEN_BUFFER_INFOEX lpConsoleScreenBufferInfoEx
        );

        #endregion

        // @

        #region SetConsoleScreenBufferSize => bool

        /// <summary>
        /// Changes the size of the specified console screen buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="dwSize">
        /// A "COORD" structure that specifies the new size of the console screen buffer, in
        /// character rows and columns. The specified width and height cannot be less than the
        /// width and height of the console screen buffer's window. The specified dimensions
        /// also cannot be less than the minimum size allowed by the system. This minimum
        /// depends on the current font size for the console (selected by the user) and the
        /// "SM_CXMIN" and "SM_CYMIN" values returned by the "GetSystemMetrics" function.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleScreenBufferSize", SetLastError = true)]
        public static extern bool SetConsoleScreenBufferSize(
            [In] IntPtr hConsoleOutput,
            [In] COORD dwSize
        );

        #endregion

        // @

        #region SetConsoleTextAttribute => bool

        /// <summary>
        /// Sets the attributes of characters written to the console screen buffer by the
        /// "WriteFile" or "WriteConsole" function, or echoed by the "ReadFile" or "ReadConsole"
        /// function. This function affects text written after the function call.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="wAttributes">
        /// The character attributes. This member can be zero or a combination of
        /// values ​​from the "CHAR_ATTRIBUTES" enumeration.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleTextAttribute", SetLastError = true)]
        public static extern bool SetConsoleTextAttribute(
            [In] IntPtr hConsoleOutput,
            [In] CHAR_ATTRIBUTES wAttributes
        );

        #endregion

        // @

        #region SetConsoleTitle (Unicode - LPWStr) => bool

        /// <summary>
        /// Sets the title for the current console window.
        /// </summary>
        /// 
        /// <param name="lpConsoleTitle">
        /// The string to be displayed in the title bar of the console window. The total size
        /// must be less than 64K.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleTitle", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool SetConsoleTitle(
            [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpConsoleTitle
        );

        #endregion

        // @

        #region SetConsoleWindowInfo => bool

        /// <summary>
        /// Sets the current size and position of a console screen buffer's window.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_READ"
        /// access right.
        /// </param>
        /// <param name="bAbsolute">
        /// If this parameter is "TRUE", the coordinates specify the new upper-left and
        /// lower-right corners of the window. If it is "FALSE", the coordinates are relative
        /// to the current window-corner coordinates.
        /// </param>
        /// <param name="lpConsoleWindow">
        /// A pointer to a "SMALL_RECT" structure that specifies the new upper-left and
        /// lower-right corners of the window.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetConsoleWindowInfo", SetLastError = true)]
        public static extern bool SetConsoleWindowInfo(
            [In] IntPtr hConsoleOutput,
            [In] bool bAbsolute,
            [In] ref SMALL_RECT lpConsoleWindow
        );

        #endregion

        // @

        #region SetCurrentConsoleFontEx => bool

        /// <summary>
        /// Sets extended information about the current console font.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// <param name="bMaximumWindow">
        /// If this parameter is "TRUE", font information is set for the maximum window size.
        /// If this parameter is "FALSE", font information is set for the current window size.
        /// </param>
        /// <param name="lpConsoleCurrentFontEx">
        /// A pointer to a "CONSOLE_FONT_INFOEX" structure that contains the font information.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetCurrentConsoleFontEx", SetLastError = true)]
        public static extern bool SetCurrentConsoleFontEx(
            [In] IntPtr hConsoleOutput,
            [In] bool bMaximumWindow,
            [In] ref CONSOLE_FONT_INFOEX lpConsoleCurrentFontEx
        );

        #endregion

        // @

        #region SetStdHandle => bool

        /// <summary>
        /// Sets the handle for the specified standard device (standard input, standard output,
        /// or standard error).
        /// </summary>
        /// 
        /// <param name="nStdHandle">
        /// The standard device for which the handle is to be set. This parameter can be set by
        /// one of the values ​​in the "CONSOLE_STANDARD_DEVICE" enumeration.
        /// </param>
        /// <param name="hHandle">
        /// The handle for the standard device.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "SetStdHandle", SetLastError = true)]
        public static extern bool SetStdHandle(
            [In] CONSOLE_STANDARD_DEVICE nStdHandle,
            [In] IntPtr hHandle
        );

        #endregion

        // @

        #region WriteConsole (Unicode or ANSI - LPTStr) => bool

        /// <summary>
        /// Writes a character string to a console screen buffer beginning at the current
        /// cursor location.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// <param name="lpBuffer">
        /// A pointer to a buffer that contains characters to be written to the console
        /// screen buffer.
        /// </param>
        /// <param name="nNumberOfCharsToWrite">
        /// The number of characters to be written. If the total size of the specified number
        /// of characters exceeds the available heap, the function fails with
        /// "ERROR_NOT_ENOUGH_MEMORY (8)".
        /// </param>
        /// <param name="lpNumberOfCharsWritten">
        /// A pointer to a variable that receives the number of characters actually written.
        /// </param>
        /// <param name="lpReserved">
        /// Reserved. Must be "NULL".
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "WriteConsole", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool WriteConsole(
            [In] IntPtr hConsoleOutput,
            [In, MarshalAs(UnmanagedType.LPTStr)] ref StringBuilder lpBuffer,
            [In] uint nNumberOfCharsToWrite,
            [Out] out uint lpNumberOfCharsWritten,
            [In] IntPtr lpReserved = default
        );

        #endregion

        // @

        #region WriteConsoleInput => bool

        /// <summary>
        /// Writes data directly to the console input buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleInput">
        /// A handle to the console input buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// <param name="lpBuffer">
        /// A pointer to an array of "INPUT_RECORD" structures that contain data to be written
        /// to the input buffer.
        /// </param>
        /// <param name="nLength">
        /// The number of input records to be written.
        /// </param>
        /// <param name="lpNumberOfEventsWritten">
        /// A pointer to a variable that receives the number of input records actually written.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "WriteConsoleInput", SetLastError = true)]
        public static extern bool WriteConsoleInput(
            [In] IntPtr hConsoleInput,
            [In] ref INPUT_RECORD lpBuffer,
            [In] uint nLength,
            [Out] out uint lpNumberOfEventsWritten
        );

        #endregion

        // @

        #region WriteConsoleOutput => bool

        /// <summary>
        /// Writes character and color attribute data to a specified rectangular block of
        /// character cells in a console screen buffer. The data to be written is taken from a
        /// correspondingly sized rectangular block at a specified location in the source buffer.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// <param name="lpBuffer">
        /// The data to be written to the console screen buffer. This pointer is treated as the
        /// origin of a two-dimensional array of "CHAR_INFO" structures whose size is specified
        /// by the "dwBufferSize" parameter.
        /// </param>
        /// <param name="dwBufferSize">
        /// The size of the buffer pointed to by the "lpBuffer" parameter, in character cells.
        /// The "X" member of the "COORD" structure is the number of columns; the "Y" member is
        /// the number of rows.
        /// </param>
        /// <param name="dwBufferCoord">
        /// The coordinates of the upper-left cell in the buffer pointed to by the "lpBuffer"
        /// parameter. The "X" member of the "COORD" structure is the column, and the "Y"
        /// member is the row.
        /// </param>
        /// <param name="lpWriteRegion">
        /// A pointer to a "SMALL_RECT" structure. On input, the structure members specify the
        /// upper-left and lower-right coordinates of the console screen buffer rectangle to
        /// write to. On output, the structure members specify the actual rectangle that was used.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "WriteConsoleOutput", SetLastError = true)]
        public static extern bool WriteConsoleOutput(
            [In] IntPtr hConsoleOutput,
            [In] ref CHAR_INFO[] lpBuffer,
            [In] COORD dwBufferSize,
            [In] COORD dwBufferCoord,
            [In, Out] ref SMALL_RECT lpWriteRegion
        );

        #endregion

        // @

        #region WriteConsoleOutputAttribute => bool

        /// <summary>
        /// Copies a number of character attributes to consecutive cells of a console screen
        /// buffer, beginning at a specified location.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// <param name="lpAttribute">
        /// The attributes to be used when writing to the console screen buffer. This member
        /// can be zero or a combination of values ​​from the "CHAR_ATTRIBUTES" enumeration.
        /// </param>
        /// <param name="Length">
        /// The number of screen buffer character cells to which the attributes will be copied.
        /// </param>
        /// <param name="dwWriteCoord">
        /// A "COORD" structure that specifies the character coordinates of the first cell in
        /// the console screen buffer to which the attributes will be written.
        /// </param>
        /// <param name="lpNumberOfAttrsWritten">
        /// A pointer to a variable that receives the number of attributes actually written to
        /// the console screen buffer.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "WriteConsoleOutputAttribute", SetLastError = true)]
        public static extern bool WriteConsoleOutputAttribute(
            [In] IntPtr hConsoleOutput,
            [In] ref CHAR_ATTRIBUTES lpAttribute,
            [In] uint Length,
            [In] COORD dwWriteCoord,
            [Out] out uint lpNumberOfAttrsWritten
        );

        #endregion

        // @

        #region WriteConsoleOutputCharacter => bool

        /// <summary>
        /// Copies a number of characters to consecutive cells of a console screen buffer,
        /// beginning at a specified location.
        /// </summary>
        /// 
        /// <param name="hConsoleOutput">
        /// A handle to the console screen buffer. The handle must have the "GENERIC_WRITE"
        /// access right.
        /// </param>
        /// <param name="lpCharacter">
        /// The characters to be written to the console screen buffer.
        /// </param>
        /// <param name="nLength">
        /// The number of characters to be written.
        /// </param>
        /// <param name="dwWriteCoord">
        /// A "COORD" structure that specifies the character coordinates of the first cell in
        /// the console screen buffer to which characters will be written.
        /// </param>
        /// <param name="lpNumberOfCharsWritten">
        /// A pointer to a variable that receives the number of characters actually written.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. If the function fails, the
        /// return value is zero. To get extended error information, call "GetLastError".
        /// </returns>
        [DllImport(DLL_NAME, EntryPoint = "WriteConsoleOutputCharacter", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool WriteConsoleOutputCharacter(
            [In] IntPtr hConsoleOutput,
            [In, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpCharacter,
            [In] uint nLength,
            [In] COORD dwWriteCoord,
            [Out] out uint lpNumberOfCharsWritten
        );

        #endregion
    }
}
