using System;
using System.Collections;
using System.Collections.Generic;
using BSFramework.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace BSFramework
{
    [SLua.CustomLuaClass]
    public class Asset
    {
        private string _name;
        private string _path;

        public MonoBehaviour CoroutineProvider = null;
        public Func<Bundle, AsyncRequest> LoadAssetAsync;
        public Action<Object, Asset> OnAssetLoaded;
        public Action<float> OnProgress;

        private Bundle _Bundle;

        public Asset(string assetName, Bundle bundle, string path)
        {
            _name = assetName;
            _Bundle = bundle;
            _path = path;
        }

        public void Load()
        {
            CoroutineProvider.StartCoroutine(Load(CoroutineProvider));
        }

        public IEnumerator Load(MonoBehaviour coroutineProvider)
        {
            // 协程加载assetbundle
            if (!_Bundle.IsLoaded)
                yield return coroutineProvider.StartCoroutine(_Bundle.Load());

            // 如果有其它加载asset的方法，直接调用，没有的话就使用默认的asset request
            AsyncRequest request;
            if (LoadAssetAsync != null)
                request = LoadAssetAsync(_Bundle);
            else
                request = new AssetRequest(_Bundle.LoadAssetAsync(_name, typeof(Object)));

            while (!request.isDone)
            {
                if (OnProgress != null)
                    OnProgress(request.progress);
                yield return 0;
            }

            if (OnProgress != null)
                OnProgress(1.0f);

            if (OnAssetLoaded != null)
                OnAssetLoaded(request.asset, this);
        }

        public void UnLoad()
        {
            _Bundle.UnLoad();
        }

        public interface AsyncRequest
        {
            bool isDone { get; }
            float progress { get; }
            Object asset { get; }
        }

        public class AssetRequest : AsyncRequest
        {
            private AssetBundleRequest request;

            public AssetRequest(AssetBundleRequest request)
            {
                this.request = request;
            }

            public bool isDone
            {
                get { return request.isDone; }
            }

            public float progress
            {
                get { return request.progress; }
            }

            public Object asset
            {
                get { return request.asset; }
            }
        }

        public class SceneRequest : AsyncRequest
        {
            private AsyncOperation request;
            private string _sceneName;

            public SceneRequest(AsyncOperation request, string sceneName)
            {
                this.request = request;
                this._sceneName = sceneName;
                request.allowSceneActivation = false;
            }

            public bool isDone
            {
                get
                {
                    if (request.progress >= 0.9f)
                    {
                        request.allowSceneActivation = true;
                    }

                    if (SceneManager.GetActiveScene().name == _sceneName)
                    {
                        return true;
                    }
                    return false;
                }
            }

            public float progress
            {
                get { return request.progress; }
            }

            public Object asset
            {
                get { return null; }
            }
        }
    }
}