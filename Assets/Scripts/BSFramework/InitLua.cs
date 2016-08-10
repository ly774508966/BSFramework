using BSFramework.Tools;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using SLua;

namespace BSFramework
{
    public class InitLua : MonoBehaviour
    {
        public LuaFunction onDestroyFn;
        public LuaFunction onAppPauseFn;
        public LuaFunction onAppQuitFn;
        public LuaFunction onAppFocusFn;
        public string enterLua = "main";
        public bool isDebug = true;

        private LuaSvr svr;
        private static InitLua instance;
        private static Dictionary<string, byte[]> luacache;
        private string luaMain = "";

        void Awake()
        {
            DontDestroyOnLoad(gameObject);
            instance = this;

            this.luaMain = "return require(\"" + enterLua + "\") \n";
            luacache = new Dictionary<string, byte[]>();
            svr = new LuaSvr();
            LuaState.loaderDelegate = Loader;
        }

        void Start()
        {
            //LuaHelper.LoadAssetBundleWithName("layout", "TestPanel", typeof(GameObject), null);
            svr.init(null, () => { LoadBundle(true); }, LuaSvrFlag.LSF_BASIC | LuaSvrFlag.LSF_3RDDLL);//svr.start("main"); LoadBundle(true);
        }

        public static InitLua getInstance()
        {
            return instance;
        }

        private void DoMain()
        {
            svr.luaState.doString(this.luaMain);
        }

        public void LoadBundle(bool domain)
        {
#if UNITY_EDITOR
            if (isDebug)
            {
                if (domain)
                    DoMain();
            }
            else
            {
                StopCoroutine(loadLuaBundle(domain));
                StartCoroutine(loadLuaBundle(domain));
            }
#else
		StopCoroutine(loadLuaBundle(domain));
		StartCoroutine(loadLuaBundle(domain));
#endif
        }

        private IEnumerator loadLuaBundle(bool domain)
        {
            string keyName = "";
            string luaP = Utils.GetAssetFullPath("font.u3d");
            WWW luaLoader = new WWW(luaP);
            yield return luaLoader;
            if (luaLoader.error == null)
            {
#if UNITY_5_3
                AssetBundle item = AssetBundle.LoadFromMemory(luaLoader.bytes);
#else
                AssetBundle item = AssetBundle.CreateFromMemoryImmediate(luaLoader.byts);
#endif
                TextAsset[] all = item.LoadAllAssets<TextAsset>();
                foreach (var ass in all)
                {
                    keyName = ass.name;
                    luacache[keyName] = ass.bytes;
                }

                item.Unload(true);
                luaLoader.Dispose();
            }

            if (domain)
                DoMain();
        }

        /// <summary>
        ///  loader
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static byte[] Loader(string name)
        {
            byte[] str = null;
#if UNITY_EDITOR
            if (getInstance().isDebug)
            {
                name = name.Replace('.', '/');
                string path = Application.dataPath + "/LuaScripts/" + name + ".lua";
                try
                {
                    str = File.ReadAllBytes(path);
                }
                catch(System.Exception e)
                {
                    Debug.Log(e.Message);
                }
            }
            else
            {
                name = name.Replace('.', '_').Replace('/', '_');
                if (luacache.ContainsKey(name))
                {
                    var bytes = luacache[name];
                    str = bytes;
                }
            }
#else
		name = name.Replace('.','_').Replace('/','_'); 
        if(luacache.ContainsKey(name))
        {
	        var bytes = luacache[name];
	        str = bytes;
        }
#endif
            return str;
        }

        void OnDestroy()
        {
            if (onDestroyFn != null) onDestroyFn.call();
            svr = null;
            instance = null;
            luacache.Clear();
        }

        void OnApplicationFocus(bool focusStatus)
        {
            if (onAppFocusFn != null) onAppFocusFn.call(this, focusStatus);
        }

        void OnApplicationPause(bool pauseStatus)
        {
            if (onAppPauseFn != null) onAppPauseFn.call(this, pauseStatus);
        }

        void OnApplicationQuit()
        {
            if (onAppQuitFn != null) onAppQuitFn.call(this, true);
        }
    }
}