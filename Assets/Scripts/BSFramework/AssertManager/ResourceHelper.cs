using System;
using UnityEngine;

namespace BSFramework
{
    [SLua.CustomLuaClass]
	public class ResourceHelper : MonoBehaviour
	{
	    public Action onFinish;
	    private static ResourceHelper Instance;
	    private string assetInfo;
        void Start()
		{
		    Instance = this;
		}

	    public void LoadAssetInfo(string assetInfo)
	    {
	        this.assetInfo = assetInfo;
            StartCoroutine(AssetMgr.Init(this, onFinish, assetInfo));
	    }

	    public static ResourceHelper getInstance()
	    {
	        return Instance;
	    }

        void OnDestroy()
        {
            StopCoroutine(AssetMgr.Init(this, onFinish, this.assetInfo));
        }
	}
}
