set LUBAN_DLL=../../luban\Luban.dll

dotnet %LUBAN_DLL% ^
    -t all ^
    -c cs-simple-json ^
    -d json  ^
    --conf ../luban.conf ^
    -x forceLoadDatas=1
pause