using System;

namespace ThirtyTwo.Kernel32.Enumerations
{
    /// <summary>
    /// Specifies the system error codes returned by the "GetLastError" method.
    /// </summary>
    [Flags]
    public enum SYSTEM_ERROR_CODES : uint
    {
        /// <summary>
        /// The operation completed successfully.
        /// </summary>
        ERROR_SUCCESS = 0x0,

        /// <summary>
        /// Incorrect function.
        /// </summary>
        ERROR_INVALID_FUNCTION = 0x1,

        /// <summary>
        /// The system cannot find the file specified.
        /// </summary>
        ERROR_FILE_NOT_FOUND = 0x2,

        /// <summary>
        /// The system cannot find the path specified.
        /// </summary>
        ERROR_PATH_NOT_FOUND = 0x3,

        /// <summary>
        /// The system cannot open the file.
        /// </summary>
        ERROR_TOO_MANY_OPEN_FILES = 0x4,

        /// <summary>
        /// Access is denied.
        /// </summary>
        ERROR_ACCESS_DENIED = 0x5,

        /// <summary>
        /// The handle is invalid.
        /// </summary>
        ERROR_INVALID_HANDLE = 0x6,

        /// <summary>
        /// The storage control blocks were destroyed.
        /// </summary>
        ERROR_ARENA_TRASHED = 0x7,

        /// <summary>
        /// Not enough memory resources are available to process this command.
        /// </summary>
        ERROR_NOT_ENOUGH_MEMORY = 0x8,

        /// <summary>
        /// The storage control block address is invalid.
        /// </summary>
        ERROR_INVALID_BLOCK = 0x9,

        /// <summary>
        /// The environment is incorrect.
        /// </summary>
        ERROR_BAD_ENVIRONMENT = 0xA,

        /// <summary>
        /// An attempt was made to load a program with an incorrect format.
        /// </summary>
        ERROR_BAD_FORMAT = 0xB,

        /// <summary>
        /// The access code is invalid.
        /// </summary>
        ERROR_INVALID_ACCESS = 0xC,

        /// <summary>
        /// The data is invalid.
        /// </summary>
        ERROR_INVALID_DATA = 0xD,

        /// <summary>
        /// Not enough storage is available to complete this operation.
        /// </summary>
        ERROR_OUTOFMEMORY = 0xE,

        /// <summary>
        /// The system cannot find the drive specified.
        /// </summary>
        ERROR_INVALID_DRIVE = 0xF,

        /// <summary>
        /// The directory cannot be removed.
        /// </summary>
        ERROR_CURRENT_DIRECTORY = 0x10,

        /// <summary>
        /// The system cannot move the file to a different disk drive.
        /// </summary>
        ERROR_NOT_SAME_DEVICE = 0x11,

        /// <summary>
        /// There are no more files.
        /// </summary>
        ERROR_NO_MORE_FILES = 0x12,

        /// <summary>
        /// The media is write protected.
        /// </summary>
        ERROR_WRITE_PROTECT = 0x13,

        /// <summary>
        /// The system cannot find the device specified.
        /// </summary>
        ERROR_BAD_UNIT = 0x14,

        /// <summary>
        /// The device is not ready.
        /// </summary>
        ERROR_NOT_READY = 0x15,

        /// <summary>
        /// The device does not recognize the command.
        /// </summary>
        ERROR_BAD_COMMAND = 0x16,

        /// <summary>
        /// Data error (cyclic redundancy check).
        /// </summary>
        ERROR_CRC = 0x17,

        /// <summary>
        /// The program issued a command but the command length is incorrect.
        /// </summary>
        ERROR_BAD_LENGTH = 0x18,

        /// <summary>
        /// The drive cannot locate a specific area or track on the disk.
        /// </summary>
        ERROR_SEEK = 0x19,

        /// <summary>
        /// The specified disk or diskette cannot be accessed.
        /// </summary>
        ERROR_NOT_DOS_DISK = 0x1A,

        /// <summary>
        /// The drive cannot find the sector requested.
        /// </summary>
        ERROR_SECTOR_NOT_FOUND = 0x1B,

        /// <summary>
        /// The printer is out of paper.
        /// </summary>
        ERROR_OUT_OF_PAPER = 0x1C,

        /// <summary>
        /// The system cannot write to the specified device.
        /// </summary>
        ERROR_WRITE_FAULT = 0x1D,

        /// <summary>
        /// The system cannot read from the specified device.
        /// </summary>
        ERROR_READ_FAULT = 0x1E,

        /// <summary>
        /// A device attached to the system is not functioning.
        /// </summary>
        ERROR_GEN_FAILURE = 0x1F,

