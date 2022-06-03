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
            if (importedAssets.Length == 0)
            {
                return;
            }
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
    }
}