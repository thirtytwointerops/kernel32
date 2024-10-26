[url_releases]: https://github.com/thirtytwointerops/kernel32/releases
[url_author]: https://github.com/eduardobaginskicosta
[url_dotnet]: https://dotnet.microsoft.com/pt-br/download/dotnet-framework
[url_nuget]: https://www.nuget.org/packages/ThirtyTwo.Kernel32/
[url_curl]: https://curl.se/download.html
[url_docs]: https://learn.microsoft.com/en-us/windows/console/console-reference

<!-- ======= -->

## 📘 Get Started

The [Kernel32][url_nuget], developed by a community specialized in the interoperability of
**Windows APIs**, enables the use of all functions available in the **Kernel32 API**. It
offers meticulously organized and named structures and enumerations, all based on [official Microsoft documentation][url_docs].
   
**✨ Start using the library right now ✨**

- **Get the [Official NuGet Package][url_nuget].**
- **Download the [latest avaliable version][url_releases].**

## 📦 Create the NuGet Package

All libraries associated with the **.NET Framework** come with a pre-configured **`.nuspec`**
file intended for package creation. To ensure the safety of developers, we have consolidated
all necessary commands into a single **Batch** file.

For the packaging process, it is imperative that the following tools are installed on the
**Microsoft Windows** operating system:

- **[.NET Framework][url_dotnet]**: required for project compilation.
- **[cURL][url_curl]**: used for downloading external dependencies.

If all dependencies are properly installed, the following command should be executed from
the root directory of the project. The package will be generated within the **NuGet** directory:

```bash
.\pack # or
.\pack.bat
```

**🧑‍💻 Maintained by [Eduardo Baginski Costa][url_author].**