        /// <summary>
        /// The process cannot access the file because it is being used by another process.
        /// </summary>
        ERROR_SHARING_VIOLATION = 0x20,

        /// <summary>
        /// The process cannot access the file because another process has locked a portion of
        /// the file.
        /// </summary>
        ERROR_LOCK_VIOLATION = 0x21,

        /// <summary>
        /// The wrong diskette is in the drive. Insert %2 (Volume Serial Number: %3) into
        /// drive %1.
        /// </summary>
        ERROR_WRONG_DISK = 0x22,

        /// <summary>
        /// Too many files opened for sharing.
        /// </summary>
        ERROR_SHARING_BUFFER_EXCEEDED = 0x24,

        /// <summary>
        /// Reached the end of the file.
        /// </summary>
        ERROR_HANDLE_EOF = 0x26,

        /// <summary>
        /// The disk is full.
        /// </summary>
        ERROR_HANDLE_DISK_FULL = 0x27,

        /// <summary>
        /// The request is not supported.
        /// </summary>
        ERROR_NOT_SUPPORTED = 0x32,

        /// <summary>
        /// Windows cannot find the network path. Verify that the network path is correct and
        /// the destination computer is not busy or turned off. If Windows still cannot find
        /// the network path, contact your network administrator.
        /// </summary>
        ERROR_REM_NOT_LIST = 0x33,

        /// <summary>
        /// You were not connected because a duplicate name exists on the network. If joining a
        /// domain, go to System in Control Panel to change the computer name and try again. If
        /// joining a work group, choose another work group name.
        /// </summary>
        ERROR_DUP_NAME = 0x34,

        /// <summary>
        /// The network path was not found.
        /// </summary>
        ERROR_BAD_NETPATH = 0x35,

        /// <summary>
        /// The network is busy.
        /// </summary>
        ERROR_NETWORK_BUSY = 0x36,

        /// <summary>
        /// The specified network resource or device is no longer available.
        /// </summary>
        ERROR_DEV_NOT_EXIST = 0x37,

        /// <summary>
        /// The network BIOS command limit has been reached.
        /// </summary>
        ERROR_TOO_MANY_CMDS = 0x38,

        /// <summary>
        /// A network adapter hardware error occurred.
        /// </summary>
        ERROR_ADAP_HDW_ERR = 0x39,

        /// <summary>
        /// The specified server cannot perform the requested operation.
        /// </summary>
        ERROR_BAD_NET_RESP = 0x3A,

        /// <summary>
        /// An unexpected network error occurred.
        /// </summary>
        ERROR_UNEXP_NET_ERR = 0x3B,

        /// <summary>
        /// The remote adapter is not compatible.
        /// </summary>
        ERROR_BAD_REM_ADAP = 0x3C,

        /// <summary>
        /// The printer queue is full.
        /// </summary>
        ERROR_PRINTQ_FULL = 0x3D,

        /// <summary>
        /// Space to store the file waiting to e printed is not available on the server.
        /// </summary>
        ERROR_NO_SPOOL_SPACE = 0x3E,

        /// <summary>
        /// Your file waiting to be printed was deleted.
        /// </summary>
        ERROR_PRINT_CANCELLED = 0x3F,

        /// <summary>
        /// The specified network name is no longer available.
        /// </summary>
        ERROR_NETNAME_DELETED = 0x40,

        /// <summary>
        /// Network access is denied.
        /// </summary>
        ERROR_NETWORK_ACCESS_DENIED = 0x41,

        /// <summary>
        /// The network resource type is not correct.
        /// </summary>
        ERROR_BAD_DEV_TYPE = 0x42,

        /// <summary>
        /// The network name cannot be found.
        /// </summary>
        ERROR_BAD_NET_NAME = 0x43,

        /// <summary>
        /// The name limit for the local computer network adapter card was exceeded.
        /// </summary>
        ERROR_TOO_MANY_NAMES = 0x44,

        /// <summary>
        /// The network BIOS session limit was exceeded.
        /// </summary>
        ERROR_TOO_MANY_SESS = 0x45,

        /// <summary>
        /// The remote server has been paused o is in the process of being started.
        /// </summary>
        ERROR_SHARING_PAUSED = 0x46,

        /// <summary>
        /// No more connections can be made to this remote computer at this time because there
        /// are already as many connections as the computer can accept.
        /// </summary>
        ERROR_REQ_NOT_ACCEP = 0x47,

        /// <summary>
        /// The specified printer or disk device has been paused.
        /// </summary>
        ERROR_REDIR_PAUSED = 0x48,

        /// <summary>
        /// The file exists.
        /// </summary>
        ERROR_FILE_EXISTS = 0x50,

