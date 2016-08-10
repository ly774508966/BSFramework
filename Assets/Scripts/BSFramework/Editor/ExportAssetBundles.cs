// Copyright (c) 2014 hugula
// direct https://github.com/tenvick/hugula
//
// C# Example
// Builds an asset bundle from the selected objects in the project view.
// Once compiled go to "Menu" -> "Assets" and select one of the choices
// to build the Asset Bundle

using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using BSFramework.Tools;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BSFramework.Editor
{
    public class ExportAssetBundles
    {
        private static string OutLuaPath = "/Tmp/" + Common.LUACFOLDER + "/";
        private static string outPath = "Assets/StreamingAssets";
        private string suffix = Common.ASSETBUNDLE_SUFFIX;
#if Nlua
#if UNITY_EDITOR_OSX
	    public static string luacPath=Application.dataPath+"/../tools/luaTools/luac";
#else
        public static string luacPath = Application.dataPath + "/../tools/luaTools/win/luac.exe";
#endif
#else
#if UNITY_EDITOR_OSX && UNITY_IPHONE
	public static string luacPath=Application.dataPath+"/../tools/luaTools/lua5.1.4c";
#elif UNITY_EDITOR_OSX 
	public static string luacPath=Application.dataPath+"/../tools/luaTools/luajit";
#else
        public static string luacPath = Application.dataPath + "/../tools/luaTools/win/luajit.exe";
#endif
#endif
        public static void BuildAssetBundleLua()
        {
            checkLuaExportPath();

            string path = Application.dataPath + "/LuaScripts/"; //lua path

            List<string> files = getAllChildFiles(path); // Directory.GetFiles(Application.dataPath + path);

            IList<string> childrens = new List<string>();

            foreach (string file in files)
            {
                if (file.EndsWith("lua"))
                {
                    childrens.Add(file);
                }
            }
            Debug.Log("luajit path = " + luacPath);
            string crypName = "", fileName = "", outfilePath = "", arg = "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //refresh directory
            DirectoryDelete(Application.dataPath + OutLuaPath);
            CheckDirectory(Application.dataPath + OutLuaPath);

            List<string> exportNames = new List<string>();
            foreach (string filePath in childrens)
            {
                fileName = Utils.GetURLFileName(filePath);
                crypName =
                    filePath.Replace(path, "")
                        .Replace(".lua", "." + Common.LUA_LC_SUFFIX)
                        .Replace("\\", "_")
                        .Replace("/", "_");
                outfilePath = Application.dataPath + OutLuaPath + crypName;
                exportNames.Add("Assets" + OutLuaPath + crypName);
                sb.Append(fileName);
                sb.Append("=");
                sb.Append(crypName);
                sb.Append("\n");

#if Nlua || UNITY_IPHONE 
			arg="-o "+outfilePath+" "+filePath;// luac 
			File.Copy(filePath, outfilePath, true);// source code copy
#else
                arg = "-b " + filePath + " " + outfilePath; //for jit
                //Debug.Log(arg);
                //System.Diagnostics.Process.Start(luacPath, arg);//jit 
                File.Copy(filePath, outfilePath, true); // source code copy
#endif
            }
            Debug.Log("lua:" + path + "files=" + files.Count + " completed");
            System.Threading.Thread.Sleep(1000);
            AssetDatabase.Refresh();

            //u5 打包
            string outPath = ExportAssetBundles.GetOutPath();
            CheckDirectory(Application.dataPath.Replace("Assets", "") + outPath);
            ExportAssetBundles.BuildABs(exportNames.ToArray(), "Assets" + OutLuaPath, "luaout.bytes",
                BuildAssetBundleOptions.CompleteAssets);

            //Encrypt
            string tarName = Application.dataPath + OutLuaPath + "luaout.bytes";
            string realOutPath = ExportAssetBundles.GetOutPath() + "/font.u3d";
            byte[] by = File.ReadAllBytes(tarName);
            //byte[] Encrypt = CryptographHelper.Encrypt (by, GetKey (), GetIV());
            File.WriteAllBytes(realOutPath, by);
            Debug.Log(realOutPath + " export");

        }

        public static void BuildAssetBundleUI()
        {
            Caching.CleanCache();

            

            GameObject []goList = Selection.gameObjects;
            for (int i = 0; i < goList.Length; i++)
            {
                Debug.Log(AssetDatabase.GetAssetPath(goList[i]));
                //Debug.Log(goList[i].name);
            }

            AssetDatabase.Refresh();
        }

        public static void BuildAssetBundleUIs()
        {
            Caching.CleanCache();

            string outBasePath = GetOutPath();
            CheckDirectory(outBasePath);

            BundleXml xml = new BundleXml();
            xml.Open();

            string prefabPath = Application.dataPath + "/Prefabs/UI/";
            var rootDirInfo = new DirectoryInfo(prefabPath);
            foreach (DirectoryInfo dirInfo in rootDirInfo.GetDirectories())
            {
                string outPath = outBasePath + "/" + dirInfo.Name;
                CheckDirectory(outPath);
                foreach (FileInfo preaInfoFile in dirInfo.GetFiles("*.prefab", SearchOption.AllDirectories))
                {
                    string assetsName = prefabPath + dirInfo.Name + "/" + preaInfoFile.Name;
                    string name = Path.GetFileNameWithoutExtension(preaInfoFile.Name);
                    string abName = (name + ".assetbundle").ToLower();
                    AssetBundleBuild[] bab = new AssetBundleBuild[1];
                    bab[0].assetBundleName = abName;
                    bab[0].assetNames = new string[] { assetsName };
                    BuildPipeline.BuildAssetBundles(outPath, bab, BuildAssetBundleOptions.ChunkBasedCompression, EditorUserBuildSettings.activeBuildTarget);
                    string pathFile = dirInfo.Name + "/" + abName;
                    string abPath = outPath + "/" + abName;
                    xml.UpdateAssetBundle(name, abPath, pathFile);
                    Debug.Log("Saved " + abName + ". (" + abPath + ")");
                }
            }

            xml.Close();
            AssetDatabase.Refresh();
        }

        public static void BuildAssetBundleScene()
        {
            EditorBuildSettingsScene []s = EditorBuildSettings.scenes;
            for (int i = 0; i < s.Length; i++)
            {
                Debug.Log(s[i].path);
            }
        }

        public static void BuildAssetBundleScenes()
        {
            Caching.CleanCache();

            string outBasePath = GetOutPath();
            CheckDirectory(outBasePath);

            BundleXml xml = new BundleXml();
            xml.Open();

            string scenePath = Application.dataPath + "/Scenes/";
            DirectoryInfo dirInfo = new DirectoryInfo(scenePath);

            string outPath = outBasePath + "\\" + "Scenes";
            CheckDirectory(outPath);
            foreach (FileInfo preaInfoFile in dirInfo.GetFiles("*.unity", SearchOption.AllDirectories))
            {
                string assetsName = scenePath + preaInfoFile.Name;
                string name = Path.GetFileNameWithoutExtension(preaInfoFile.Name);
                string abName = (name + ".unity3d").ToLower();
                string sceneFileName = outPath + "/" + abName;
                string[] levels = { assetsName };
                BuildPipeline.BuildPlayer(levels, sceneFileName, EditorUserBuildSettings.activeBuildTarget, BuildOptions.BuildAdditionalStreamedScenes);
                string pathFile = dirInfo.Name + "/" + abName;
                string abPath = outPath + "/" + abName.ToLower();
                xml.UpdateAssetBundle(name, abPath, pathFile);
                Debug.Log("Saved " + abName + ". (" + outPath + ")");
            }

            xml.Close();
            AssetDatabase.Refresh();
        }

        public static void CheckDirectory(string fullPath)
        {
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
        }

        private static void checkLuaExportPath()
        {
            string dircAssert = Application.dataPath + OutLuaPath;
            if (!Directory.Exists(dircAssert))
            {
                Directory.CreateDirectory(dircAssert);
            }
        }

        public static List<string> getAllChildFiles(string path, string suffix = "lua", List<string> files = null)
        {
            if (files == null) files = new List<string>();
            addFiles(path, suffix, files);
            string[] dires = Directory.GetDirectories(path);
            foreach (string dirp in dires)
            {
                //            Debug.Log(dirp);
                getAllChildFiles(dirp, suffix, files);
            }
            return files;
        }

        public static void addFiles(string direPath, string suffix, List<string> files)
        {
            string[] fileMys = Directory.GetFiles(direPath);
            foreach (string f in fileMys)
            {
                if (f.ToLower().EndsWith(suffix.ToLower()))
                {
                    files.Add(f);
                }
            }
        }

        public static void DirectoryDelete(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists) di.Delete(true);
        }

        public static void BuildABs(string[] assets, string outPath, string abName, BuildAssetBundleOptions bbo)
        {
            AssetBundleBuild[] bab = new AssetBundleBuild[1];
            bab[0].assetBundleName = abName; //打包的资源包名称 随便命名
            bab[0].assetNames = assets;

            BuildPipeline.BuildAssetBundles(outPath, bab, bbo, EditorUserBuildSettings.activeBuildTarget);
        }

        public static string GetOutPath()
        {
            return outPath + "/" + EditorUserBuildSettings.activeBuildTarget.ToString();
        }
    }
}
