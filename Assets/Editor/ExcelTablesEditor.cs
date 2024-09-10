using Congroo.Core;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ExcelTablesEditor
{
    [MenuItem("Congroo/��excel�ļ���")]
    private static void OpenExcelFolder()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath);

        Debug.Log(Path.Combine(directoryInfo.Parent.FullName, "LuBan\\cfgs\\Datas"));
        Application.OpenURL(Path.Combine(directoryInfo.Parent.FullName, "LuBan\\cfgs\\Datas"));
    }

    [MenuItem("Congroo/���ĵ�Ŀ¼")]
    private static void OpenDocDir()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath);
        string url = Path.Combine(directoryInfo.Parent.Parent.FullName, "Doc");
        CLog.L(url);
        Application.OpenURL(url);
    }

    [MenuItem("Congroo/��ProtoĿ¼")]
    private static void OpenProtoDir()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath);
        string url = Path.Combine(directoryInfo.Parent.Parent.FullName, "proto");
        CLog.L(url);
        Application.OpenURL(url);
    }

    [MenuItem("Congroo/�򿪴浵·��")]
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
            UnityEngine.Debug.Log($"{fileName} �ļ��������������ϡ�");
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
            UnityEngine.Debug.Log($"{fileName} �ļ�����{path}��������");
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
            UnityEngine.Debug.Log($"{fileName} �ļ��������������ϡ�");
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
            UnityEngine.Debug.Log($"{fileName} �ļ�����{path}��������");
            process.WaitForExit();
        }
    }
}