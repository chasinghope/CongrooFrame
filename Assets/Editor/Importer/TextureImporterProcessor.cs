// using UnityEditor;
// using UnityEngine;
//
// public class TextureImporterProcessor : AssetPostprocessor
// {
//     // ����ͼƬ�����¼�
//     void OnPreprocessTexture()
//     {
//         // ��ȡ������
//         TextureImporter textureImporter = assetImporter as TextureImporter;
//         
//         // ȷ������������
//         if (textureImporter != null)
//         {
//             // ��ȡWebGLƽ̨������
//             TextureImporterPlatformSettings webGLSettings = textureImporter.GetPlatformTextureSettings("WebGL");
//
//             // ����ѹ����ʽΪASTC 6x6
//             webGLSettings.format = TextureImporterFormat.ASTC_6x6;
//             webGLSettings.overridden = true; // ����WebGLƽ̨�ĸ�������
//
//             // Ӧ������
//             textureImporter.SetPlatformTextureSettings(webGLSettings);
//         }
//     }
// }