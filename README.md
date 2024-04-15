<!-- URLS: ASSETS -->

[img_badges_funding_patreon]: .\Assets\Badges\FundingPatreon.svg
[img_badges_funding_github]: .\Assets\Badges\FundingGitHub.svg

[img_badges_nuget]: .\Assets\Badges\NuGet.svg
[img_banner]: .\Assets\Banner\/Kernel32.png

<!-- URLS: DONATION & FUNDING -->

[funding_patreon]: https://www.patreon.com/eduardobcosta
[funding_github]: https://github.com/sponsors/eduardobaginskicosta

<!-- URLS: EXTERNAL REFERENCES -->

[docs_microsoft_console]: https://learn.microsoft.com/en-us/windows/console/console-reference

<!-- URLS: TOOLS -->

[tool_dotnet]: https://dotnet.microsoft.com/pt-br/download/dotnet-framework
[tool_nuget]: https://www.nuget.org/
[tool_curl]: https://curl.se/download.html

<!-- URLS: INTERNAL & EXTERNAL -->

[url_thirtytwo]: https://github.com/thirtytwointerops
[url_package]: https://www.nuget.org/packages/ThirtyTwo.Kernel32/

<!-- SECTION: BANNER -->

<h1 align="center">ThirtyTwo Interops • Kernel32</h1>
<img aria-label="TWindows API Kernel32 interop library for the .NET Framework." src=".\Assets\Kernel32.png" />

<p align="center">
	<a aria-label="Follow in LinkedIn" href="https://www.linkedin.com/company/thirtytwointerops/" target="_blank">
		<img alt="" src=".\Assets\Badges\LinkedIn.svg">
	</a>
	<a aria-label="Get NuGet Package" href="https://www.nuget.org/packages/ThirtyTwo.Kernel32/" target="_blank">
		<img alt="" src=".\Assets\Badges\NuGet.svg">
	</a>
	<a aria-label="License" href=".\LICENSE" target="_blank">
		<img alt="" src=".\Assets\Badges\License.svg">
	</a>
	<a aria-label="Join the community on GitHub" href="https://github.com/thirtytwointerops/.github/discussions" target="_blank">
		<img alt="" src=".\Assets\Badges\Community.svg">
	</a>
</p>

<!-- SECTION: GET STARTED -->

## 📘 Get Started

The [Kernel32][url_package], developed by a community specialized in the interoperability of Windows APIs, enables the use of all functions available in the Kernel32 API. It offers meticulously organized and named structures and enumerations, all based on [official Microsoft documentation][docs_microsoft_console].

<!-- SECTION: PACKAGING -->

## 📦 Create the NuGet Package

All libraries associated with the .NET Framework come with a pre-configured **.nuspec** file intended for
package creation. To ensure the safety of developers, we have consolidated all necessary commands into a single **Batch** file.

For the packaging process, it is imperative that the following tools are installed on the Microsoft
Windows operating system:

- [.NET Framework][tool_dotnet], required for project compilation.
- [cURL][tool_curl], used for downloading external dependencies.

If all dependencies are properly installed, the following command should be executed from the root
directory of the project. The package will be generated within the **NuGet** directory:

```bash
.\pack # or
.\pack.bat
```

<!-- SECTION: SECURITY -->

## 🛡️ Security

If you suspect that you have identified a vulnerability in any of our products, we ask that you disclose
it responsibly, avoiding the creation of a public issue. All legitimate reports will be subject to active
investigation. Please use the email `eduardobcosta1234@gmail.com` to report any security vulnerabilities.
   
**We count on your collaboration to ensure the safety of everyone.**

<!-- SECTION: DONATE -->

## ❤️ Become a sponsor or make a donation

With an unwavering commitment to excellence, our team tirelessly dedicates itself to enriching the
**Open Source** community with new repositories, documents, style guides, and libraries. We take great
pride in being a part of this transformative movement. We invite you to join us on this journey by
becoming a **Sponsor** or contributing a **Donation** to the ThirtyTwo Interops initiative or to its
dedicated contributors.

**Your generosity will enable us to continue driving innovation and expanding the horizons of the Open Source community.**

<p>
	<a aria-label="GitHub Sponsors" href="https://github.com/sponsors/eduardobaginskicosta" target="_blank">
		<img alt="" src=".\Assets\Badges\FundingGitHub.svg">
	</a>
	<a aria-label="Patreon" href="https://www.patreon.com/eduardobcosta" target="_blank">
		<img alt="" src=".\Assets\Badges\FundingPatreon.svg">
	</a>
</p>