using UnityEditor;
using Sirenix.Utilities;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
public class GameDebugWindows : OdinEditorWindow
{
    private static GameDebugWindows window;

    [MenuItem("Congroo/���Դ���")]
    public static void ShowWindow()
    {
        window = GetWindow<GameDebugWindows>();
        window.name = "���Դ���";
        window.position = GUIHelper.GetEditorWindowRect().AlignCenter(700, 700);
    }
}