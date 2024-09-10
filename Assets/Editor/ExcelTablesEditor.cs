using Congroo.Core;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ExcelTablesEditor
{
    [MenuItem("Congroo/打开excel文件夹")]
    private static void OpenExcelFolder()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath);

        Debug.Log(Path.Combine(directoryInfo.Parent.FullName, "LuBan\\cfgs\\Datas"));
        Application.OpenURL(Path.Combine(directoryInfo.Parent.FullName, "LuBan\\cfgs\\Datas"));
    }

    [MenuItem("Congroo/打开文档目录")]
    private static void OpenDocDir()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath);
        string url = Path.Combine(directoryInfo.Parent.Parent.FullName, "Doc");
        CLog.L(url);
        Application.OpenURL(url);
    }

    [MenuItem("Congroo/打开Proto目录")]
    private static void OpenProtoDir()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath);
        string url = Path.Combine(directoryInfo.Parent.Parent.FullName, "proto");
        CLog.L(url);
        Application.OpenURL(url);
    }

    [MenuItem("Congroo/打开存档路径")]
    private static void OpenPlayerLog()
    {
        Application.OpenURL(Application.persistentDataPath);
    }

    [MenuItem("Congroo/excel2bytes")]
    private static void Excel2bytes()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath);
        string path = Path.Combine(directoryInfo.Parent.FullName, "LuBan");
        string fileName = "gen_code_bin.bat";
        string batFilePath = Path.Combine(path, fileName);
        if (!File.Exists(batFilePath))
        {
            UnityEngine.Debug.Log($"{fileName} 文件不存在于桌面上。");
            return;
        }
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = batFilePath,
            WorkingDirectory = path,
            UseShellExecute = true,
            CreateNoWindow = true
        };
        using (Process process = new Process { StartInfo = startInfo })
        {
            process.Start();
            UnityEngine.Debug.Log($"{fileName} 文件已在{path}上启动。");
            process.WaitForExit();
        }
    }

    [MenuItem("Congroo/excel2json")]
    private static void Excel2Json()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath);
        string path = Path.Combine(directoryInfo.Parent.FullName, "LuBan");
        string fileName = "gen_code_json.bat";
        string batFilePath = Path.Combine(path, fileName);
        if (!File.Exists(batFilePath))
        {
            UnityEngine.Debug.Log($"{fileName} 文件不存在于桌面上。");
            return;
        }
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = batFilePath,
            WorkingDirectory = path,
            UseShellExecute = true,
            CreateNoWindow = true
        };
        using (Process process = new Process { StartInfo = startInfo })
        {
            process.Start();
            UnityEngine.Debug.Log($"{fileName} 文件已在{path}上启动。");
            process.WaitForExit();
        }
    }
}