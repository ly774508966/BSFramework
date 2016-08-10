using BSFramework.Tools;
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine.SceneManagement;

namespace BSFramework
{
    [SLua.CustomLuaClass]
    public class AssetMgr
    {
        private static Dictionary<string, Asset> _assetDict = new Dictionary<string, Asset>();
        private static MonoBehaviour _coroutineProvider = null;

        public static IEnumerator Init(MonoBehaviour main, Action onFinish, string assetInfo)
        {
            _coroutineProvider = main;

            string assetPath = Utils.GetAssetFullPath(assetInfo);

            Debug.Log(assetPath);

            using (WWW www = new WWW(assetPath))
            {
                yield return www;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(new StringReader(www.text));
                XmlNode root = xmlDoc.SelectSingleNode("AssetBundles");
                if (root != null)
                {
                    foreach (XmlNode xn1 in root.ChildNodes)
                    {
                        XmlElement bundleEle = (XmlElement) xn1;

                        string name = bundleEle.GetAttribute("name");
                        string md5 = bundleEle.GetAttribute("md5");
                        string path = bundleEle.GetAttribute("path");

                        Bundle bundle = new Bundle(name, md5, path);
                        Asset asset = new Asset(name, bundle, path);
                        asset.CoroutineProvider = _coroutineProvider;
                        _assetDict.Add(name, asset);
                    }
                }
                yield return null;
            }

            if (onFinish != null)
                onFinish();
        }

        public static Asset Load(string name)
        {
            Asset asset;
            if (!_assetDict.TryGetValue(name, out asset))
            {
                Debug.Log("AssetMgr::Load - not find " + name);
                return null;
            }

            return asset;
        }

        public static Asset LoadScene(string name)
        {
            Asset asset = Load(name);
            if (asset == null)
                return null;

            asset.LoadAssetAsync = delegate(Bundle bundle)
            {
                return new Asset.SceneRequest(SceneManager.LoadSceneAsync(name), name);
            };

            return asset;
        }

        public static void UnLoad(string name)
        {
            Resources.UnloadUnusedAssets();
        }
    }
}