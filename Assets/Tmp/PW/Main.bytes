require "BSFramework.Core.require"
require "Service.TestUI"
require "Service.TestUI1"

local LuaLog, tablePrint_ptk = setLuaLog(1, "main")

local function main()
	LuaLog("你好 hello"..VERSION)
	LeanTween.init()

	BSFramework.ResourceHelper.getInstance().onFinish = function(  )
		LuaLog("完成")
		
		local function OnAssetLoaded( ... )
			local t1 = TestUI1.new()
			t1:Init()
		end

		local function OnProgress( o )
			LuaLog(o)
		end
		SceneManager.GetInstance():LoadSceneAsync("Loading", OnAssetLoaded, OnProgress)
	end
	BSFramework.ResourceHelper.getInstance():LoadAssetInfo("assetinfo.xml")
end

main()