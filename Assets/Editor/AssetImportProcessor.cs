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
            // if (EditorTools.AvoidReimport) return;
            //检测变更文件
            if (importedAssets.Length != 0)
            {
                for (int i = 0; i < importedAssets.Length; i++)
                {
                    if(importedAssets[i].EndsWith(".ts"))
                    {
                        UnityEngine.Debug.Log("Reimported Asset: " + importedAssets[i]);
                        System.Diagnostics.Process p = new System.Diagnostics.Process();

                        p.StartInfo.FileName = Application.dataPath+"/TsProj/npm_run_build.bat";
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardInput = true;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.RedirectStandardError = false;
                        p.StartInfo.CreateNoWindow = true;

                        try
                        {
                            p.Start();
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
                }
            }

            //检测删除文件
            if (deletedAssets.Length != 0)
            {
                for (int i = 0; i < deletedAssets.Length; i++)
                {
                    if(deletedAssets[i].EndsWith(".ts"))
                    {
                        UnityEngine.Debug.Log("Deleted Asset: " + deletedAssets[i]);
                        string[] path = deletedAssets[i].Split('/');
                        AssetDatabase.DeleteAsset("Assets/Resources/"+path[path.Length-1].Replace(".ts",".js.txt"));
                        AssetDatabase.DeleteAsset("Assets/TsProj/output/"+path[path.Length-1].Replace(".ts",".js"));
                    }
                }
            }
        }
    }
}