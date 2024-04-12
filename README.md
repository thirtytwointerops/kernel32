<!-- DONATION LINKS -->

[funding_url]: https://github.com/sponsors/eduardobaginskicosta
[funding_image]: ./Assets/funding.svg

<!-- EXTERNAL LINKS -->

[url_microsoft_docs]: https://learn.microsoft.com/en-us/windows/console/console-reference
[url_visual_studio]: https://visualstudio.microsoft.com/
[url_nuget_cli]: https://www.nuget.org/downloads
[url_curl]: https://curl.se/download.html
[url_nuget]: https://www.nuget.org/

<!-- "INTERNAL" LINKS -->

[url_thirtytwo]: https://github.com/thirtytwointerops

<!-- INTRODUCTION -->

![ThirtyTwo Interops - Kernel32 Logo](/Assets/modern.png)

We interoperate all Kernel32 methods, structures, and enumerations from the Windows API to the .NET Framework following [official Microsoft documentation][url_microsoft_docs].

> **IMPORTANT**<br/>
> Some methods may not work correctly, as they were designed for use in the C++ environment, we suggest that, if there are alternative and more reliable means for a given objective, use them.

<!-- NUGET PACKAGE -->

## Create the NuGet Package

The library comes with the pre-configured **.nuspec** file for creating the [Nuget][url_nuget] package, with only the need to change the package information.

To create your package, follow these steps:

- On Microsoft Windows, install the recent [NuGet CLI][url_nuget_cli] version.
- Open the project in [Visual Studio][url_visual_studio] and compile in **Release** mode
- Download and copy the **nuget.exe** file into the **NuGet** folder.
- Run the **nuget pack** command.

If you have [cURL][url_curl] installed, after compiling the project, run the command:

```bash
curl -o "NuGet/nuget.exe" "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
cd NuGet && ./nuget pack
```

<!-- DONATE -->

## Become a sponsor or make a donation

With an unwavering commitment to excellence, our team tirelessly dedicates itself to enriching the **Open Source** community with new repositories, documents, style guides, and libraries. We take great pride in being a part of this transformative movement. We invite you to join us on this journey by becoming a **Sponsor** or contributing a **Donation** to the ThirtyTwo Interops initiative or to its dedicated contributors.

**Your generosity will enable us to continue driving innovation and expanding the horizons of the Open Source community.**

[![Donate with GitHub Sponsors][funding_image]][funding_url]