        /// <summary>
        /// The directory or file cannot be related.
        /// </summary>
        ERROR_CANNOT_MAKE = 0x52,

        /// <summary>
        /// Fail on INT 24
        /// </summary>
        ERROR_FAIL_I24 = 0x53,

        /// <summary>
        /// Storage to process this request is not available.
        /// </summary>
        ERROR_OUT_OF_STRUCTURES = 0x54,

        /// <summary>
        /// The local device name is already in use.
        /// </summary>
        ERROR_ALREADY_ASSIGNED = 0x55,

        /// <summary>
        /// The specified network password is not correct.
        /// </summary>
        ERROR_INVALID_PASSWORD = 0x56,

        /// <summary>
        /// The parameter is incorrect.
        /// </summary>
        ERROR_INVALID_PARAMETER = 0x57,

        /// <summary>
        /// A write fault occurred on the network.
        /// </summary>
        ERROR_NET_WRITE_FAULT = 0x58,

        /// <summary>
        /// The system cannot start another process at this time.
        /// </summary>
        ERROR_NO_PROC_SLOTS = 0x59,

        /// <summary>
        /// Cannot create another system semaphore.
        /// </summary>
        ERROR_TOO_MANY_SEMAPHORES = 0x64,

        /// <summary>
        /// The exclusive semaphore is owned by another process.
        /// </summary>
        ERROR_EXCL_SEM_ALREADY_OWNED = 0x65,

        /// <summary>
        /// The semaphore is set and cannot be closed.
        /// </summary>
        ERROR_SEM_IS_SET = 0x66,

        /// <summary>
        /// The semaphore cannot be set again.
        /// </summary>
        ERROR_TOO_MANY_SEM_REQUESTS = 0x67,

        /// <summary>
        /// Cannot request exclusive semaphores at interrupt time.
        /// </summary>
        ERROR_INVALID_AT_INTERRUPT_TIME = 0x68,

        /// <summary>
        /// The previous ownership of this semaphore has ended.
        /// </summary>
        ERROR_SEM_OWNER_DIED = 0x69,

        /// <summary>
        /// Insert the diskette for drive %1.
        /// </summary>
        ERROR_SEM_USER_LIMIT = 0x6A,

        /// <summary>
        /// The program stopped because an alternate diskette was not inserted.
        /// </summary>
        ERROR_DISK_CHANGE = 0x6B,

        /// <summary>
        /// The disk is in use or locked by another process.
        /// </summary>
        ERROR_DRIVE_LOCKED = 0x6C,

        /// <summary>
        /// The pipe has been ended.
        /// </summary>
        ERROR_BROKEN_PIPE = 0x6D,

        /// <summary>
        /// The system cannot open the device or file specified.
        /// </summary>
        ERROR_OPEN_FAILED = 0x6E,

        /// <summary>
        /// The file name is too long.
        /// </summary>
        ERROR_BUFFER_OVERFLOW = 0x6F,

        /// <summary>
        /// There is not enough space on the disk.
        /// </summary>
        ERROR_DISK_FULL = 0x70,

        /// <summary>
        /// No more internal file identifiers available.
        /// </summary>
        ERROR_NO_MORE_SEARCH_HANDLES = 0x71,

        /// <summary>
        /// The target internal file identifier is incorrect.
        /// </summary>
        ERROR_INVALID_TARGET_HANDLE = 0x72,

        /// <summary>
        /// The IOCTL call made by the application program is not correct.
        /// </summary>
        ERROR_INVALID_CATEGORY = 0x75,

        /// <summary>
        /// The verify-on-write switch parameter value is not correct.
        /// </summary>
        ERROR_INVALID_VERIFY_SWITCH = 0x76,

        /// <summary>
        /// The system does not support the command requested.
        /// </summary>
        ERROR_BAD_DRIVER_LEVEL = 0x77,

        /// <summary>
        /// This function is not supported on this system.
        /// </summary>
        ERROR_CALL_NOT_IMPLEMENTED = 0x78,

        /// <summary>
        /// The semaphore timeout period has expired.
        /// </summary>
        ERROR_SEM_TIMEOUT = 0x79,

        /// <summary>
        /// The data area passed to a system call is too small.
        /// </summary>
        ERROR_INSUFFICIENT_BUFFER = 0x7A,

        /// <summary>
        /// The filename, directory name, or volume label syntax is incorrect.
        /// </summary>
        ERROR_INVALID_NAME = 0x7B,

        /// <summary>
        /// The system call level is not correct.
        /// </summary>
        ERROR_INVALID_LEVEL = 0x7C,

