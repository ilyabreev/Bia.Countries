@echo off

del "Bia.Countries\bin\Release\*.nupkg"
del "%~dp0*.nupkg"

for /f "usebackq tokens=1* delims=: " %%i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -latest -requires Microsoft.Component.MSBuild`) do (
  if /i "%%i"=="installationPath" set InstallDir=%%j
)

if exist "%InstallDir%\MSBuild\15.0\Bin\MSBuild.exe" (
  "%InstallDir%\MSBuild\15.0\Bin\MSBuild.exe" -t:Pack -p:Configuration=Release "Bia.Countries\Bia.Countries.csproj"
)

copy Bia.Countries\bin\Release\*.nupkg %~dp0


@echo.
@echo ------------------------------------------------
@echo               Finish package create
@echo ------------------------------------------------
@echo.

pause

cd %~dp0
forfiles /m *.nupkg /c "cmd /c nuget.exe push @FILE -ApiKey XXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX -Source https://www.nuget.org/api/v2/package -Verbosity detailed"

@echo.
@echo ------------------------------------------------
@echo                  Finish publish
@echo ------------------------------------------------
@echo.
pause