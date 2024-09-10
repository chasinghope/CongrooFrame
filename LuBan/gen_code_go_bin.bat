set LUBAN_DLL=Luban\Luban.dll
set CONF_ROOT=cfgs
set OUTPUT_CODE_DIR=D:/code/go/src/github.com/zzn99/backpack-like/pkg/lubancfg
set OUTPUT_DATA_DIR=D:/code/go/src/github.com/zzn99/backpack-like/resource/data
dotnet %LUBAN_DLL% ^
    -t server ^
    -c go-bin ^
    -d bin  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=%OUTPUT_CODE_DIR%^
    -x outputDataDir=%OUTPUT_DATA_DIR%^
    -x lubanGoModule=backpack-like/pkg/luban

pause