        /// <summary>
        /// The disk has no volume label.
        /// </summary>
        ERROR_NO_VOLUME_LABEL = 0x7D,

        /// <summary>
        /// The specified module could not be found.
        /// </summary>
        ERROR_MOD_NOT_FOUND = 0x7E,

        /// <summary>
        /// The specified procedure could not be found.
        /// </summary>
        ERROR_PROC_NOT_FOUND = 0x7F,

        /// <summary>
        /// There are no child processes to wait or.
        /// </summary>
        ERROR_WAIT_NO_CHILDREN = 0x80,

        /// <summary>
        /// The %1 application cannot be run in Win32 mode.
        /// </summary>
        ERROR_CHILD_NOT_COMPLETE = 0x81,

        /// <summary>
        /// Attempt to use a file handle to an open disk partition for an operation other than
        /// raw disk I/O.
        /// </summary>
        ERROR_DIRECT_ACCESS_HANDLE = 0x82,

        /// <summary>
        /// An attempt was made to move the fie pointer before the beginning of the file.
        /// </summary>
        ERROR_NEGATIVE_SEEK = 0x83,

        /// <summary>
        /// The file pointer cannot be set on the specified device or file.
        /// </summary>
        ERROR_SEEK_ON_DEVICE = 0x84,

        /// <summary>
        /// A JOIN or SUBST command cannot be used for a drive that contains previously
        /// joined drives.
        /// </summary>
        ERROR_IS_JOIN_TARGET = 0x85,

        /// <summary>
        /// An attempt was made to use a JIN or SUBST command on a drive that has already
        /// been joined.
        /// </summary>
        ERROR_IS_JOINED = 0x86,

        /// <summary>
        /// An attempt was made to use a JON or SUBST command on a drive that has already
        /// been substituted.
        /// </summary>
        ERROR_IS_SUBSTED = 0x87,

        /// <summary>
        /// The system tried to delete the OIN of a drive that is not joined.
        /// </summary>
        ERROR_NOT_JOINED = 0x88,

        /// <summary>
        /// The system tried to delete the substitution of a drive that is not substituted.
        /// </summary>
        ERROR_NOT_SUBSTED = 0x89,

        /// <summary>
        /// The system tried to join a drive to a directory on a joined drive.
        /// </summary>
        ERROR_JOIN_TO_JOIN = 0x8A,

        /// <summary>
        /// The system tried to substitute a drive to a directory on a substituted drive.
        /// </summary>
        ERROR_SUBST_TO_SUBST = 0x8B,

        /// <summary>
        /// The system tried to join a drive to a directory on a substituted drive.
        /// </summary>
        ERROR_JOIN_TO_SUBST = 0x8C,

        /// <summary>
        /// The system tried to SUBST a drive to a directory on a joined drive.
        /// </summary>
        ERROR_SUBST_TO_JOIN = 0x8D,

        /// <summary>
        /// The system cannot perform a JOIN or SUBST at this time.
        /// </summary>
        ERROR_BUSY_DRIVE = 0x8E,

        /// <summary>
        /// The system cannot join or substitute a drive to or for a directory on the
        /// same drive.
        /// </summary>
        ERROR_SAME_DRIVE = 0x8F,

        /// <summary>
        /// The directory is not a subdirectory of the root directory.
        /// </summary>
        ERROR_DIR_NOT_ROOT = 0x90,

        /// <summary>
        /// The directory is not empty.
        /// </summary>
        ERROR_DIR_NOT_EMPTY = 0x91,

        /// <summary>
        /// The path specified is being used in a substitute.
        /// </summary>
        ERROR_IS_SUBST_PATH = 0x92,

        /// <summary>
        /// Not enough resources are available to process this command.
        /// </summary>
        ERROR_IS_JOIN_PATH = 0x93,

        /// <summary>
        /// The path specified cannot be used at this time.
        /// </summary>
        ERROR_PATH_BUSY = 0x94,

        /// <summary>
        /// An attempt was made to join or substitute a drive for which a directory on the
        /// drive is the target of a previous substitute.
        /// </summary>
        ERROR_IS_SUBST_TARGET = 0x95,

        /// <summary>
        /// System trace information was not specified in your "CONFIG.SYS" file, or tracing
        /// is disallowed.
        /// </summary>
        ERROR_SYSTEM_TRACE = 0x96,

        /// <summary>
        /// The number of specified semaphore events for DosMuxSemWait is not correct.
        /// </summary>
        ERROR_INVALID_EVENT_COUNT = 0x97,

        /// <summary>
        /// DosMuxSemWait did not execute; too many semaphores are already set.
        /// </summary>
        ERROR_TOO_MANY_MUXWAITERS = 0x98,

