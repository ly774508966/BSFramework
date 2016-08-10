using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEditor;
using UnityEngine;

namespace BSFramework.Editor
{
    public class MenuItems
    {
        [MenuItem("BSFramework/Menus/AssetBundles/Export Lua [Assets\\Lua] %l", false, 12)]
        public static void exportLua()
        {
            ExportAssetBundles.BuildAssetBundleLua();
        }

        [MenuItem("Assets/Menus/Build Assetbundle UI")]
        static private void BuildAssetBundleUI()
        {
            ExportAssetBundles.BuildAssetBundleUI();
        }

        [MenuItem("BSFramework/Menus/AssetBundles/Build Assetbundle UIS")]
        static private void BuildAssetBundleUIs()
        {
            ExportAssetBundles.BuildAssetBundleUIs();
        }

        [MenuItem("Assets/Menus/Build Assetbundle Scene")]
        static private void BuildAssetBundleScene()
        {
            ExportAssetBundles.BuildAssetBundleScene();
        }

        [MenuItem("BSFramework/Menus/AssetBundles/Build Assetbundle Scene")]
        static private void BuildAssetBundleScenes()
        {
            ExportAssetBundles.BuildAssetBundleScenes();
        }

        [MenuItem("BSFramework/Menus/DynamicUI")]
        static private void DynamicUI()
	    {
            string spriteDir = Application.dataPath + "/Prefabs/UI/Dynamic";
		
		    if(!Directory.Exists(spriteDir)){
			    Directory.CreateDirectory(spriteDir);
		    }

            var rootDirInfo = new DirectoryInfo(Application.dataPath + "/Textures/UI/Dynamic");
		    foreach (DirectoryInfo dirInfo in rootDirInfo.GetDirectories()) {
			    foreach (FileInfo pngFile in dirInfo.GetFiles("*.png",SearchOption.AllDirectories)) {
				    string allPath = pngFile.FullName;
				    string assetPath = allPath.Substring(allPath.IndexOf("Assets"));
				    var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(assetPath);
				    var go = new GameObject(sprite.name);
				    go.AddComponent<SpriteRenderer>().sprite = sprite;
				    allPath = spriteDir+"/"+sprite.name+".prefab";
				    string prefabPath = allPath.Substring(allPath.IndexOf("Assets"));
				    PrefabUtility.CreatePrefab(prefabPath,go);
				    GameObject.DestroyImmediate(go);
			    }
		    }	
	    }
    }
}
