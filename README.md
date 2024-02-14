[url_github_sponsors]: https://github.com/sponsors/eduardobaginskicosta
[url_patreon]: https://www.patreon.com/eduardobcosta
[url_microsoft_docs]: https://learn.microsoft.com/en-us/windows/console/console-reference
[url_nuget]: https://www.nuget.org/
[url_nuget_cli]: https://www.nuget.org/downloads
[url_curl]: https://curl.se/download.html

### **Português (Brasil)**

Interoperamos todos os métodos, estruturas e enumerações Kernel32 da API do Windows para o .NET Framework seguindo a [documentação oficial da Microsoft][url_microsoft_docs].

> **IMPORTANTE:** alguns métodos podem não funcionar corretamente, pois foram projetados para uso no ambiente **C++**, sugerimos que, caso existam meios alternativos e mais confiáveis ​​para determinado objetivo, utilize-os.

---

### **English (United States)**

We interoperate all Kernel32 methods, structures, and enumerations from the Windows API to the .NET Framework following [official Microsoft documentation][url_microsoft_docs].

> **IMPORTANT:** some methods may not work correctly, as they were designed for use in the **C++** environment, we suggest that, if there are alternative and more reliable means for a given objective, use them.

---

### Create the NuGet Package

The library comes with the pre-configured `.nuspec` file for creating the [Nuget][url_nuget] package, with only the need to change the package information.

To create your package, follow these steps:

-   On Microsoft Windows, install the recent [NuGet CLI][url_nuget_cli] version.
-   Copy the `nuget.exe` file into the `NuGet` folder.
-   Run the `nuget pack` command.

If you have [cURL][url_curl] installed, run:

```bash
curl -o "NuGet/nuget.exe" "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
cd NuGet
./nuget pack
```

---

[Donate with GitHub Sponsors][url_github_sponsors]  
[Donate with Patreon][url_patreon]