        /// <summary>
        /// The DosMuxSemWait list is not correct.
        /// </summary>
        ERROR_INVALID_LIST_FORMAT = 0x99,

        /// <summary>
        /// The volume label you entered exceeds the label character limit of the target
        /// file system.
        /// </summary>
        ERROR_LABEL_TOO_LONG = 0x9A,

        /// <summary>
        /// Cannot create another thread.
        /// </summary>
        ERROR_TOO_MANY_TCBS = 0x9B,

        /// <summary>
        /// The recipient process has refused the signal.
        /// </summary>
        ERROR_SIGNAL_REFUSED = 0x9C,

        /// <summary>
        /// The segment is already discard and cannot be locked.
        /// </summary>
        ERROR_DISCARDED = 0x9D,

        /// <summary>
        /// The segment is already unlocked.
        /// </summary>
        ERROR_NOT_LOCKED = 0x9E,

        /// <summary>
        /// The address for the thread ID is not correct.
        /// </summary>
        ERROR_BAD_THREADID_ADDR = 0x9F,

        /// <summary>
        /// One or more arguments are not correct.
        /// </summary>
        ERROR_BAD_ARGUMENTS = 0xA0,

        /// <summary>
        /// The specified path is invalid.
        /// </summary>
        ERROR_BAD_PATHNAME = 0xA1,

        /// <summary>
        /// A signal is already pending.
        /// </summary>
        ERROR_SIGNAL_PENDING = 0xA2,

        /// <summary>
        /// No more threads can be created in the system.
        /// </summary>
        ERROR_MAX_THRDS_REACHED = 0xA4,

        /// <summary>
        /// Unable to lock a region of a file.
        /// </summary>
        ERROR_LOCK_FAILED = 0xA7,

        /// <summary>
        /// The requested resource is in use.
        /// </summary>
        ERROR_BUSY = 0xAA,

        /// <summary>
        /// Device's command support detection is in progress.
        /// </summary>
        ERROR_DEVICE_SUPPORT_IN_PROGRESS = 0xAB,

        /// <summary>
        /// A lock request was not outstanding for the supplied cancel region.
        /// </summary>
        ERROR_CANCEL_VIOLATION = 0xAD,

        /// <summary>
        /// The file system does not support atomic changes to the lock type.
        /// </summary>
        ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 0xAE,

        /// <summary>
        /// The system detected a segment number that was not correct.
        /// </summary>
        ERROR_INVALID_SEGMENT_NUMBER = 0xB4,

        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_ORDINAL = 0xB6,

        /// <summary>
        /// Cannot create a file when that file already exists.
        /// </summary>
        ERROR_ALREADY_EXISTS = 0xB7,

        /// <summary>
        /// The flag passed is not correct.
        /// </summary>
        ERROR_INVALID_FLAG_NUMBER = 0xBA,

        /// <summary>
        /// The specified system semaphore name was not found.
        /// </summary>
        ERROR_SEM_NOT_FOUND = 0xBB,

        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_STARTING_CODESEG = 0xBC,

        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_STACKSEG = 0xBD,

        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_MODULETYPE = 0xBE,

        /// <summary>
        /// Cannot run %1 in Win32 mode.
        /// </summary>
        ERROR_INVALID_EXE_SIGNATURE = 0xBF,

        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_EXE_MARKED_INVALID = 0xC0,

        /// <summary>
        /// %1 is not a valid Win32 application.
        /// </summary>
        ERROR_BAD_EXE_FORMAT = 0xC1,

        /// <summary>
        /// The operating system cannot run %1
        /// </summary>
        ERROR_ITERATED_DATA_EXCEEDS_64k = 0xC2,

        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_MINALLOCSIZE = 0xC3,

        /// <summary>
        /// The operating system cannot run this application program.
        /// </summary>
        ERROR_DYNLINK_FROM_INVALID_RING = 0xC4,

        /// <summary>
        /// The operating system is not presently configured to run this application.
        /// </summary>
        ERROR_IOPL_NOT_ENABLED = 0xC5,

        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_SEGDPL = 0xC6,

        /// <summary>
        /// The operating system cannot run this application program.
        /// </summary>
        ERROR_AUTODATASEG_EXCEEDS_64k = 0xC7,

        /// <summary>
        /// The code segment cannot be greater than or equal to 64K.
        /// </summary>
        ERROR_RING2SEG_MUST_BE_MOVABLE = 0xC8,

        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 0xC9,

        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INFLOOP_IN_RELOC_CHAIN = 0xCA,

        /// <summary>
        /// The system could not find the environment option that was entered.
        /// </summary>
        ERROR_ENVVAR_NOT_FOUND = 0xCB,

