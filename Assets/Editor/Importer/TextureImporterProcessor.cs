// using UnityEditor;
// using UnityEngine;
//
// public class TextureImporterProcessor : AssetPostprocessor
// {
//     // 处理图片导入事件
//     void OnPreprocessTexture()
//     {
//         // 获取导入器
//         TextureImporter textureImporter = assetImporter as TextureImporter;
//         
//         // 确保导入器存在
//         if (textureImporter != null)
//         {
//             // 获取WebGL平台的设置
//             TextureImporterPlatformSettings webGLSettings = textureImporter.GetPlatformTextureSettings("WebGL");
//
//             // 设置压缩格式为ASTC 6x6
//             webGLSettings.format = TextureImporterFormat.ASTC_6x6;
//             webGLSettings.overridden = true; // 启用WebGL平台的覆盖设置
//
//             // 应用设置
//             textureImporter.SetPlatformTextureSettings(webGLSettings);
//         }
//     }
// }