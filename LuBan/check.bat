set LUBAN_DLL=../../Luban\Luban.dll

dotnet %LUBAN_DLL% ^
    -t all ^
    --conf ../luban.conf ^
    -x forceLoadDatas=1

pause