        /// <summary>
        /// No process in the command subtree has a signal handler.
        /// </summary>
        ERROR_NO_SIGNAL_SENT = 0xCD,

        /// <summary>
        /// The filename or extension is too long.
        /// </summary>
        ERROR_FILENAME_EXCED_RANGE = 0xCE,

        /// <summary>
        /// The ring 2 stack is in use.
        /// </summary>
        ERROR_RING2_STACK_IN_USE = 0xCF,

        /// <summary>
        /// The global filename characters, "*" or "?", are entered incorrectly or too many
        /// global filename characters are specified.
        /// </summary>
        ERROR_META_EXPANSION_TOO_LONG = 0xD0,

        /// <summary>
        /// The signal being posted is not correct.
        /// </summary>
        ERROR_INVALID_SIGNAL_NUMBER = 0xD1,

        /// <summary>
        /// The signal handler cannot be set.
        /// </summary>
        ERROR_THREAD_1_INACTIVE = 0xD2,

        /// <summary>
        /// The segment is locked and cannot be reallocated.
        /// </summary>
        ERROR_LOCKED = 0xD4,

        /// <summary>
        /// Too many dynamic - link modules are attached to this program or dynamic -
        /// link module.
        /// </summary>
        ERROR_TOO_MANY_MODULES = 0xD6,

        /// <summary>
        /// Cannot nest calls to LoadModule.
        /// </summary>
        ERROR_NESTING_NOT_ALLOWED = 0xD7,

        /// <summary>
        /// This version of %1 is not compatible with the version of Windows you're running.
        /// Check your computer's system information and then contact the software publisher.
        /// </summary>
        ERROR_EXE_MACHINE_TYPE_MISMATCH = 0xD8,

        /// <summary>
        /// The image file %1 is signed, unable to modify.
        /// </summary>
        ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 0xD9,

        /// <summary>
        /// The image file %1 is strong signed, unable to modify.
        /// </summary>
        ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 0xDA,

        /// <summary>
        /// This file is checked out or locked for editing by another user.
        /// </summary>
        ERROR_FILE_CHECKED_OUT = 0xDC,

        /// <summary>
        /// The file must be checked out before saving changes.
        /// </summary>
        ERROR_CHECKOUT_REQUIRED = 0xDD,

        /// <summary>
        /// The file type being saved or retrieved has been blocked.
        /// </summary>
        ERROR_BAD_FILE_TYPE = 0xDE,

        /// <summary>
        /// The file size exceeds the limit allowed and cannot be saved.
        /// </summary>
        ERROR_FILE_TOO_LARGE = 0xDF,

        /// <summary>
        /// Access Denied. Before opening files in this location, you must first add the web
        /// site to your trusted sites list, browse to the web site, and select the option to
        /// login automatically.
        /// </summary>
        ERROR_FORMS_AUTH_REQUIRED = 0xE0,

        /// <summary>
        /// Operation did not complete successfully because the file contains a virus or
        /// potentially unwanted software.
        /// </summary>
        ERROR_VIRUS_INFECTED = 0xE1,

        /// <summary>
        /// This file contains a virus or potentially unwanted software and cannot be opened.
        /// Due to the nature of this virus or potentially unwanted software, the file has been
        /// removed from this location.
        /// </summary>
        ERROR_VIRUS_DELETED = 0xE2,

        /// <summary>
        /// The pipe is local.
        /// </summary>
        ERROR_PIPE_LOCAL = 0xE5,

        /// <summary>
        /// The pipe state is invalid.
        /// </summary>
        ERROR_BAD_PIPE = 0xE6,

        /// <summary>
        /// All pipe instances are busy.
        /// </summary>
        ERROR_PIPE_BUSY = 0xE7,

        /// <summary>
        /// The pipe is being closed.
        /// </summary>
        ERROR_NO_DATA = 0xE8,

        /// <summary>
        /// No process is on the other end of the pipe.
        /// </summary>
        ERROR_PIPE_NOT_CONNECTED = 0xE9,

        /// <summary>
        /// More data is available.
        /// </summary>
        ERROR_MORE_DATA = 0xEA,

        /// <summary>
        /// The session was canceled.
        /// </summary>
        ERROR_VC_DISCONNECTED = 0xF0,

        /// <summary>
        /// The specified extended attribute name was invalid.
        /// </summary>
        ERROR_INVALID_EA_NAME = 0xFE,

        /// <summary>
        /// The extended attributes are inconsistent.
        /// </summary>
        ERROR_EA_LIST_INCONSISTENT = 0xFF,

        /// <summary>
        /// The wait operation timed out.
        /// </summary>
        WAIT_TIMEOUT = 0x102,

