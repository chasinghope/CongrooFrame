set LUBAN_DLL=Luban\Luban.dll
set CONF_ROOT=cfgs

dotnet %LUBAN_DLL% ^
    -t client ^
    -c protobuf3 ^
    -d protobuf-json  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=protobuf-json^
    -x outputDataDir=protobuf-json-code

pause