set LUBAN_DLL=Luban\Luban.dll
set CONF_ROOT=cfgs
set OUTPUT_DATA_DIR=cfgs\testlist

dotnet %LUBAN_DLL% -t all ^ -d text-list  ^
    --conf %CONF_ROOT%\luban.conf ^
    --validationFailAsError ^
    -x outputDataDir=%OUTPUT_DATA_DIR%^
    -x l10n.textListFile=texts.txt
pause