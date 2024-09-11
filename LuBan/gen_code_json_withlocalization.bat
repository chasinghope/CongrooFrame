set LUBAN_DLL=Luban\Luban.dll
set CONF_ROOT=cfgs
set OUTPUT_CODE_DIR=../Assets/Game/GenCfgs
set OUTPUT_DATA_DIR=../Assets/AB\cfgs\jsons

dotnet %LUBAN_DLL% ^
    -t client ^
    -c cs-simple-json ^
    -d json  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=%OUTPUT_CODE_DIR%^
    -x outputDataDir=%OUTPUT_DATA_DIR%^
    -x l10n.provider=default ^
    -x "l10n.textFile.path=*@%OUTPUT_CODE_DIR%\Datas\l10n\texts.json" ^
    -x l10n.textFile.keyFieldName=key 



pause