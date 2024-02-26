namespace ThirtyTwo.Kernel32.Enumerations
{
  /// <summary>
  /// Specifies the system error codes returned by the "GetLastError" method.
  /// </summary>
  [System.Flags]
  public enum SystemErrorCodes : uint
  {
    /// <summary>
    /// The operation completed successfully.
    /// </summary>
    Success = 0x0,

    /// <summary>
    /// Incorrect function.
    /// </summary>
    InvalidFunction = 0x1,

    /// <summary>
    /// The system cannot find the file specified.
    /// </summary>
    FileNotFound = 0x2,

    /// <summary>
    /// The system cannot find the path specified.
    /// </summary>
    PathNotFound = 0x3,

    /// <summary>
    /// The system cannot open the file.
    /// </summary>
    TooManyOpenFiles = 0x4,

    /// <summary>
    /// Access is denied.
    /// </summary>
    AccessDenied = 0x5,

    /// <summary>
    /// The handle is invalid.
    /// </summary>
    InvalidHandle = 0x6,

    /// <summary>
    /// The storage control blocks were destroyed.
    /// </summary>
    ArenaTrashed = 0x7,

    /// <summary>
    /// Not enough memory resources are available to process this command.
    /// </summary>
    NotEnoughMemory = 0x8,

    /// <summary>
    /// The storage control block address is invalid.
    /// </summary>
    InvalidBlock = 0x9,

    /// <summary>
    /// The environment is incorrect.
    /// </summary>
    BadEnvironment = 0xa,

    /// <summary>
    /// An attempt was made to load a program with an incorrect format.
    /// </summary>
    BadFormat = 0xb,

    /// <summary>
    /// The access code is invalid.
    /// </summary>
    InvalidAccess = 0xc,

    /// <summary>
    /// The data is invalid.
    /// </summary>
    InvalidData = 0xd,

    /// <summary>
    /// Not enough storage is available to complete this operation.
    /// </summary>
    OutOfMemory = 0xe,

    /// <summary>
    /// The system cannot find the drive specified.
    /// </summary>
    InvalidDrive = 0xf,

    /// <summary>
    /// The directory cannot be removed.
    /// </summary>
    CurrentDirectory = 0x10,

    /// <summary>
    /// The system cannot move the file to a different disk drive.
    /// </summary>
    NotSameDevice = 0x11,

    /// <summary>
    /// There are no more files.
    /// </summary>
    NoMoreFiles = 0x12,

    /// <summary>
    /// The media is write protected.
    /// </summary>
    WriteProtect = 0x13,

    /// <summary>
    /// The system cannot find the device specified.
    /// </summary>
    BadUnit = 0x14,

    /// <summary>
    /// The device is not ready.
    /// </summary>
    NotReady = 0x15,

    /// <summary>
    /// The device does not recognize the command.
    /// </summary>
    BadCommand = 0x16,

    /// <summary>
    /// Data error (cyclic redundancy check).
    /// </summary>
    CyclicRedundancyCheck = 0x17,

    /// <summary>
    /// The program issued a command but the command length is incorrect.
    /// </summary>
    BadLength = 0x18,

    /// <summary>
    /// The drive cannot locate a specific area or track on the disk.
    /// </summary>
    Seek = 0x19,

    /// <summary>
    /// The specified disk or diskette cannot be accessed.
    /// </summary>
    NotDosDisk = 0x1a,

    /// <summary>
    /// The drive cannot find the sector requested.
    /// </summary>
    SectorNotFound = 0x1b,

    /// <summary>
    /// The printer is out of paper.
    /// </summary>
    OutOfPaper = 0x1c,

    /// <summary>
    /// The system cannot write to the specified device.
    /// </summary>
    WriteFault = 0x1d,

    /// <summary>
    /// The system cannot read from the specified device.
    /// </summary>
    ReadFault = 0x1e,

    /// <summary>
    /// A device attached to the system is not functioning.
    /// </summary>
    GenFailure = 0x1f,

    /// <summary>
    /// The process cannot access the file because it is being used by another process.
    /// </summary>
    SharingViolation = 0x20,

    /// <summary>
    /// The process cannot access the file because another process has locked a portion of
    /// the file.
    /// </summary>
    LockViolation = 0x21,

    /// <summary>
    /// The wrong diskette is in the drive. Insert %2 (Volume Serial Number: %3) into
    /// drive %1.
    /// </summary>
    WrongDisk = 0x22,

    /// <summary>
    /// Too many files opened for sharing.
    /// </summary>
    SharingBufferExceeded = 0x24,

    /// <summary>
    /// Reached the end of the file.
    /// </summary>
    HandleEOF = 0x26,

    /// <summary>
    /// The disk is full.
    /// </summary>
    HandleDiskFull = 0x27,

    /// <summary>
    /// The request is not supported.
    /// </summary>
    NotSupported = 0x32,

    /// <summary>
    /// Windows cannot find the network path. Verify that the network path is correct and
    /// the destination computer is not busy or turned off. If Windows still cannot find
    /// the network path, contact your network administrator.
    /// </summary>
    RemoteNotList = 0x33,

    /// <summary>
    /// You were not connected because a duplicate name exists on the network. If joining a
    /// domain, go to System in Control Panel to change the computer name and try again. If
    /// joining a work group, choose another work group name.
    /// </summary>
    DuplicateName = 0x34,

    /// <summary>
    /// The network path was not found.
    /// </summary>
    BadNetPath = 0x35,

    /// <summary>
    /// The network is busy.
    /// </summary>
    NetworkBusy = 0x36,

    /// <summary>
    /// The specified network resource or device is no longer available.
    /// </summary>
    DevNotExist = 0x37,

    /// <summary>
    /// The network BIOS command limit has been reached.
    /// </summary>
    TooManyCommands = 0x38,

    /// <summary>
    /// A network adapter hardware error occurred.
    /// </summary>
    AdapterHardwareError = 0x39,

    /// <summary>
    /// The specified server cannot perform the requested operation.
    /// </summary>
    BadNetworkResponse = 0x3a,

    /// <summary>
    /// An unexpected network error occurred.
    /// </summary>
    UnexpectedNetworkError = 0x3b,

    /// <summary>
    /// The remote adapter is not compatible.
    /// </summary>
    BadRemoteAdapter = 0x3c,

    /// <summary>
    /// The printer queue is full.
    /// </summary>
    PrinterQueueFull = 0x3d,

    /// <summary>
    /// Space to store the file waiting to e printed is not available on the server.
    /// </summary>
    NoSpoolSpace = 0x3e,

    /// <summary>
    /// Your file waiting to be printed was deleted.
    /// </summary>
    PrintCancelled = 0x3f,

    /// <summary>
    /// The specified network name is no longer available.
    /// </summary>
    NetworkNameDeleted = 0x40,

    /// <summary>
    /// Network access is denied.
    /// </summary>
    NetworkAccessDenied = 0x41,

    /// <summary>
    /// The network resource type is not correct.
    /// </summary>
    BadDevType = 0x42,

    /// <summary>
    /// The network name cannot be found.
    /// </summary>
    BadNetworkName = 0x43,

    /// <summary>
    /// The name limit for the local computer network adapter card was exceeded.
    /// </summary>
    TooManyNames = 0x44,

    /// <summary>
    /// The network BIOS session limit was exceeded.
    /// </summary>
    TooManySession = 0x45,

    /// <summary>
    /// The remote server has been paused o is in the process of being started.
    /// </summary>
    SharingPaused = 0x46,

    /// <summary>
    /// No more connections can be made to this remote computer at this time because there
    /// are already as many connections as the computer can accept.
    /// </summary>
    RequestNotAccepted = 0x47,

    /// <summary>
    /// The specified printer or disk device has been paused.
    /// </summary>
    RedirectPaused = 0x48,

    /// <summary>
    /// The file exists.
    /// </summary>
    FileExists = 0x50,

    /// <summary>
    /// The directory or file cannot be related.
    /// </summary>
    CannotMake = 0x52,

    /// <summary>
    /// Fail on INT 24
    /// </summary>
    FailInt24 = 0x53,

    /// <summary>
    /// Storage to process this request is not available.
    /// </summary>
    OutOfStructures = 0x54,

    /// <summary>
    /// The local device name is already in use.
    /// </summary>
    AlreadyAssigned = 0x55,

    /// <summary>
    /// The specified network password is not correct.
    /// </summary>
    InvalidPassword = 0x56,

    /// <summary>
    /// The parameter is incorrect.
    /// </summary>
    InvalidParameter = 0x57,

    /// <summary>
    /// A write fault occurred on the network.
    /// </summary>
    NetworkWriteFault = 0x58,

    /// <summary>
    /// The system cannot start another process at this time.
    /// </summary>
    NoProcSlots = 0x59,

    /// <summary>
    /// Cannot create another system semaphore.
    /// </summary>
    TooManySemaphores = 0x64,

    /// <summary>
    /// The exclusive semaphore is owned by another process.
    /// </summary>
    ExclusiveSemAlreadyOwned = 0x65,

    /// <summary>
    /// The semaphore is set and cannot be closed.
    /// </summary>
    SemIsSet = 0x66,

    /// <summary>
    /// The semaphore cannot be set again.
    /// </summary>
    TooManySemRequests = 0x67,

    /// <summary>
    /// Cannot request exclusive semaphores at interrupt time.
    /// </summary>
    InvalidAtInterruptTime = 0x68,

    /// <summary>
    /// The previous ownership of this semaphore has ended.
    /// </summary>
    SemOwnerDied = 0x69,

    /// <summary>
    /// Insert the diskette for drive %1.
    /// </summary>
    SemUserLimit = 0x6a,

    /// <summary>
    /// The program stopped because an alternate diskette was not inserted.
    /// </summary>
    DiskChange = 0x6b,

    /// <summary>
    /// The disk is in use or locked by another process.
    /// </summary>
    DriveLocked = 0x6c,

    /// <summary>
    /// The pipe has been ended.
    /// </summary>
    BrokenPipe = 0x6d,

    /// <summary>
    /// The system cannot open the device or file specified.
    /// </summary>
    OpenFailed = 0x6e,

    /// <summary>
    /// The file name is too long.
    /// </summary>
    BufferOverflow = 0x6f,

    /// <summary>
    /// There is not enough space on the disk.
    /// </summary>
    DiskFull = 0x70,

    /// <summary>
    /// No more internal file identifiers available.
    /// </summary>
    NoMoreSearchHandles = 0x71,

    /// <summary>
    /// The target internal file identifier is incorrect.
    /// </summary>
    InvalidTargetHandle = 0x72,

    /// <summary>
    /// The IOCTL call made by the application program is not correct.
    /// </summary>
    InvalidCategory = 0x75,

    /// <summary>
    /// The verify-on-write switch parameter value is not correct.
    /// </summary>
    InvalidVerifySwitch = 0x76,

    /// <summary>
    /// The system does not support the command requested.
    /// </summary>
    BadDriverLevel = 0x77,

    /// <summary>
    /// This function is not supported on this system.
    /// </summary>
    callNotImplemented = 0x78,

    /// <summary>
    /// The semaphore timeout period has expired.
    /// </summary>
    SemTimeout = 0x79,

    /// <summary>
    /// The data area passed to a system call is too small.
    /// </summary>
    InsufficientBuffer = 0x7a,

    /// <summary>
    /// The filename, directory name, or volume label syntax is incorrect.
    /// </summary>
    InvalidName = 0x7b,

    /// <summary>
    /// The system call level is not correct.
    /// </summary>
    InvalidLevel = 0x7c,

    /// <summary>
    /// The disk has no volume label.
    /// </summary>
    NoVolumeLabel = 0x7d,

    /// <summary>
    /// The specified module could not be found.
    /// </summary>
    ModuleNotFound = 0x7e,

    /// <summary>
    /// The specified procedure could not be found.
    /// </summary>
    ProcedureNotFound = 0x7f,

    /// <summary>
    /// There are no child processes to wait or.
    /// </summary>
    WaitNoChildren = 0x80,

    /// <summary>
    /// The %1 application cannot be run in Win32 mode.
    /// </summary>
    ChildNotComplete = 0x81,

    /// <summary>
    /// Attempt to use a file handle to an open disk partition for an operation other than
    /// raw disk I/O.
    /// </summary>
    DirectAccessHandle = 0x82,

    /// <summary>
    /// An attempt was made to move the fie pointer before the beginning of the file.
    /// </summary>
    NegativeSeek = 0x83,

    /// <summary>
    /// The file pointer cannot be set on the specified device or file.
    /// </summary>
    SeekOnDevice = 0x84,

    /// <summary>
    /// A JOIN or SUBST command cannot be used for a drive that contains previously
    /// joined drives.
    /// </summary>
    IsJoinTarget = 0x85,

    /// <summary>
    /// An attempt was made to use a JIN or SUBST command on a drive that has already
    /// been joined.
    /// </summary>
    IsJoined = 0x86,

    /// <summary>
    /// An attempt was made to use a JON or SUBST command on a drive that has already
    /// been substituted.
    /// </summary>
    IsSubsted = 0x87,

    /// <summary>
    /// The system tried to delete the OIN of a drive that is not joined.
    /// </summary>
    NotJoined = 0x88,

    /// <summary>
    /// The system tried to delete the substitution of a drive that is not substituted.
    /// </summary>
    NotSubsted = 0x89,

    /// <summary>
    /// The system tried to join a drive to a directory on a joined drive.
    /// </summary>
    JoinToJoin = 0x8a,

    /// <summary>
    /// The system tried to substitute a drive to a directory on a substituted drive.
    /// </summary>
    SubstToSubst = 0x8b,

    /// <summary>
    /// The system tried to join a drive to a directory on a substituted drive.
    /// </summary>
    JoinToSubst = 0x8c,

    /// <summary>
    /// The system tried to SUBST a drive to a directory on a joined drive.
    /// </summary>
    SubstToJoin = 0x8d,

    /// <summary>
    /// The system cannot perform a JOIN or SUBST at this time.
    /// </summary>
    BusyDrive = 0x8e,

    /// <summary>
    /// The system cannot join or substitute a drive to or for a directory on the
    /// same drive.
    /// </summary>
    SameDrive = 0x8f,

    /// <summary>
    /// The directory is not a subdirectory of the root directory.
    /// </summary>
    DirectoryNotRoot = 0x90,

    /// <summary>
    /// The directory is not empty.
    /// </summary>
    DirectoryNotEmpty = 0x91,

    /// <summary>
    /// The path specified is being used in a substitute.
    /// </summary>
    IsSubstPath = 0x92,

    /// <summary>
    /// Not enough resources are available to process this command.
    /// </summary>
    IsJoinPath = 0x93,

    /// <summary>
    /// The path specified cannot be used at this time.
    /// </summary>
    PathBusy = 0x94,

    /// <summary>
    /// An attempt was made to join or substitute a drive for which a directory on the
    /// drive is the target of a previous substitute.
    /// </summary>
    IsSubstTarget = 0x95,

    /// <summary>
    /// System trace information was not specified in your "CONFIG.SYS" file, or tracing
    /// is disallowed.
    /// </summary>
    SystemTrace = 0x96,

    /// <summary>
    /// The number of specified semaphore events for DosMuxSemWait is not correct.
    /// </summary>
    InvalidEventCount = 0x97,

    /// <summary>
    /// DosMuxSemWait did not execute; too many semaphores are already set.
    /// </summary>
    TooManyMuxWaiters = 0x98,

    /// <summary>
    /// The DosMuxSemWait list is not correct.
    /// </summary>
    InvalidListFormat = 0x99,

    /// <summary>
    /// The volume label you entered exceeds the label character limit of the target
    /// file system.
    /// </summary>
    labelTooLong = 0x9a,

    /// <summary>
    /// Cannot create another thread.
    /// </summary>
    TooManyTcbs = 0x9b,

    /// <summary>
    /// The recipient process has refused the signal.
    /// </summary>
    SignalRefused = 0x9c,

    /// <summary>
    /// The segment is already discard and cannot be locked.
    /// </summary>
    Discarded = 0x9d,

    /// <summary>
    /// The segment is already unlocked.
    /// </summary>
    NotLocked = 0x9e,

    /// <summary>
    /// The address for the thread ID is not correct.
    /// </summary>
    BadThreadidAddr = 0x9f,

    /// <summary>
    /// One or more arguments are not correct.
    /// </summary>
    BadArguments = 0xa0,

    /// <summary>
    /// The specified path is invalid.
    /// </summary>
    BadPathname = 0xa1,

    /// <summary>
    /// A signal is already pending.
    /// </summary>
    SignalPending = 0xa2,

    /// <summary>
    /// No more threads can be created in the system.
    /// </summary>
    MaxThrdsReached = 0xa4,

    /// <summary>
    /// Unable to lock a region of a file.
    /// </summary>
    LockFailed = 0xa7,

    /// <summary>
    /// The requested resource is in use.
    /// </summary>
    Busy = 0xaa,

    /// <summary>
    /// Device's command support detection is in progress.
    /// </summary>
    DeviceSupportInProgress = 0xab,

    /// <summary>
    /// A lock request was not outstanding for the supplied cancel region.
    /// </summary>
    CancelViolation = 0xad,

    /// <summary>
    /// The file system does not support atomic changes to the lock type.
    /// </summary>
    AtomicLocksNotSupported = 0xae,

    /// <summary>
    /// The system detected a segment number that was not correct.
    /// </summary>
    InvalidSegmentNumber = 0xb4,

    /// <summary>
    /// The operating system cannot run %1.
    /// </summary>
    InvalidOrdinal = 0xb6,

    /// <summary>
    /// Cannot create a file when that file already exists.
    /// </summary>
    AlreadyExists = 0xb7,

    /// <summary>
    /// The flag passed is not correct.
    /// </summary>
    InvalidFlagNumber = 0xba,

    /// <summary>
    /// The specified system semaphore name was not found.
    /// </summary>
    SemNotFound = 0xbb,

    /// <summary>
    /// The operating system cannot run %1.
    /// </summary>
    InvalidStartingCodeseg = 0xbc,

    /// <summary>
    /// The operating system cannot run %1.
    /// </summary>
    InvalidStackseg = 0xbd,

    /// <summary>
    /// The operating system cannot run %1.
    /// </summary>
    InvalidModuletype = 0xbe,

    /// <summary>
    /// Cannot run %1 in Win32 mode.
    /// </summary>
    InvalidExeSignature = 0xbf,

    /// <summary>
    /// The operating system cannot run %1.
    /// </summary>
    ExeMarkedInvalid = 0xc0,

    /// <summary>
    /// %1 is not a valid Win32 application.
    /// </summary>
    BadExeFormat = 0xc1,

    /// <summary>
    /// The operating system cannot run %1
    /// </summary>
    IteratedDataExceeds_64k = 0xc2,

    /// <summary>
    /// The operating system cannot run %1.
    /// </summary>
    InvalidMinallocsize = 0xc3,

    /// <summary>
    /// The operating system cannot run this application program.
    /// </summary>
    DynlinkFromInvalidRing = 0xc4,

    /// <summary>
    /// The operating system is not presently configured to run this application.
    /// </summary>
    IoplNotEnabled = 0xc5,

    /// <summary>
    /// The operating system cannot run %1.
    /// </summary>
    InvalidSegmentDPL = 0xc6,

    /// <summary>
    /// The operating system cannot run this application program.
    /// </summary>
    AutoDataSegmentExceeds64k = 0xc7,

    /// <summary>
    /// The code segment cannot be greater than or equal to 64K.
    /// </summary>
    Ring2SegmentMustBeMovable = 0xc8,

    /// <summary>
    /// The operating system cannot run %1.
    /// </summary>
    RelocChainXeedsSegmentLimit = 0xc9,

    /// <summary>
    /// The operating system cannot run %1.
    /// </summary>
    InFloopInRelocChain = 0xca,

    /// <summary>
    /// The system could not find the environment option that was entered.
    /// </summary>
    EnvironmentVariableNotFound = 0xcb,

    /// <summary>
    /// No process in the command subtree has a signal handler.
    /// </summary>
    NoSignalSent = 0xcd,

    /// <summary>
    /// The filename or extension is too long.
    /// </summary>
    FilenameExcedRange = 0xce,

    /// <summary>
    /// The ring 2 stack is in use.
    /// </summary>
    Ring2StackInUse = 0xcf,

    /// <summary>
    /// The global filename characters, "*" or "?", are entered incorrectly or too many
    /// global filename characters are specified.
    /// </summary>
    MetaExpansionTooLong = 0xd0,

    /// <summary>
    /// The signal being posted is not correct.
    /// </summary>
    InvalidSignalNumber = 0xd1,

    /// <summary>
    /// The signal handler cannot be set.
    /// </summary>
    Thread1Inactive = 0xd2,

    /// <summary>
    /// The segment is locked and cannot be reallocated.
    /// </summary>
    Locked = 0xd4,

    /// <summary>
    /// Too many dynamic - link modules are attached to this program or dynamic -
    /// link module.
    /// </summary>
    TooManyModules = 0xd6,

    /// <summary>
    /// Cannot nest calls to LoadModule.
    /// </summary>
    NestingNotAllowed = 0xd7,

    /// <summary>
    /// This version of %1 is not compatible with the version of Windows you're running.
    /// Check your computer's system information and then contact the software publisher.
    /// </summary>
    ExeMachineTypeMismatch = 0xd8,

    /// <summary>
    /// The image file %1 is signed, unable to modify.
    /// </summary>
    ExeCannotModifySignedBinary = 0xd9,

    /// <summary>
    /// The image file %1 is strong signed, unable to modify.
    /// </summary>
    ExeCannotModifyStrongSignedBinary = 0xda,

    /// <summary>
    /// This file is checked out or locked for editing by another user.
    /// </summary>
    FileCheckedOut = 0xdc,

    /// <summary>
    /// The file must be checked out before saving changes.
    /// </summary>
    checkoutRequired = 0xdd,

    /// <summary>
    /// The file type being saved or retrieved has been blocked.
    /// </summary>
    BadFileType = 0xde,

    /// <summary>
    /// The file size exceeds the limit allowed and cannot be saved.
    /// </summary>
    FileTooLarge = 0xdf,

    /// <summary>
    /// Access Denied. Before opening files in this location, you must first add the web
    /// site to your trusted sites list, browse to the web site, and select the option to
    /// login automatically.
    /// </summary>
    FormsAuthRequired = 0xe0,

    /// <summary>
    /// Operation did not complete successfully because the file contains a virus or
    /// potentially unwanted software.
    /// </summary>
    VirusInfected = 0xe1,

    /// <summary>
    /// This file contains a virus or potentially unwanted software and cannot be opened.
    /// Due to the nature of this virus or potentially unwanted software, the file has been
    /// removed from this location.
    /// </summary>
    VirusDeleted = 0xe2,

    /// <summary>
    /// The pipe is local.
    /// </summary>
    PipeLocal = 0xe5,

    /// <summary>
    /// The pipe state is invalid.
    /// </summary>
    BadPipe = 0xe6,

    /// <summary>
    /// All pipe instances are busy.
    /// </summary>
    PipeBusy = 0xe7,

    /// <summary>
    /// The pipe is being closed.
    /// </summary>
    NoData = 0xe8,

    /// <summary>
    /// No process is on the other end of the pipe.
    /// </summary>
    PipeNotConnected = 0xe9,

    /// <summary>
    /// More data is available.
    /// </summary>
    MoreData = 0xea,

    /// <summary>
    /// The session was canceled.
    /// </summary>
    SessionDisconnected = 0xf0,

    /// <summary>
    /// The specified extended attribute name was invalid.
    /// </summary>
    InvalidExtendedAttributeName = 0xfe,

    /// <summary>
    /// The extended attributes are inconsistent.
    /// </summary>
    ExtendedAttributeListInconsistent = 0xff,

    /// <summary>
    /// The wait operation timed out.
    /// </summary>
    WaitTimeout = 0x102,

    /// <summary>
    /// No more data is available.
    /// </summary>
    NoMoreItems = 0x103,

    /// <summary>
    /// The copy functions cannot be used.
    /// </summary>
    CannotCopy = 0x10a,

    /// <summary>
    /// The directory name is invalid.
    /// </summary>
    Directory = 0x10b,

    /// <summary>
    /// The extended attributes did not fit in the buffer.
    /// </summary>
    ExtendedAttributesDidntFit = 0x113,

    /// <summary>
    /// The extended attribute file on the mounted file system is corrupt.
    /// </summary>
    ExtendedAttributeFileCorrupt = 0x114,

    /// <summary>
    /// The extended attribute table file i full.
    /// </summary>
    ExtendedAttributeTableFull = 0x115,

    /// <summary>
    /// The specified extended attribute handle is invalid.
    /// </summary>
    InvalidExtendedAttributeHandle = 0x116,

    /// <summary>
    /// The mounted file system does not support extended attributes.
    /// </summary>
    ExtendedAttributesNotSupported = 0x11a,

    /// <summary>
    /// Attempt to release mutex not owned by caller.
    /// </summary>
    NotOwner = 0x120,

    /// <summary>
    /// Too many posts were made to a semaphore.
    /// </summary>
    TooManyPosts = 0x12a,

    /// <summary>
    /// Only part of a ReadProcessMemory or WriteProcessMemory request was completed.
    /// </summary>
    PartialCopy = 0x12b,

    /// <summary>
    /// The oplock request is denied.
    /// </summary>
    OpLockNotGranted = 0x12c,

    /// <summary>
    /// An invalid oplock acknowledgment was received by the system.
    /// </summary>
    InvalidOpLockProtocol = 0x12d,

    /// <summary>
    /// The volume is too fragmented to complete his operation.
    /// </summary>
    DiskTooFragmented = 0x12e,

    /// <summary>
    /// The file cannot be opened because itis in the process of being deleted.
    /// </summary>
    DeletePending = 0x12f,

    /// <summary>
    /// Short name settings may not be changed on this volume due to the global
    /// registry setting.
    /// </summary>
    IncompatibleWithGlobalShortNameRegistrySetting = 0x130,

    /// <summary>
    /// Short names are not enabled on this volume.
    /// </summary>
    ShortNamesNotEnabledOnVolume = 0x131,

    /// <summary>
    /// The security stream for the given volume is in an inconsistent state. Please run
    /// CHKDSK on the volume.
    /// </summary>
    SecurityStreamIsInconsistent = 0x132,

    /// <summary>
    /// A requested file lock operation cannot be processed due to an invalid byte range.
    /// </summary>
    InvalidLockRange = 0x133,

    /// <summary>
    /// The subsystem needed to support the image type is not present.
    /// </summary>
    ImageSubsystemNotPresent = 0x134,

    /// <summary>
    /// The specified file already has a notification GUID associated with it.
    /// </summary>
    NotificationGuidAlreadyDefined = 0x135,

    /// <summary>
    /// An invalid exception handler routine has been detected.
    /// </summary>
    InvalidExceptionHandler = 0x136,

    /// <summary>
    /// Duplicate privileges were specified for the token.
    /// </summary>
    DuplicatePrivileges = 0x137,

    /// <summary>
    /// No ranges for the specified operation were able to be processed.
    /// </summary>
    NoRangesProcessed = 0x138,

    /// <summary>
    /// Operation is not allowed on a file system internal file.
    /// </summary>
    NotAllowedOnSystemFile = 0x139,

    /// <summary>
    /// The physical resources of this disk have been exhausted.
    /// </summary>
    DiskResourcesExhausted = 0x13a,

    /// <summary>
    /// The token representing the data is invalid.
    /// </summary>
    InvalidToken = 0x13b,

    /// <summary>
    /// The device does not support the command feature.
    /// </summary>
    DeviceFeatureNotSupported = 0x13c,

    /// <summary>
    /// The system cannot find message text for message number 0x%1 in the message
    /// file for %2.
    /// </summary>
    MemoryMidNotFound = 0x13d,

    /// <summary>
    /// The scope specified was not found.
    /// </summary>
    ScopeNotFound = 0x13e,

    /// <summary>
    /// The Central Access Policy specified is not defined on the target machine.
    /// </summary>
    UndefinedScope = 0x13f,

    /// <summary>
    /// The Central Access Policy obtained from Active Directory is invalid.
    /// </summary>
    InvalidCentralAccessPolicy = 0x140,

    /// <summary>
    /// The device is unreachable.
    /// </summary>
    DeviceUnreachable = 0x141,

    /// <summary>
    /// The target device has insufficient resources to complete the operation.
    /// </summary>
    DeviceNoResources = 0x142,

    /// <summary>
    /// A data integrity checksum error occurred. Data in the file stream is corrupt.
    /// </summary>
    DataChecksumError = 0x143,

    /// <summary>
    /// An attempt was made to modify both a KERNEL and normal Extended Attribute (EA) in
    /// the same operation.
    /// </summary>
    IntermixedKernelExtendedAttributeOperation = 0x144,

    /// <summary>
    /// Device does not support file-level TRIM.
    /// </summary>
    FileLevelTrimNotSupported = 0x146,

    /// <summary>
    /// The command specified a data offset that does not align to the device's
    /// granularity/alignment.
    /// </summary>
    OffsetAlignmentViolation = 0x147,

    /// <summary>
    /// The command specified an invalid field in its parameter list.
    /// </summary>
    InvalidFieldInParameterList = 0x148,

    /// <summary>
    /// An operation is currently in progress with he device.
    /// </summary>
    OperationInProgress = 0x149,

    /// <summary>
    /// An attempt was made to send down the command via an invalid path to the
    /// target device.
    /// </summary>
    BadDevicePath = 0x14a,

    /// <summary>
    /// The command specified a number of descriptors that exceeded the maximum supported
    /// by the device.
    /// </summary>
    TooManyDescriptors = 0x14b,

    /// <summary>
    /// Scrub is disabled on the specified file.
    /// </summary>
    scrubDataDisabled = 0x14c,

    /// <summary>
    /// The storage device does not provide redundancy.
    /// </summary>
    NotRedundantStorage = 0x14d,

    /// <summary>
    /// An operation is not supported on a resident file.
    /// </summary>
    ResidentFileNotSupported = 0x14e,

    /// <summary>
    /// An operation is not supported on a compressed file.
    /// </summary>
    CompressedFileNotSupported = 0x14f,

    /// <summary>
    /// An operation is not supported on a directory.
    /// </summary>
    DirectoryNotSupported = 0x150,

    /// <summary>
    /// The specified copy of the requested data could not be read.
    /// </summary>
    NotReadFromCopy = 0x151,

    /// <summary>
    /// No action was taken as a system reboot is required.
    /// </summary>
    FailNoactionReboot = 0x15e,

    /// <summary>
    /// The shutdown operation failed.
    /// </summary>
    FailShutdown = 0x15f,

    /// <summary>
    /// The restart operation failed.
    /// </summary>
    FailRestart = 0x160,

    /// <summary>
    /// The maximum number of sessions has been reached.
    /// </summary>
    MaxSessionsReached = 0x161,

    /// <summary>
    /// The thread is already in background processing mode.
    /// </summary>
    ThreadModeAlreadyBackground = 0x190,

    /// <summary>
    /// The thread is not in background processing mode.
    /// </summary>
    ThreadModeNotBackground = 0x191,

    /// <summary>
    /// The process is already in background processing mode.
    /// </summary>
    ProcessModeAlreadyBackground = 0x192,

    /// <summary>
    /// The process is not in background processing mode.
    /// </summary>
    ProcessModeNotBackground = 0x193,

    /// <summary>
    /// Attempt to access invalid address.
    /// </summary>
    InvalidAddress = 0x1e7,
  }
}
