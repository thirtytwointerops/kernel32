[url_visualstudio]: https://visualstudio.microsoft.com/
[url_releases]: https://github.com/thirtytwointerops/kernel32/releases
[url_author]: https://github.com/eduardobaginskicosta
[url_dotnet]: https://dotnet.microsoft.com/en-us/download/dotnet-framework
[url_nuget]: https://www.nuget.org/packages/ThirtyTwo.Kernel32/
[url_curl]: https://curl.se/download.html
[url_docs]: https://learn.microsoft.com/en-us/windows/console/console-reference

<!-- ======= -->

## 📘 Get Started

The [Kernel32][url_nuget], developed by a community specialized in the interoperability
of **Windows APIs**, enables the use of all functions available in the **Kernel32 API**.
It offers meticulously organized and named structures and enumerations, all based on
[official Microsoft documentation][url_docs].

**✨ Start using the library right now ✨**

- **Get the [Official NuGet Package][url_nuget].**
- **Download the [latest available version][url_releases].**

<!-- ======= -->

## 📔 About the Kernel32 API

**Kernel32** is a **Windows API library** that provides low-level functions essential for
the operation of the operating system. It is responsible for functions such as memory
management, process and thread manipulation, and input/output device control.

**Purposes**:

- **Memory Management**: Allocation and release of memory.
- **Process and Thread Manipulation**: Creation, control, and termination of processes and threads.
- **Device Control**: Handling of files, directories, and I/O devices.
- **Synchronization**: Synchronization functions like mutexes and events.

This API is fundamental for developers who need to interact directly with the core of the
Windows operating system.

<!-- ======= -->

## 📦 Compiling The Library

The original project code for **Kernel32** has been moved to a **.NET 8.0** class library
solution to facilitate the generation of the **NuGet** package, providing greater
security as there is no need to install third-party applications. The solution was
generated using [Microsoft Visual Studio][url_visualstudio], meaning no additional
configuration is required if used.

<!-- ======= -->

**🧑‍💻 Maintained by [Eduardo Baginski Costa][url_author].**
