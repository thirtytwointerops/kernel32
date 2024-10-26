﻿namespace ThirtyTwo.Kernel32.Enumerations
{
  [Flags]
  public enum SystemErrorCodes : uint
  {
    Success = 0x0,
    InvalidFunction = 0x1,
    FileNotFound = 0x2,
    PathNotFound = 0x3,
    TooManyOpenFiles = 0x4,
    AccessDenied = 0x5,
    InvalidHandle = 0x6,
    ArenaTrashed = 0x7,
    NotEnoughMemory = 0x8,
    InvalidBlock = 0x9,
    BadEnvironment = 0xa,
    BadFormat = 0xb,
    InvalidAccess = 0xc,
    InvalidData = 0xd,
    OutOfMemory = 0xe,
    InvalidDrive = 0xf,
    CurrentDirectory = 0x10,
    NotSameDevice = 0x11,
    NoMoreFiles = 0x12,
    WriteProtect = 0x13,
    BadUnit = 0x14,
    NotReady = 0x15,
    BadCommand = 0x16,
    CyclicRedundancyCheck = 0x17,
    BadLength = 0x18,
    Seek = 0x19,
    NotDosDisk = 0x1a,
    SectorNotFound = 0x1b,
    OutOfPaper = 0x1c,
    WriteFault = 0x1d,
    ReadFault = 0x1e,
    GenFailure = 0x1f,
    SharingViolation = 0x20,
    LockViolation = 0x21,
    WrongDisk = 0x22,
    SharingBufferExceeded = 0x24,
    HandleEOF = 0x26,
    HandleDiskFull = 0x27,
    NotSupported = 0x32,
    RemoteNotList = 0x33,
    DuplicateName = 0x34,
    BadNetPath = 0x35,
    NetworkBusy = 0x36,
    DevNotExist = 0x37,
    TooManyCommands = 0x38,
    AdapterHardwareError = 0x39,
    BadNetworkResponse = 0x3a,
    UnexpectedNetworkError = 0x3b,
    BadRemoteAdapter = 0x3c,
    PrinterQueueFull = 0x3d,
    NoSpoolSpace = 0x3e,
    PrintCancelled = 0x3f,
    NetworkNameDeleted = 0x40,
    NetworkAccessDenied = 0x41,
    BadDevType = 0x42,
    BadNetworkName = 0x43,
    TooManyNames = 0x44,
    TooManySession = 0x45,
    SharingPaused = 0x46,
    RequestNotAccepted = 0x47,
    RedirectPaused = 0x48,
    FileExists = 0x50,
    CannotMake = 0x52,
    FailInt24 = 0x53,
    OutOfStructures = 0x54,
    AlreadyAssigned = 0x55,
    InvalidPassword = 0x56,
    InvalidParameter = 0x57,
    NetworkWriteFault = 0x58,
    NoProcSlots = 0x59,
    TooManySemaphores = 0x64,
    ExclusiveSemAlreadyOwned = 0x65,
    SemIsSet = 0x66,
    TooManySemRequests = 0x67,
    InvalidAtInterruptTime = 0x68,
    SemOwnerDied = 0x69,
    SemUserLimit = 0x6a,
    DiskChange = 0x6b,
    DriveLocked = 0x6c,
    BrokenPipe = 0x6d,
    OpenFailed = 0x6e,
    BufferOverflow = 0x6f,
    DiskFull = 0x70,
    NoMoreSearchHandles = 0x71,
    InvalidTargetHandle = 0x72,
    InvalidCategory = 0x75,
    InvalidVerifySwitch = 0x76,
    BadDriverLevel = 0x77,
    callNotImplemented = 0x78,
    SemTimeout = 0x79,
    InsufficientBuffer = 0x7a,
    InvalidName = 0x7b,
    InvalidLevel = 0x7c,
    NoVolumeLabel = 0x7d,
    ModuleNotFound = 0x7e,
    ProcedureNotFound = 0x7f,
    WaitNoChildren = 0x80,
    ChildNotComplete = 0x81,
    DirectAccessHandle = 0x82,
    NegativeSeek = 0x83,
    SeekOnDevice = 0x84,
    IsJoinTarget = 0x85,
    IsJoined = 0x86,
    IsSubsted = 0x87,
    NotJoined = 0x88,
    NotSubsted = 0x89,
    JoinToJoin = 0x8a,
    SubstToSubst = 0x8b,
    JoinToSubst = 0x8c,
    SubstToJoin = 0x8d,
    BusyDrive = 0x8e,
    SameDrive = 0x8f,
    DirectoryNotRoot = 0x90,
    DirectoryNotEmpty = 0x91,
    IsSubstPath = 0x92,
    IsJoinPath = 0x93,
    PathBusy = 0x94,
    IsSubstTarget = 0x95,
    SystemTrace = 0x96,
    InvalidEventCount = 0x97,
    TooManyMuxWaiters = 0x98,
    InvalidListFormat = 0x99,
    labelTooLong = 0x9a,
    TooManyTcbs = 0x9b,
    SignalRefused = 0x9c,
    Discarded = 0x9d,
    NotLocked = 0x9e,
    BadThreadidAddr = 0x9f,
    BadArguments = 0xa0,
    BadPathname = 0xa1,
    SignalPending = 0xa2,
    MaxThrdsReached = 0xa4,
    LockFailed = 0xa7,
    Busy = 0xaa,
    DeviceSupportInProgress = 0xab,
    CancelViolation = 0xad,
    AtomicLocksNotSupported = 0xae,
    InvalidSegmentNumber = 0xb4,
    InvalidOrdinal = 0xb6,
    AlreadyExists = 0xb7,
    InvalidFlagNumber = 0xba,
    SemNotFound = 0xbb,
    InvalidStartingCodeseg = 0xbc,
    InvalidStackseg = 0xbd,
    InvalidModuletype = 0xbe,
    InvalidExeSignature = 0xbf,
    ExeMarkedInvalid = 0xc0,
    BadExeFormat = 0xc1,
    IteratedDataExceeds_64k = 0xc2,
    InvalidMinallocsize = 0xc3,
    DynlinkFromInvalidRing = 0xc4,
    IoplNotEnabled = 0xc5,
    InvalidSegmentDPL = 0xc6,
    AutoDataSegmentExceeds64k = 0xc7,
    Ring2SegmentMustBeMovable = 0xc8,
    RelocChainXeedsSegmentLimit = 0xc9,
    InFloopInRelocChain = 0xca,
    EnvironmentVariableNotFound = 0xcb,
    NoSignalSent = 0xcd,
    FilenameExcedRange = 0xce,
    Ring2StackInUse = 0xcf,
    MetaExpansionTooLong = 0xd0,
    InvalidSignalNumber = 0xd1,
    Thread1Inactive = 0xd2,
    Locked = 0xd4,
    TooManyModules = 0xd6,
    NestingNotAllowed = 0xd7,
    ExeMachineTypeMismatch = 0xd8,
    ExeCannotModifySignedBinary = 0xd9,
    ExeCannotModifyStrongSignedBinary = 0xda,
    FileCheckedOut = 0xdc,
    checkoutRequired = 0xdd,
    BadFileType = 0xde,
    FileTooLarge = 0xdf,
    FormsAuthRequired = 0xe0,
    VirusInfected = 0xe1,
    VirusDeleted = 0xe2,
    PipeLocal = 0xe5,
    BadPipe = 0xe6,
    PipeBusy = 0xe7,
    NoData = 0xe8,
    PipeNotConnected = 0xe9,
    MoreData = 0xea,
    SessionDisconnected = 0xf0,
    InvalidExtendedAttributeName = 0xfe,
    ExtendedAttributeListInconsistent = 0xff,
    WaitTimeout = 0x102,
    NoMoreItems = 0x103,
    CannotCopy = 0x10a,
    Directory = 0x10b,
    ExtendedAttributesDidntFit = 0x113,
    ExtendedAttributeFileCorrupt = 0x114,
    ExtendedAttributeTableFull = 0x115,
    InvalidExtendedAttributeHandle = 0x116,
    ExtendedAttributesNotSupported = 0x11a,
    NotOwner = 0x120,
    TooManyPosts = 0x12a,
    PartialCopy = 0x12b,
    OpLockNotGranted = 0x12c,
    InvalidOpLockProtocol = 0x12d,
    DiskTooFragmented = 0x12e,
    DeletePending = 0x12f,
    IncompatibleWithGlobalShortNameRegistrySetting = 0x130,
    ShortNamesNotEnabledOnVolume = 0x131,
    SecurityStreamIsInconsistent = 0x132,
    InvalidLockRange = 0x133,
    ImageSubsystemNotPresent = 0x134,
    NotificationGuidAlreadyDefined = 0x135,
    InvalidExceptionHandler = 0x136,
    DuplicatePrivileges = 0x137,
    NoRangesProcessed = 0x138,
    NotAllowedOnSystemFile = 0x139,
    DiskResourcesExhausted = 0x13a,
    InvalidToken = 0x13b,
    DeviceFeatureNotSupported = 0x13c,
    MemoryMidNotFound = 0x13d,
    ScopeNotFound = 0x13e,
    UndefinedScope = 0x13f,
    InvalidCentralAccessPolicy = 0x140,
    DeviceUnreachable = 0x141,
    DeviceNoResources = 0x142,
    DataChecksumError = 0x143,
    IntermixedKernelExtendedAttributeOperation = 0x144,
    FileLevelTrimNotSupported = 0x146,
    OffsetAlignmentViolation = 0x147,
    InvalidFieldInParameterList = 0x148,
    OperationInProgress = 0x149,
    BadDevicePath = 0x14a,
    TooManyDescriptors = 0x14b,
    scrubDataDisabled = 0x14c,
    NotRedundantStorage = 0x14d,
    ResidentFileNotSupported = 0x14e,
    CompressedFileNotSupported = 0x14f,
    DirectoryNotSupported = 0x150,
    NotReadFromCopy = 0x151,
    FailNoactionReboot = 0x15e,
    FailShutdown = 0x15f,
    FailRestart = 0x160,
    MaxSessionsReached = 0x161,
    ThreadModeAlreadyBackground = 0x190,
    ThreadModeNotBackground = 0x191,
    ProcessModeAlreadyBackground = 0x192,
    ProcessModeNotBackground = 0x193,
    InvalidAddress = 0x1e7,
  }
}
