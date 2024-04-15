@echo off
echo Verifying necessary tools...

rem Validate if the "dotnet" tool is installed
where /q dotnet

if %errorlevel% neq 0 (
	echo Error: The "dotnet" tool was not detected!
	echo Recommendation: Download online at https://dotnet.microsoft.com/pt-br/download/dotnet-framework
	echo Alternative: Install with Winget using 'winget install Microsoft.DotNet.SDK.8'
	exit
) else (
	echo Success: The "dotnet" tool has been detected!
)

rem Validate if the "curl" tool is installed
where /q curl

if %errorlevel% neq 0 (
	echo Error: The "curl" tool was not detected!
	echo Recommendation: Download online at https://curl.se/download.html
	echo Alternative: Install with Winget using 'winget install --id=cURL.cURL  -e'
	exit
) else (
	echo Success: The "curl" tool has been detected!
)

rem Compile the project
cls
echo Commencing compilation...
dotnet build "ThirtyTwo" -c Release

rem Download NuGet.exe
cls
echo Initiating the NuGet CLI download...

if not exist ".\NuGet\nuget.exe" (
	curl -o "NuGet\nuget.exe" "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
)
cd .\NuGet
.\nuget.exe pack

rem Cleaning
cls
echo Removing files for security purposes...

if exist .\nuget.exe (
	del .\nuget.exe
)

rem Completion
cls
echo The library has been packaged successfully!
cd ..\