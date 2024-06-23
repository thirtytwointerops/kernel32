[tool_dotnet]: https://dotnet.microsoft.com/pt-br/download/dotnet-framework
[tool_nuget]: https://www.nuget.org/
[tool_curl]: https://curl.se/download.html

<!-- === -->

[url_docs_microsoft_console]: https://learn.microsoft.com/en-us/windows/console/console-reference
[url_thirtytwo]: https://github.com/thirtytwointerops
[url_package]: https://www.nuget.org/packages/ThirtyTwo.Kernel32/

<!-- === -->

<h1>Kernel32</h1>

## 📘 Get Started

The [Kernel32][url_package], developed by a community specialized in the interoperability
of Windows APIs, enables the use of all functions available in the Kernel32 API. It
offers meticulously organized and named structures and enumerations, all based on
[official Microsoft documentation][url_docs_microsoft_console].

**[Get The Official NuGet Package](https://www.nuget.org/packages/ThirtyTwo.Kernel32/)**

## 📦 Create the NuGet Package

All libraries associated with the .NET Framework come with a pre-configured **.nuspec**
file intended for package creation. To ensure the safety of developers, we have
consolidated all necessary commands into a single **Batch** file.

For the packaging process, it is imperative that the following tools are installed on the
Microsoft Windows operating system:

- [.NET Framework][tool_dotnet], required for project compilation.
- [cURL][tool_curl], used for downloading external dependencies.

If all dependencies are properly installed, the following command should be executed from
the root directory of the project. The package will be generated within the **NuGet**
directory:

```bash
.\pack # or
.\pack.bat
```

---

<p>
  <b>
    Maintained by <a href="https://github.com/eduardobaginskicosta" alt="Eduardo Baginski Costa profile">Eduardo Baginski Costa</a> and <a href="https://www.linkedin.com/company/novusinspire/">Novus Inspire</a>.
  </b>
</p>
