<!-- DONATION LINKS -->

[url_github_sponsors]: https://github.com/sponsors/eduardobaginskicosta
[url_patreon]: https://www.patreon.com/eduardobcosta
[url_microsoft_docs]: https://learn.microsoft.com/en-us/windows/console/console-reference

<!-- EXTERNAL LINKS -->

[url_nuget]: https://www.nuget.org/
[url_visual_studio]: https://visualstudio.microsoft.com/
[url_nuget_cli]: https://www.nuget.org/downloads
[url_curl]: https://curl.se/download.html

<!-- "INTERNAL" LINKS -->

[url_thirtytwo]: https://github.com/thirtytwointerops
[url_package]: https://www.nuget.org/packages/ThirtyTwo.Kernel32/

<!-- IMAGES LINKS -->

[image_nuget]: /Assets/install_nuget_package.svg
[image_sponsors]: /Assets/sponsor_github.svg
[image_patreon]: /Assets/sponsor_patreon.svg

<!-- INTRODUCTION -->

![ThirtyTwo Interops • Kernel32](/Assets/rounded_banner.png)

We interoperate all Kernel32 methods, structures, and enumerations from the Windows API to the .NET Framework following [official Microsoft documentation][url_microsoft_docs].

[![Install NuGet Package][image_nuget]][url_package]

---

<h3 align="center">⚠️ IMPORTANT ⚠️</h3>

**Some methods may not work correctly, as they were designed for use in the C++ environment, we suggest that, if there are alternative and more reliable means for a given objective, use them.**

<!-- NUGET PACKAGE -->

---

<h3 align="center">📦 CREATE THE NUGET PACKAGE 📦</h3>

---

The library comes with the pre-configured `.nuspec` file for creating the [Nuget][url_nuget] package, with only the need to change the package information.

To create your package, follow these steps:

- On Microsoft Windows, install the recent [NuGet CLI][url_nuget_cli] version.
- Open the project in [Visual Studio][url_visual_studio] and compile in `Release` mode
- Download and copy the `nuget.exe` file into the `NuGet` folder.
- Run the `nuget pack` command.

If you have [cURL][url_curl] installed, after compiling the project, run the command:

```bash
curl -o "NuGet/nuget.exe" "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
cd NuGet
./nuget pack
```

<!-- DONATE -->

---

<h3 align="center">❤️ BECOME A SPONSOR <i>or</i> MAKE A DONATION ❤️</h3>

---

Consider becoming a [Sponsor][url_github_sponsors] or [Donating][url_patreon] if the libraries in the [ThirtyTwo][url_thirtytwo] ecosystem help you in your daily life as a developer.

[![Donate with GitHub Sponsors][image_sponsors]][url_github_sponsors]
[![Donate with Patreon][image_patreon]][url_patreon]