        /// <summary>
        /// No more data is available.
        /// </summary>
        ERROR_NO_MORE_ITEMS = 0x103,

        /// <summary>
        /// The copy functions cannot be used.
        /// </summary>
        ERROR_CANNOT_COPY = 0x10A,

        /// <summary>
        /// The directory name is invalid.
        /// </summary>
        ERROR_DIRECTORY = 0x10B,

        /// <summary>
        /// The extended attributes did not fit in the buffer.
        /// </summary>
        ERROR_EAS_DIDNT_FIT = 0x113,

        /// <summary>
        /// The extended attribute file on the mounted file system is corrupt.
        /// </summary>
        ERROR_EA_FILE_CORRUPT = 0x114,

        /// <summary>
        /// The extended attribute table file i full.
        /// </summary>
        ERROR_EA_TABLE_FULL = 0x115,

        /// <summary>
        /// The specified extended attribute handle is invalid.
        /// </summary>
        ERROR_INVALID_EA_HANDLE = 0x116,

        /// <summary>
        /// The mounted file system does not support extended attributes.
        /// </summary>
        ERROR_EAS_NOT_SUPPORTED = 0x11A,

        /// <summary>
        /// Attempt to release mutex not owned by caller.
        /// </summary>
        ERROR_NOT_OWNER = 0x120,

        /// <summary>
        /// Too many posts were made to a semaphore.
        /// </summary>
        ERROR_TOO_MANY_POSTS = 0x12A,

        /// <summary>
        /// Only part of a ReadProcessMemory or WriteProcessMemory request was completed.
        /// </summary>
        ERROR_PARTIAL_COPY = 0x12B,

        /// <summary>
        /// The oplock request is denied.
        /// </summary>
        ERROR_OPLOCK_NOT_GRANTED = 0x12C,

        /// <summary>
        /// An invalid oplock acknowledgment was received by the system.
        /// </summary>
        ERROR_INVALID_OPLOCK_PROTOCOL = 0x12D,

        /// <summary>
        /// The volume is too fragmented to complete his operation.
        /// </summary>
        ERROR_DISK_TOO_FRAGMENTED = 0x12E,

        /// <summary>
        /// The file cannot be opened because itis in the process of being deleted.
        /// </summary>
        ERROR_DELETE_PENDING = 0x12F,

        /// <summary>
        /// Short name settings may not be changed on this volume due to the global
        /// registry setting.
        /// </summary>
        ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = 0x130,

        /// <summary>
        /// Short names are not enabled on this volume.
        /// </summary>
        ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = 0x131,

        /// <summary>
        /// The security stream for the given volume is in an inconsistent state. Please run
        /// CHKDSK on the volume.
        /// </summary>
        ERROR_SECURITY_STREAM_IS_INCONSISTENT = 0x132,

        /// <summary>
        /// A requested file lock operation cannot be processed due to an invalid byte range.
        /// </summary>
        ERROR_INVALID_LOCK_RANGE = 0x133,

        /// <summary>
        /// The subsystem needed to support the image type is not present.
        /// </summary>
        ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT = 0x134,

        /// <summary>
        /// The specified file already has a notification GUID associated with it.
        /// </summary>
        ERROR_NOTIFICATION_GUID_ALREADY_DEFINED = 0x135,

        /// <summary>
        /// An invalid exception handler routine has been detected.
        /// </summary>
        ERROR_INVALID_EXCEPTION_HANDLER = 0x136,

        /// <summary>
        /// Duplicate privileges were specified for the token.
        /// </summary>
        ERROR_DUPLICATE_PRIVILEGES = 0x137,

        /// <summary>
        /// No ranges for the specified operation were able to be processed.
        /// </summary>
        ERROR_NO_RANGES_PROCESSED = 0x138,

        /// <summary>
        /// Operation is not allowed on a file system internal file.
        /// </summary>
        ERROR_NOT_ALLOWED_ON_SYSTEM_FILE = 0x139,

        /// <summary>
        /// The physical resources of this disk have been exhausted.
        /// </summary>
        ERROR_DISK_RESOURCES_EXHAUSTED = 0x13A,

        /// <summary>
        /// The token representing the data is invalid.
        /// </summary>
        ERROR_INVALID_TOKEN = 0x13B,

        /// <summary>
        /// The device does not support the command feature.
        /// </summary>
        ERROR_DEVICE_FEATURE_NOT_SUPPORTED = 0x13C,

        /// <summary>
        /// The system cannot find message text for message number 0x%1 in the message
        /// file for %2.
        /// </summary>
        ERROR_MR_MID_NOT_FOUND = 0x13D,

