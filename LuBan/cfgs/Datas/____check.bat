set LUBAN_DLL=../../Luban\Luban.dll

dotnet %LUBAN_DLL% ^
    -t all ^
    -f ^
    --conf ../luban.conf ^
    ...

pause