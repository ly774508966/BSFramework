using BSFramework.Tools;
using UnityEngine;
using System;
using System.Collections;

namespace BSFramework
{
    [SLua.CustomLuaClass]
    public class Bundle
    {
        public string name;
        public string md5;
        public string path;

        private AssetBundle bundle = null;

        public Bundle(string _name, string _md5, string _path)
        {
            name = _name;
            md5 = _md5;
            path = _path;
        }

        public IEnumerator Load()
        {
            if (bundle != null)
            {
                Debug.Log("Bundle::Load - bundle is loaded " + path);
                yield break;
            }

            using (WWW www = new WWW(Utils.GetAssetFullPath(path)))
            {
                yield return www;
                bundle = www.assetBundle;
            }
        }

        public void UnLoad()
        {
            bundle.Unload(false);
        }

        public AssetBundleRequest LoadAssetAsync(string name, Type type)
        {
            return bundle.LoadAssetAsync(name, type);
        }

        public bool IsLoaded
        {
            get
            {
                if (bundle == null)
                    return false;

                return true;
            }
        }
    }
}