        /// <summary>
        /// The scope specified was not found.
        /// </summary>
        ERROR_SCOPE_NOT_FOUND = 0x13E,

        /// <summary>
        /// The Central Access Policy specified is not defined on the target machine.
        /// </summary>
        ERROR_UNDEFINED_SCOPE = 0x13F,

        /// <summary>
        /// The Central Access Policy obtained from Active Directory is invalid.
        /// </summary>
        ERROR_INVALID_CAP = 0x140,

        /// <summary>
        /// The device is unreachable.
        /// </summary>
        ERROR_DEVICE_UNREACHABLE = 0x141,

        /// <summary>
        /// The target device has insufficient resources to complete the operation.
        /// </summary>
        ERROR_DEVICE_NO_RESOURCES = 0x142,

        /// <summary>
        /// A data integrity checksum error occurred. Data in the file stream is corrupt.
        /// </summary>
        ERROR_DATA_CHECKSUM_ERROR = 0x143,

        /// <summary>
        /// An attempt was made to modify both a KERNEL and normal Extended Attribute (EA) in
        /// the same operation.
        /// </summary>
        ERROR_INTERMIXED_KERNEL_EA_OPERATION = 0x144,

        /// <summary>
        /// Device does not support file-level TRIM.
        /// </summary>
        ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED = 0x146,

        /// <summary>
        /// The command specified a data offset that does not align to the device's
        /// granularity/alignment.
        /// </summary>
        ERROR_OFFSET_ALIGNMENT_VIOLATION = 0x147,

        /// <summary>
        /// The command specified an invalid field in its parameter list.
        /// </summary>
        ERROR_INVALID_FIELD_IN_PARAMETER_LIST = 0x148,

        /// <summary>
        /// An operation is currently in progress with he device.
        /// </summary>
        ERROR_OPERATION_IN_PROGRESS = 0x149,

        /// <summary>
        /// An attempt was made to send down the command via an invalid path to the
        /// target device.
        /// </summary>
        ERROR_BAD_DEVICE_PATH = 0x14A,

        /// <summary>
        /// The command specified a number of descriptors that exceeded the maximum supported
        /// by the device.
        /// </summary>
        ERROR_TOO_MANY_DESCRIPTORS = 0x14B,

        /// <summary>
        /// Scrub is disabled on the specified file.
        /// </summary>
        ERROR_SCRUB_DATA_DISABLED = 0x14C,

        /// <summary>
        /// The storage device does not provide redundancy.
        /// </summary>
        ERROR_NOT_REDUNDANT_STORAGE = 0x14D,

        /// <summary>
        /// An operation is not supported on a resident file.
        /// </summary>
        ERROR_RESIDENT_FILE_NOT_SUPPORTED = 0x14E,

        /// <summary>
        /// An operation is not supported on a compressed file.
        /// </summary>
        ERROR_COMPRESSED_FILE_NOT_SUPPORTED = 0x14F,

        /// <summary>
        /// An operation is not supported on a directory.
        /// </summary>
        ERROR_DIRECTORY_NOT_SUPPORTED = 0x150,

        /// <summary>
        /// The specified copy of the requested data could not be read.
        /// </summary>
        ERROR_NOT_READ_FROM_COPY = 0x151,

        /// <summary>
        /// No action was taken as a system reboot is required.
        /// </summary>
        ERROR_FAIL_NOACTION_REBOOT = 0x15E,

        /// <summary>
        /// The shutdown operation failed.
        /// </summary>
        ERROR_FAIL_SHUTDOWN = 0x15F,

        /// <summary>
        /// The restart operation failed.
        /// </summary>
        ERROR_FAIL_RESTART = 0x160,

        /// <summary>
        /// The maximum number of sessions has been reached.
        /// </summary>
        ERROR_MAX_SESSIONS_REACHED = 0x161,

        /// <summary>
        /// The thread is already in background processing mode.
        /// </summary>
        ERROR_THREAD_MODE_ALREADY_BACKGROUND = 0x190,

        /// <summary>
        /// The thread is not in background processing mode.
        /// </summary>
        ERROR_THREAD_MODE_NOT_BACKGROUND = 0x191,

        /// <summary>
        /// The process is already in background processing mode.
        /// </summary>
        ERROR_PROCESS_MODE_ALREADY_BACKGROUND = 0x192,

        /// <summary>
        /// The process is not in background processing mode.
        /// </summary>
        ERROR_PROCESS_MODE_NOT_BACKGROUND = 0x193,

        /// <summary>
        /// Attempt to access invalid address.
        /// </summary>
        ERROR_INVALID_ADDRESS = 0x1E7,
    }
}
