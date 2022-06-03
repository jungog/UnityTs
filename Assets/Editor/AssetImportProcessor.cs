using UnityEngine;
using UnityEditor;
using System;

namespace AssetImportProcessor
{
    /// <summary>
    /// Configure Asset import settings on first import.
    /// </summary>
    public class AssetImportProcessor : AssetPostprocessor
    {
        static void OnPostprocessAllAssets (string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths) 
        {
            // UnityEngine.Debug.Log("static hello world tsaaaaaaaaaaaaaaaaaa");
            // Debug.Log("static OnPostprocessAsset import settings for: " + importer);
            // LogError("static hello world tsaaaaaaaaaaaaaaaaaa");
		    // if (EditorTools.AvoidReimport) return;

            if (importedAssets.Length == 0)
            {
                return;
            }
            // foreach (string str in importedAssets)
            // {
            //      UnityEngine.Debug.Log("Reimported Asset: " + str);
                 
            // }
            for (int i = 0; i < importedAssets.Length; i++)
            {
                if(importedAssets[i].Contains(".ts"))
                {
                    UnityEngine.Debug.Log("Reimported Asset: " + importedAssets[i]);
                    System.Diagnostics.Process p = new System.Diagnostics.Process();

                    p.StartInfo.FileName = Application.dataPath+"/TsProj/npm_run_build.bat";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = false;
                    p.StartInfo.CreateNoWindow = true;
            // string strOutput = null;
            // UnityEngine.Debug.Log("pi.FileName: " + p.StartInfo.FileName);
                    try
                    {

                        p.Start();
                        // p.StandardInput.WriteLine(cmd); //写入要执行的命令 可以多条写入也可以复合命令写入
                        // p.StandardInput.WriteLine("D:\\cube\\Unity\\NewUnityTs\\Assets\\TsProj");
                        // p.StandardInput.WriteLine("npm run build");
                        // p.StandardInput.WriteLine("exit");
                        // strOutput = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();
                        p.Close();                         
                    }
                    catch (Exception e)
                    {
                        //异常处理
                    UnityEngine.Debug.Log(" error" + e);
                    }
                    break;
                }
                // Debug.Log("Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
                // UnityEngine.Debug.Log("u Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
            }

/*string[] path = UnityEditor.AssetDatabase.FindAssets(_scriptName);
if(path.Length>1)
{
Debug.LogError("有同名文件"+_scriptName+"获取路径失败");
return null;
}*/
// string[] path = UnityEditor.AssetDatabase.FindAssets();
// if(path.Length>1)
// {
// Debug.LogError("有同名文件"+_scriptName+"获取路径失败");
// return null;
// }











            // foreach (string str in deletedAssets)
            // {
            //     Debug.Log("Deleted Asset: " + str);
            //     UnityEngine.Debug.Log("u Deleted Asset: " + str);
            // }

            // for (int i = 0; i < movedAssets.Length; i++)
            // {
            //     Debug.Log("Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
            //     UnityEngine.Debug.Log("u Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
            // }
		}
    }
}