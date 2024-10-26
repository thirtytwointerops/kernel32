using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

using ThirtyTwo.Kernel32.Enumerations;
using ThirtyTwo.Kernel32.Structures;

namespace ThirtyTwo.Kernel32
{
  public static class Kernel
  {
    #region Public Constants

    public const string DLL_NAME = @"kernel32.dll";

    #endregion

    // @

    #region GetLastError => SystemErrorCodes

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetLastError"
    )]
    public static extern SystemErrorCodes GetLastError();

    #endregion

    // @

    #region GetLastErrorCode => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetLastError"
    )]
    public static extern uint GetLastErrorCode();

    #endregion

    // @

    #region AddConsoleAlias (Unicode - LPWStr) => bool

    [DllImport(
        DLL_NAME,
        EntryPoint = "AddConsoleAlias",
        CharSet = CharSet.Unicode,
        SetLastError = true
    )]
    public static extern bool AddConsoleAlias(
      [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder Source,
      [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder Target,
      [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder ExeName
    );

    #endregion

    // @

    #region AllocConsole => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "AllocConsole",
      SetLastError = true
    )]
    public static extern bool AllocConsole();

    #endregion

    // @

    #region AttachConsole => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "AttachConsole",
      SetLastError = true
    )]
    public static extern bool AttachConsole(
      [In] uint dwProcessId
    );

    #endregion

    // @

    #region ClosePseudoConsole => void

    [DllImport(
      DLL_NAME,
      EntryPoint = "ClosePseudoConsole",
      SetLastError = true
    )]
    public static extern void ClosePseudoConsole(
      [In] IntPtr hPC
    );

    #endregion

    // @

    #region CreatePseudoConsole => ResultHandle

    [DllImport(
      DLL_NAME,
      EntryPoint = "CreatePseudoConsole",
      SetLastError = true
    )]
    public static extern ResultHandle CreatePseudoConsole(
      [In] Coordinate size,
      [In] IntPtr hInput,
      [In] IntPtr hOutput,
      [In] PseudoConsoleCreationOption dwFlags,
      [Out] out IntPtr phPC
    );

    #endregion

    // @

    #region CreateConsoleScreenBuffer => SafeFileHandle

    [DllImport(
      DLL_NAME,
      EntryPoint = "CreateConsoleScreenBuffer",
      SetLastError = true
    )]
    public static extern SafeFileHandle CreateConsoleScreenBuffer(
      [In] AccessRights dwDesiredAccess,
      [In] ShareMode dwShareMode,
      [In] ref SecurityAttributes lpSecurityAttributes,
      [In] uint dwFlags,
      [In] IntPtr lpScreenBufferData = default
    );

    #endregion

    // @

    #region FillConsoleOutputAttribute => bool

    [DllImport(DLL_NAME, EntryPoint = "FillConsoleOutputAttribute", SetLastError = true)]
    public static extern bool FillConsoleOutputAttribute(
      [In] IntPtr hConsoleOutput,
      [In] CharacterAttributes wAttribute,
      [In] uint nLength,
      [In] Coordinate dwWriteCoord,
      [Out] out uint lpNumberOfAttrsWritten
    );

    #endregion

    // @

    #region FillConsoleOutputCharacter (Unicode - LPWStr) => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "FillConsoleOutputCharacter",
      CharSet = CharSet.Unicode,
      SetLastError = true
    )]
    public static extern bool FillConsoleOutputCharacter(
      [In] IntPtr hConsoleOutput,
      [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder cCharacter,
      [In] uint nLength,
      [In] Coordinate dwWriteCoord,
      [Out] out uint lpNumberOfCharsWritten
    );

    #endregion

    // @

    #region FlushConsoleInputBuffer => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "FlushConsoleInputBuffer",
      SetLastError = true
    )]
    public static extern bool FlushConsoleInputBuffer(
      [In] IntPtr hConsoleInput
    );

    #endregion

    // @

    #region FreeConsole => void

    [DllImport(
      DLL_NAME,
      EntryPoint = "FreeConsole",
      SetLastError = true
    )]
    public static extern void FreeConsole();

    #endregion

    // @

    #region GenerateConsoleCtrlEvent => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GenerateConsoleCtrlEvent",
      SetLastError = true
    )]
    public static extern bool GenerateConsoleCtrlEvent(
      [In] ControlEvent dwCtrlEvent,
      [In] uint dwProcessGroupId
    );

    #endregion

    // @

    #region GetConsoleAlias (Unicode - LPWStr) => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleAlias",
      CharSet = CharSet.Unicode,
      SetLastError = true
    )]
    public static extern uint GetConsoleAlias(
      [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpSource,
      [Out] out StringBuilder lpTargetBuffer,
      [In, MarshalAs(UnmanagedType.LPWStr)] uint TargetBufferLength,
      [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpExeName
    );

    #endregion

    // @

    #region GetConsoleAliases (Unicode - LPWStr) => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleAliases",
      CharSet = CharSet.Unicode,
      SetLastError = true
    )]
    public static extern uint GetConsoleAliases(
      [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder lpAliasBuffer,
      [In] uint AliasBufferLength,
      [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpExeName
    );

    #endregion

    // @

    #region GetConsoleAliasesLength (Unicode - LPWStr) => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleAliasesLength",
      CharSet = CharSet.Unicode,
      SetLastError = true
    )]
    public static extern uint GetConsoleAliasesLength(
      [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpExeName
    );

    #endregion

    // @

    #region GetConsoleAliasExes (Unicode - LPWStr) => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleAliasExes",
      CharSet = CharSet.Unicode,
      SetLastError = true
    )]
    public static extern uint GetConsoleAliasExes(
      [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder lpExeNameBuffer,
      [In] uint ExeNameBufferLength
    );

    #endregion

    // @

    #region GetConsoleAliasExesLength => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleAliasExesLength",
      SetLastError = true
    )]
    public static extern uint GetConsoleAliasExesLength();

    #endregion

    // @

    #region GetConsoleCP => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleCP",
      SetLastError = true
    )]
    public static extern uint GetConsoleCP();

    #endregion

    // @

    #region GetConsoleCursorInfo => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleCursorInfo",
      SetLastError = true
    )]
    public static extern bool GetConsoleCursorInfo(
      [In] IntPtr hConsoleOutput,
      [Out] out ConsoleCursorInformation lpConsoleCursorInfo
    );

    #endregion

    // @

    #region GetConsoleDisplayMode => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleDisplayMode",
      SetLastError = true
    )]
    public static extern bool GetConsoleDisplayMode(
      [Out] out ConsoleDisplayMode lpModeFlags
    );

    #endregion

    // @

    #region GetConsoleFontSize => Coordinate

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleFontSize",
      SetLastError = true
    )]
    public static extern Coordinate GetConsoleFontSize(
      [In] IntPtr hConsoleOutput,
      [In] uint nFont
    );

    #endregion

    // @

    #region GetConsoleHistoryInfo => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleHistoryInfo",
      SetLastError = true
    )]
    public static extern bool GetConsoleHistoryInfo(
      [Out] out ConsoleHistoryInformation lpConsoleHistoryInfo
    );

    #endregion

    // @

    #region GetConsoleMode => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleMode",
      SetLastError = true
    )]
    public static extern bool GetConsoleMode(
      [In] IntPtr hConsoleHandle,
      [Out] out ConsoleMode lpMode
    );

    #endregion

    // @

    #region GetConsoleOriginalTitle (Unicode - LPWStr) => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleOriginalTitle",
      CharSet = CharSet.Unicode,
      SetLastError = true
    )]
    public static extern uint GetConsoleOriginalTitle(
      [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder lpConsoleTitle,
      [In] uint nSize
    );

    #endregion

    // @

    #region GetConsoleOutputCP => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleOutputCP",
      SetLastError = true
    )]
    public static extern uint GetConsoleOutputCP();

    #endregion

    // @

    #region GetConsoleProcessList => uint

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleProcessList",
      SetLastError = true
    )]
    public static extern uint GetConsoleProcessList(
      [Out] out IntPtr[] lpdwProcessList,
      [In] uint dwProcessCount
    );

    #endregion

    // @

    #region GetConsoleScreenBufferInfo => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleScreenBufferInfo",
      SetLastError = true
    )]
    public static extern bool GetConsoleScreenBufferInfo(
      [In] IntPtr hConsoleOutput,
      [Out] out ConsoleScreenBufferInformation lpConsoleScreenBufferInfo
    );

    #endregion

    // @

    #region GetConsoleScreenBufferInfoEx => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleScreenBufferInfoEx",
      SetLastError = true
    )]
    public static extern bool GetConsoleScreenBufferInfoEx(
      [In] IntPtr hConsoleOutput,
      [Out] out ConsoleScreenBufferInformationExtended lpConsoleScreenBufferInfoEx
    );

    #endregion

    // @

    #region GetConsoleSelectionInfo => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleSelectionInfo",
      SetLastError = true
    )]
    public static extern bool GetConsoleSelectionInfo(
      [Out] out ConsoleSelectionInformation lpConsoleSelectionInfo
    );

    #endregion

    // @

    #region GetConsoleTitle (Unicode - LPWStr) => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleTitle",
      SetLastError = true
    )]
    public static extern bool GetConsoleTitle(
      [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder lpConsoleTitle,
      [In] uint nSize
    );

    #endregion

    // @

    #region GetConsoleWindow => IntPtr

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetConsoleWindow",
      SetLastError = true
    )]
    public static extern IntPtr GetConsoleWindow();

    #endregion

    // @

    #region GetCurrentConsoleFont => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetCurrentConsoleFont",
      SetLastError = true
    )]
    public static extern bool GetCurrentConsoleFont(
      [In] IntPtr hConsoleOutput,
      [In] bool bMaximumWindow,
      [Out] out ConsoleFontInformation lpConsoleCurrentFont
    );

    #endregion

    // @

    #region GetCurrentConsoleFontEx => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetCurrentConsoleFontEx",
      SetLastError = true
    )]
    public static extern bool GetCurrentConsoleFontEx(
      [In] IntPtr hConsoleOutput,
      [In] bool bMaximumWindow,
      [Out] out ConsoleFontInformationExtended lpConsoleCurrentFontEx
    );

    #endregion

    // @

    #region GetLargestConsoleWindowSize => Coordinate

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetLargestConsoleWindowSize",
      SetLastError = true
    )]
    public static extern Coordinate GetLargestConsoleWindowSize(
      [In] IntPtr hConsoleOutput
    );

    #endregion

    // @

    #region GetNumberOfConsoleInputEvents => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetNumberOfConsoleInputEvents",
      SetLastError = true
    )]
    public static extern bool GetNumberOfConsoleInputEvents(
      [In] IntPtr hConsoleInput,
      [Out] out uint lpcNumberOfEvents
    );

    #endregion

    // @

    #region GetNumberOfConsoleMouseButtons => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetNumberOfConsoleMouseButtons",
      SetLastError = true
    )]
    public static extern bool GetNumberOfConsoleMouseButtons(
      [Out] out uint lpNumberOfMouseButtons
    );

    #endregion

    // @

    #region GetStdHandle => IntPtr

    [DllImport(
      DLL_NAME,
      EntryPoint = "GetStdHandle",
      SetLastError = true
    )]
    public static extern IntPtr GetStdHandle(
      [In] ConsoleStandardDevice nStdHandle
    );

    #endregion

    // @

    #region HandlerRoutine (delegate) => bool

    public delegate bool HandlerRoutine(
      [In] ControlEvent dwCtrlType
    );

    #endregion

    // @

    #region PeekConsoleInput => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "PeekConsoleInput",
      SetLastError = true
    )]
    public static extern bool PeekConsoleInput(
      [In] IntPtr hConsoleInput,
      [Out] out InputRecord lpBuffer,
      [In] uint nLength,
      [Out] out uint lpNumberOfEventsRead
    );

    #endregion

    // @

    #region ReadConsole => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "ReadConsole",
      SetLastError = true
    )]
    public static extern bool ReadConsole(
      [In] IntPtr hConsoleInput,
      [Out] out byte[] lpBuffer,
      [In] uint nNumberOfCharsToRead,
      [Out] out uint lpNumberOfCharsRead,
      [In] ref ReadConsoleControl pInputControl
    );

    #endregion

    // @

    #region ReadConsoleInput => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "ReadConsoleInput",
      SetLastError = true
    )]
    public static extern bool ReadConsoleInput(
      [In] IntPtr hConsoleInput,
      [Out] out InputRecord lpBuffer,
      [In] uint nLength,
      [Out] out uint lpNumberOfEventsRead
    );

    #endregion

    // @

    #region ReadConsoleInputEx => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "ReadConsoleInputEx",
      SetLastError = true
    )]
    public static extern bool ReadConsoleInputEx(
      [In] IntPtr hConsoleInput,
      [Out] out InputRecord lpBuffer,
      [In] uint nLength,
      [Out] out uint lpNumberOfEventsRead,
      [In] ConsoleReadingBehavior wFlags
    );

    #endregion

    // @

    #region ReadConsoleOutput => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "ReadConsoleOutput",
      SetLastError = true
    )]
    public static extern bool ReadConsoleOutput(
      [In] IntPtr hConsoleOutput,
      [Out] out CharacterInformation lpBuffer,
      [In] Coordinate dwBufferSize,
      [In] Coordinate dwBufferCoord,
      [In, Out] ref SmallRectangle lpReadRegion
    );

    #endregion

    // @

    #region ReadConsoleOutputAttribute => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "ReadConsoleOutputAttribute",
      SetLastError = true
    )]
    public static extern bool ReadConsoleOutputAttribute(
      [In] IntPtr hConsoleOutput,
      [Out] out CharacterAttributes lpAttribute,
      [In] uint nLength,
      [In] Coordinate dwReadCoord,
      [Out] out uint lpNumberOfAttrsRead
    );

    #endregion

    // @

    #region ReadConsoleOutputCharacter (Unicode or ANSI - LPTStr) => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "ReadConsoleOutputCharacter",
      CharSet = CharSet.Auto,
      SetLastError = true
    )]
    public static extern bool ReadConsoleOutputCharacter(
      [In] IntPtr hConsoleOutput,
      [Out, MarshalAs(UnmanagedType.LPTStr)] out StringBuilder lpCharacter,
      [In] uint nLength,
      [In] Coordinate dwReadCoord,
      [Out] out uint lpNumberOfCharsRead
    );

    #endregion

    // @

    #region ResizePseudoConsole => ResultHandle

    [DllImport(
      DLL_NAME,
      EntryPoint = "ResizePseudoConsole",
      SetLastError = true
    )]
    public static extern ResultHandle ResizePseudoConsole(
      [In] IntPtr hPC,
      [In] Coordinate size
    );

    #endregion

    // @

    #region ScrollConsoleScreenBuffer => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "ScrollConsoleScreenBuffer",
      SetLastError = true
    )]
    public static extern bool ScrollConsoleScreenBuffer(
      [In] IntPtr hConsoleOutput,
      [In] ref SmallRectangle lpScrollRectangle,
      [In] ref SmallRectangle lpClipRectangle,
      [In] Coordinate dwDestinationOrigin,
      [In] ref CharacterInformation lpFill
    );

    #endregion

    // @

    #region SetConsoleActiveScreenBuffer => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleActiveScreenBuffer",
      SetLastError = true
    )]
    public static extern bool SetConsoleActiveScreenBuffer(
      [In] IntPtr hConsoleOutput
    );

    #endregion

    // @

    #region SetConsoleCP => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleCP",
      SetLastError = true
    )]
    public static extern bool SetConsoleCP(
      [In] uint wCodePageID
    );

    #endregion

    // @

    #region SetConsoleCtrlHandler => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleCtrlHandler",
      SetLastError = true
    )]
    public static extern bool SetConsoleCtrlHandler(
      [In] HandlerRoutine HandlerRoutine,
      [In] bool Add
    );

    #endregion

    // @

    #region SetConsoleCursorInfo => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleCursorInfo",
      SetLastError = true
    )]
    public static extern bool SetConsoleCursorInfo(
      [In] IntPtr hConsoleOutput,
      [In] ref ConsoleCursorInformation lpConsoleCursorInfo
    );

    #endregion

    // @

    #region SetConsoleCursorPosition => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleCursorPosition",
      SetLastError = true
    )]
    public static extern bool SetConsoleCursorPosition(
      [In] IntPtr hConsoleOutput,
      [In] Coordinate dwCursorPosition
    );

    #endregion

    // @

    #region SetConsoleDisplayMode => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleDisplayMode",
      SetLastError = true
    )]
    public static extern bool SetConsoleDisplayMode(
      [In] IntPtr hConsoleOutput,
      [In] ConsoleDisplayMode dwFlags,
      [Out] out Coordinate lpNewScreenBufferDimensions
    );

    #endregion

    // @

    #region SetConsoleHistoryInfo => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleHistoryInfo",
      SetLastError = true
    )]
    public static extern bool SetConsoleHistoryInfo(
      [In] ConsoleHistoryInformation lpConsoleHistoryInfo
    );

    #endregion

    // @

    #region SetConsoleMode => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleMode",
      SetLastError = true
    )]
    public static extern bool SetConsoleMode(
      [In] IntPtr hConsoleHandle,
      [In] ConsoleMode dwMode
    );

    #endregion

    // @

    #region SetConsoleOutputCP => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleOutputCP",
      SetLastError = true
    )]
    public static extern bool SetConsoleOutputCP(
      [In] uint wCodePageID
    );

    #endregion

    // @

    #region SetConsoleScreenBufferInfoEx => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleScreenBufferInfoEx",
      SetLastError = true
    )]
    public static extern bool SetConsoleScreenBufferInfoEx(
      [In] IntPtr hConsoleOutput,
      [In] ConsoleScreenBufferInformationExtended lpConsoleScreenBufferInfoEx
    );

    #endregion

    // @

    #region SetConsoleScreenBufferSize => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleScreenBufferSize",
      SetLastError = true
    )]
    public static extern bool SetConsoleScreenBufferSize(
      [In] IntPtr hConsoleOutput,
      [In] Coordinate dwSize
    );

    #endregion

    // @

    #region SetConsoleTextAttribute => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleTextAttribute",
      SetLastError = true
    )]
    public static extern bool SetConsoleTextAttribute(
      [In] IntPtr hConsoleOutput,
      [In] CharacterAttributes wAttributes
    );

    #endregion

    // @

    #region SetConsoleTitle (Unicode - LPWStr) => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleTitle",
      CharSet = CharSet.Unicode,
      SetLastError = true
    )]
    public static extern bool SetConsoleTitle(
      [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpConsoleTitle
    );

    #endregion

    // @

    #region SetConsoleWindowInfo => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetConsoleWindowInfo",
      SetLastError = true
    )]
    public static extern bool SetConsoleWindowInfo(
      [In] IntPtr hConsoleOutput,
      [In] bool bAbsolute,
      [In] ref SmallRectangle lpConsoleWindow
    );

    #endregion

    // @

    #region SetCurrentConsoleFontEx => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetCurrentConsoleFontEx",
      SetLastError = true
    )]
    public static extern bool SetCurrentConsoleFontEx(
      [In] IntPtr hConsoleOutput,
      [In] bool bMaximumWindow,
      [In] ref ConsoleFontInformationExtended lpConsoleCurrentFontEx
    );

    #endregion

    // @

    #region SetStdHandle => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "SetStdHandle",
      SetLastError = true
    )]
    public static extern bool SetStdHandle(
      [In] ConsoleStandardDevice nStdHandle,
      [In] IntPtr hHandle
    );

    #endregion

    // @

    #region WriteConsole (Unicode or ANSI - LPTStr) => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "WriteConsole",
      CharSet = CharSet.Auto,
      SetLastError = true
    )]
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

    [DllImport(
      DLL_NAME,
      EntryPoint = "WriteConsoleInput",
      SetLastError = true
    )]
    public static extern bool WriteConsoleInput(
      [In] IntPtr hConsoleInput,
      [In] ref InputRecord lpBuffer,
      [In] uint nLength,
      [Out] out uint lpNumberOfEventsWritten
    );

    #endregion

    // @

    #region WriteConsoleOutput => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "WriteConsoleOutput",
      SetLastError = true
    )]
    public static extern bool WriteConsoleOutput(
      [In] IntPtr hConsoleOutput,
      [In] ref CharacterInformation[] lpBuffer,
      [In] Coordinate dwBufferSize,
      [In] Coordinate dwBufferCoord,
      [In, Out] ref SmallRectangle lpWriteRegion
    );

    #endregion

    // @

    #region WriteConsoleOutputAttribute => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "WriteConsoleOutputAttribute",
      SetLastError = true
    )]
    public static extern bool WriteConsoleOutputAttribute(
      [In] IntPtr hConsoleOutput,
      [In] ref CharacterAttributes lpAttribute,
      [In] uint Length,
      [In] Coordinate dwWriteCoord,
      [Out] out uint lpNumberOfAttrsWritten
    );

    #endregion

    // @

    #region WriteConsoleOutputCharacter => bool

    [DllImport(
      DLL_NAME,
      EntryPoint = "WriteConsoleOutputCharacter",
      CharSet = CharSet.Auto,
      SetLastError = true
    )]
    public static extern bool WriteConsoleOutputCharacter(
      [In] IntPtr hConsoleOutput,
      [In, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpCharacter,
      [In] uint nLength,
      [In] Coordinate dwWriteCoord,
      [Out] out uint lpNumberOfCharsWritten
    );

    #endregion
  }
}
