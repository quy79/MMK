@ECHO ON

REM The following directory is for .NET 2.0
set DOTNETFX2=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX2%

echo Installing EmailServices...
echo ---------------------------------------------------
InstallUtil /i C:\code\Code\DBLayer\EmailServices\bin\Debug\EmailServices.exe
echo ---------------------------------------------------
echo Done.
pause